using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi kolikon heittoa. Anna kuinka monta kertaa kolikkoa heitetaan");
            string userInput = Console.ReadLine();
            int tossNumber = int.Parse(userInput);
            Random rnd = new Random();

            int counter = 0;
            int kruuna = 0;
            int klaava = 0;

            do
            {
                counter = counter + 1;
               int toss = rnd.Next(2);
                
               if (toss == 1)
                {
                    kruuna = kruuna + 1;
                }
               else
                {
                    klaava = klaava + 1;
                }
            }
            while (counter < tossNumber);
            Console.WriteLine($"Kruunia tuli {kruuna} ja klaavoja {klaava}");

            Console.ReadKey();
        }
    }
}
