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
        Politicus NewPol = new Politicus();
        List<Politicus> PoliticusList = new List<Politicus>();
        

        public MainWindow()
        {

            InitializeComponent();
            NewPol = new Politicus("Magie", "De Block", "Open VLD", 120, "Vrouw");
            PoliticusList.Add(NewPol);
            comboPoliticus.Items.Add($"{NewPol._Voornaam} {NewPol._Achternaam} {NewPol._Partij}");

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Creating and setting the properties of comboBox 
            NewPol = new Politicus() { _Voornaam = txtVoornaam.Text, _Achternaam = txtAchternaam.Text, _Partij = txtPartij.Text, _VoorkeurStemmen = Convert.ToInt32(txtVoorkeurstemmen.Text), _Geslacht = comboGeslacht.Text };
            PoliticusList.Add(NewPol);
            comboPoliticus.Items.Add($"{NewPol._Voornaam} {NewPol._Achternaam} {NewPol._Partij}");
        }

        private void comboPoliticus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Politicus politicus in PoliticusList)
            {
                string selectedPol = ($"{politicus._Voornaam} {politicus._Achternaam} {politicus._Partij}");
                string selectedItem = comboPoliticus.SelectedItem.ToString();

                if (selectedPol == selectedItem)
                {
                    txtVoornaam.Text = politicus._Voornaam;
                    txtAchternaam.Text = politicus._Achternaam;
                    txtPartij.Text = politicus._Partij;
                    txtVoorkeurstemmen.Text = Convert.ToString(politicus._VoorkeurStemmen);
                }

            }
        }
    }
}
