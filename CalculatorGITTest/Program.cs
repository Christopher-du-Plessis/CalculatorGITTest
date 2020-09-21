using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGITTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter value 1");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 2");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("The calculator will now add value 1 and 2");
            int Answer = value1 + value2;

            Console.WriteLine(Answer);

            Console.WriteLine("Push any key to end the application . . .");
            Console.ReadKey();
        }
    }
}
