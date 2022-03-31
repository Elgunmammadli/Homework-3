using System;

namespace Task11
{
    internal class Program
    {

       
        static void Main(string[] args)
        {    /*11) 
        Shert1 8 reqemli ededin reqemlerini iki -iki qruplashdir.
        Shert2 Qruplarin cemini tap.
        Shert3 Alinan cavabin axirina 99 artir.
        Shert4 Sonra cavabin ozunden onun 18% ni cix;*/
        
            Condition(ReadNumber("8 reqemli: "));
        }

        

        static void Condition(int a)
        {
            //Shert1 
            int ilk4luk = a / 10000;
            int son4luk = a % 10000;
            //Shert2
            int qrupCem = ilk4luk + son4luk;
            //Shert3
            int add99Sonuna = qrupCem * 100 + 99;
            //Shert4
            double ferq = add99Sonuna - add99Sonuna * 1.0 * 18 / 100;
            

            Console.WriteLine($"Shert1: 1ci qrup: {ilk4luk} , 2ci qrup: {son4luk}");
            Console.WriteLine($"Shert2: Qruplarin cemi: {qrupCem}");
            Console.WriteLine($"Shert3: Sonuna 99 artiranda: {add99Sonuna}");
            Console.WriteLine($"Shert4: Ferqden ozunun 18faizini chixdiqda: {ferq}");
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
            if (!(number >= 10000000 && number < 100000000))
            {
                Console.WriteLine("Eded 8 reqemli deyil");
                goto l1;
            }
            else
            {
                return number;
            }
        }
    }
}
