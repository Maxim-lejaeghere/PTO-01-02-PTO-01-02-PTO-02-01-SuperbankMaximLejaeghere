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

namespace Wpf_stap_1
{
    
    public partial class MainWindow : Window
    {
        private int x = 50;
        private int breedte = 100;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonTekenen_Click(object sender, RoutedEventArgs e)
        {
            //Ellipse ellipse1 = new Ellipse();
            Balloon ellipse1 = new Balloon();
            Balloon ellipse2 = new Balloon(50, 100);
            //Hoogte als parameter. De breedte staat ingegeven in de derde constructor
            Balloon ellipse3 = new Balloon(70);


            //DisplayON
            ellipse1.DisplayOn(canvasTekenen);
            ellipse2.DisplayOn(canvasTekenen);
            ellipse3.DisplayOn(canvasTekenen);

            //UpdateBalloon

            //inkleuren van de ballon. Methode werd aangeroepen vanuit de klasse Balloon
            ellipse1.inkleuren();
        }

        private void buttonVerplaatsen_Click(object sender, RoutedEventArgs e)
        {

            VerplaatsenHor(50);
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            canvasTekenen.Children.Clear();
        }

        private void buttonVergroten_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse1 = new Ellipse();
            ellipse1.Width = breedte;
            ellipse1.Height = 50;
            ellipse1.Stroke = new SolidColorBrush(Colors.Black);
            ellipse1.Margin = new Thickness(0, 0, 0, 0);
            canvasTekenen.Children.Add(ellipse1);

            breedte = breedte + 100;
        }

        private void buttonBreedte_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse1 = new Ellipse();
            ellipse1.Width = 100;
            ellipse1.Height = 50;
            ellipse1.Stroke = new SolidColorBrush(Colors.Black);
            ellipse1.Margin = new Thickness(0, 0, 0, 0);
            

        }

        // Functie dat de ellipse verplaatst zonder te verdubbelen. 
        // Wordt aangeroepen wanneer men op de knop verplaatsen duwt
        private void VerplaatsenHor(int position)
        {
            Ellipse ellipse1 = (Ellipse)canvasTekenen.Children[canvasTekenen.Children.Count - 1];
            //MessageBox.Show((canvasTekenen.Children.Count - 1).ToString());
            ellipse1.Margin = new Thickness(position + ellipse1.Margin.Left, 0, 0, 0);
            canvasTekenen.UpdateLayout();
        }

       

        private void ChangeWidth(int width)
        {
            Ellipse ellipse1 = (Ellipse)canvasTekenen.Children[canvasTekenen.Children.Count - 1];
            ellipse1.Width = ellipse1.Width + width;
            canvasTekenen.UpdateLayout();
        }


       
    }
}
