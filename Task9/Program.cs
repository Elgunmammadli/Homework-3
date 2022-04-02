using System;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439 */

            Condition(ReadNumber("9 reqemli: "));
        }

        static void Condition(int a)
        {
            //Shert1 
            int tekYer = 0;
            int count = 0;
            while (a > 0)
            {
                int quvvet = (int)Math.Pow(10, count);

                tekYer = tekYer + (a % 10) * quvvet;
                a /= 100;
                count++;
            }
      
            Console.WriteLine($"Shert1: tek yer: {tekYer} ");
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
