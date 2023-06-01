using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static List<Osztaly> lista = new List<Osztaly>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("nobel.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Osztaly o = new Osztaly(sor);
                lista.Add(o);
            }
            sr.Close();

            // 4. feladat
            Console.WriteLine($"4. feladat: {lista.Find(x => x.Evszam == 2017 && x.Tipus == "irodalmi").KerNev} {lista.Find(x => x.Evszam == 2017 && x.Tipus == "irodalmi").VezNev}");

            // 6. feladat
            List<Osztaly> CurieLista = lista.Where(x => x.VezNev.Contains("Curie") || x.KerNev.Contains("Curie")).ToList();
            Console.WriteLine("6. feladat:");
            foreach (var item in CurieLista)
            {
                Console.WriteLine($"{item.Evszam}: {item.KerNev} {item.VezNev} ({item.Tipus})");
            }

            // 7. feladat

            Console.WriteLine("7. feladat:");
            Console.WriteLine($"kémiai    { lista.Count(x => x.Tipus == "kémiai")}db");
            Console.WriteLine($"fizikai    { lista.Count(x => x.Tipus == "fizikai")}db");
            Console.WriteLine($"orvosi    { lista.Count(x => x.Tipus == "orvosi")}db");
            Console.WriteLine($"irodalmi    { lista.Count(x => x.Tipus == "irodalmi")}db");
            Console.WriteLine($"béke    { lista.Count(x => x.Tipus == "béke")}db");
            Console.WriteLine($"közgazdaságtani    { lista.Count(x => x.Tipus == "közgazdaságtani")}db");


            // 8. feladat

            StreamWriter sw = new StreamWriter("orvosi.txt");

            foreach (var item in lista)
            {
                string sor = $"{item.Evszam}:{item.KerNev} {item.VezNev}";
                sw.WriteLine(sor);
            }
            Console.WriteLine("orvosi.txt");
            sw.Close();



        }
    }
}
