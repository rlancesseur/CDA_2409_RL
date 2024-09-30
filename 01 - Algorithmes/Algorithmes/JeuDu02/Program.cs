namespace JeuDu02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();

            int N;
            int saisieUtilisateur = 0;
            int pointsUtilisateur = 0;
            int pointOrdinateur = 0;

            while(pointOrdinateur < 10 && pointsUtilisateur < 10 && saisieUtilisateur >= 0)
            {
                Console.Write("Votre chiffre : ");
                saisieUtilisateur = int.Parse(Console.ReadLine());

                N = aleatoire.Next(0, 2);
                Console.WriteLine("Chiffre de l'ordinateur : " + N);

                if (saisieUtilisateur - N == 2)
                {
                    pointsUtilisateur++;
                }
                else if (N - saisieUtilisateur == 2)
                {
                    pointOrdinateur++;
                }
                else if (saisieUtilisateur - N == 1)
                {
                    pointOrdinateur++;
                }
                else if (N - saisieUtilisateur == 1)
                {
                    pointsUtilisateur++;
                }
                else if(N == saisieUtilisateur)
                {
                    Console.WriteLine("Aucun point n'est marqué.");
                }

                Console.WriteLine("Point de l'utilisateur : " + pointsUtilisateur);
                Console.WriteLine("Point de l'ordinateur : " + pointOrdinateur);
                Console.WriteLine("");

            }

        }
    }
}
