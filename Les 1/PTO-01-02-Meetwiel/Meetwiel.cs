using System;

namespace PTO_01_02_Meetwiel
{

    class Meetwiel
    {   // Properties
        //Public Properties, method -> altijd beginnen met een hoofdletter -> public int Getal
        // private fields beginnen met _  en kleine letter -> private int _getal

        public int Number;
        public bool Succes = false;
        public string Value = "";
        public int RndGetal;
        private bool _succes;
        public Random randomGenerator = new Random();
        public int i;
        public int randomGetal;
        public double uitkomst;


        //methodes

        private double BerekenenOmtrek()
        {
            double diameter = 45;
            double omtrek = diameter * Math.PI;
            return omtrek;
        }

        public double BerekenenAfgelegdeWeg(int rndGetal)
        {
            double omtrek = BerekenenOmtrek();
            uitkomst = omtrek * rndGetal;
            return uitkomst;
        }

        public bool ButtonGenereerTrue(string Value)
        {
            
            Succes = Int32.TryParse(Value, out Number); // manier om een string om te zetten naar een int ALLEEN als de inhoud in een INT kan worden gestoken.
            if (Succes) //True
            {
                if (Number > 0 && Number <= 10)
                {
                    Succes = true;
                }
                else
                {
                    Succes = false;
                }
            }
            else //False
            {
                Succes = false;
            }
            return Succes;
        }

        public double RandomGenerator(int number, int RandomGetal )
        {
            randomGetal = randomGenerator.Next(50, 2500);
            RndGetal = randomGetal;
            uitkomst = BerekenenAfgelegdeWeg(RndGetal);

            return uitkomst;
        }
        //         

    //constructor
    public Meetwiel()
        {

        }

    }
}
