using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    public class Compte
    {
        public int numero;
        string nomProprietaire;
        public float solde;
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
            numero = _numero;
            nomProprietaire = _nomProprietaire;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }

        public override string ToString()
        {
            return "Numéro du compte: " + numero + " Nom : " + nomProprietaire + " Solde : " + solde + " Découvert autorisé : " + decouvertAutorise;
        }

        public void CrediterMontant(float montant)
        {
            solde += montant;
        }

        public bool DebiterMontant(float montant)
        {
            if ((solde - montant) >= decouvertAutorise)
            {
                solde -= montant;
                return true;
            }
            return false;
        }

        public void TransfererMontant(float montant, Compte compte)
        {
            DebiterMontant(montant);
            compte.CrediterMontant(montant);
        }

        public bool ComparerSolde(Compte compte)
        {
            if (solde > compte.solde)
            {
                return true;
            }
            return false;
        }
    }
}
