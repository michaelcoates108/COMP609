using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OverallApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Dictionary<int, Animal> farm = new Dictionary<int, Animal>();
        static void SortAnimal(String[] columns, String type)
        {
            //initialise the variables used by every class (first 6 columns of each table)
            int id = int.Parse(columns[0]);
            double waterAmount = double.Parse(columns[1]);
            double cost = double.Parse(columns[2]);
            double weight = double.Parse(columns[3]);
            int age = int.Parse(columns[4]);
            String colour = columns[5];
            double milkOrWool;

            //check type of animal, assign values from columns 6 and 7 in to their respective variables
            if (type == "Dogs")
            {
                farm.Add(id, new Dog(id, waterAmount, cost, weight, age, colour));
            }
            if (type == "Goats")
            {
                milkOrWool= double.Parse(columns[6]);
                farm.Add(id, new Goat(id, waterAmount, cost, weight, age, colour, milkOrWool));
            }
            if (type == "Sheep")
            {
                milkOrWool = double.Parse(columns[6]);
                farm.Add(id, new Sheep(id, waterAmount, cost, weight, age, colour, milkOrWool));
            }
            if (type == "Cows")
            {
                milkOrWool = double.Parse(columns[6]);
                bool isJersey = bool.Parse(columns[7]);
                
                if (isJersey)
                {
                    farm.Add(id, new Jersey_cow(id, waterAmount, cost, weight, age, colour, milkOrWool, isJersey));
                }
                else
                {
                    farm.Add(id, new Cow(id, waterAmount, cost, weight, age, colour, milkOrWool, isJersey));
                }
            }
        }

        static String chooseDB()
        {
            //Method that allows user choose database. Returns file path of chosen database.
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\\",
                Filter = "Access 2000-2003 (*.mdb)|*.mdb|Access 2007 (*.accdb)|*accdb",
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            //Display chosen database in textbox
            filenameBox.Text = chooseDB();
            try
            {
                String ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + filenameBox.Text + "; Persist Security Info = False";
                OleDbConnection conn = null;
                conn = new OleDbConnection(ConnStr);
                conn.Open();
                //Retrieve commodity prices from "Rates and prices" table then stores them in array. Assign values to the appropriate variable.
                String query = "SELECT * FROM [Rates and prices]";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                double[] prices = new double[6];
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    int q = 0;
                    while (reader.Read())
                    {
                        prices[q] = Convert.ToDouble(reader.GetValue(1));
                        q++;
                    }
                }
                Prices.goatMilkPrice = prices[0];
                Prices.cowMilkPrice = prices[1];
                Prices.sheepWoolPrice = prices[2];
                Prices.waterPrice = prices[3];
                Prices.tax = prices[4];
                Prices.jerseyCowTax = prices[5];
                //For each table of animals, retrieve data and send to the SortAnimal method.
                int count = 0;
                String[] tablenames = {"Cows", "Goats", "Sheep", "Dogs" };
                foreach (String table in tablenames)
                {
                    query = "SELECT * FROM [" + table + "];";
                    cmd = new OleDbCommand(query, conn);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        count = reader.FieldCount;
                        String[] columns = new String[count + 1];
                        while (reader.Read())
                        {
                            for (int i = 0; i < count; i++)
                            {
                                columns[i] = reader.GetValue(i).ToString();
                            }
                            SortAnimal(columns, table);
                        }
                    }
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                if (filenameBox.Text.Length != 0)
                {
                    MessageBox.Show("Cannot use this database.\r\n\r\n" + ex.Message);
                }
            }
        }
        public int searchCount;
        static Boolean CheckFarm()
        {
            if(farm.Count != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No animals in database.");
                return false;
            }
        }
        private void searchByIDButton_Click(object sender, EventArgs e) // Report #1
        {
            if (CheckFarm())
            {
                //Displays the info of animal using search ID
                try
                {
                    searchCount++;
                    int searchID = int.Parse(IDBox.Text);
                    bool found = false;
                    foreach (var animal in farm)
                    {
                        if (animal.Value.id == searchID)
                        {
                            // Separates searches with a line
                            if (searchCount > 1) animalInfoBox.Text += "------------------------------------------------\r\n\r\n";
                            animalInfoBox.Text += animal.Value.displayInfo() + "\r\n";
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        if (searchCount > 1) animalInfoBox.Text += "------------------------------------------------\r\n\r\n";
                        animalInfoBox.Text += "No animals found for ID: " + searchID.ToString() + "\r\n\r\n";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void SearchClearButton_Click(object sender, EventArgs e)
        {
            //Clear box of search info, set search count back to 0
            animalInfoBox.Clear();
            searchCount = 0;
        }

        private void profButton_Click(object sender, EventArgs e) //(Report #2)
        {
            //Calculates and displays the daily profitability for all animals 
            if (CheckFarm()){
                try
                {
                    double totProf = 0;
                    foreach (var animal in farm)
                    {
                        totProf += animal.Value.GetProf();
                    }
                    outBox.Text += "Total profitability per day: \t\t" + totProf.ToString("$#.00") + "\r\n\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MonthlyTaxButton_Click(object sender, EventArgs e) //Report #3
        {
            //Calculates and displays tax paid per month (daily tax * 365/12)
            if (CheckFarm())
            {
                try
                {
                    double totTax = 0;
                    foreach (var animal in farm)
                    {
                        totTax += animal.Value.GetTax();
                    }
                    outBox.Text += "Tax paid per month: \t\t" + ((totTax * 365) / 12).ToString("$#.00") + "\r\n\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TotalMilkButton_Click(object sender, EventArgs e) //Report #4
        {
            //Calculates and displays litres of milk produced daily. Uses the GetProduct method but excludes Sheep.
            if (CheckFarm())
            {
                try
                {
                    double totMilk = 0;
                    foreach (var animal in farm)
                    {
                        if (!(animal.Value is Sheep))
                        {
                            totMilk += animal.Value.GetProduct();
                        }
                    }
                    outBox.Text += "Milk produced per day: \t\t" + totMilk.ToString("#.00") + "L\r\n\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AverageAgeButton_Click(object sender, EventArgs e) //Report #5
        {
            //Calculates and displays average age of animals (excluding dogs)
            if (CheckFarm())
            {
                try
                {
                    double totAge = 0;
                    int count = 0;
                    foreach (var animal in farm)
                    {
                        if (!(animal.Value is Dog))
                        {
                            totAge += animal.Value.age;
                            count++;
                        }
                    }
                    outBox.Text += "Avg age of farm animals: \t\t" + (totAge / count).ToString("#.00") + " years\r\n\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GoatsCowsVsSheepButton_Click(object sender, EventArgs e) //Report #6
        {
            //Calculates and displays average profitability for goats plus cows, and also for sheep. 
            if (CheckFarm())
            {
                double goatCowProf = 0, sheepProf = 0;
                int goatCowCount = 0, sheepCount = 0;
                foreach (var animal in farm)
                {
                    if (animal.Value is Sheep)
                    {
                        sheepProf += animal.Value.GetProf();
                        sheepCount++;
                    }
                    else
                    {
                        if (!(animal.Value is Dog))
                        {
                            goatCowProf += animal.Value.GetProf();
                            goatCowCount++;
                        }
                    }
                }
                outBox.Text += "Avg profitability from Goats + Cows: \t" + (goatCowProf / goatCowCount).ToString("$#.00") + "\r\n";
                outBox.Text += "Avg profitability from Sheep: \t\t" + (sheepProf / sheepCount).ToString("$#.00") + "\r\n\r\n";
            }
        }

        private void DogRatioButton_Click(object sender, EventArgs e) //Report #7
        {
            //Calculates total cost of all animals, and all dogs. Displays ratio.
            if (CheckFarm())
            {
                double dogCost = 0;
                double totCost = 0;
                foreach (var animal in farm)
                {
                    totCost += animal.Value.cost;
                    if (animal.Value is Dog)
                    {
                        dogCost += animal.Value.cost;
                    }
                }
                double dogRatio = dogCost / totCost;
                outBox.Text += "Cost of Dogs as % of total: \t\t" + dogRatio.ToString("0.00%") + dogCost.ToString(" ($#.00") + totCost.ToString("/#.00)") + "\r\n\r\n";
            }
        }

        private void FileLocationButton_Click(object sender, EventArgs e)
        {
            //Allows user to select file for the txtfile to be created in. 
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            String pathName = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Use the current day to name the file. Format "Profits dd-mm-yy.txt"
                pathName = folderBrowserDialog.SelectedPath + "\\Profits " + DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year.ToString().Substring(2) +".txt";
            }
            FileChosenBox.Text = pathName;
        }

        private void GenerateFileButton_Click(object sender, EventArgs e) //Report #8
        {
            //Generates txt file of animal IDs ranked by profitability.
            try
            {
                if(CheckFarm())
                {
                    String path = FileChosenBox.Text;
                    if (path.Length != 0)
                    {
                        //If a database and a file destination have both been selected. Sorts animals by profit and creates txt file.
                        printToFile(sortByProfit(), path);   
                    }
                    else
                    {
                        MessageBox.Show("Please choose a destination file.");
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        static List<Animal> sortByProfit()
        {
            //Initialise two lists for sorted and unsorted animals
            List<Animal> sorted = new List<Animal>();
            List<Animal> unsorted = new List<Animal>();
            //Add all animals to the unsorted list
            foreach (var animal in farm)
            {
                if (!(animal.Value is Dog))
                {
                    unsorted.Add(animal.Value);
                }
            }
            //Iterate through unsorted list, find max each time, remove it and add to sorted list. O(n^2)
            while (unsorted.Count != 0)
            {
                Animal max = unsorted[0];
                foreach (Animal animal in unsorted)
                {
                    if (animal.GetProf() > max.GetProf())
                    {
                        max = animal;
                    }
                }
                sorted.Add(max);
                unsorted.Remove(max);
            }
            return sorted;
        }

        static void printToFile(List<Animal> animals, String path)
        {
            ////Uses filepath chosen by user. Replaces file if it already exists.
            if (File.Exists(path)) File.Delete(path);
            //Writes to the txt file. Headings followed by a loop to write the IDs and their profitabilities.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Animal IDs Ranked by Daily Profitability");
                sw.WriteLine("Date: \t{0}", DateTime.Now.Date.ToShortDateString());
                sw.WriteLine("Cows\t10XX\r\nGoats\t11XX\r\nSheep\t3XXX\r\n");
                sw.WriteLine("ID\t Profits\r\n");
                foreach (Animal animal in animals)
                {
                    sw.WriteLine(animal.id.ToString() + " \t" + animal.GetProf().ToString("$0.00"));
                }
            }
            MessageBox.Show("Textfile created successfully");
        }

        private void RedRatioButton_Click(object sender, EventArgs e) //Report #9
        {
            //Calculates and displays the ratio of red animals
            if (CheckFarm())
            {
                try
                {
                    double totRed = 0;
                    foreach (var animal in farm)
                    {
                        if (animal.Value.colour == "Red")
                        {
                            totRed++;
                        }
                    }
                    double redRatio = totRed / farm.Count;
                    outBox.Text += "Red animals as % of total: \t\t" + redRatio.ToString("0.00%") + " (" + totRed + "/" + farm.Count + ")\r\n\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void JerseyTaxButton_Click(object sender, EventArgs e) //Report #10
        {
            //Calculates and displays the total daily tax paid for Jersey Cows
            if (CheckFarm())
            {
                try
                {
                    double totTax = 0;
                    foreach (var animal in farm)
                    {
                        if (animal.Value is Jersey_cow)
                        {
                            totTax += animal.Value.GetTax();
                        }
                    }
                    outBox.Text += "Daily tax paid for Jersey Cows: \t" + totTax.ToString("$#.00") + "\r\n\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void JerseyCowProfButton_Click(object sender, EventArgs e) //Report #12
        {
            //Calculates and displays the total daily profitability for Jersey Cows
            if (CheckFarm())
            {
                try
                {
                    double totProf = 0;
                    foreach (var animal in farm)
                    {
                        if (animal.Value is Jersey_cow)
                        {
                            totProf += animal.Value.GetProf();
                        }
                    }
                    outBox.Text += "Daily Profitability for Jersey Cows: \t" + totProf.ToString("$#.00") + "\r\n\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SearchAgeButton_Click(object sender, EventArgs e) //Report #11
        {
            // Uses the age entered by the user. Calculates and displays % of animals above that age.
            if (CheckFarm())
            {
                try
                {
                    double searchAge = double.Parse(ageBox.Text);
                    double aboveAge = 0;
                    foreach (var animal in farm)
                    {
                        if (animal.Value.age >= searchAge)
                        {
                            aboveAge++;
                        }
                    }
                    outBox.Text += "Percentage of animals above age " + searchAge.ToString() + ": \t" + (aboveAge / farm.Count).ToString("0.00%") + " (" + aboveAge + "/" + farm.Count + ")\r\n\r\n";
                }
                catch
                {
                    MessageBox.Show("Please enter a number.");
                }
            }
            
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clears the box of report info
            outBox.Clear();
        }
    }
}





