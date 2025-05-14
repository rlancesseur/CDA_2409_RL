using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    public class Partie421
    {
        int nbrMancheAJouer;
        int nbrMancheJouee;
        int point;
        Manche saMancheCourante;

        public int Point { get => point; /*set => point = value;*/ }

        /// <summary>
        /// Constructeur par défaut qui instancie un nombre de manche précisé par l'utilisateur en paramètre
        /// </summary>
        /// <param name="_nbrMancheAJouer"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Partie421(int _nbrMancheAJouer)
        {
            if(_nbrMancheAJouer <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_nbrMancheAJouer), "Le nombre de manche à jouer doit être positif");
            }

            nbrMancheAJouer = _nbrMancheAJouer;
            nbrMancheJouee = 0;
            point = nbrMancheAJouer * 10;
            saMancheCourante = new Manche();
        }

        /// <summary>
        /// Crée une nouvelle manche
        /// </summary>
        public void NouvelleManche()
        {
            saMancheCourante = new Manche();
        }

        /// <summary>
        /// Lance un dé (précisé en paramètre)
        /// </summary>
        /// <param name="numeroDe"></param>
        public void LancerUnDe(int numeroDe)
        {
            this.saMancheCourante.LancerUnDe(numeroDe);
        }

        /// <summary>
        /// Lance deux dés (précisés en paramètre)
        /// </summary>
        /// <param name="numeroDe1"></param>
        /// <param name="numeroDe2"></param>
        public void LancerDeuxDes(int numeroDe1, int numeroDe2)
        {
            this.saMancheCourante.LancerDeuxDes(numeroDe1, numeroDe2);
        }

        /// <summary>
        /// Lance les trois dés
        /// </summary>
        public void LancerTroisDes()
        {
            this.saMancheCourante.LancerTroisDes();
        }

        /// <summary>
        /// Affiche la valeur des trois dés de la manche en cours
        /// </summary>
        /// <returns></returns>
        public string AfficherValeursDesDeMancheCourante()
        {
            return this.saMancheCourante.AfficherValeursDe();
        }

        /// <summary>
        /// Retourne le nombre de manche restante
        /// </summary>
        /// <returns></returns>
        private int MancheRestante()
        {
            return nbrMancheAJouer - nbrMancheJouee;
        }

        public bool MancheCouranteEstTerminee()
        {
            return saMancheCourante.MancheEstTerminee();
        }

        /// <summary>
        /// Incrémente le nombre de manche jouée une fois qu'une manche est terminée
        /// </summary>
        public void MancheJouee()
        {
            if (saMancheCourante.MancheEstTerminee())
            {
                nbrMancheJouee++;
            }
        }

        /// <summary>
        /// Retourne true si la partie est terminée (s'il ne reste plus de manche, ou si le nombre de points de l'utilisateur est inférieur à 0)
        /// </summary>
        /// <returns></returns>
        public bool PartieEstTerminee()
        {
            if(MancheRestante() == 0 || point < 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Calcul le nombre de point (+30 si la manche est gagnée, -10 si la manche est perdue)
        /// </summary>
        public void CalculerPoints()
        {
            if(this.saMancheCourante.MancheEstGagnee())
            {
                this.point += 30;
            }
            else
            {
                this.point -= 10;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "; Nombre de manches à jouer : " + nbrMancheAJouer + "; Nombre de manches jouées : " + nbrMancheJouee
                + "; Points : " + point;
        }
    }
}
