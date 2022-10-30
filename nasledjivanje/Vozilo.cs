using System;
namespace vezbe1.nasledjivanje
{
    public class Vozilo
    {
        public string boja = "crna";
        public int prosecnaBrzina = 100;
        public string brend = "Mercedes";

        public void ispisiBoju()
        {
            Console.WriteLine("Boja automobila je: " + boja);
        }
    }
}

