using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PTO_02_01_Politicus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Politicus politicus1 = new Politicus();
        List<Politicus> PoliticusList = new List<Politicus>();
        

        public MainWindow()
        {

            InitializeComponent();
            Politicus initialPoliticus = new Politicus("Magie", "De Block", "Open VLD", 120, "Vrouw");
            PoliticusList.Add(initialPoliticus);
            comboPoliticus.Items.Add($"{initialPoliticus._Voornaam} {initialPoliticus._Achternaam} {initialPoliticus._Partij}");

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Creating and setting the properties of comboBox 
            //string Voornaam, string Achternaam, string Partij, int Voorkeurstemmen, string Geslacht
            politicus1._VoorkeurStemmen = Convert.ToInt32(txtVoorkeurstemmen.Text);
            politicus1._Voornaam = txtVoornaam.Text;
            politicus1._Geslacht = comboGeslacht.Text;
            politicus1._Achternaam = txtAchternaam.Text;
            politicus1._Partij = txtPartij.Text;
            Politicus NewPoliticus = new Politicus(politicus1._Voornaam, politicus1._Achternaam, politicus1._Partij, politicus1._VoorkeurStemmen, politicus1._Geslacht);
            PoliticusList.Add(NewPoliticus);
            comboPoliticus.Items.Add($"{politicus1._Voornaam} {politicus1._Achternaam} {politicus1._Partij}");
        }

        private void comboPoliticus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
