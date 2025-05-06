using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoitureBisbis
{
    public class Moteur
    {
        string typeMoteur;
        public bool estDemarre;

        public Moteur(string _typeMoteur, bool _estDemarre)
        {
            typeMoteur = _typeMoteur;
            estDemarre = _estDemarre;
        }

        public Moteur() : this("Diesel", false)
        {
        }

        public Moteur(Moteur moteurACopier)
        {
            typeMoteur = moteurACopier.typeMoteur;
            estDemarre = moteurACopier.estDemarre;
        }

        public bool DemarrerMoteur()
        {
            if (!estDemarre)
            {
                estDemarre = true;
                return true;
            }
            return false;
        }

        public bool ArreterMoteur()
        {
            if (estDemarre)
            {
                estDemarre = false;
                return true;
            }
            return false;
        }

        public bool Entrainer2RouesMotrices(Roue r1, Roue r2)
        {
            if (estDemarre)
            {
                if (!r1.tourne && !r2.tourne)
                {
                    r1.Tourner();
                    r2.Tourner();
                    return true;
                }
            }
            return false;
        }

        public bool Arreter2RouesMotrices(Roue r1, Roue r2)
        {
            if (estDemarre)
            {
                if (r1.tourne && r2.tourne)
                {
                    r1.ArreterTourner();
                    r2.ArreterTourner();
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + "; Type du moteur : " + typeMoteur + "; est démarré : " + estDemarre;
        }
    }
}
