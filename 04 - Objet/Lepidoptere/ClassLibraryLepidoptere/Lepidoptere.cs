namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        string espece;
        StadeEvolution sonStadeCourant;

        public Lepidoptere(string _espece)
        {
            this.espece = _espece;
            this.sonStadeCourant = new Oeuf();
        }

        public void SeDeplacer()
        {
            this.sonStadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            this.sonStadeCourant = this.sonStadeCourant.SeMetamorphoser();
        }
    }
}
