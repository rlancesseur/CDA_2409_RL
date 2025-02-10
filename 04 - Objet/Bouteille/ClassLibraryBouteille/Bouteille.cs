namespace ClassLibraryBouteille
{
    /// <summary>
    /// Représente une bouteille avec un état (ouverte ou fermée), une contenance en litre et un contenu en litre.
    /// </summary>
    public class Bouteille
    {
        bool ouvert; 
        float contenanceEnL;
        float contenuEnL;

        /// <summary>
        /// Constructeur par défaut pour initialiser une nouvelle instance de la classe bouteille.
        /// </summary>
        public Bouteille()
        {
            ouvert = false;
            contenanceEnL = 2;
            contenuEnL = 1.5f;
        }

        /// <summary>
        /// Constructeur classique pour initialiser une nouvelle instance de la classe bouteille.
        /// </summary>
        /// <param name="_ouvert">Etat de la bouteille (ouverte ou fermée)</param>
        /// <param name="_contenanceEnL">Contenance de la bouteille en litre</param>
        /// <param name="_contenuEnL">Contenu de la bouteille en litre</param>
        public Bouteille(bool _ouvert, float _contenanceEnL, float _contenuEnL)
        {
            ouvert = _ouvert;
            contenanceEnL = _contenanceEnL;
            contenuEnL = _contenuEnL;
        }

        /// <summary>
        /// Constructeur hybride pour initialiser une nouvelle instance de la classe bouteille.
        /// </summary>
        /// <param name="_contenanceEnL">Contenance de la bouteille en litre</param>
        /// <param name="_contenuEnL">Contenu de la bouteille en litre</param>
        public Bouteille(float _contenanceEnL, float _contenuEnL):this(false, _contenanceEnL, _contenuEnL)
        {
        }

        /// <summary>
        /// Constructeur par clonage pour initialiser une nouvelle instance de la classe bouteille par rapport à une autre bouteille.
        /// </summary>
        /// <param name="bouteilleACopier">Bouteille à copier déjà existante</param>
        public Bouteille(Bouteille bouteilleACopier)
        {
            this.ouvert = bouteilleACopier.ouvert;
            this.contenanceEnL = bouteilleACopier.contenanceEnL;
            this.contenuEnL = bouteilleACopier.contenuEnL;
        }


        /// <summary>
        /// Ferme la bouteille si elle est ouverte.
        /// </summary>
        /// <returns>Retourne True si la bouteille a pu être fermée.</returns>
        public bool Fermer()
        {
            bool result = false;
            if (this.ouvert)
            {
                this.ouvert = false;
                result = true;
            }
            return result;
        }


        /// <summary>
        /// Ouvre la bouteille si elle est fermée.
        /// </summary>
        /// <returns>Retourne True si la bouteille a pu être ouverte.</returns>
        public bool Ouvrir()
        {
            if (!this.ouvert)
            {
                this.ouvert = true;
                return true;
            }
            return false;
        }


        /// <summary>
        /// Remplit la bouteille complètement.
        /// </summary>
        /// <returns>Retourne True si la bouteille a pu être remplie complètement.</returns>
        public bool Remplir()
        {
            return RemplirQuantite(this.contenanceEnL - this.contenuEnL);
        }


        /// <summary>
        /// Remplit la bouteille avec une quantité donnée.
        /// </summary>
        /// <param name="quantiteEnL">La quantité en litre à ajouter</param>
        /// <returns>Retourne True si la bouteille a pu être remplie avec la quantité donnée.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public bool RemplirQuantite(float quantiteEnL)
        {
            bool result = false;

            if (quantiteEnL < 0)
                throw new ArgumentOutOfRangeException("quantiteEnL", quantiteEnL, "La quantité ne peut pas être négative.");

            if (this.ouvert && quantiteEnL > 0 && (this.contenuEnL + quantiteEnL) <= this.contenanceEnL)
            {
                this.contenuEnL += quantiteEnL;
                result = true;
            }
            return result;
        }


        /// <summary>
        /// Vide la bouteille complètement.
        /// </summary>
        /// <returns>Retourne True si la bouteille a pu être vidé complètement.</returns>
        public bool Vider()
        {
            return ViderQuantite(this.contenuEnL);
        }


        /// <summary>
        /// Vide la bouteille avec une quantité donnée.
        /// </summary>
        /// <param name="quantiteEnL">La quantité en litre à vider.</param>
        /// <returns>Retourne True si la bouteille a pu être vidée avec la quantité donnée.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public bool ViderQuantite(float quantiteEnL)
        {
            bool result = false;

            if (quantiteEnL < 0)
                throw new ArgumentOutOfRangeException("quantiteEnL", "La quantité ne peut pas être négative.");

            if (this.ouvert && quantiteEnL > 0 && (this.contenuEnL - quantiteEnL) >= 0)
            {
                this.contenuEnL -= quantiteEnL;
                result = true;
            }
            return result;
        }

    }
}
