using Rlancesseur.tools;
using System.Text.RegularExpressions;

namespace MotDePasseSecure
{
    /*
     * Mot de passe de :
     * - 12 caractère minimum
     *      Et au moins 1 minuscule
     *      Et au moins 1 majuscule
     *      Et au moins 1 chiffre
     *      Et au moins 1 caractère spécial
     * OU
     * - 20 caractère minimum
     *      Et au moins 1 minuscule
     *      Et au moins 1 majuscule
     *      Et au moins 1 chiffre
     *  */

    internal class Program
    {
        static void Main(string[] args)
        {
            string motDePasse;
            bool motDePasseOk;
            /*
            string regexMinuscules;
            string regexMajuscules;
            string regexChiffres;
            string regexCaracteresSpeciaux;


            regexMinuscules = @"[a-z]{1,}";  On ne met pas de ^ et $ car on veut juste que le mdp contienne des lettres (pas QUE des lettres)
            regexMajuscules = @"[A-Z]{1,}";
            regexChiffres = @"[0-9]+";
            regexCaracteresSpeciaux = @"[^a-zA-Z0-9]+";  le ^ dans les crochets veut dire l'inverse
            */

            Console.WriteLine("Saisir un mot de passe");
            motDePasse = Console.ReadLine() ?? ""; // null coalescing operator

            /*
            if (Regex.IsMatch(motDePasse, regexMinuscules) &&
                Regex.IsMatch(motDePasse, regexMajuscules) &&
                Regex.IsMatch(motDePasse, regexChiffres) &&
                (Regex.IsMatch(motDePasse, regexCaracteresSpeciaux) || motDePasse.Length > 20) && motDePasse.Length >= 12)
            {
                Console.WriteLine("Mot de passe OK");
            }
            else
            {
                Console.WriteLine("Mot de passe trop faible");
            }
            */

            motDePasseOk = ControleRegex.ControleMotDePasse(motDePasse);

            if (motDePasseOk)
            {
                Console.WriteLine("Mot de passe OK");
            }
            else
            {
                Console.WriteLine("Mot de passe trop faible");
            }
        }
    }
}
