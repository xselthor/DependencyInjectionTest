using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DependencyInjectionTest
{
    public class LoadXML : ILoading
    {
        public static List<DandDMonster> monsters = new List<DandDMonster>();

        public void WczytajDane(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<DandDMonster>), new XmlRootAttribute("root"));

            using (FileStream fstream = File.OpenRead(filename))
            {
                monsters = (List<DandDMonster>)serializer.Deserialize(fstream);
            }

            foreach (var monster in monsters)
            {
                Console.WriteLine(monster.name);
            }
        }

        public void ShowData()
        {
            throw new NotImplementedException();
        }

        public List<DandDMonster> GetDMonsters()
        {
            return monsters;
        }

        public string DataFrom()
        {
            return "XML";
        }
    }
}
