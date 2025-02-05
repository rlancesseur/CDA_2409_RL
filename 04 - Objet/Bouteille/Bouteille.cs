using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    class Bouteille
    {

        bool ouvert;
        float contenanceEnL;
        float contenuEnL;

        public Bouteille()
        {
            ouvert = false;
            contenanceEnL = 2;
            contenuEnL = 1.5f;
        }

        public Bouteille(bool _ouvert, float _contenanceEnL, float _contenuEnL)
        {
            this.ouvert = _ouvert;
            this.contenanceEnL = _contenanceEnL;
            this.contenuEnL = _contenuEnL;
        }

        public bool Fermer()
        {
            bool result = false;
            if(this.ouvert == true)
            {
                this.ouvert = false;
                result = true;
            }
            return result;
        }

        public bool Ouvrir()
        {
            bool result = false;
            if (this.ouvert == false)
            {
                this.ouvert = true;
                result = true;
            }
            return result;
        }

        public bool Remplir()
        {
            bool result = false;

            if(this.ouvert == true && this.contenuEnL < this.contenanceEnL)
            {
                this.contenuEnL = this.contenanceEnL;
                result = true;
            }
            return result;
        }

        public bool Vider()
        {
            bool result = false;

            if (this.ouvert == true && this.contenuEnL > 0)
            {
                this.contenuEnL = 0;
                result = true;
            }
            return result;
        }

        public bool RemplirQuantite(float quantiteEnL)
        {
            bool result = false;

            if (quantiteEnL < 0)
                throw new ArgumentOutOfRangeException("quantiteEnL", "La quantité ne peut pas être négative.");

            if (this.ouvert == true && (this.contenuEnL + quantiteEnL) <= this.contenanceEnL)
            {
                this.contenuEnL += quantiteEnL;
                result = true;
            }
            return result;
        }

        public bool ViderQuantite(float quantiteEnL)
        {
            bool result = false;

            if (quantiteEnL < 0)
                throw new ArgumentOutOfRangeException("quantiteEnL", "La quantité ne peut pas être négative.");

            if (this.ouvert == true && (this.contenuEnL - quantiteEnL) >= 0)
            {
                this.contenuEnL -= quantiteEnL;
                result = true;
            }
            return result;
        }

    }
}
