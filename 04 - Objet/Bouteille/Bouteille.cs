using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    class Bouteille
    {

        public Boolean ouvert;
        public float contenanceEnL;
        public float contenuEnL;

        public Bouteille()
        {
            ouvert = false;
            contenanceEnL = 2;
            contenuEnL = 1.5f;
        }

        public Bouteille(Boolean _ouvert, float _contenanceEnL, float _contenuEnL)
        {
            this.ouvert = _ouvert;
            this.contenanceEnL = _contenanceEnL;
            this.contenuEnL = _contenuEnL;
        }

        public Boolean fermer()
        {
            Boolean result = false;
            if(this.ouvert == true)
            {
                this.ouvert = false;
                result = true;
            }
            return result;
        }

        public Boolean ouvrir()
        {
            Boolean result = false;
            if (this.ouvert == false)
            {
                this.ouvert = true;
                result = true;
            }
            return result;
        }

        public Boolean remplir()
        {
            Boolean result = false;

            if(this.ouvert == true && this.contenuEnL != this.contenanceEnL)
            {
                this.contenuEnL = this.contenanceEnL;
                result = true;
            }
            return result;
        }

        public Boolean vider()
        {
            Boolean result = false;

            if (this.ouvert == true && this.contenuEnL != 0)
            {
                this.contenuEnL = 0;
                result = true;
            }
            return result;
        }

        public Boolean remplirQuantite(float quantite)
        {
            Boolean result = false;

            if (this.ouvert == true && (this.contenuEnL + quantite) <= this.contenanceEnL)
            {
                this.contenuEnL += quantite;
                result = true;
            }
            return result;
        }

        public Boolean viderQuantite(float quantite)
        {
            Boolean result = false;

            if (this.ouvert == true && (this.contenuEnL - quantite) >= 0)
            {
                this.contenuEnL -= quantite;
                result = true;
            }
            return result;
        }

    }
}
