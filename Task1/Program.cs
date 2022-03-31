using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 1) verilmish 4 reqemli ededin reqemlerinin cemini tap */

            Condition(ReadNumber("4 reqemli: "));
        }

        static void Condition(int a)
        {
            //Shert1
            int qaliq, cem = 0, dublikat = a;
            while (a > 0)
            {
                qaliq = a % 10;
                cem += qaliq;
                a /= 10;
            }

            Console.WriteLine($"Shert1: Ededin({dublikat}) reqemleri cemi: {cem}");
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
            if (!(number >= 1000 && number < 10000))
            {
                Console.WriteLine("Eded 4 reqemli deyil");
                goto l1;
            }
            else
            {
                return number;
            }
        }
    }
}
