using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulut luvulle 1-9");

            int number = 1;

            do
            {
                int counter = 0;
                int result = 0;

                do
                {
                    
                    counter = counter + 1;
                    result = counter * number;

                    Console.WriteLine($"{counter}*{number}={result}");

                }
                while (counter < 9);
                number = number + 1;
            }
            while (number <= 9);
            Console.ReadKey();
        }
    }
}
