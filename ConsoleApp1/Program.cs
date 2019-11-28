using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
         static void Main(string[] args)
        {
            Toyduck toyduck = new Toyduck();

            toyduck.Walk();
            toyduck.Swim();

            Console.ReadKey();

        }
    }
}
