namespace ClassLibraryBanque
{
    public class CompteAvecDecouvert : Compte
    {
        protected float decouvertAutorise;
        public CompteAvecDecouvert(uint _numero, string _nomProprietaire, float _solde, float _decouvertAutorise) : base(_numero, _nomProprietaire, _solde)
        {
            if (_decouvertAutorise > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_decouvertAutorise), "Le d�couvert autoris� � la cr�ation du compte doit �tre n�gatif.");
            }
            decouvertAutorise = _decouvertAutorise;
        }

        public override bool DebiterMontant(float montant)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), "Le montant � d�biter ne peut pas �tre n�gatif.");
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
            return base.ToString() + "; Num�ro du compte: " + numero + " Nom : " + nomProprietaire + " Solde : " + solde + " D�couvert autoris� : " + decouvertAutorise;
        }
    }
}

        