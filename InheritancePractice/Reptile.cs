using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
     class Reptile: Species
    {
        public Reptile()
        {
            //Default Constructor
        }

        public Reptile(string name,double weight, double height,string habatit, bool isColdblooded, bool hasTail )
        {
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Habitat = habatit;
            this.IsColdBlooded = isColdblooded;
            this.HasTail = hasTail;
        }
    }
}
