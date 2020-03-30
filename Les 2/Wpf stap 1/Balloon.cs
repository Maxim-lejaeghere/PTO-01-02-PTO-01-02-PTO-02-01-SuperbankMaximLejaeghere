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
    class Balloon
    {
        //Stap 1: Fields
        public int _breedte;
        public int _hoogte;
        private Ellipse ellipse;

        //Stap 2: Contructor(s)
        public Balloon()
        {
            _breedte = 100;
            _hoogte = 200;
            CreateBalloon();
            UpdateBalloon();
        }

        public Balloon(int breedte, int hoogte)
        {
            _breedte = breedte;
            _hoogte = hoogte;
            CreateBalloon();
            UpdateBalloon();
        }

        public Balloon(int hoogte)
        {
            _breedte = 100;
            _hoogte = hoogte;
            CreateBalloon();
            UpdateBalloon();
        }

        //Stap 3 Methods
        private void CreateBalloon()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
        }

        private void UpdateBalloon()
        {
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            ellipse.Width = _breedte;
            ellipse.Height = _hoogte;
        }

        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }

        //Methode aanmaken voor het inkleuren van de ballon
        public void inkleuren()
        {
            ellipse.Fill = new SolidColorBrush(Colors.Red);
        }

    }
}
