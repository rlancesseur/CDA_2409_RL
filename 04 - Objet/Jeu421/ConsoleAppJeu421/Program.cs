using ClassLibraryJeu421;

namespace ConsoleAppJeu421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            De de1 = new();

            de1.Jeter();
            de1.Jeter();


            Manche manche1 = new();
            manche1.LancerTroisDes();
            string result = manche1.AfficherValeursDe();
            manche1.LancerUnDe(1);
            result = manche1.AfficherValeursDe();

            Partie421 maPartie = new(5);
            maPartie.ToString();
        }
    }
}
