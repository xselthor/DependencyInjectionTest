using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class LoadJSON : ILoading
    {
        public static List<DandDMonster> monsters = new List<DandDMonster>();

        public LoadJSON()
        {

        }

        public void WczytajDane(string filename)
        {
            Console.WriteLine("monster list");

            using (StreamReader fstream = new StreamReader(filename))
            {
                var data = fstream.ReadToEnd();
                monsters = JsonConvert.DeserializeObject <List<DandDMonster>>(data);
            }
        }

        public void ShowData()
        {
            Console.WriteLine("test");
        }

        public List<DandDMonster> GetDMonsters()
        {
            return monsters;
        }

        public string DataFrom()
        {
            return "JSON";
        }
    }
}


