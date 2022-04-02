using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 4) verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati  */

            Condition(ReadNumber("5 reqemli: "));
        }

        static void Condition(int a)
        {
            //Shert1 
            int ilk = a / 10000;
            int axir = a % 10;
            double cemSqr = Math.Pow(ilk,2)+Math.Pow(axir,2);

            Console.WriteLine($"Shert1: Ededin({a}) ilk reqeminin({ilk}) ve son reqeminin({axir}) kvadrati cemi: {cemSqr}");
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
            if (!(number >= 10000 && number < 100000))
            {
                Console.WriteLine("Eded 5 reqemli deyil");
                goto l1;
            }
            else
            {
                return number;
            }
        }
    }
}
