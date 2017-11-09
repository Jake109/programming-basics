using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi tuhat nopan heittoa ja tulostaa kuinka monta kutosta tuli");

            Random rnd = new Random();
            int counter = 0;
            int sixes = 0;

            do
            {
                counter = counter + 1;

                int toss = rnd.Next(7);
                if (toss == 0)
                {
                    counter = counter - 1;
                }
                else
                {
                    Console.WriteLine($"{counter}. {toss}");
                    if (toss == 6)
                    {
                        sixes = sixes + 1;
                    }

                    else
                    { }
                }
            }
            while (counter < 1000);
            Console.WriteLine($"Kutosia tuli {sixes} kertaa");

            Console.ReadKey();

        }
    }
}
