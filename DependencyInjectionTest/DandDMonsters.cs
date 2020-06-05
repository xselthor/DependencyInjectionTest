using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DependencyInjectionTest
{
    public class Rootobject
    {
        public DandDMonster[] Property1 { get; set; }
    }

    public class DandDMonster
    {
        [XmlElement(ElementName = "name")]
        public string name { get; set; }
        [XmlElement(ElementName = "meta")]
        public string meta { get; set; }
        [XmlElement(ElementName = "ArmorClass")]
        public string ArmorClass { get; set; }
        [XmlElement(ElementName = "HitPoints")]
        public string HitPoints { get; set; }
        [XmlElement(ElementName = "Speed")]
        public string Speed { get; set; }
        [XmlElement(ElementName = "STR")]
        public string STR { get; set; }
        [XmlElement(ElementName = "STR_mod")]
        public string STR_mod { get; set; }
        [XmlElement(ElementName = "DEX")]
        public string DEX { get; set; }
        [XmlElement(ElementName = "DEX_mod")]
        public string DEX_mod { get; set; }
        [XmlElement(ElementName = "CON")]
        public string CON { get; set; }
        [XmlElement(ElementName = "CON_mod")]
        public string CON_mod { get; set; }
        [XmlElement(ElementName = "INT")]
        public string INT { get; set; }
        [XmlElement(ElementName = "INT_mod")]
        public string INT_mod { get; set; }
        [XmlElement(ElementName = "WIS")]
        public string WIS { get; set; }
        [XmlElement(ElementName = "WIS_mod")]
        public string WIS_mod { get; set; }
        [XmlElement(ElementName = "CHA")]
        public string CHA { get; set; }
        [XmlElement(ElementName = "CHA_mod")]
        public string CHA_mod { get; set; }
        [XmlElement(ElementName = "SavingThrows")]
        public string SavingThrows { get; set; }
        [XmlElement(ElementName = "Skills")]
        public string Skills { get; set; }
        [XmlElement(ElementName = "Senses")]
        public string Senses { get; set; }
        [XmlElement(ElementName = "Languages")]
        public string Languages { get; set; }
        [XmlElement(ElementName = "Challenge")]
        public string Challenge { get; set; }
        [XmlElement(ElementName = "Traits")]
        public string Traits { get; set; }
        [XmlElement(ElementName = "Actions")]
        public string Actions { get; set; }
        [XmlElement(ElementName = "LegendaryActions")]
        public string LegendaryActions { get; set; }
        [XmlElement(ElementName = "img_url")]
        public string img_url { get; set; }
        [XmlElement(ElementName = "DamageImmunities")]
        public string DamageImmunities { get; set; }
        [XmlElement(ElementName = "ConditionImmunities")]
        public string ConditionImmunities { get; set; }
        [XmlElement(ElementName = "DamageResistances")]
        public string DamageResistances { get; set; }
        [XmlElement(ElementName = "DamageVulnerabilities")]
        public string DamageVulnerabilities { get; set; }
        [XmlElement(ElementName = "Reactions")]
        public string Reactions { get; set; }
    }
}





