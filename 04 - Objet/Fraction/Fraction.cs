using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public class Fraction : IComparable<Fraction>
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
        public Fraction(int _numerateur) : this(_numerateur, 1)
        {
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return a.Plus(b);
        }

        public string AffichageTextuelle()
        {
            if(this.denominateur == 1)
            {
                return this.numerateur + "";
            }

            else if(this.numerateur == 0)
            {
                return 0 + "";
            }
            return this.numerateur + "/" + this.denominateur;

        }

        public void Oppose()
        {
            this.numerateur = -(this.numerateur);
        }

        public void Inverse()
        {
            if(this.numerateur == 0)
            {
                throw new ArgumentException("Le dénominateur ne peut pas être 0");
            }
            int pot = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = pot;
        }

        private int ComparerA(Fraction _fraction)
        {
            float gauche = this.numerateur / this.denominateur;
            float droite = _fraction.numerateur / _fraction.denominateur;
            return gauche.CompareTo(droite);
        }

        public bool SuperieurA(Fraction _fraction)
        {
            return ComparerA(_fraction) > 0;
        }

        public bool EgalA(Fraction _fraction)
        {
            return ComparerA(_fraction) == 0;
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
            int pgcd = GetPgcd();
            this.numerateur /= pgcd;
            this.denominateur /= pgcd;
        }

        public Fraction Plus(Fraction _fraction)
        {
            int nouveauNumerateur = ((this.numerateur * _fraction.denominateur) + (this.denominateur * _fraction.numerateur));
            int nouveauDenominateur = this.denominateur * _fraction.denominateur;

            Fraction nouvelleFraction = new(nouveauNumerateur, nouveauDenominateur);
            nouvelleFraction.Reduire();
            return nouvelleFraction;
        }

        public Fraction Moins(Fraction _fraction)
        {
            int nouveauNumerateur = ((this.numerateur * _fraction.denominateur) - (this.denominateur * _fraction.numerateur));
            int nouveauDenominateur = this.denominateur * _fraction.denominateur;

            Fraction nouvelleFraction = new(nouveauNumerateur, nouveauDenominateur);
            nouvelleFraction.Reduire();
            return nouvelleFraction;
        }

        public Fraction Multiplie(Fraction _fraction)
        {
            Fraction nouvelleFraction = new(this.numerateur * _fraction.numerateur, this.denominateur * _fraction.denominateur);
            nouvelleFraction.Reduire();
            return nouvelleFraction;
        }

        public Fraction Divise(Fraction _fraction)
        {
            Fraction nouvelleFraction = new(this.numerateur * _fraction.denominateur, this.denominateur * _fraction.numerateur);
            nouvelleFraction.Reduire();
            return nouvelleFraction;
        }
        public int CompareTo(Fraction? other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + "; Numérateur : " + numerateur + "; Dénominateur : " + denominateur;
        }
    }
}
