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

namespace PTO_06_01_MaximLejaeghere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FooiModel GetFooi = new FooiModel();

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            GetFooi = new FooiModel() { InputPrijsTekst = txtInputPrijs.Text, FooiPercentage = sliderPercent.Value };
            GetFooi.TotalePrijsBerekenen(GetFooi.Fooi, GetFooi.InputPrijsTekst);
            lblFooi.Content = GetFooi.Fooi;
            lblTotaal.Content = GetFooi.TotalePrijs;
        }

    }
}
