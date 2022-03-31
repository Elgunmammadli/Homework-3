using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir */

            Condition(ReadNumber("4 reqemli: "));
        }

        static int ReadNumber(string message)
        {
            l1:
            Console.Write(message);

            if(!int.TryParse(Console.ReadLine(),out int number))
            {
                Console.WriteLine("Daxil etdiyiniz eded deyil!");
                goto l1;
            }
            if(!(number>=1000 && number < 10000))
            {
                Console.WriteLine("Eded 4 reqemli deyil");
                goto l1;
            }
            else
            {
                return number;
            }
        }

        static void Condition(int a)
        {
            int ilkReqem = a / 1000;
            int ikinciReqem = (a / 100) % 10;
            int uchuncuReqem = (a / 10) % 10;
            int sonReqem = a % 10;
            int newNumber = 800008 + sonReqem * 10000 + uchuncuReqem * 1000 + ikinciReqem * 100 + ilkReqem * 10;

            Console.WriteLine($"Answer: {newNumber}");
        }
        
    }
}
