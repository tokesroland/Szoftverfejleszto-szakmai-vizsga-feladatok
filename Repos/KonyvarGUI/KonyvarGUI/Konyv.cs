using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace KonyvarGUI
{
    internal class Konyv
    {
        public Konyv(string sor)
        {
            string[] data = sor.Split(';');
            Cim = data[0];
            Szerzo = data[1];
            Megjelenes = int.Parse(data[2]);
            Ar = int.Parse(data[3]);
            Mufaj = data[4];
        }

        public static List<Konyv> Beolvasas(string FilePath)
        {
            List<Konyv> list = new List<Konyv>();
            string[] sorok = File.ReadAllLines(FilePath);
            for (int i = 1; i < sorok.Length; i++)
            {
                list.Add(new Konyv(sorok[i]));
            }
            return list;
        }

        public static void QueryAll(List<Konyv> list)
        {
            foreach (Konyv v in list)
            {
                Console.WriteLine($"* \t{v.Cim} | {v.Szerzo} | {v.Mufaj} | {v.Ar} | {v.Megjelenes}");
            }
        }

        public static void MostExpensive(List<Konyv> list)
        {
            int priceMax =  list.Max(konyv => konyv.Ar);
            foreach(Konyv v in list)
            {
                if(v.Ar == priceMax)
                {
                    Console.WriteLine($"A legdrágább könyv: {v.Cim} | {v.Ar}");
                }
            }
        }

        public static double BookPriceAvg(List<Konyv> list)
        {
            return list.Average(book => book.Ar);
        }

        public static void PriceByCategory(List<Konyv> list)
        {
            Dictionary<string,int> PricesByCategory = new Dictionary<string,int>();

            foreach(Konyv v in list)
            {
                if (!PricesByCategory.ContainsKey(v.Mufaj))
                {
                    PricesByCategory.Add(v.Mufaj, v.Ar);
                }
                PricesByCategory[v.Mufaj] += v.Ar;
            }

            foreach(var a in PricesByCategory)
            {
                Console.WriteLine($"{a.Key} | {a.Value}");
            }
        }

        public static void Kereses(List<Konyv> list, int yearDate)
        {
            bool foundBook = false;
            foreach (Konyv v in list)
            {

                if (v.Megjelenes == yearDate)
                {
                    Console.WriteLine($"{v.Cim} - {v.Megjelenes}");
                    foundBook = true;
                }
            }
            if (foundBook == false)
            {
                Console.WriteLine("Nincs találat!");
            }
        }

        public static void BooksFrom(List<Konyv> list)
        {
            foreach (Konyv v in list)
            {
                if(v.Megjelenes >= 2000)
                {
                    Console.WriteLine($"{v.Cim} - {v.Megjelenes}");
                }
            }
        }
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public int Megjelenes { get; set; }
        public int Ar { get; set; }
        public string Mufaj { get; set; }


    }
}