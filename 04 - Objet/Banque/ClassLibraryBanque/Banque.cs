namespace ClassLibraryBanque
{
    public class Banque
    {
        string nom;
        string ville;
        List<Compte> compte;

        public Banque()
        {
            nom = "Banque de France";
            ville = "Paris";
            compte = new List<Compte>();
        }

        public Banque(string _nom, string _ville)
        {
            this.nom = _nom;
            this.ville = _ville;
            this.compte = new List<Compte>();
        }


        /// <summary>
        /// Ajoute un nouveau compte à la banque.
        /// </summary>
        /// <param name="_nouveauCompte">Le nom du compte à ajouter</param>
        public void AjouterCompte(Compte _nouveauCompte)
        {
            compte.Add(_nouveauCompte);
        }

        public void AjouterCompte(int _numero, string _nomProprietaire, float _solde, float _decouvertAutorise)
        {
            Compte nouveauCompte = new(_numero, _nomProprietaire, _solde, _decouvertAutorise);
            compte.Add(nouveauCompte);
        }

        public override string ToString()
        {
            return "Nom : " + this.nom + " Ville : " + this.ville + " Nombre de comptes : " + compte.Count;
        }

        public string CompteSup()
        {
            string? result = null;
            float soldeSup = 0;

            for (int i = 0; i < compte.Count; i++)
            {
                if (compte[i].solde > soldeSup)
                {
                    soldeSup = compte[i].solde;
                    result = compte[i].ToString();
                }
            }
            return result;
        }

        public string RendCompte(int numeroCompteDemande)
        {
            string? result = null;

            for (int i = 0; i < compte.Count; i++)
            {
                if (compte[i].numero == numeroCompteDemande)
                {
                    result = compte[i].ToString();
                }
            }
            return result;
        }

        public bool Transferer(int numeroCompteDebiteur, int numeroCompteCrediteur, float montantTransfert)
        {
            bool result = false;
            int a = 0;
            int b = 0;

            for (int i = 0; i < compte.Count; i++)
            {
                if (compte[i].numero == numeroCompteDebiteur)
                {
                    a = compte[i].numero;
                }
                if (compte[i].numero == numeroCompteCrediteur)
                {
                    b = compte[i].numero;
                }
            }

            if (a != 0 && b != 0)
            {
                bool debitReussi = false;
                for (int i = 0; i < compte.Count; i++)
                {
                    if (compte[i].numero == a)
                    {
                        debitReussi = compte[i].DebiterMontant(montantTransfert);
                    }
                }

                if (debitReussi)
                {
                    result = true;
                    for (int i = 0; i < compte.Count; i++)
                    {
                        if (compte[i].numero == b)
                        {
                            compte[i].solde += montantTransfert;
                        }
                    }
                }
            }

            return result;
        }
    }
}
