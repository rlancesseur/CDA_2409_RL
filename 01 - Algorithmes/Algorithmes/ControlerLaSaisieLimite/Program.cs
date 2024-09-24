using System;

namespace ControlerLaSaisieLimite
{
    public class ControlerLaSaisieLimite
    {
        public static void Main(string[] args)
        {
            string motDePasse = "formation";
            string saisieUtilisateur;
            bool mdp = false;

            for(int i = 0; i < 3; i++)
            {
            Console.Write("Mot de passe : ");
            saisieUtilisateur = Console.ReadLine();

                if(saisieUtilisateur == motDePasse)
                {
                    mdp = true;
                    break;
                }
            }

            if(mdp == true)
            {
                Console.WriteLine("Vous êtes connecté.");
            }
            else
            {
                Console.WriteLine("Votre compte est bloqué");
            }

        }
    }
}