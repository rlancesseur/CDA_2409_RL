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

        public bool fermer()
        {
            bool result = false;
            if(this.ouvert == true)
            {
                this.ouvert = false;
                result = true;
            }
            return result;
        }

        public bool ouvrir()
        {
            bool result = false;
            if (this.ouvert == false)
            {
                this.ouvert = true;
                result = true;
            }
            return result;
        }

        public bool remplir()
        {
            bool result = false;

            if(this.ouvert == true && this.contenuEnL != this.contenanceEnL)
            {
                this.contenuEnL = this.contenanceEnL;
                result = true;
            }
            return result;
        }

        public bool vider()
        {
            bool result = false;

            if (this.ouvert == true && this.contenuEnL != 0)
            {
                this.contenuEnL = 0;
                result = true;
            }
            return result;
        }

        public bool remplirQuantite(float quantite)
        {
            bool result = false;

            if (this.ouvert == true && (this.contenuEnL + quantite) <= this.contenanceEnL)
            {
                this.contenuEnL += quantite;
                result = true;
            }
            return result;
        }

        public bool viderQuantite(float quantite)
        {
            bool result = false;

            if (this.ouvert == true && (this.contenuEnL - quantite) >= 0)
            {
                this.contenuEnL -= quantite;
                result = true;
            }
            return result;
        }

    }
}
