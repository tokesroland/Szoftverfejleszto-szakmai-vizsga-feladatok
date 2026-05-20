using System.Collections.Generic;
using System.IO;
using System;

namespace javitasNetrunner
{
    class Implant
    {
        static char hibas_karakter;
        static bool readme_file_isdone = false;
        static bool repaired_file_is_done = false;

        public Implant(string sor)
        {
            string javitott = sor.Replace(';', '|');
            string[] data = javitott.Split(hibas_karakter);

            Id = int.Parse(data[0]);
            Name = data[1];
            Slot = data[2];
            Ram_usage = int.Parse(data[3]);
            Danger_level = int.Parse(data[4]);
        }

        public static List<Implant> Beolvas(string filePath)
        {
            List<Implant> list = new List<Implant>();
            string[] adat = File.ReadAllLines(filePath);

            string a = adat[0];
            hibas_karakter = a[2];

            for (int i = 1; i < adat.Length; i++)
            {
                list.Add(new Implant(adat[i]));
            }

            return list;
        }

        public static void ReadmeCreator(string path, List<Implant> list)
        {
            List<string> lista = new List<string>();
            int dangerCnt = 0;

            foreach (Implant item in list) 
            {
                if (!lista.Contains(item.Slot))
                {
                    lista.Add(item.Slot);
                }

                if(item.Danger_level > 80)
                {
                    dangerCnt++;
                }
                
            }
            string SlotCnt = lista.Count.ToString();
            string SerultKarakter = hibas_karakter.ToString();
            string dangerStr = dangerCnt.ToString();

            string[] toFile = new string[5];
            toFile[0] = "CYBERWARE ADATELEMZÉSI JELENTÉS\n";
            toFile[1] = "-------------------------------\n";
            toFile[2] = $"Aktív hálózati slotok száma: {SlotCnt}\n";
            toFile[3] = $"Sérült elválasztó karakter: {SerultKarakter}\n";
            toFile[4] = $"Kiemelten veszélyes modulok(danger > 80): {dangerStr} db\n";

            try
            {
                File.WriteAllLines(path, toFile);
                readme_file_isdone = true;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void FileCorrector(List<Implant> list, string filePath)
        {
            File.WriteAllText(filePath, "id;name;slot;ram_usage;danger_level\n");
            foreach(Implant item in list)
            {
                try
                {
                    File.AppendAllText(filePath, $"{item.Id};{item.Name};{item.Slot};{item.Ram_usage};{item.Danger_level}\n");
                    repaired_file_is_done = true;
                }
                catch (IOException ex) 
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static void Kiiratas(List<Implant> lista)
        {
            Console.WriteLine(
                "[=] === NEONCITY CYBERWARE RECOVERY SYSTEM === [=]\r\n" +
                "Időbélyeg: 2076-05-20\r\n" +
                "Sérült szektorok beolvasása...\r\n" +
                $"Sikeresen dekódolva: {lista.Count} hardver-profil.\n\n"
                
                + "Adatstruktúra javítása...\r\n" +
                $"[FIXED] Hibás elválasztó karakter ({hibas_karakter}) sikeresen javítva pontosvesszőre (;)."
             );

            Console.WriteLine("Archiválás folyamatban...");
            if (readme_file_isdone)
            {
                Console.WriteLine("-> Mentve: Readme.txt (Statisztikai jelentés)");
            }
            else
            {
                Console.WriteLine("Nem sikerült a mentés!");
            }

            if (repaired_file_is_done)
            {
                Console.WriteLine("-> Mentve: implants_javitott.csv (Tiszta adatfolyam)");
            }
            else
            {
                Console.WriteLine("Nem sikerült a mentés!");
            }

            Console.WriteLine("Rendszer üzenet: A dekódolás sikeresen lefutott. Ready.");

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slot { get; set; }
        public int Ram_usage { get; set; }
        public int Danger_level { get; set; }
    }
}