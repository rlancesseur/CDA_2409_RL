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
                string formatPrenom = "^[a-zA-Z]{2,32}$"; //Contient des lettres de a à z et de A à Z (de 2 caractères à l'infini)
                // formatPrenom = "^[^a-z]$"; Ne doit pas contenir des lettres de a à z


                do
                {
                    Console.WriteLine("Quel est votre prénom ? ");
                    prenom = Console.ReadLine();
                }
                while (!Regex.IsMatch(prenom, formatPrenom/*, RegexOptions.IgnoreCase*/));

                Console.WriteLine("Bonjour " + prenom);

            }
            catch (Exception e)
            {
                Console.WriteLine("Contactez le service informatique");
            }
        }
    }
}