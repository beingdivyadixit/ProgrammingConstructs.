using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs_
{
    internal class TwoNumIsEqual
    {
        public static void IsWqual()
        {
            Console.WriteLine("Enter first number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            if(numberOne== numberTwo)
            {
                Console.WriteLine("numbers are Equal");
            }
            else
            {
                Console.WriteLine("Number are not Equal");
            }
        }
    }
}
