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

        public VoitureEssence(string _marque, float _chargeBatterieEnPourcentage, bool _pharesAllume, bool _porteOuverte, bool _moteurDemarre, float contenuReservoirEnL, float contenanceReservoirEnL) : base(_marque, _chargeBatterieEnPourcentage, _pharesAllume, _porteOuverte)
        {
            this.moteurDemarre = _moteurDemarre;
            this.contenuReservoirEnL = contenuReservoirEnL;
            this.contenanceReservoirEnL = contenanceReservoirEnL;
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

    }
}
