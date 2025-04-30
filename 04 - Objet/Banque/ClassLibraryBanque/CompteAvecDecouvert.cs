namespace ClassLibraryBanque
{
    public class CompteAvecDecouvert : Compte
    {
        protected float decouvertAutorise;
        public CompteAvecDecouvert(uint _numero, string _nomProprietaire, float _solde, float _decouvertAutorise) : base(_numero, _nomProprietaire, _solde)
        {
            if (_decouvertAutorise > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_decouvertAutorise), "Le découvert autorisé à la création du compte doit être négatif.");
            }
            decouvertAutorise = _decouvertAutorise;
        }

        public override bool DebiterMontant(float montant)
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
        public override string ToString()
        {
            return base.ToString() + "; Numéro du compte: " + numero + " Nom : " + nomProprietaire + " Solde : " + solde + " Découvert autorisé : " + decouvertAutorise;
        }
    }
}

        