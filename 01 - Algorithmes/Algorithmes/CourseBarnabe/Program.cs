using System.Security.Cryptography.X509Certificates;

namespace CourseBarnabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S;
            int nombreMagasin;

            do
            {
                Console.Write("Somme dont Barnabé dispose : ");
                S = int.Parse(Console.ReadLine());
            }
            while (S < 1);

            nombreMagasin = DansCombienDeMagasins(S);            

            Console.WriteLine("Barnabé a fait ses courses dans " + nombreMagasin + " magasins.");
        }


        static int DansCombienDeMagasins(double somme)
        {
            double moitieS = 0;
            int nombreMagasin = 0;

            while (somme > 0)
            {
                moitieS = somme / 2;
                somme = moitieS - (double)1;

                if (somme <= 2)
                {
                    somme = 0;
                }

                nombreMagasin += 1;
            }

            return nombreMagasin;
        }
    }
}
