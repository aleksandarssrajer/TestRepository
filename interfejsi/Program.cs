using System;
namespace vezbe1.interfejsi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Automobil automobil = new Automobil();

            automobil.ispisiBrend();
            automobil.ispisiModel();

            // zadatak 3. Proširiti klasu automobil sa poljem kubikaza.
            //            Dodati metodu ispisiKubikazu u interfejs i implementirati tu metodu u klasi automobil.
            //            Pozvati metodu za ispis kubikaže.

            Console.ReadKey();
        }
    }
}

