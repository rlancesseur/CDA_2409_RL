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
                maPartie.SaMancheCourante.TrierDes();

                Console.WriteLine(maPartie.SaMancheCourante.AfficherValeursDe());

                while (!maPartie.SaMancheCourante.MancheEstTerminee())
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
                        maPartie.SaMancheCourante.LancerUnDe(desARelancer[0]);
                    }
                    else if (desARelancer.Length == 2)
                    {
                        maPartie.SaMancheCourante.LancerDeuxDes(desARelancer[0], desARelancer[1]);
                    }
                    else if (desARelancer.Length == 3)
                    {
                        maPartie.SaMancheCourante.LancerTroisDes();
                    }
                    maPartie.SaMancheCourante.TrierDes();
                    Console.WriteLine(maPartie.SaMancheCourante.AfficherValeursDe());
                }
                maPartie.CalculerPoints(); // Devrait ajouter ou supp les points de la manche jouée mais nope
                maPartie.MancheJouee(); //Devrait incrémenter le nombre de manches jouées mais non plus
                Console.WriteLine(maPartie.ToString());
                compteurManche++;
            }

            Console.WriteLine("Score final : " + maPartie.Point);
            Console.WriteLine("Merci d'avoir joué !");
        }
    }
}
