using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 2) verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3 */

            Condition(ReadNumber("6 reqemli: "));
        }

        static void Condition(int a)
        {
            //Shert1 
            int ilk3 = (a / 1000);
            int qaliq, cem = 0, dublikat = ilk3;
            while (ilk3 > 0)
            {
                qaliq = ilk3 % 10;
                cem += qaliq;
                ilk3 /= 10;
            }

            Console.WriteLine($"Shert1: Ededin({a}) ilk 3 reqeminin({dublikat}) reqemleri cemi: {cem}");
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
