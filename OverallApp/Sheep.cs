using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    class Sheep : Animal
    {
        public double woolAmount;
        public Sheep(int id, double waterAmount, double cost, double weight, int age, String colour,
            double woolAmount) : base(id, waterAmount, cost, weight, age, colour)
        {
            this.woolAmount = woolAmount;
        }
        override public double GetProf()
        {
            double income = (this.woolAmount * Prices.sheepWoolPrice) - this.cost - (this.waterAmount * Prices.waterPrice) - GetTax();
            return income;
        }
        override public double GetTax()
        {
            return this.weight * Prices.tax;
        }
        override public double GetProduct()
        {
            return this.woolAmount;
        }
        override public String displayInfo()
        {
            String output_str = "ID: \t\t" + this.id.ToString() + "\r\n";
            output_str += "Type: \t\t" + "Sheep" + "\r\n";
            output_str += "Water Usage: \t" + this.waterAmount.ToString() + "L\tper day\r\n";
            output_str += "Cost: \t\t" + this.cost.ToString("$#.00") + "\tper day\r\n";
            output_str += "Weight: \t\t" + this.weight.ToString() + "kg\r\n";
            output_str += "Age: \t\t" + this.age.ToString() + "\r\n";
            output_str += "Colour: \t\t" + this.colour + "\r\n";
            output_str += "Wool Produced: \t" + this.woolAmount.ToString() + "kg\tper year\r\n";
            return output_str;
        }
    }
}
