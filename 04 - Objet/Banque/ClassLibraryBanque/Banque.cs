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

        }

        public string RendCompte(int numeroCompteDemande)
        {
            
        }

        public bool AjouteCompte(int numeroCompteDebiteur, int numeroCompteCrediteur, float montantTransfert)
        {
            bool result = false;

            return result;
        }
    }
}
