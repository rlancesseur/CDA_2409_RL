using Rlancesseur.tools;

namespace Chifoumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisieUtilisateur = null;
            int pointUtilisateur ;
            int saisieOrdinateur;
            string saisieOrdinateurString = null;
            int pointOrdinateur;
            bool recommencer = true;
            Random Aleatoire = new Random();

            while (recommencer)
            {
                pointUtilisateur = 0;
                pointOrdinateur = 0;

                while (pointOrdinateur < 3 && pointUtilisateur < 3)
                {
                    do
                    {
                        Console.Write("Votre tour : ");
                        saisieUtilisateur = (Console.ReadLine());
                    }
                    while (saisieUtilisateur != "Pierre" && saisieUtilisateur != "Papier" && saisieUtilisateur != "Ciseaux");

                    saisieOrdinateur = Aleatoire.Next(1, 4);

                    if (saisieOrdinateur == 1)
                    {
                        saisieOrdinateurString = "Pierre";
                    }
                    else if (saisieOrdinateur == 2)
                    {
                        saisieOrdinateurString = "Papier";
                    }
                    else if (saisieOrdinateur == 3)
                    {
                        saisieOrdinateurString = "Ciseaux";
                    }

                    Console.WriteLine("Tour de l'ordinateur : " + saisieOrdinateurString);

                    if (saisieUtilisateur == "Pierre" && saisieOrdinateur == 2)
                    {
                        pointOrdinateur++;
                    }
                    else if (saisieUtilisateur == "Pierre" && saisieOrdinateur == 3)
                    {
                        pointUtilisateur++;
                    }
                    else if (saisieUtilisateur == "Papier" && saisieOrdinateur == 1)
                    {
                        pointUtilisateur++;
                    }
                    else if (saisieUtilisateur == "Papier" && saisieOrdinateur == 3)
                    {
                        pointOrdinateur++;
                    }
                    else if (saisieUtilisateur == "Ciseaux" && saisieOrdinateur == 1)
                    {
                        pointOrdinateur++;
                    }
                    else if (saisieUtilisateur == "Ciseaux" && saisieOrdinateur == 2)
                    {
                        pointUtilisateur++;
                    }
                    else if (saisieUtilisateur == saisieOrdinateurString)
                    {
                        Console.WriteLine("Personne ne remporte de points.");
                    }

                    Console.WriteLine("Vos points : " + pointUtilisateur);
                    Console.WriteLine("Points de l'ordinateur : " + pointOrdinateur);
                    Console.WriteLine("");
                }

                if (pointUtilisateur == 3)
                {
                    Console.WriteLine("Vous avez gagné !");
                }
                else if (pointOrdinateur == 3)
                {
                    Console.WriteLine("L'ordinateur a gagné !");
                }

                recommencer = Rejouer.RejouerProgramme();
                Console.Clear();

            }
        }
    }
}
