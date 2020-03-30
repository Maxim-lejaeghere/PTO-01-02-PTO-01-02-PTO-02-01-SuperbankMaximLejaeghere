using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTO_02_01_Politicus
{
    class Politicus
    {
        public string _Voornaam { get; set; }
        public string _Achternaam { get; set; }
        public string _Partij { get; set; }
        public int _VoorkeurStemmen { get; set; }
        public string _Geslacht { get; set; }
        public object SelectedItem { get; set; }


        public Politicus(string Voornaam, string Achternaam, string Partij, int Voorkeurstemmen, string Geslacht)
        {
            _Voornaam = Voornaam;
            _Achternaam = Achternaam;
            _Partij = Partij;
            _VoorkeurStemmen = Voorkeurstemmen;
            _Geslacht = Geslacht;
        }
        
        public Politicus()
        {

        }

    }
    
}
