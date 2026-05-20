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
            string hibasFilePath = "C:\\Users\\tokerola\\Desktop\\Új mappa\\implants_hibas.csv";
            string JavitottPath = "C:\\Users\\tokerola\\Desktop\\Új mappa\\implants_javitott.csv";
            List<Implant> lista = Implant.Beolvas(hibasFilePath);
            Implant.FileCorrector(lista, JavitottPath);
            Implant.ReadmeCreator("C:\\Users\\tokerola\\Desktop\\Új mappa\\Readme.txt", lista);
            Implant.Kiiratas(lista);
        }
    }
}
