namespace ClassLibraryJeu421
{
    public class De
    {
        int valeur;

        public De()
        {
            valeur = Alea.Instance().Nouveau(1, 6);
        }
    }
}
