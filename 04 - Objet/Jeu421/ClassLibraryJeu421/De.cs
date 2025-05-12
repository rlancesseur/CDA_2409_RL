namespace ClassLibraryJeu421
{
    public class De : IComparable<De>
    {
        int valeur;

        public int Valeur { get => valeur; /* set => valeur = value;*/ }

        public De()
        {
            Jeter();
        }

        public void Jeter()
        {
            valeur = Alea.Instance().Nouveau(1, 6);
        }

        public int CompareTo(De? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other), "Le dé n'existe pas");
            }

            return other.Valeur.CompareTo(this.Valeur);
        }
    }
}
