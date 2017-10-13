using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee antamasi luvun ensimmaisen parittoman ja parillisen summan");
            Console.WriteLine("Anna luku");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int counter = 0;
            int evenSum = 0;
            int oddSum = 0;

            do
            {
                if (counter % 2 == 0)
                {                  
                    evenSum = counter + evenSum;                   
                }
                else
                {                    
                    oddSum = counter + oddSum;                  
                }
                counter = counter + 1;
            }
            while (counter <= number);
            Console.WriteLine($"Parillisten summa = {evenSum}");
            Console.WriteLine($"Parittomien summa = {oddSum}");

            Console.ReadKey();
          
        }
    }
}
