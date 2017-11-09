using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma arpoo 100 lukua valilta 0-50 ja tallettaa ne taulukkoon iT. Arvotut luvut ja niiden keskiarvo ilmoitetaan");
            Random rnd = new Random();
            int laskuri = 0;
            int[] array = new int[100];
            int arrayIndex = 0;
            int sum = 0;
            int laskuri2 = 0;
            int laskuri3 = 1;

            while (laskuri < 100)
            {
                int number = rnd.Next(50);
                array[laskuri] = number;
                laskuri = laskuri + 1;
                
            }
            while (arrayIndex < 100)
            {
                sum = sum + array[arrayIndex];
                arrayIndex = arrayIndex + 1;
            }
            
            int keskiArvo = sum / 100;
            

            while(laskuri2 < 100)
            {
                Console.WriteLine($"{laskuri3}."+array[laskuri2]);
                laskuri2 = laskuri2 + 1;
                laskuri3 = laskuri3 + 1;
            }
            Console.WriteLine($"keskiarvo on {keskiArvo}");


            Console.ReadKey();
        }

    }
}
