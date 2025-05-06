namespace ClassLibraryVoitureBisbis
{
    public class Voiture
    {
        string marque;
        string modele;
        Moteur monMoteur;
        List<Roue> mesRoues;


        public Voiture(string _marque, string _model, string _typeMoteur, bool _estDemarre, string _marqueRoue, bool _tourne, float _usureEnMm)
        {
            marque = _marque;
            modele = _model;
            monMoteur = new Moteur(_typeMoteur, _estDemarre);
            //mesRoues.Add();
        }

        public Voiture() : this("Toyota", "Auris", "Diesel", false, "Michelin", false, 0.5f)
        {
        }

        public Voiture(Voiture voitureACopier)
        {
            marque = voitureACopier.marque;
            modele = voitureACopier.modele;
            monMoteur = new Moteur(voitureACopier.monMoteur);
        }
    }
}
