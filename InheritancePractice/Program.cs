using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Reptile dragonlLizard = new Reptile("Dracos",100,100,"china",true,true);
            Mammal platypus = new Mammal("Joke", 50, 100, "??", false, true);
            dragonlLizard.GetInfo();
            platypus.GetInfo();
            

            
            
        }
    }
}
