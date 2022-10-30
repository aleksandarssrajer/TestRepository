using System;
namespace vezbe1.interfejsi
{
    public class Automobil : IAuto
    {
        string brend;
        string model;

        public Automobil()
        {
            brend = "Fiat";
            model = "500";
        }

        public void ispisiBrend()
        {
            Console.WriteLine(brend);
        }

        public void ispisiModel()
        {
            Console.WriteLine(model);
        }
    }
}

