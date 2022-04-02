using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {    /* 8) Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap */

            Condition(ReadNumber("Reqem daxil et: "));
        }

        static void Condition(int a)
        {
            //Shert1 
            int axir3 = (a % 1000) / 100;
            int axir = a % 10;
            int cem = axir + axir3;

            Console.WriteLine($"axirdan 3cu reqemle({axir3}) axirinci reqemin({axir}) cemi:{cem}");
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
            return number;
        }
    }
}

