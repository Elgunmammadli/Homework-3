using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi */

            Condition(ReadNumber("9 reqemli: "));
        }

        static void Condition(int a)
        {
            //Shert1 
            int orta3 = (a / 1000) % 1000;
            int qaliq, cem = 0,dublikat=orta3;
            while (orta3 > 0)
            {
                qaliq = orta3 % 10;
                cem += qaliq;
                orta3 /= 10;
            }

            Console.WriteLine($"Shert1: Ededin({a}) ortasindaki 3 reqemin({dublikat}) reqemleri cemi: {cem}");
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
