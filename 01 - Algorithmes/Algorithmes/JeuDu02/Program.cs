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

            while(pointOrdinateur = 10 || pointsUtilisateur = 10 || saisieUtilisateur < 0)
            {
                Console.WriteLine("Votre chiffre : ");
                saisieUtilisateur = Console.ReadLine();

                N = aleatoire.Next(0, 2);
                Console.WriteLine("Chiffre de l'ordinateur : " + N);

                if(saisieUtilisateur > N)
                {
                    pointsUtilisateur++;
                }
                else if(N > pointsUtilisateur)
                {
                    pointOrdinateur++;
                }
                else if(N = 0 && pointsUtilisateur = 0)
                {
                    Console.WriteLine("Aucun des utilisateurs n'a gagné de points.");
                }

                Console.WriteLine("Point de l'utilisateur : " + pointsUtilisateur);
                Console.WriteLine("Point de l'ordinateur : " + pointOrdinateur);

            }


        }
    }
}
