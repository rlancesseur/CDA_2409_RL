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
        int nbrMancheJoue;
        int point;
        bool estTerminee;
        Manche saMancheCourante;

        public Partie421(int _nbrMancheAJouer)
        {
            if(_nbrMancheAJouer <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_nbrMancheAJouer), "Le nombre de manche à jouer doit être positif");
            }

            nbrMancheAJouer = _nbrMancheAJouer;
            nbrMancheJoue = 0;
            point = nbrMancheAJouer * 10;
            estTerminee = false;
            saMancheCourante = new Manche();

            if(saMancheCourante.estTerminee)
            {
                point += saMancheCourante.pointManche;
                saMancheCourante = new Manche();
                nbrMancheJoue++;
            }
        }

        public void EstTerminee()
        {
            if(nbrMancheJoue == nbrMancheAJouer || point < 0)
            {
                estTerminee = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "; Nombre de manches à jouer : " + nbrMancheAJouer + "; Nombre de manches jouées : " + nbrMancheJoue
                + "; Points : " + point + "; Partie terminée : " + estTerminee;
        }

    }
}
