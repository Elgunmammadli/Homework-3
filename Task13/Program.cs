using System;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             13) 3 dene 5 reqemli eded var.
            Shert:1 Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet.
            Shert:2 Alinan neticeleri topla
            Shert:3 Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.*/
            Console.Write("5 reqemli: ");
            int eded1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli: ");
            int eded2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli: ");
            int eded3 = Convert.ToInt32(Console.ReadLine());

            if (eded1 >= 10000 && eded1 < 100000 && eded2 >= 10000 && eded2 < 100000 && eded3 >= 10000 && eded3 < 100000)
            {
                //shert 1
                int eded1Yeni = (eded1 / 10000) * 10 + eded1 % 10;
                int eded2Yeni = (eded2 / 10000) * 10 + eded2 % 10;
                int eded3Yeni = (eded3 / 10000) * 10 + eded3 % 10;
                //Shert 2
                int cem = eded1Yeni + eded2Yeni + eded3Yeni;
                //Shert 3
                double AddPercent = cem + cem * 1.0 * 50 / 100;
                Console.WriteLine($"Shert1 {eded1Yeni} , {eded2Yeni} , {eded3Yeni}");
                Console.WriteLine($"Shert2 Cem : {cem}");
                Console.WriteLine($"Shert3 {AddPercent}");
            }
            else
            {
                Console.WriteLine("her 3u 5reqemli olmalidir!");
            }

        }
    }
}
