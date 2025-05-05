namespace ClassLibraryVoitureBis
{
    public class Roue
    {
        string marqueRoue;
        bool tourne;
        float usureEnMm;

        public Roue(string _marqueRoue, bool _tourne, float _usureEnMm)
        {
            marqueRoue = _marqueRoue;
            tourne = _tourne;
            usureEnMm = _usureEnMm;
        }

        public Roue() : this("Michelin", false, 0)
        {
        }

        public Roue(Roue roueACopier)
        {
            marqueRoue = roueACopier.marqueRoue;
            tourne = roueACopier.tourne;
            usureEnMm = roueACopier.usureEnMm;
        }

        public override string ToString()
        {
            return base.ToString() + "Marque : " + marqueRoue + "; tourne : " + tourne + "; usure : " + usureEnMm;
        }
    }
}
