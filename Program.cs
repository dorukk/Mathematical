using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematic
{
    class Program
    {
        static void Main(string[] args)
        {
            MathematicalClass m = new MathematicalClass();

            Console.Write("Enter your number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

        }
    }
}
