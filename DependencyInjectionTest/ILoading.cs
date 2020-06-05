using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public interface ILoading
    {
        public void WczytajDane(string filename);
        public void ShowData();
        public List<DandDMonster> GetDMonsters();
        public string DataFrom();
    }
}
