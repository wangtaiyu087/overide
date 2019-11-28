using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Duck
    {
        public string Name { get; set; } ="duck";
        public abstract void Swim();

        public void Walk()
        {

            Console.WriteLine("cc");
        }
    }
}
