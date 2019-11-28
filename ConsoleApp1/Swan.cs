using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Swan : Duck, Fly
    {
        public void Fly()
        {
            Console.WriteLine("xddddd");
        }

        public override void Swim()
        {
            Console.WriteLine("xd");
        }
    }
}
