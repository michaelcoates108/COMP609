using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    abstract class Animal
    {
        public int id;
        public double waterAmount;
        public double cost;
        public double weight;
        public int age;
        public String colour;

        public Animal(int id, double waterAmount, double cost, double weight, int age, String colour)
        {
            this.id = id;
            this.waterAmount = waterAmount;
            this.cost = cost;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        public abstract double GetProf();
        public abstract double GetTax();
        public abstract double GetProduct();
        public abstract String displayInfo();
    }
}
