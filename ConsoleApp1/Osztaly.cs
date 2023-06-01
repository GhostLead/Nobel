using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Osztaly
    {

        int evszam;
        string tipus;
        string kerNev;
        string vezNev;
        

        public Osztaly(string CSVsor)
        {
            string[] tomb = CSVsor.Split(';');

            this.evszam = int.Parse(tomb[0]);
            this.tipus = tomb[1];
            this.vezNev = tomb[2];
            this.kerNev = tomb[3];
        }

        public int Evszam { get => evszam; set => evszam = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string KerNev { get => kerNev; set => kerNev = value; }
        public string VezNev { get => vezNev; set => vezNev = value; }
    }
}
