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

namespace PTO_01_02_Meetwiel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomGenerator = new Random();
        int number;
        string value = "";

        int rndGetal;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Te_Generen_Omwentellingen_TextChanged(object sender, TextChangedEventArgs e)
        {
            value = tboxTeGenerenOmwentellingen.Text;
            bool Succes = Int32.TryParse(value, out number); // manier om een string om te zetten naar een int ALLEEN als de inhoud in een INT kan worden gestoken.
            if (Succes) //True
            {
                if (number > 0 && number <= 10)
                {
                    btnGenereerOmwentelingen.IsEnabled = true;

                }
                else
                {
                    btnGenereerOmwentelingen.IsEnabled = false;
                }
            }
            else //False
            {
                btnGenereerOmwentelingen.IsEnabled = false;
            }

        }

        private void btn_Genereer_Omwentelingen_Click(object sender, RoutedEventArgs e)
        {

            btnBerekenen.IsEnabled = true;

        }

        private void btn_Berekenen_Click(object sender, RoutedEventArgs e)
        {
            int i;

            for (i = number; i > 0; i--)
            {
                int randomGetal = randomGenerator.Next(50, 2500);
                rndGetal = randomGetal;
                double uitkomst = BerekenenAfgelegdeWeg(rndGetal);
                ListBoxItem newResult = new ListBoxItem();
                newResult.Content = tboxTeGenerenOmwentellingen.Text;
                listBoxUitkomst.Items.Add(uitkomst);
            }

        }

        private double BerekenenOmtrek()
        {
            double diameter = 45;
            double omtrek = diameter * Math.PI;
            return omtrek;
        }

        private double BerekenenAfgelegdeWeg(int rndGetal)
        {
            double omtrek = BerekenenOmtrek();
            double uitkomst = omtrek * rndGetal;
            return uitkomst;
        }
    }
}