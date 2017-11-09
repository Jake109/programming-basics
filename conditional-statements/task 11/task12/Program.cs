using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma antaa Lotto rivin 7 lukua sekä lisä- ja tuplausnumerot");

            Random rnd = new Random();
            int counter = 0;
            int[] array = new int[40];

            while(counter < 7)
            {
                int number = rnd.Next(40);
                if (array[number] ==0)
                {
                    array[number] = 1;
                    counter = counter + 1;
                }
                else
                { }                
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
