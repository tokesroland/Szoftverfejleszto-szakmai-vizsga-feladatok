using System.Collections.Generic;
using System.IO;
using System;
using System.Threading.Tasks;

namespace javitasNetrunner
{
internal class Implant
{
static char hibas_karakter = '|';
static bool readme_file_is_done=false;
static bool repaired_file_is_done = false;
public Implant(string sor)
{
string javitott = sor.Replace(';', '|');
string[] adat = javitott.Split('|');


ID = int.Parse(adat[0]);
Name = adat[1];
Slot = adat[2];
Ram_usage = int.Parse(adat[3]);
Danger_level = int.Parse(adat[4]);
}

public static List<Implant> Beolvasas(string filePath)
{
List<Implant> lista = new List<Implant>();
string[] fajlTartalma = File.ReadAllLines(filePath);
for (int i = 1; i < fajlTartalma.Length; i++)
{
lista.Add(new Implant(fajlTartalma[i]));
}

return lista;
}

public static void ReadmeCreator(string ReadmePath, List<Implant> lista)
{
List<string> slotok = new List<string>();
int dangerCnt = 0;
foreach (var item in lista)
{
if (!slotok.Contains(item.Slot))
{
slotok.Add(item.Slot);
}

if (item.Danger_level > 80)
{
dangerCnt++;
}


}

string SlotCnt = slotok.Count.ToString();
string SEK = hibas_karakter.ToString();
string dangerStr = dangerCnt.ToString();
string[] fajlba = new string[5];

fajlba[0] = "CYBERWARE ADATELEMZÉSI JELENTÉS\n";
fajlba[1] = "-------------------------------\n";
fajlba[2] = $"Aktív hálózati slotok száma: {SlotCnt}\n";
fajlba[3] = $"Sérült elválasztó karakter: ({hibas_karakter})\n";
fajlba[4] = $"Kiemelten veszélyes modulok (danger > 80): {dangerStr} db\n";

try
{
File.WriteAllLines(ReadmePath, fajlba);
readme_file_is_done = true;
}
catch (IOException ex)
{
Console.WriteLine(ex.ToString());
}
}

public static void RepairFile(List<Implant> lista, string FilePath)
{
File.WriteAllText(FilePath, "id;name;slot;ram_usage;danger_level\n");
foreach (Implant item in lista)
{
try
{
File.AppendAllText(FilePath,
item.ID + ";" +
item.Name + ";" +
item.Slot + ";" +
item.Ram_usage + ";" +
item.Danger_level + "\n");
repaired_file_is_done = true;
}catch (IOException ex)
{
Console.WriteLine(ex.ToString());
}

}
}



public static void Kiiratas(List<Implant> lista)
{
Console.WriteLine("" +
"[=] === NEONCITY CYBERWARE RECOVERY SYSTEM === [=]\n" +
"Időbélyeg: 2076-05-20\n" +
"Sérült szektorok beolvasása...");
Console.WriteLine($"Sikeresen dekódolva: {lista.Count} hardver-profil.\n\n");

Console.WriteLine($"Adatstruktúra javítása...\n" +
$"[FIXED] Hibás elválasztó karakter ({hibas_karakter}) " +
$"sikeresen javítva pontosvesszőre (;).");

Console.WriteLine("Archiválás folyamatban:");
if (readme_file_is_done)
{
Console.WriteLine("-> Mentve: Readme.txt (Statisztikai jelentés)");
}
else
{
Console.WriteLine("****** Nincs mentve: Readme.txt (Statisztikai jelentés)*******");
}

if (repaired_file_is_done)
{
Console.WriteLine("-> Mentve: implants_javitott.csv (Tiszta adatfolyam)");
}
else
{
Console.WriteLine("****** Nincs mentve: implants_javitott.csv (Tiszta adatfolyam)*******");
}

Console.WriteLine("Rendszer üzenet: A dekódolás sikeresen lefutott. Ready.");

}

public int ID { get; set; }
public string Name { get; set; }
public string Slot { get; set; }
public int Ram_usage { get; set; }
public int Danger_level { get; set; }
}
}
