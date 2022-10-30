using System;

namespace vezbe1
{
    public class KonvertovanjeTipova
    {
        private static void Main(string[] args)
        {
            int mojBroj = 10;
            Console.WriteLine("Tip broja je: " + mojBroj.GetType());

            // Automatska konverzija iz int u double
            double mojDouble = mojBroj;
            Console.WriteLine("Tip broja posle konverzije je: " + mojDouble.GetType() + "\n");

            double mojNoviDouble = 5.2;
            Console.WriteLine("Tip broja je: " + mojNoviDouble.GetType());

            // Ručna konverzija iz int u double
            int mojNoviBroj = (int)mojDouble;
            Console.WriteLine("Tip broja posle konverzije je: " + mojNoviBroj.GetType() + "\n");

            // Konverzija int u string
            int noviBroj = 10;
            Console.WriteLine("Tip broja je: " + noviBroj.GetType());
            Console.WriteLine("Tip broja posle konverzije je: " + Convert.ToString(noviBroj).GetType());

            Console.ReadKey();
        }
    }
}

