using System;
namespace vezbe1
{
    public class Automobil
    {
        string boja;
        int prosecnaBrzina;

        // Konstruktor postavlja inicijalne vrednosti
        public Automobil()  
        {
            boja = "crna";
            prosecnaBrzina = 100;
        }


        // metoda za ispis boje automobila
        public void ispisiBoju()              
        {
            Console.WriteLine("Boja automobila je: " + boja);
        }

        // zadatak 2. Dodati metodu za ispis prosečne brzine na konzoli i pozvati je na odgovarajućem mestu
    }
}

