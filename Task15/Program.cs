using System;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             15)* 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
            Shert1  3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            Shert2  Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            Shert3  Cavabdan 7 reqemli ededin son 5 reqemini cix.
            Shert4  Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            Shert5  Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            Shert6  Cavabin axirina 11 artir.
            Shert7  Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            Shert8  Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et. */
            Console.Write("3 reqemli: ");
            int eded1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3 reqemli: ");
            int eded2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli: ");
            int eded3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli: ");
            int eded4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("7 reqemli: ");
            int eded5 = Convert.ToInt32(Console.ReadLine());

            if (eded1 >= 100 && eded1 < 1000 && eded2 >= 100 && eded2 < 1000 && eded3 >= 100000 && eded3 < 1000000 && eded4 >= 100000 && eded4 < 1000000 && eded5 >= 1000000 && eded5 < 10000000)
            {
                //shert 1
                int cem = eded1 + eded2;
                double sqrSonIki =Math.Pow(cem%100,2);

                //Shert 2
                double AddBirleshme =sqrSonIki + (eded1 * 1000 + eded2);
                int AddBirleshmeInt = Convert.ToInt32(AddBirleshme);
                //Shert 3
                int son57Req = eded5 % 100000;
                int ferq = AddBirleshmeInt - son57Req;
                //Shert 4
                int cem6Req = eded3 + eded4;
                int son36Req = cem6Req % 1000;
                int cem2 = ferq+son36Req;
                //Shert 5
                int _7reqemleriCemi = 0, qaliq,tersine=0,Reqem7Dublikat=eded5;
                while (eded5 > 0)
                {
                    qaliq = eded5 % 10;
                    _7reqemleriCemi += qaliq;
                    eded5 /= 10;
                    if (_7reqemleriCemi >= 10 && _7reqemleriCemi < 100)
                    {
                        tersine = (_7reqemleriCemi % 10) * 10 + (_7reqemleriCemi / 10);
                    }
                    else tersine = _7reqemleriCemi;
                }
                int cem3 = cem2 + tersine;
                //Shert 6
                int Add11Sonuna = cem3 * 100 + 11;
                //Shert7
                int Req7TekYer =(Reqem7Dublikat / 1000000)%10 * 1000 + (Reqem7Dublikat / 10000)%10 * 100 + (Reqem7Dublikat / 100)%10 * 10 + Reqem7Dublikat % 10;
                int ferq2 = Add11Sonuna - Req7TekYer;
                //Shert8
                int yeni4Reqemli = 880 + (ferq2 % 100 / 10) * 1000 + ferq2 % 10;

                Console.WriteLine($"Shert1: {cem}, son ikisinin kvadrati {sqrSonIki}");
                Console.WriteLine($"Shert2: {AddBirleshme}");
                Console.WriteLine($"Shert3: {ferq}");
                Console.WriteLine($"Shert4: cemin son 3req:{son36Req} answer:{cem2}");
                Console.WriteLine($"Shert5: reqemleri cemi:{_7reqemleriCemi} ,onun tersi:{tersine}. Answer:{cem3}");
                Console.WriteLine($"Shert6: sonuna 11 artiranda:{Add11Sonuna}");
                Console.WriteLine($"Shert7: sonuna 11 artirandaki eded({Add11Sonuna}) chixilsin 7reqemlinin({Reqem7Dublikat}) tek yerde duranlardan alinan eded({Req7TekYer}) = {ferq2}");
                Console.WriteLine($"Shert8: {ferq2}-in son iki reqemi arasina 88 elave edende: {yeni4Reqemli}");

            }
            else
            {
                Console.WriteLine("Daxil edilen ededler sherte uygun deyil");
            }
        }
    }
}
