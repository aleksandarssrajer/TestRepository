using System;
namespace vezbe1.grananjaiiteracije
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int mojBroj = 25;

            Console.WriteLine("Primer grananja");
            if (mojBroj < 10)
            {
                Console.WriteLine("Broj je manji od 10.");
            }
            else if (mojBroj < 22)
            {
                Console.WriteLine("Broj je manji od 22.");
            }
            else
            {
                Console.WriteLine("Broj je velik.");
            }


            Console.WriteLine("\nFOR petlja");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\nWHILE");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("\nSWITCH");
            int broj = 2;
            switch (broj)
            {
                case 1:
                    Console.WriteLine("Ponedeljka");
                    break;
                case 2:
                    Console.WriteLine("Utorak");
                    break;
            }

            Console.ReadKey();
        }
    }
}

