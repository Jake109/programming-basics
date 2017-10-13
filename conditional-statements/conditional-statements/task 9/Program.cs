using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee yhteen luvut ykkösesta antamaasi lukuun asti. Anna luku");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int i = 0;
            int f = 0;

            if (number >= 1)
            {                
                do
                {
                    i = i + 1;
                    f = f + i;
                }
                while (i < number);
                Console.WriteLine($"annoit luvun {number}, vastaus: {f}");
            }
            else
            {
                do
                {
                    i = i - 1;
                    f = f + i;
                }
                while (i > number);
                Console.WriteLine($"annoit luvun {number}, vastaus: {f}");
            }

            Console.ReadKey();
        }
    }
}
