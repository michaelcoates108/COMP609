using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    class Jersey_cow : Cow
    {
        public Jersey_cow(int id, double waterAmount, double cost, double weight, int age, String colour,
            double milkAmount, bool isJersey) : base(id, waterAmount, cost, weight, age, colour, milkAmount, isJersey) { }
         override public double GetTax()
        {
            return this.weight * Prices.jerseyCowTax;
        }
        override public String displayInfo()
        {
            String output_str = "ID: \t\t" + this.id.ToString() + "\r\n";
            output_str += "Type: \t\t" + "Jersey Cow" + "\r\n";
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
