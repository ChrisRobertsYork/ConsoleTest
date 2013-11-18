using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            Console.WriteLine();
            var businessLogic = new BusinessLogic();
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Calculating: 3 + 3 = {0}", businessLogic.Add(3, 3)));
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Calculating: 3 - 3 = {0}", businessLogic.Subtract(3, 3)));
            Console.Read();
        }

        public static bool SayHello()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("World");
            return true;
        }
    }
}
