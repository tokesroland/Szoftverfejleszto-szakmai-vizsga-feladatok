using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javitasNetrunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wrongCsvPath = "C:\\Users\\Szonja\\OneDrive\\Asztali gép\\csv\\implants_hibas.csv";
            string FixedcsvPath = "C:\\Users\\Szonja\\OneDrive\\Asztali gép\\csv\\implants_javitott.csv";
            string ReadMePath = "C:\\Users\\Szonja\\OneDrive\\Asztali gép\\csv\\readme.txt";

            List<Implant> implantsList = Implant.Beolvasas(wrongCsvPath);
            Implant.CreateReadMe(ReadMePath, implantsList);
            Implant.FileFixer(wrongCsvPath, FixedcsvPath);

            Implant.ConsoleKiiratas();
        }
    }
}
