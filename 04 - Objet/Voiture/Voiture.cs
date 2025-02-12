using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public class Voiture
    {
        string marque;
        protected float chargeBatterieEnPourcentage;
        bool pharesAllume;
        bool porteOuverte;

        public Voiture()
        {
            marque = "Toyota";
            chargeBatterieEnPourcentage = 80;
            pharesAllume = false;
            porteOuverte = true;
        }

        public Voiture(string _marque, float _chargeBatterieEnPourcentage, bool _pharesAllume, bool _porteOuverte)
        {
            marque = _marque;
            chargeBatterieEnPourcentage = _chargeBatterieEnPourcentage;
            pharesAllume = _pharesAllume;
            porteOuverte = _porteOuverte;
        }

        public Voiture(Voiture voitureACopier)
        {
            marque = voitureACopier.marque;
            chargeBatterieEnPourcentage = voitureACopier.chargeBatterieEnPourcentage;
            pharesAllume = voitureACopier.pharesAllume;
            porteOuverte = voitureACopier.porteOuverte;
        }

        public bool AllumerPhares()
        {
            if(chargeBatterieEnPourcentage > 0 && !pharesAllume) 
            {
                pharesAllume = true;
                return true;
            }
            return false;
        }

        public bool EteindrePhares()
        {
            if (pharesAllume)
            {
                pharesAllume = false;
                return true;
            }
            return false;
        }

        public bool FermerPorte()
        {
            if(porteOuverte)
            {
                porteOuverte = false;
                return true;
            }
            return false;
        }

        public bool OuvrirPorte()
        {
            if (!porteOuverte)
            {
                porteOuverte = true;
                return true;
            }
            return false;
        }

    }
}
