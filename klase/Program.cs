using System;

namespace vezbe1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Automobil automobil1 = new Automobil();

            automobil1.ispisiBoju();

            Osoba osoba = new Osoba();

            // upotreba class properties
            osoba.Ime = "Kornelije";
            Console.WriteLine(osoba.Ime);

            Console.ReadKey();
        }
    }
}

