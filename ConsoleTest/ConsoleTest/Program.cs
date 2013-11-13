using System;
using System.Collections.Generic;
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
            var businessLogic = new BusinessLogic();
            Console.WriteLine(businessLogic.Add(3, 3));
            Console.WriteLine(businessLogic.Subtract(3, 3));
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
