using ClassLibraryJeu421;

namespace ConsoleAppJeu421
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Combien de manches voulez-vous jouer ?");
            int nbrMancheUtilisateur = int.Parse(Console.ReadLine());

            Partie421 maPartie = new Partie421(nbrMancheUtilisateur);
            int compteurManche = 1;

            Console.WriteLine(maPartie.ToString());

            while (!maPartie.PartieEstTerminee())
            {
                Console.WriteLine("Manche : " + compteurManche);

                maPartie.NouvelleManche();

                Console.WriteLine(maPartie.AfficherValeursDesDeMancheCourante());

                while (!maPartie.MancheCouranteEstTerminee())
                {
                    int[]? desARelancer = null;
                    string? input;
                    do
                    {
                        Console.Write("Numéro dés à relancer (1, 2 ou 3) : ");
                        input = Console.ReadLine();
                        desARelancer = new int[input.Length];
                    } while (input.Length > 3);
                    

                    for (int i = 0; i < input.Length; i++)
                    {
                        desARelancer[i] = int.Parse(input[i].ToString());
                    }

                    if (desARelancer.Length == 1)
                    {
                        maPartie.LancerUnDe(desARelancer[0]);
                    }
                    else if (desARelancer.Length == 2)
                    {
                        maPartie.LancerDeuxDes(desARelancer[0], desARelancer[1]);
                    }
                    else if (desARelancer.Length == 3)
                    {
                        maPartie.LancerTroisDes();
                    }
                    Console.WriteLine(maPartie.AfficherValeursDesDeMancheCourante());
                }
                maPartie.CalculerPoints();
                maPartie.MancheJouee();
                Console.WriteLine(maPartie.ToString());
                compteurManche++;
            }

            Console.WriteLine("Score final : " + maPartie.Point);
            Console.WriteLine("Merci d'avoir joué !");
        }
    }
}
