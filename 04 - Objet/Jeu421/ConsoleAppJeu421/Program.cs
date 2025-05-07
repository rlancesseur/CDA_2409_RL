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
            manche1.LancerDes();
            manche1.LancerDes();
            manche1.LancerDes();


            Partie421 maPartie = new(5);
            maPartie.ToString();
        }
    }
}
