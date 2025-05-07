namespace ClassLibraryVoitureBisbis
{
    public class Voiture
    {
        string marque;
        string modele;
        Moteur monMoteur;
        List<Roue> mesRoues;
        Roue roueDeSecours = null;

        public Voiture(string _marque, string _model, string _typeMoteur, bool _estDemarre, string _marqueRoue, bool _tourne, float _usureEnMm)
        {
            marque = _marque;
            modele = _model;
            monMoteur = new Moteur(_typeMoteur, _estDemarre);
            mesRoues = new List<Roue>();

            for (int i = 0; i < 4; i++)
            {
                mesRoues.Add(new Roue(_marqueRoue, _tourne, _usureEnMm));
            }
        }

        public Voiture() : this("Toyota", "Auris", "Diesel", false, "Michelin", false, 0.5f)
        {
        }

        public Voiture(Voiture voitureACopier)
        {
            marque = voitureACopier.marque;
            modele = voitureACopier.modele;
            monMoteur = new Moteur(voitureACopier.monMoteur);
            mesRoues = new List<Roue>();

            foreach (Roue roue in voitureACopier.mesRoues)
            {
                mesRoues.Add(new Roue(roue));
            }
        }

        /// <summary>
        /// Méthode pour démarrer la voiture
        /// </summary>
        /// <returns></returns>
        public bool DemarrerVoiture()
        {
            return monMoteur.DemarrerMoteur();
        }

        /// <summary>
        /// Méthode pour arrêter la voiture
        /// </summary>
        /// <returns></returns>
        public bool ArreterVoiture()
        {
            if (monMoteur.ArreterMoteur())
            {
                ArreterAvancer();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Méthode privée pour modifier la rotation des roues arrière
        /// </summary>
        /// <param name="tourne"></param>
        private void ModifierRotationRouesAriere(bool tourne)
        {
            mesRoues[2].tourne = tourne;
            mesRoues[3].tourne = tourne;
        }

        /// <summary>
        /// Méthode pour faire avancer la voiture (active les roues)
        /// </summary>
        /// <returns></returns>
        public bool Avancer()
        {
            if (monMoteur.Entrainer2RouesMotrices(mesRoues[0], mesRoues[1]))
            {
                ModifierRotationRouesAriere(true);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Méthode pour arrêter la voiture
        /// </summary>
        /// <returns></returns>
        public bool ArreterAvancer()
        {
            if (monMoteur.Arreter2RouesMotrices(mesRoues[0], mesRoues[1]))
            {
                ModifierRotationRouesAriere(false);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Méthode pour ajouter une roue de secours si elle n'existe pas déjà
        /// </summary>
        /// <returns></returns>
        public Roue AjouterRoueDeSecours()
        {
            if (roueDeSecours == null)
            {
                roueDeSecours = new Roue();
                return roueDeSecours;
            }
            return null;
        }

        public override string ToString()
        {
            return base.ToString() + "; Marque : " + marque + "; Modele : " + modele + "; \n" + monMoteur.ToString() + "; \n" + mesRoues[0].ToString();
        }
    }
}
