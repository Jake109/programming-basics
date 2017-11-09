using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tulostaa haluamasi maaran tahtia");
            Console.WriteLine("Annakuinka monta tahtea haluat");

            int stars;
            while (true)
            {
                stars = int.Parse(Console.ReadLine());
                if ( stars<0)
                {
                    Console.WriteLine("Antamasi luvun pitaa olla positiivinen");
                }
                else
                {
                    break;
                }
            }
           
            Console.WriteLine($"Annoit {stars}");
            Console.ReadKey();
        }       


    }
}
