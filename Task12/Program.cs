using System;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           12) 2 dene 5 reqemli eded daxil et.
           I ededin reqemleri ceminin usutne
           II ededin reqemleri hasilini gel.
           Shert2: Neticenin axirina I ededin en axiinci reqemini artir.*/
            Console.Write("5 reqemli: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a>=10000 && a < 100000 && b >= 10000 && b < 100000)
            {
                int axir = a % 10,qaliq,qaliqB,cem=0,hasil=1;
                while (a > 0)
                {
                    qaliq = a % 10;
                    cem += qaliq;
                    a /= 10;
                }

                while (b > 0)
                {
                    qaliqB = b % 10;
                    hasil *= qaliqB;
                    b /= 10;
                }
                int cemHasil = cem + hasil;
                Console.WriteLine($"birinci ededin reqemleri cemi({cem}) + ikinci ededin reqemleri hasili ({hasil}) = {cemHasil}");
                Console.WriteLine($"shert2 : {cemHasil*10+axir}");
            }
            else
            {
                Console.WriteLine("her ikisi 5reqemli olmalidir!");
            }

        }
    }
}
