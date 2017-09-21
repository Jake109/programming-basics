using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
            Console.Write("syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();


            Console.WriteLine("Syötit arvon (0)",userInput);
            Console.WriteLine($"Syötit arvon (userInput)");
            Console.ReadKey();
        }
    }
}
