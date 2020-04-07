using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PTO_06_01_MaximLejaeghere
{
    class FooiModel
    {
        //Fields
    
        private string _inputPrijsTekst;

        public string InputPrijsTekst
        {
            get { return _inputPrijsTekst; }
            set { _inputPrijsTekst = value; }
        }


        private double _inputPrijs;
        public double Inputprijs
        {
            get { return _inputPrijs; }
            set { _inputPrijs = value; }
        }

        private double _fooiPercentage;

        public double FooiPercentage
        {
            get { return _fooiPercentage; }
            set { _fooiPercentage = value; }
        }

        private double _fooi;

        public double Fooi
        {
            get { return _fooi; }
            set { _fooi = value; }
        }

        private int _totalePrijs;

        public int TotalePrijs
        {
            get { return _totalePrijs; }
            set { _totalePrijs = value; }
        }



        //Constructors
        
        public FooiModel(string inputPrijsTekst, double fooiPercentage)
        {
            inputPrijsTekst = _inputPrijsTekst;
            fooiPercentage = _fooiPercentage;
            
        }

        public FooiModel()
        {

        }

        //Methods
        public double TotaleFooi(double inputprijs, double fooipercentage)
        {
            Fooi = Math.Round(inputprijs * fooipercentage / 100, 2); // Berekening fooi, met afronding naar maximaal 2 cijfers na de comma
            return Fooi;
        }

        public int TotalePrijsBerekenen(double fooi, string prijsberekening)
        {
            bool Succes;
            double s;

            Succes = double.TryParse(InputPrijsTekst, out s); // manier om een string om te zetten naar een int ALLEEN als de inhoud in een INT kan worden gestoken.
            if (Succes) //True
            {
                Inputprijs = s;

            }
            else //False (als de string "InputPrijsRekening" niet omgezet kan worden naar een double, zal deze automatisch op 0 worden gezet.
            {
                Inputprijs = 0;
            }
            TotaleFooi(Inputprijs, FooiPercentage);
            TotalePrijs = Convert.ToInt32(Fooi + Inputprijs);
            return TotalePrijs;
        }


       
        
       
    }
}
