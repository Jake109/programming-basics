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
            Console.WriteLine("Syötä numero1");
            string numero1 = Console.ReadLine();
            int num1 = int.Parse(numero1);
            Console.WriteLine(num1);

            Console.WriteLine("Syötä numero2");
            string numero2 = Console.ReadLine();
            int num2 = int.Parse(numero2);
            Console.WriteLine(num2);

            Console.WriteLine("Syötä numero3");
            string numero3 = Console.ReadLine();
            int num3 = int.Parse(numero3);
            Console.WriteLine(num3);

            

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    if (num2 < num3)
                    {
                        Console.WriteLine($"{num1}, {num2}, {num3}");
                    }
                    else
                        Console.WriteLine($"{num1}, {num3}, {num2}");
                }
                else
                    Console.WriteLine($"{num3}, {num1}, {num2}");
            }
            else
                if (num1 < num3)
                {
                    Console.WriteLine($"{num2}, {num1}, {num3}");
                }
                else
                    if (num2 < num3)
                    {
                        Console.WriteLine($"{num2}, {num3}, {num1}");
                    }
                    else
                        Console.WriteLine($"{num3}, {num2}, {num1}");     




                Console.ReadKey();
        }
    }
}
