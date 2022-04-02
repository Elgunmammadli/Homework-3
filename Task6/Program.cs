using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et */

            Condition(ReadNumber("8 reqemli: "));
        }

        static void Condition(int a)
        {
            //Shert1 
            int ilk = a / 10000000;
            int axir = a % 10;

            int newNumber = (a - (ilk * 10000000 + axir)) / 10;

            Console.WriteLine($"Shert1: Ededin({a}) ilk({ilk}) ve son({axir}) reqemlerini legv edende: {newNumber}");
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
            if (!(number >= 10000000 && number < 100000000))
            {
                Console.WriteLine("Eded 8 reqemli deyil");
                goto l1;
            }
            else
            {
                return number;
            }
        }
    }
}
