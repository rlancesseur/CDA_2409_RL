using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public class VoitureEssence : Voiture
    {
        float contenuReservoirEnL;
        float contenanceReservoirEnL;
        bool moteurDemarre;
        bool avance;

        public VoitureEssence(string _marque, float _chargeBatterieEnPourcentage, bool _pharesAllume, bool _porteOuverte, bool _moteurDemarre, float _contenuReservoirEnL, float _contenanceReservoirEnL, bool _avance) : base(_marque, _chargeBatterieEnPourcentage, _pharesAllume, _porteOuverte)
        {
            moteurDemarre = _moteurDemarre;
            contenuReservoirEnL = _contenuReservoirEnL;
            contenanceReservoirEnL = _contenanceReservoirEnL;
            avance = _avance;
        }

        public bool DemarrerMoteur()
        {
            if(chargeBatterieEnPourcentage > 0 && contenuReservoirEnL > 0 && !moteurDemarre)
            {
                moteurDemarre = true;
                return true;
            }
            return false;
        }

        public bool EteindreMoteur()
        {
            bool result = false;
            if (moteurDemarre == true)
            {
                moteurDemarre = false;
                result = true;
            }
            return result;
        }

        public bool RemplirReservoir()
        {
            if(contenuReservoirEnL < contenanceReservoirEnL)
            {
                contenuReservoirEnL = contenanceReservoirEnL;
                return true;
            }
            return false;
        }

        public bool RemplirReservoirQuantite(float quantite)
        {
            if ((contenuReservoirEnL + quantite) <= contenanceReservoirEnL)
            {
                contenuReservoirEnL += quantite;
                return true;
            }
            return false;
        }

        public bool Avancer()
        {
            if(moteurDemarre && !avance)
            {
                avance = true;
                return true;
            }
            return false;
        }

        public bool Arreter()
        {
            if (avance)
            {
                avance = false;
                return true;
            }
            return false;
        }

    }
}
