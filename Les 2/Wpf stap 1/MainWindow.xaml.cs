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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int x = 50;
        private int breedte = 100;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellips1 = new Ellipse();
            ellips1.Width = 100;
            ellips1.Height = 50;
            ellips1.Stroke = new SolidColorBrush(Colors.Black);
            canvasTekenen.Children.Add(ellips1);
        }

        private void btnVerplaatsen_Click(object sender, RoutedEventArgs e)
        {
            //Ellipse ellips1 = new Ellipse();
            //ellips1.Width = 100;
            //ellips1.Height = 50;
            //ellips1.Stroke = new SolidColorBrush(Colors.Black);
            //ellips1.Margin = new Thickness(x, 0, 0, 0);
            //canvasTekenen.Children.Add(ellips1);

            //x = x + 50;

            verplaatsenMor(50);
        }

        private void btnClearCanvas_Click(object sender, RoutedEventArgs e)
        {
            canvasTekenen.Children.Clear();
        }

        private void btnVergroten_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellips1 = new Ellipse();
            ellips1.Width = breedte;
            ellips1.Height = 50;
            ellips1.Stroke = new SolidColorBrush(Colors.Black);
            ellips1.Margin = new Thickness(x, 0, 0, 0);
            canvasTekenen.Children.Add(ellips1);

            breedte = breedte + 50;
        }

        private void verplaatsenMor (int position) {
            Ellipse ellips1 = (Ellipse)canvasTekenen.Children[canvasTekenen.Children.Count - 1];
            MessageBox.Show((canvasTekenen.Children.Count - 1).ToString());
            ellips1.Margin = new Thickness(position + ellips1.Margin.Left, 0, 0, 0);
            canvasTekenen.UpdateLayout();

        }
    }
}
