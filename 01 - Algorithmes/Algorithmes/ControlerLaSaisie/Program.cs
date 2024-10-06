using Rlancesseur.tools;
using System;
using System.Text.RegularExpressions;

namespace ControlerLaSaisie
{
    public class ControlerLaSaisie
    {
        static public void Main(string[] args)
        {
            try
            {
                string prenom;
                bool prenomOk;
                // string formatPrenom = "^[a-zA-Z]{2, }$"; Contient des lettres de a à z et de A à Z (de 2 caractères à l'infini)
                // formatPrenom = "^[^a-z]$"; Ne doit pas contenir des lettres de a à z

                

                do
                {
                    Console.WriteLine("Quel est votre prénom ? ");
                    prenom = Console.ReadLine() ?? "";
                    prenomOk = ControleRegex.ControleNom(prenom);
                }
                while (!prenomOk);

                Console.WriteLine("Bonjour " + prenom);

            }
            catch (Exception e)
            {
                Console.WriteLine("Contactez le service informatique");
            }
        }
    }
}