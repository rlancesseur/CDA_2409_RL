using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    public class Television
    {
        public bool allume;
        public int chaine;
        public string marque;
        public string resolution;
        public float tailleEcranPouces;
        public int volume;

        public Television()
        {
            allume = true;
            chaine = 6;
            marque = "Samsung";
            resolution = "4k";
            tailleEcranPouces = 30;
            volume = 10;
        }

        public Television(bool _allume, int _chaine, string _marque, string _resolution, float _tailleEcranPouces, int _volume)
        {
            this.allume = _allume;
            this.chaine = _chaine;
            this.marque = _marque;
            this.resolution = _resolution;
            this.tailleEcranPouces = _tailleEcranPouces;
            this.volume = _volume;
        }

        public bool allumer()
        {
            bool result = false;
            if(this.allume == false)
            {
                this.allume = true;
                result = true;
            }

            return result;
        }

        public bool eteindre()
        {
            bool result = false;
            if (this.allume == true)
            {
                this.allume = false;
                result = true;
            }

            return result;
        }

        public void augmenterChaine()
        {
            if(this.allume == true)
            {
                this.chaine++;
            }
        }

        public void diminuerChaine()
        {
            if(this.allume == true && this.chaine > 0)
            {
                this.chaine--;
            }
        }

        public void changerChaine(int chaine)
        {
            if (this.allume == true)
            {
                this.chaine = chaine;
            }
        }

        public void augmenterVolume()
        {
            if (this.allume == true)
            {
                this.volume++;
            }
        }

        public void diminuerVolume()
        {
            if (this.allume == true && this.volume > 0)
            {
                this.volume--;
            }
        }

    }
}
