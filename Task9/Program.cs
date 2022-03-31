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
            int tekYer = (a / 100000000) * 10000 + ((a / 1000000) % 10) * 1000 + ((a / 10000) % 10) * 100 + ((a / 100) % 10) * 10 + a % 10;
      
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
