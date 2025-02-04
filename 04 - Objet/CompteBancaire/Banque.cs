using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class Banque
    {
        string nom;
        string ville;
        List<CompteBancaire> compte;
        static int nbComptes = 0;

        public Banque(string _nom, string _ville)
        {
            this.nom = _nom;
            this.ville = _ville;
        }

        public void AjouterCompte(CompteBancaire _nouveauCompte)
        {
            compte.Add(_nouveauCompte);
            nbComptes++;
        }

        public void AjouterCompte(int _numero, string _nomProprietaire, float _solde, float _decouvertAutorise)
        {

            // A Refaire
            CompteBancaire nouveauCompte = new(_numero, _nomProprietaire, _solde, _decouvertAutorise);

            nbComptes++;
        }
    }
}
