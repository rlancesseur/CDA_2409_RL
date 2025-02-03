namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new(12, 7);
            f1.Afficher();

            Fraction f2 = new();
            f2.Afficher();

            Fraction f3 = new Fraction(9);
            f3.Afficher();

            string affichage = f1.AffichageTextuelle();
            Console.WriteLine(affichage);
            affichage = f2.AffichageTextuelle();
            Console.WriteLine(affichage);
            affichage = f3.AffichageTextuelle();
            Console.WriteLine(affichage);
        }
    }
}
