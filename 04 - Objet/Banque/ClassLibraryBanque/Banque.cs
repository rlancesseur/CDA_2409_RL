namespace ClassLibraryBanque
{
    public class Banque
    {
        string nom;
        string ville;
        public List<Compte> comptes;

        public Banque(string _nom, string _ville)
        {
            nom = _nom;
            ville = _ville;
            comptes = new List<Compte>();
        }

        public void AjouterCompte(Compte _nouveauCompte)
        {
            comptes.Add(_nouveauCompte);
        }

        public void AjouterCompte(uint _numero, string _nomProprietaire, float _solde)
        {
            Compte nouveauCompte = new(_numero, _nomProprietaire, _solde);
            AjouterCompte(nouveauCompte);
        }

        public Compte CompteAuSoldeLePlusGrand()
        {
            Compte? result = null;
            float soldeSup = 0;

            for (int i = 0; i < comptes.Count; i++)
            {
                if (comptes[i].solde > soldeSup)
                {
                    soldeSup = comptes[i].solde;
                    result = comptes[i];
                }
            }
            return result;
        }

        public Compte RendCompte(uint numeroCompteDemande)
        {
            for (int i = 0; i < comptes.Count; i++)
            {
                if (comptes[i].numero == numeroCompteDemande)
                {
                    return comptes[i];
                }
            }
            return null;
        }

        public bool Transferer(uint numeroCompteDebiteur, uint numeroCompteCrediteur, float montantTransfert)
        {
            if (montantTransfert <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montantTransfert), "Le montant à transférer doit être positif.");
            }
            if (numeroCompteDebiteur == numeroCompteCrediteur)
            {
                return false;
            }
            Compte compteDebiteur = RendCompte(numeroCompteDebiteur);
            Compte compteCrediteur = RendCompte(numeroCompteCrediteur);

            bool result = false;

            if (compteDebiteur != null && compteCrediteur != null)
            {
                if (compteDebiteur.DebiterMontant(montantTransfert))
                {
                    compteCrediteur.CrediterMontant(montantTransfert);
                    result = true;
                }
            }
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + "; Nom : " + this.nom + " Ville : " + this.ville + " Nombre de comptes : " + comptes.Count;
        }
    }
}
