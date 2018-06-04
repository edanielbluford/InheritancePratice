using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Species
    {
        

        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Habitat { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasTail { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("{0} is {1} pounds and {2} inches tall. Lives in {3} and is cold blodded: {4} and has a tail: {5}", Name, Weight, Height, Habitat, IsColdBlooded,HasTail );
            Console.WriteLine(this.Sum());
        }
        public double Sum()
        {
            double sum = Weight + Height;
            return sum;
        }
        public virtual double GetWeight(double num)
        {
            return Weight;
        }
    }
}
