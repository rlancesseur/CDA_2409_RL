using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    public class Compte : IComparable
    {
        public uint numero;
        string nomProprietaire;
        public float solde;
        float decouvertAutorise;

        public Compte(uint _numero, string _nomProprietaire, float _solde, float _decouvertAutorise)
        {
            if (_solde < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_solde), "Le solde à la création du compte ne peut pas être négatif.");
            }
            if (_decouvertAutorise > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_decouvertAutorise), "Le découvert autorisé à la création du compte doit être négatif.");
            }
            numero = _numero;
            nomProprietaire = _nomProprietaire;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }

        public void CrediterMontant(float montant)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), "Le montant à créditer ne peut pas être négatif.");
            }
            solde += montant;
        }

        public bool DebiterMontant(float montant)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), "Le montant à débiter ne peut pas être négatif.");
            }
            if ((solde - montant) >= decouvertAutorise)
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

            DebiterMontant(montant);
            compteDestinataire.CrediterMontant(montant);
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Le compte n'existe pas");
            }

            if (obj is Compte compteAComparer)
            {
                if (solde > compteAComparer.solde)
                {
                    return 1;
                }
                else if (solde < compteAComparer.solde)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + "; Numéro du compte: " + numero + " Nom : " + nomProprietaire + " Solde : " + solde + " Découvert autorisé : " + decouvertAutorise;
        }
    }
}
