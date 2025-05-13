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

            while (!maPartie.PartieEstTerminee())
            {
                Console.WriteLine("Nouvelle manche");
                Manche nouvelleManche = new();

                Console.WriteLine(nouvelleManche.AfficherValeursDe());

                while (!nouvelleManche.MancheEstTerminee())
                {
                    Console.WriteLine("Dés à relancer : ");
                    string? input = Console.ReadLine();
                    int[]? desARelancer = new int[input.Length];

                    for (int i = 0; i < input.Length; i++)
                    {
                        desARelancer[i] = int.Parse(input[i].ToString());
                    }

                    if (desARelancer.Length == 1)
                    {
                        nouvelleManche.LancerUnDe(desARelancer[0]);
                    }
                    else if (desARelancer.Length == 2)
                    {
                        nouvelleManche.LancerDeuxDes(desARelancer[0], desARelancer[1]);
                    }
                    else if (desARelancer.Length == 3)
                    {
                        nouvelleManche.LancerTroisDes();
                    }
                    nouvelleManche.TrierDes();
                    Console.WriteLine(nouvelleManche.AfficherValeursDe());
                }
                maPartie.CalculerPoints(); // Devrait ajouter ou supp les points de la manche jouée mais nope
                maPartie.MancheJouee(); //Devrait incrémenter le nombre de manches jouées mais non plus
                Console.WriteLine(maPartie.ToString());
            }

        }
    }
}
