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

            Console.WriteLine(f1.AffichageTextuelle());
            Console.WriteLine(f2.AffichageTextuelle());
            Console.WriteLine(f3.AffichageTextuelle());

            f1.Oppose();
            f1.Afficher();

            f1.Inverse();
            f1.Afficher();

            bool estSuperieur = f2.SuperieurA(f3);
            Console.WriteLine(estSuperieur ? "f2 est supérieur à f3." : "f3 est supérieur à f2.");

            Fraction f4 = new(18, 2);
            bool estEgal = f3.EgalA(f4);
            Console.WriteLine(estEgal ? "f3 est égal à f4." : "f3 n'est pas égal à f4.");

            
        }
    }
}
