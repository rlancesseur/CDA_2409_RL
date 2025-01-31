using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public class VoitureEssence : Voiture
    {
        protected float contenuReservoirEnL;
        protected float contenanceReservoirEnL;
        protected bool moteurDemarre;
        protected bool avance;

        public VoitureEssence(string _marque, float _chargeBatterieEnPourcentage, bool _pharesAllume, bool _porteOuverte, bool _moteurDemarre, float _contenuReservoirEnL, float _contenanceReservoirEnL, bool _avance) : base(_marque, _chargeBatterieEnPourcentage, _pharesAllume, _porteOuverte)
        {
            this.moteurDemarre = _moteurDemarre;
            this.contenuReservoirEnL = _contenuReservoirEnL;
            this.contenanceReservoirEnL = _contenanceReservoirEnL;
            this.avance = _avance;
        }

        public bool demarrerMoteur()
        {
            bool result = false;
            if(this.chargeBatterieEnPourcentage > 0 && this.contenuReservoirEnL > 0 && this.moteurDemarre == false)
            {
                this.moteurDemarre = true;
                result = true;
            }
            return result;
        }

        public bool eteindreMoteur()
        {
            bool result = false;
            if (this.moteurDemarre == true)
            {
                this.moteurDemarre = false;
                result = true;
            }
            return result;
        }

        public bool remplirReservoir()
        {
            bool result = false;
            if(this.contenuReservoirEnL < this.contenanceReservoirEnL)
            {
                this.contenuReservoirEnL = this.contenanceReservoirEnL;
                result = true;
            }
            return result;
        }

        public bool remplirReservoirQuantite(float quantite)
        {
            bool result = false;
            if ((this.contenuReservoirEnL + quantite) <= this.contenanceReservoirEnL)
            {
                this.contenuReservoirEnL += quantite;
                result = true;
            }
            return result;
        }

        public bool avancer()
        {
            bool result = false;
            if(this.moteurDemarre == true && this.avance == false)
            {
                this.avance = true;
                result = true;
            }
            return result;
        }

        public bool arreter()
        {
            bool result = false;
            if (this.avance == true)
            {
                this.avance = false;
                result = true;
            }
            return result;
        }

    }
}
