using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class CompteBancaire
    {
        public int numero;
        public string nomProprietaire;
        public float solde;
        public float decouvertAutorise;

        public CompteBancaire()
        {
            numero = 0000;
            nomProprietaire = "Toto";
            solde = 1000;
            decouvertAutorise = -500;
        }

        public CompteBancaire(int _numero, string _nomProprietaire, float _solde, float _decouvertAutorise)
        {
            this.numero = _numero;
            this.nomProprietaire = _nomProprietaire;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }

        public override string ToString()
        {
            return "Numéro du compte: " + this.numero + "Nom : " + this.nomProprietaire + "Solde : " + this.solde + "Découvert autorisé : " + this.decouvertAutorise;
        }

        public void crediterMontant(float montant)
        {
            this.solde += montant;
        }

        public bool debiterMontant(float montant)
        {
            bool result = false;

            if ((this.solde - montant) >= this.decouvertAutorise)
            {
                this.solde -= montant;
                result = true;
            }
            return result;
        }

        public void transfererMontant(float montant, CompteBancaire compte)
        {
            this.debiterMontant(montant);
            compte.crediterMontant(montant);
        }

        public bool comparerSolde(CompteBancaire compte)
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
