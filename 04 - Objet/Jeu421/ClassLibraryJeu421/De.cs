namespace ClassLibraryJeu421
{
    public class De : IComparable<De>
    {
        int valeur;

        public int Valeur { get => valeur; /* set => valeur = value;*/ }

        /// <summary>
        /// Constructeur par défaut (les dés sont directement lancés quand ils sont instanciés)
        /// </summary>
        public De()
        {
            Jeter();
        }

        /// <summary>
        /// Jete un dé, et retourne une valeur aléatoire comprise entre 1 et 6
        /// </summary>
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
