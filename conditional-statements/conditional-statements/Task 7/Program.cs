using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee yhteen luvut ykkosesta antamaasi lukuun asti. Anna luku");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number >= 1)
            {
                int i = 0;
                int f = 0;

                do
                {
                    i = i + 1;
                    f = f + i;
                }
                while (i < number);
                Console.WriteLine($"annoit luvun {number}, vastaus: {f}");
            }
            else
                Console.WriteLine("luvun pitaa olla vahintaan 1");

            Console.ReadKey();
        }
    }
}
