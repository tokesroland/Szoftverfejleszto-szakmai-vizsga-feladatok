using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace javitasNetrunner
{
    internal class Implant
    {
        static int dangerousImplantCount = 0;
        static int hardwareProfileCount = 0;
        static char wrongChar;
        static bool ReadmeReady = false;
        static bool FileFixReady = false;

        public Implant(string sor)
        {
            string javitottSor = sor.Replace(';', '|');
            string[] data = javitottSor.Split('|');

            ID = int.Parse(data[0]);
            name = data[1];
            slot = data[2];
            ram_usage = int.Parse(data[3]);
            danger_level = int.Parse(data[4]);
        }

        public static List<Implant> Beolvasas(string filePath)
        {
            List<Implant> list = new List<Implant>();
            string[] data = File.ReadAllLines(filePath);
            wrongChar = data[1][1];

            for(int i = 1; i < data.Length; i++)
            {
                list.Add(new Implant(data[i]));
                hardwareProfileCount++;
            }
            return list;
        }

        public static void CreateReadMe(string filePath, List<Implant> list)
        {
            string[] sorok = new string[5];
            List<string> slotok = new List<string>();

            foreach(Implant im in list)
            {
                if (!slotok.Contains(im.slot))
                {
                    slotok.Add(im.slot);
                }
                if(im.danger_level > 80)
                {
                    dangerousImplantCount++;
                }
            }
            int slotCount = slotok.Count;

            sorok[0] = "CYBERWARE ADATELEMZÉSI JELENTÉS";
            sorok[1] = "-------------------------------";
            sorok[2] = $"Aktív hálózati slotok száma: {slotCount}";
            sorok[3] = $"Sérült elválasztó karakter: pipe ({wrongChar})";
            sorok[4] = $"Kiemelten veszélyes modulok (danger > 80): {dangerousImplantCount} db";
            try
            {
                File.WriteAllLines(filePath, sorok);

                if (File.Exists(filePath))
                {
                    ReadmeReady = true;
                }
            } catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void FileFixer(string path, string fixedPath)
        {
            string[] adatok = File.ReadAllLines(path);
            string[] NewData = new string[adatok.Length];

            for (int i = 0; i < adatok.Length; i++) 
            {
                NewData[i] = adatok[i].Replace('|', ';');
            }

            try
            {
                File.WriteAllLines(path, NewData);
                if (File.Exists(path))
                {
                    FileFixReady = true;
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void ConsoleKiiratas()
        {
            try
            {
                Console.WriteLine(
                    "[=] === NEONCITY CYBERWARE RECOVERY SYSTEM === [=]\n" +
                    "Időbélyeg: 2076-05-20\n" +
                    "Sérült szektorok beolvasása...\n" +
                    $"Sikeresen dekódolva: {hardwareProfileCount} hardver-profil.\n" +
                    $"\nAdatstruktóra javítása..."
                );
                if (FileFixReady)
                {
                    Console.WriteLine($"[FIXED] Hibás elválasztó karakter ({wrongChar}) sikeresen javítva pontosvesszőre (;).\n\n");
                }
                else
                {
                    Console.WriteLine("[ERROR] a hibás karakter nem lett javítva!");
                }

                Console.WriteLine("Archiválás folyamatban:");

                if (FileFixReady) 
                {
                    Console.WriteLine("-> Mentve: Readme.txt (Statisztikai jelentés)\n");
                } else Console.WriteLine("-> Readme.txt mentési hiba");

                if (ReadmeReady) 
                {
                    Console.WriteLine("-> Mentve: implants_javitott.csv (Tiszta adatfolyam)\n");
                } else Console.WriteLine("-> csv mentési hiba");

                if (ReadmeReady && FileFixReady) 
                {
                    Console.WriteLine("Rendszer üzenet: A dekódolás sikeresen lefutott. Ready.");
                }

            } catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public int ID { get; set; }
        public string name { get; set; }
        public string slot { get; set; }
        public int ram_usage { get; set; }
        public int danger_level { get; set; }
    }
}