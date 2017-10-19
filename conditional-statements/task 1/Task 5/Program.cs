using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin");
            Console.WriteLine("Kotivoitto = 1, Tasapeli = x, Vierasvoitto = 2");

            Random rnd = new Random();
            int counter = 0;

            do
            {
                double number = rnd.NextDouble();
                counter = counter + 1;

                if (number <= 0.4)
                {
                    Console.WriteLine($"{counter}. 1");
                }
                else if(number <= 0.6)
                {
                    Console.WriteLine($"{counter}. x");
                }
                else
                {
                    Console.WriteLine($"{counter}. 2");
                }
               
            }
            while (counter < 13);

            Console.ReadKey();
        }
    }
}
