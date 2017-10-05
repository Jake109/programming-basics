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
            float price = 16;
            float discount = 0;
           
            float endPrice = 0;
            


            Console.WriteLine("Anna ikasi");
            string age1 = Console.ReadLine();
            int age = int.Parse(age1);





            if (age <= 7)
            {
                
                Console.WriteLine("Alle 7 vuotiaat paasevat ilmaiseksi");

            }
            else if (age > 7 && age <= 15)
            {
                Console.WriteLine("Ikasi on 7 ja 15 valissa");
                discount = price / 100 * 50;
                endPrice = price - discount;
                Console.WriteLine($"Hinta on {endPrice}");
               
            }
            else if (age >= 65)
            {
                discount = price / 100 * 50;
                endPrice = price - discount;
                Console.WriteLine($"Hinta on {endPrice}");
                
            }
            else
            {
                Console.WriteLine("Oletko varusmies? 1 = kylla, 0 = ei");
                string varus = Console.ReadLine();
                int varusMies = int.Parse(varus);

                if (varusMies == 1)
                {
                    discount = price / 100 * 50;
                    endPrice = price - discount;
                    Console.WriteLine($"hinta on {endPrice}");
                  
                }
                else
                {
                    Console.WriteLine("Oletko opiskelija? 1 = kylla, 0 = ei");
                    string opis = Console.ReadLine();
                    int opiskelija = int.Parse(opis);

                    if (opiskelija == 1)
                    {
                        Console.WriteLine("Oletko myos Mtk: jasen? 1 = kylla 0 =ei");
                        string mtk = Console.ReadLine();
                        int jasen = int.Parse(mtk);

                        if (jasen == 1)
                        {
                            discount = price / 100 * 60;
                            endPrice = price - discount;
                            Console.WriteLine($"Hinta on {endPrice}");
                        }
                        else
                        {
                            discount = price / 100 * 45;
                            endPrice = price - discount;
                            Console.WriteLine($"hintasi on{endPrice}");
                        }
                            else
                            {
                            Console.WriteLine("oletko mtk:n jasen? 1 = kylla 0 = ei");
                            string mtk1 = Console.ReadLine();
                            int jasen1 = int.Parse(mtk1);

                            if (jasen1 == 1)
                            {
                                discount = price / 100 * 15;
                                endPrice = price - discount;
                                Console.WriteLine($"Hintasi on {endPrice}");
                            }
                        }
                    }
                    else
                        Console.WriteLine($"hintasi on {price}");
                }

            }










            Console.ReadKey();

        }
    }
}
