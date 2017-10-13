using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua valilta 0-50");

            Random rnd = new Random();

         
            int line = 0;

            do
            {
                int counter = 0;
                do
                {
                    Console.Write($"{rnd.Next(50)}, ");
                    counter = counter + 1;
                }
                while (counter < 5);
                line = line + 1;
                Console.WriteLine("");
            }
            while (line < 4);

            Console.ReadKey();
        }
    }
}
