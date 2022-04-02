using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at. */

            Condition(ReadNumber("6 reqemli: "));
        }

        static void Condition(int a)
        {
            //Shert1 
            int ilk = a / 100000;
            int axir5 = a % 100000;
            int newNumber = axir5 * 10 + ilk;

            Console.WriteLine($"Shert1: Ededin({a}) ilk reqemini({ilk}) axira qoyanda: {newNumber}");
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
            if (!(number >= 100000 && number < 1000000))
            {
                Console.WriteLine("Eded 6 reqemli deyil");
                goto l1;
            }
            else
            {
                return number;
            }
        }
    }
}
