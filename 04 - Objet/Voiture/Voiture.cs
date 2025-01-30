using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public class Voiture
    {

        protected string marque;
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
            this.marque = _marque;
            this.chargeBatterieEnPourcentage = _chargeBatterieEnPourcentage;
            this.pharesAllume = _pharesAllume;
            this.porteOuverte = _porteOuverte;
        }

        public bool allumerPhares()
        {
            bool result = false;
            if(this.chargeBatterieEnPourcentage > 0 && this.pharesAllume == false) 
            {
                this.pharesAllume = true;
                result = true;
            }
            return result;
        }

        public bool eteindrePhares()
        {
            bool result = false;
            if (this.pharesAllume == true)
            {
                this.pharesAllume = false;
                result = true;
            }
            return result;
        }

        public bool fermerPorte()
        {
            bool result = false;
            if(this.porteOuverte == true)
            {
                this.porteOuverte = false;
                result = true;
            }
            return result;
        }

        public bool ouvrirPorte()
        {
            bool result = false;
            if (this.porteOuverte == false)
            {
                this.porteOuverte = true;
                result = true;
            }
            return result;
        }

    }
}
