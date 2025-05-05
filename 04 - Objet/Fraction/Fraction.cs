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

        /// <summary>
        /// Constructeur principal (initialise une fraction avec les coordonnées en paramètre)
        /// </summary>
        /// <param name="_numerateur"></param>
        /// <param name="_denominateur"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Fraction(int _numerateur, int _denominateur)
        {
            if(_denominateur == 0)
            {
                throw new ArgumentNullException(nameof(_denominateur), "Le dénominateur ne peut pas être nul.");
            }
            numerateur = _numerateur;
            denominateur = _denominateur;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Fraction() : this (0, 1)
        {
        }

        /// <summary>
        /// Constructeur par clonage (initialise une fraction en copiant les coordonnées de la fraction en paramètre)
        /// </summary>
        /// <param name="_fractionACopier"></param>
        public Fraction(Fraction _fractionACopier)
        {
            this.numerateur = _fractionACopier.numerateur;
            this.denominateur = _fractionACopier.denominateur;
        }

        /// <summary>
        /// Constructeur qui initialise une fraction ayant 1 pour dénominateur par défaut
        /// </summary>
        /// <param name="_numerateur"></param>
        public Fraction(int _numerateur)
        {
            numerateur = _numerateur;
            denominateur = 1;
        }


        public static Fraction operator +(Fraction a, Fraction b)
        {
            int nouveauNumerateur = 0;
            int nouveauDenominateur = 0;

            nouveauNumerateur = ((a.numerateur * b.denominateur) + (a.denominateur * b.numerateur));
            nouveauDenominateur = a.denominateur * b.denominateur;

            Fraction nouvelleFraction = new(nouveauNumerateur, nouveauDenominateur);
            return nouvelleFraction;
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

        public bool SuperieurA(Fraction _fraction)
        {
            bool result = false;
            if ((this.numerateur / this.denominateur) > (_fraction.numerateur / _fraction.denominateur))
            {
                result = true;
            }
            return result;
        }

        public bool EgalA(Fraction _fraction)
        {
            bool result = false;
            if ((this.numerateur / this.denominateur) == (_fraction.numerateur / _fraction.denominateur))
            {
                result = true;
            }
            return result;
        }

        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }

        private void Reduire()
        {   
        }

        public Fraction Plus(Fraction _fraction)
        {
            int nouveauNumerateur = 0;
            int nouveauDenominateur = 0;

            nouveauNumerateur = ((this.numerateur * _fraction.denominateur) + (this.denominateur * _fraction.numerateur));
            nouveauDenominateur = this.denominateur * _fraction.denominateur;

            Fraction nouvelleFraction = new(nouveauNumerateur, nouveauDenominateur);
            return nouvelleFraction;
        }

        public Fraction Moins(Fraction _fraction)
        {
            int nouveauNumerateur = 0;
            int nouveauDenominateur = 0;

            nouveauNumerateur = ((this.numerateur * _fraction.denominateur) - (this.denominateur * _fraction.numerateur));
            nouveauDenominateur = this.denominateur * _fraction.denominateur;

            Fraction nouvelleFraction = new(nouveauNumerateur, nouveauDenominateur);
            return nouvelleFraction;
        }

        public Fraction Multiplie(Fraction _fraction)
        {
            int nouveauNumerateur = this.numerateur * _fraction.numerateur;
            int nouveauDenominateur = this.denominateur * _fraction.denominateur;

            Fraction nouvelleFraction = new(nouveauNumerateur, nouveauDenominateur);
            return nouvelleFraction;
        }

        public Fraction Divise(Fraction _fraction)
        {
            int nouveauNumerateur = 0;
            int nouveauDenominateur = 0;

            nouveauNumerateur = (this.numerateur * _fraction.denominateur);
            nouveauDenominateur = this.denominateur * _fraction.denominateur;

            Fraction nouvelleFraction = new(nouveauNumerateur, nouveauDenominateur);
            return nouvelleFraction;
        }

        public override string ToString()
        {
            return base.ToString() + "; Numérateur : " + numerateur + "; Dénominateur : " + denominateur;
        }

    }
}
