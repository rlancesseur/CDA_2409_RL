namespace ClassLibraryJeu421
{
    public class De
    {
        int valeur;

        public De()
        {
            valeur = -1; //Pas sûr de ça
        }

        public void Jeter()
        {
            valeur = Alea.Instance().Nouveau(1, 6);
        }
    }
}
