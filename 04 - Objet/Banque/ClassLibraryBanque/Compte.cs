using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    public class Compte
    {
        int numero;
        string nomProprietaire;
        float solde;
        float decouvertAutorise;

        public Compte()
        {
            numero = 0000;
            nomProprietaire = "Toto";
            solde = 1000;
            decouvertAutorise = -500;
        }

        public Compte(int _numero, string _nomProprietaire, float _solde, float _decouvertAutorise)
        {
            this.numero = _numero;
            this.nomProprietaire = _nomProprietaire;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }

        public override string ToString()
        {
            return "Numéro du compte: " + this.numero + " Nom : " + this.nomProprietaire + " Solde : " + this.solde + " Découvert autorisé : " + this.decouvertAutorise;
        }

        public void CrediterMontant(float montant)
        {
            this.solde += montant;
        }

        public bool DebiterMontant(float montant)
        {
            bool result = false;

            if ((this.solde - montant) >= this.decouvertAutorise)
            {
                this.solde -= montant;
                result = true;
            }
            return result;
        }

        public void TransfererMontant(float montant, Compte compte)
        {
            this.DebiterMontant(montant);
            compte.CrediterMontant(montant);
        }

        public bool ComparerSolde(Compte compte)
        {
            bool result = false;

            if (this.solde > compte.solde)
            {
                result = true;
            }
            return result;
        }
    }
}
