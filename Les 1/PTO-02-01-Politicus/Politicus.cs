using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTO_02_01_Politicus
{
    class Politicus
    {
        public string _Voornaam {get; set;}
        public string _Achternaam {get; set;}
        public string _Partij  {get; set;}
        public int _VoorkeurStemmen {get; set;}
        public string _Geslacht { get; set; }
        public object SelectedItem {get; set;}
        public string selectedPol {get; set;}

        //constructor
        public Politicus(string Voornaam, string Achternaam, string Partij, int Voorkeurstemmen, string Geslacht)
        {
            _Voornaam = Voornaam;
            _Achternaam = Achternaam;
            _Partij = Partij;
            _VoorkeurStemmen = Voorkeurstemmen;
            _Geslacht = Geslacht;
        }

        //public Boolean Politicus(string selectedPol, string selectedItem)
        //{
        //    foreach (Politicus politicus in PoliticusList)
        //    {
        //        selectedPol = ($"{politicus._Voornaam} {politicus._Achternaam} {politicus._Partij}");
        //        selectedItem = comboPoliticus.SelectedItem.ToString();

        //        if (selectedPol == selectedItem)
        //        {
                   
        //        }
        //    }
        
        public Politicus()
        {

        }

    }
    
}
