using System;

namespace vezbe1
{
    public class Varijable
    {
        private static void Main(string[] args)
        {
            // Inicijalizacija varijabli i njihov ispis na konzoli
            string ime = "Radoslav";                                  // varijabla ima tip, ime i vrednost
            Console.WriteLine("Moje ime je " + ime);                  // ispis na konzoli

            int mojBroj = 20;
            Console.WriteLine("Moj broj je " + mojBroj);

            char slovo = 'A';
            Console.WriteLine("Odabrano slovo je " + slovo);

            bool mojBool = true;
            Console.WriteLine("Moj boolean " + mojBool);

            Console.ReadKey();
        }
    }
}