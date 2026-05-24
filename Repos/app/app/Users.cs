using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace app
{
    internal class Users
    {
        public Users(string line)
        {
            string[] data = line.Split(',');
            ID = int.Parse(data[0]);
            Username = data[1];
            Email = data[2];
            OrderDate = data[3];
            OrderPrice = int.Parse(data[4]);
            Authorization = data[5];
        }

        public static List<Users> DataReader(string filePath)
        {
            List<Users> list = new List<Users>();
            string[] data = File.ReadAllLines(filePath);
            for (int i = 1; i < data.Length; i++) 
            {
                list.Add(new Users(data[i]));
            }
            return list;
        }

        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string OrderDate { get; set; }
        public int OrderPrice { get; set; }
        public string Authorization { get; set; }

    }
}
