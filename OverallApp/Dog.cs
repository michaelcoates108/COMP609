using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    class Dog : Animal
    {
        public Dog(int id, double waterAmount, double cost, double weight, int age, String colour)
            : base(id, waterAmount, cost, weight, age, colour) { }
        override public double GetProf()
        {
            return -(this.waterAmount * Prices.waterPrice) - this.cost;
        }
        override public double GetTax()
        {
            return 0;
        }
        override public double GetProduct()
        {
            return 0;
        }
        override public String displayInfo()
        {
            String output_str = "ID: \t\t" + this.id.ToString() + "\r\n";
            output_str += "Type: \t\t" + "Dog" + "\r\n";
            output_str += "Water Usage: \t" + this.waterAmount.ToString() + "L\tper day\r\n";
            output_str += "Cost: \t\t" + this.cost.ToString("$#.00") + "\tper day\r\n";
            output_str += "Weight: \t\t" + this.weight.ToString() + "kg\r\n";
            output_str += "Age: \t\t" + this.age.ToString() + "\r\n";
            output_str += "Colour: \t\t" + this.colour + "\r\n";
            return output_str;
        }
    }
}
