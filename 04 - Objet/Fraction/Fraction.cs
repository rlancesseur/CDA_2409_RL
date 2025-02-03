using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        int numerateur;
        int denominateur;

        public Fraction()
        {
            numerateur = 0;
            denominateur = 1;
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }

        public Fraction(int _numerateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = 1;
        }

        public void Afficher()
        {
            Console.WriteLine("Numérateur : " + this.numerateur + ", Dénominateur : " + this.denominateur);
        }

        public string AffichageTextuelle()
        {
            string result;
            if(this.denominateur == 1)
            {
                result = this.numerateur + "";
            }

            else if(this.numerateur == 0)
            {
                result = 0 + "";
            }
            else
            {
                result = this.numerateur + "/" + this.denominateur;
            }
            return result;
        }

        public void Oppose()
        {
            this.numerateur = -(this.numerateur);
        }

        public void Inverse()
        {
            int pot = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = pot;
        }
    }
}
