using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionTest.Pages
{
    public class IndexModel : PageModel
    {
        
        //private IMojaZaleznosc _zaleznosc;
        private ILoading _loading;
        public List<DandDMonster> monsters = new List<DandDMonster>();
        public string dataFrom;

        /*
        public IndexModel(IMojaZaleznosc zaleznosc)
        {
            _zaleznosc = zaleznosc;
        }
        */
        public IndexModel(ILoading loading)
        {
            _loading = loading;
        }

        public IActionResult OnGet()
        {
            //_zaleznosc.NapiszWiadomosc("Ta wiadomość została wysłana z metody OnGet");
            
            _loading.WczytajDane("srd_5e_monsters.json");
            //_loading.WczytajDane("srd_5e_monsters.xml");
            monsters = _loading.GetDMonsters();
            dataFrom = _loading.DataFrom();
            return Page();
        }

        
    }
}
