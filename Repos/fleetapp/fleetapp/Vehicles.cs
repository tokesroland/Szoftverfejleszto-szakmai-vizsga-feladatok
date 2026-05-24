using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace fleetapp
{
    internal class Vehicles
    {
        static int dataCount = 0;
        public Vehicles(string sor)
        {
            string[] data = sor.Split(';');
            ID = int.Parse(data[0]);
            Marka = data[1];
            Modell = data[2];
            GyartasiEv = int.Parse(data[3]);
            Uzemanyag = data[4];
            Ar = int.Parse(data[5]);
            Kilometerora = int.Parse(data[5]);
        }

        public static List<Vehicles> Beolvasas(string filePath)
        {
            List<Vehicles> list = new List<Vehicles>();
            string[] data = File.ReadAllLines(filePath);
            for(int i = 1; i < data.Length; i++)
            {
                list.Add(new Vehicles(data[i]));
                dataCount++;
            }
            return list;
        }

        public static void CarCount(List<Vehicles> list)
        {
            Console.WriteLine(dataCount);
        }

        public static void KmAverage(List<Vehicles> list)
        {
            Console.WriteLine($"Az átlagos km {list.Average(car => car.Kilometerora):F2}");
        }

        public static void SearchByYear(List<Vehicles> list)
        {
            Console.WriteLine($"Ebben az évben balbal: ");
            foreach(var car in list)
            {
                if(car.GyartasiEv > 2015 && car.Ar < 5000000)
                {
                    Console.WriteLine($"\t* {car.Marka} - {car.Modell}");
                }
            }
        }

        public static void BenzinSUm(List<Vehicles> list)
        {
            Dictionary<string,int> CarDict = new Dictionary<string, int>();
            foreach (var car in list)
            {
                if (!CarDict.ContainsKey(car.Uzemanyag))
                {
                    CarDict.Add(car.Uzemanyag, 1);
                } 
                else
                {
                    CarDict[car.Uzemanyag]++;
                }
            }
        }



        public int ID { get; set; }
        public string Marka { get; set;}
        public string Modell { get; set; }
        public int GyartasiEv { get; set; }
        public string Uzemanyag { get; set; }
        public int Ar { get; set; }
        public int Kilometerora { get; set; }
    }
}