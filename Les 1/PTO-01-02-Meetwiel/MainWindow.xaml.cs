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
        Meetwiel meetwiel1;
       
        public MainWindow()
        {
            InitializeComponent();

            meetwiel1 = new Meetwiel();
        }
     
        private void Te_Generen_Omwentellingen_TextChanged(object sender, TextChangedEventArgs e)
        {
            meetwiel1.Value = tboxTeGenerenOmwentellingen.Text;
            meetwiel1.ButtonGenereerTrue(meetwiel1.Value);
            btnGenereerOmwentelingen.IsEnabled = meetwiel1.Succes;

        }

        private void btn_Genereer_Omwentelingen_Click(object sender, RoutedEventArgs e)
        {

            btnBerekenen.IsEnabled = true;

        }

        private void btn_Berekenen_Click(object sender, RoutedEventArgs e)
        {
            

            for (meetwiel1.i = meetwiel1.Number; meetwiel1.i > 0; meetwiel1.i--)
            {
                meetwiel1.RandomGenerator(meetwiel1.Number, meetwiel1.randomGetal);
                ListBoxItem newResult = new ListBoxItem();
                newResult.Content = tboxTeGenerenOmwentellingen.Text;
                listBoxUitkomst.Items.Add(meetwiel1.uitkomst);

            }
        }
    }
}
