namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new(12, 7);
            string f1ToString = f1.ToString(); 

            Fraction f2 = new();
            string f2ToString = f2.ToString();

            Fraction f3 = new Fraction(9);
            string f3ToString = f3.ToString();

            Console.WriteLine(f1.AffichageTextuelle());
            Console.WriteLine(f2.AffichageTextuelle());
            Console.WriteLine(f3.AffichageTextuelle());

            f1.Oppose();
            f1ToString = f1.ToString();

            f1.Inverse();
            f1ToString = f1.ToString();

            bool estSuperieur = f2.SuperieurA(f3);
            Console.WriteLine(estSuperieur ? "f2 est supérieur à f3." : "f3 est supérieur à f2.");

            Fraction f4 = new(18, 2);
            bool estEgal = f3.EgalA(f4);
            Console.WriteLine(estEgal ? "f3 est égal à f4." : "f3 n'est pas égal à f4.");

            Fraction f5 = f4.Plus(f3);
            string f5ToString = f5.ToString();

            Fraction f6 = f4 + f3;
            string f6ToString = f6.ToString();

        }
    }
}
