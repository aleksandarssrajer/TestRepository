using System;

namespace vezbe1.nasledjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto = new Automobil();

            auto.ispisiBoju();

            Console.WriteLine(auto.brend);

            Console.ReadKey();
        }
    }

}

