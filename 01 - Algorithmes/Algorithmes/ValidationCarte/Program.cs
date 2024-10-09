using Rlancesseur.tools;

namespace ValidationCarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Utilisateurs = { "Marie", "Allan", "Frédéric", "Fabrice", "Lores" };
            int[] carteUtilisateur = { 3, 20, 0, 45, 50 };
            int prixRepas = 4;
            string saisieUtilisateur;
            int enregistre = 0;
            bool rejouer = true;

            while (rejouer)
            {

                Console.Write("Nom : ");
                saisieUtilisateur = Console.ReadLine() ?? "";

                for (int i = 0; i < Utilisateurs.Length; i++)
                {
                    if (saisieUtilisateur == Utilisateurs[i])
                    {
                        enregistre++;

                        if ((carteUtilisateur[i] - prixRepas) >= 0)
                        {
                            carteUtilisateur[i] -= prixRepas;
                            Console.WriteLine("Il vous reste " + carteUtilisateur[i] + "e. Bon apétit");
                        }
                        else
                        {
                            Console.WriteLine("Vous devez recharger votre carte.");
                        }
                    }

                }

                if(enregistre == 0)
                {
                    Console.WriteLine("Vous n'êtes pas enregistré au CRM");
                }

                enregistre = 0;
                rejouer = Rejouer.RejouerProgramme();
                Console.Clear();
            }
        }
    }
}
