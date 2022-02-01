using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaX broj = new KlasaX(10);
            Console.WriteLine(broj.ToString());

            Console.ReadKey();
        }
    }

    class KlasaX
    {
        int broj;

        public KlasaX(int broj)
        {
            this.broj = broj;
        }

        public override string ToString()
        {
            string ispis = "Broj: " + this.broj;
            return ispis; 
        }

        private int Broj { get => broj; set => broj = value; }
    }
}
