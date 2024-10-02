using System;

namespace ControlerLaSaisieLimite
{
    public class ControlerLaSaisieLimite
    {
        public static void Main(string[] args)
        {
            const string MOT_DE_PASSE = "formation";
            string saisieUtilisateur;
            bool mdp = false;
            int nbEssais = 0;
            int essaisRestant = 3;


            while (mdp == false && nbEssais < 3)
            {
                Console.Write("Mot de passe : ");
                saisieUtilisateur = Console.ReadLine();

                if (saisieUtilisateur == MOT_DE_PASSE)
                {
                    mdp = true;
                    Console.WriteLine("Vous êtes connecté.");
                }
                else
                {
                    mdp = false;
                    nbEssais++;
                    essaisRestant--;

                    if (essaisRestant > 0)
                    {
                        Console.WriteLine("Plus que " + (essaisRestant) + " essais restant");
                    }
                }
            }

            if (nbEssais == 3)
            {
                Console.WriteLine("Votre compte est bloqué");
            }

        }
    }
}