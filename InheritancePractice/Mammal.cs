using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
     class Mammal: Species
    {

        public Mammal()
        {
            //default constructor
        }

        public Mammal(string name, double weight, double height, string habatit, bool isColdblooded, bool hasTail)
        {
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Habitat = habatit;
            this.IsColdBlooded = isColdblooded;
            this.HasTail = hasTail;
        }
        public override double GetWeight (double num)
        {
          num = num + Weight;
            return num;
        }
    }
}
