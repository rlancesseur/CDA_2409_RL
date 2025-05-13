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

        public void LancerUnDe(int numeroDe)
        {
            this.saMancheCourante.LancerUnDe(numeroDe);
        }

        public void LancerDeuxDes(int numeroDe1, int numeroDe2)
        {
            this.saMancheCourante.LancerDeuxDes(numeroDe1, numeroDe2);
        }

        public void LancerTroisDes()
        {
            this.saMancheCourante.LancerTroisDes();
        }

        public string AfficherValeursDesDeMancheCourante()
        {
            return this.saMancheCourante.AfficherValeursDe();
        }

        private int MancheRestante()
        {
            return nbrMancheAJouer - nbrMancheJouee;
        }

        public void MancheJouee()
        {
            if (saMancheCourante.MancheEstTerminee())
            {
                nbrMancheJouee++;
            }
        }

        public bool PartieEstTerminee()
        {
            if(MancheRestante() == 0 || point < 0)
            {
                return true;
            }
            return false;
        }

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
