﻿namespace ClassLibraryVoitureBis
{
    public class Roue
    {
        string marqueRoue;
        public bool tourne;
        float usureEnMm;

        public Roue(string _marqueRoue, bool _tourne, float _usureEnMm)
        {
            if (_usureEnMm < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_usureEnMm), "L'usure doit être exprimé avec un nombre positif");
            }
            marqueRoue = _marqueRoue;
            tourne = _tourne;
            usureEnMm = _usureEnMm;
        }

        public Roue() : this("Michelin", false, 0)
        {
        }

        public Roue(Roue roueACopier)
        {
            marqueRoue = roueACopier.marqueRoue;
            tourne = roueACopier.tourne;
            usureEnMm = roueACopier.usureEnMm;
        }

        public bool Tourner()
        {
            if(!tourne)
            {
                tourne = true;
                return true;
            }
            return false;
        }

        public bool ArreterTourner()
        {
            if(tourne)
            {
                tourne = false;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + "; Marque : " + marqueRoue + "; Usure en mm : " + usureEnMm + "; Tourne : " + tourne;
        }
    }
}
