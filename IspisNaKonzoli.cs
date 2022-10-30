using System;

namespace vezbe1
{
    public class IspisNaKonzoli
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unesite korisnicko ime: ");

            string korisnickoIme = Console.ReadLine();

            Console.WriteLine("Korisnicko ime je: " + korisnickoIme);
            Console.WriteLine("Korisnicko ime ispisano velikim slovima: " + korisnickoIme?.ToUpper());


            // zadatak 1. Dopuniti funkciju tako da se omogući korisniku da unese ime, prezime, grad, omiljenu boju i godinu rođenja. Godinu rođenja upisti u pomenljivu tipa int.
            //            Sve podatke ispisati na konzoli. Grad ispisati velikim slovima, a omiljenu boju malim slovima.

            Console.ReadKey();
        }

    }
}

