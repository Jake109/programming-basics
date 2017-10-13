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
            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan. Luvun pitaa olla > 1");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number >= 1)
            {
                int i = 0;
                int f = 1;

                do
                {
                    i = i + 1;
                    f = f * i;
                }
                while (i < number);
                Console.WriteLine($"syotit {number}, vastaus: {f}");
                Console.ReadKey();
            }
            else
                Console.WriteLine("numeron pitaa olla vahintaan 1");
            Console.ReadKey();
        }
    }
}
