using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    public class Compte : IComparable<Compte>
    {
        public uint numero;
        public string nomProprietaire;
        public float solde;

        public Compte(uint _numero, string _nomProprietaire, float _solde)
        {
            if (_solde < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_solde), "Le solde à la création du compte ne peut pas être négatif.");
            }
            numero = _numero;
            nomProprietaire = _nomProprietaire;
            solde = _solde;
        }

        public void CrediterMontant(float montant)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), "Le montant à créditer ne peut pas être négatif.");
            }
            solde += montant;
        }

        public virtual bool DebiterMontant(float montant)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), "Le montant à débiter ne peut pas être négatif.");
            }
            if ((solde - montant) >= 0)
            {
                solde -= montant;
                return true;
            }
            return false;
        }

        public void TransfererMontant(float montant, Compte compteDestinataire)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), "Le montant à transférer ne peut pas être négatif.");
            }
            if (compteDestinataire == null)
            {
                throw new ArgumentNullException(nameof(compteDestinataire), "Le compte destinataire n'existe pas.");
            }

            if(DebiterMontant(montant))
            {
                compteDestinataire.CrediterMontant(montant);
            }
        }

        public int CompareTo(Compte? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other), "Le compte n'existe pas");
            }

            return solde.CompareTo(other.solde);
        }

        public override string ToString()
        {
            return base.ToString() + "; Numéro du compte: " + numero + " Nom : " + nomProprietaire + " Solde : " + solde;
        }
    }
}
