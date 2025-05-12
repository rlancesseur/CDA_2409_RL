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
        bool partieEstTerminee;
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
            partieEstTerminee = false;
            saMancheCourante = new Manche();

            if(saMancheCourante.MancheEstTerminee)
            {
                // point += saMancheCourante.pointManche;
                saMancheCourante = new Manche();
                nbrMancheJoue++;
            }
        }

        public void EstTerminee()
        {
            if(nbrMancheJoue == nbrMancheAJouer || point < 0)
            {
                partieEstTerminee = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "; Nombre de manches à jouer : " + nbrMancheAJouer + "; Nombre de manches jouées : " + nbrMancheJoue
                + "; Points : " + point + "; Partie terminée : " + partieEstTerminee;
        }

    }
}
