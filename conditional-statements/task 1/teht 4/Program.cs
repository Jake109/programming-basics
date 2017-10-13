using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa luvut 1-10 ja niiden neliojuuret");

            int counter = 0;
            double square = 0;

            do
            {
                counter = counter + 1;
                square = Math.Sqrt(counter);
                Console.WriteLine($"numeron {counter} neliojuuri on {square}");
            }
            while (counter < 10);

            Console.ReadKey();
        }
    }
}
