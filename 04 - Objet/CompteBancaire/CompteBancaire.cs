using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public class CompteBancaire
    {
        public int numero;
        public string nomProprietaire;
        public float solde;
        public float decouvertAutorise;

        public CompteBancaire(int _numero, string _nomProprietaire, float _solde, float _decouvertAutorise)
        {
            this.numero = _numero;
            this.nomProprietaire = _nomProprietaire;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }

        public void afficherContenu()
        {
            Console.WriteLine("Numéro du compte : " + this.numero);
            Console.WriteLine("Nom : " + this.nomProprietaire);
            Console.WriteLine("Solde : " + this.solde);
            Console.WriteLine("Découvert autorisé : " + this.decouvertAutorise);
        }

        public void crediterMontant(float montant)
        {
            this.solde += montant;
        }

        public Boolean debiterMontant(float montant)
        {
            Boolean result = false;

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

        public Boolean comparerSolde(CompteBancaire compte)
        {
            Boolean result = false;

            if (this.solde > compte.solde)
            {
                result = true;
            }

            return result;
        }
    }
}
