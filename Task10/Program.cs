using System;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 10) 9 reqemli ededdi 
           Shert1: tek yerde dayananlardan bir eded duzlet,sonra cut yerde dayanlarinda bir eded duzlet,
           Shert2: sonra onlari topla*/

            Condition(ReadNumber("9 reqemli: "));
        }

        static void Condition(int a)
        {
            //Shert1 
            // int tekYer = (a / 100000000) * 10000 + ((a / 1000000) % 10) *1000 + ((a / 10000) % 10)*100 + ((a / 100) % 10)*10 + a % 10;
            // int cutYer = ((a / 10000000)%10) * 1000 + ((a / 100000) % 10) *100 + ((a / 1000) % 10)*10 + (a%100) / 10;

            int tekYer = 0;
            int count = 0;
            int dublikatForCut = a;
            while (a > 0)
            {
                int quvvet = (int)Math.Pow(10, count);

                tekYer = tekYer + (a % 10) * quvvet;
                a /= 100;
                count++;
            }
            int cutYer = 0;
            int countCut = 0;
            while (dublikatForCut > 0)
            {
                int quvvetc = (int)Math.Pow(10, countCut);

                cutYer = cutYer + ((dublikatForCut%100)/ 10) * quvvetc;
                dublikatForCut /= 100;
                countCut++;
                
            }
            //Shert2

            int cem = tekYer + cutYer;
           
            Console.WriteLine($"Shert1: tek yerdeki: {tekYer} , cut yerdeki: {cutYer}");
            Console.WriteLine($"Shert2: Cemi: {cem}");
        }

        static int ReadNumber(string message)
        {
        l1:
            Console.Write(message);

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Daxil etdiyiniz eded deyil!");
                goto l1;
            }
            if (!(number >= 100000000 && number < 1000000000))
            {
                Console.WriteLine("Eded 9 reqemli deyil");
                goto l1;
            }
            else
            {
                return number;
            }
        }
    }
}
