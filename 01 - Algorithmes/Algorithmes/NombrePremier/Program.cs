using Rlancesseur.tools;

namespace NombrePremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int A = 0;

            N = DemandeSaisieUtilisateur.DemanderNombreEntier("Saisissez un nombre");

            if (N == 1)
            {
                Console.WriteLine(N + " n'est pas un nombre premier");
            }

            else if (N == 2)
            {
                Console.WriteLine(N + " est un nombre premier");
            }


            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                A++;
                }
            }

            if (A > 0)
            {
                Console.Write(N + " n'est pas un nombre premier");
            }
            else
            {
                Console.WriteLine(N + " est un nombre premier");
            }
        }
    }
}
