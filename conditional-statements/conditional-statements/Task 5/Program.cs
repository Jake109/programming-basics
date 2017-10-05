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
            int price = 16;
            int discount = 0;
            bool discounted = false;

            Console.WriteLine("Anna ikasi");
            string age1 = Console.ReadLine();
            int age = int.Parse(age1);

            if (age <= 7)
            {
                discounted = true;
                price = 0;
                Console.WriteLine("Alle 7 vuotiaat paasevat ilmaiseksi");

            }
        
                


            Console.WriteLine(age);




            Console.ReadKey();

        }
    }
}
