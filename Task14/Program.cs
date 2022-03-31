using System;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            Shert1 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            Shert2 Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            Shert3 Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            Shert4 Neticenin 60 % tap. Cavabin axirina 60 artir.
            Shert5 Neticeden 18% cix.*/
            Console.Write("6 reqemli: ");
            int eded1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli: ");
            int eded2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli: ");
            int eded3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("7 reqemli: ");
            int eded4 = Convert.ToInt32(Console.ReadLine());

            if (eded1 >= 100000 && eded1 < 1000000 && eded2 >= 100000 && eded2 < 1000000 && eded3 >= 100000 && eded3 < 1000000 && eded4 >= 1000000 && eded4 < 10000000)
            {
                //shert 1
                int eded1Yeni = (eded1 / 1000);
                int eded2Yeni = (eded2 / 1000);
                int eded3Yeni = (eded3 / 1000);
                int cem = eded1Yeni + eded2Yeni + eded3Yeni;

                //Shert 2
                int cem2 = cem + eded4 % 10000;
                //Shert 3
                int ilk37req = eded4 / 10000,qaliq37,hasil37=1;
                while (ilk37req > 0)
                {
                    qaliq37 = ilk37req % 10;
                    hasil37 *= qaliq37;
                    ilk37req /= 10;
                }
                int ferq = cem2 - hasil37;
                //Shert 4
                double ferq60Faiz = ferq * 1.0 * 60 / 100;
                double add60 = ferq60Faiz * 100 + 60;
                Console.WriteLine($"Shert1 {cem}");
                Console.WriteLine($"Shert2 {cem2}");
                Console.WriteLine($"Shert3 {ferq}");
                Console.WriteLine($"Shert4 60 faizi:{ferq60Faiz} , Add 60:{add60}");
                Console.WriteLine($"Shert5 Chix 18 faizi: {add60-add60*1.0*18/100}");

            }
            else
            {
                Console.WriteLine("Daxil edilen ededler sherte uygun deyil");
            }
        }
    }
}
