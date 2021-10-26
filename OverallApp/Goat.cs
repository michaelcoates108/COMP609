using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    class Goat : Animal 
    {
        public double milkAmount;
        public Goat(int id, double waterAmount, double cost, double weight, int age, String colour,
            double milkAmount) : base(id, waterAmount, cost, weight, age, colour)
        {
            this.milkAmount = milkAmount;
        }
        override public double GetProf()
        {
            //The profitability of a livestock is calculated as the income from milk minus the cost of vaccination.
            double income = (this.milkAmount * Prices.goatMilkPrice)  - this.cost - (this.waterAmount * Prices.waterPrice) - GetTax();
            return income;
        }
        override public double GetTax()
        {
            return this.weight * Prices.tax;
        }
        override public double GetProduct()
        {
            return this.milkAmount;
        }
        override public String displayInfo()
        {
            String output_str = "ID: \t\t" + this.id.ToString() + "\r\n";
            output_str += "Type: \t\t" + "Goat" + "\r\n";
            output_str += "Water Usage: \t" + this.waterAmount.ToString() + "L\tper day\r\n";
            output_str += "Cost: \t\t" + this.cost.ToString("$#.00") + "\tper day\r\n";
            output_str += "Weight: \t\t" + this.weight.ToString() + "kg\r\n";
            output_str += "Age: \t\t" + this.age.ToString() + "\r\n";
            output_str += "Colour: \t\t" + this.colour + "\r\n";
            output_str += "Milk Produced: \t" + this.milkAmount.ToString() + "L\tper day\r\n";
            return output_str;
        }
    }
}
