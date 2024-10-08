using Rlancesseur.tools;

internal class Program
{
    private static void Main(string[] args)
    {
        string saisieUtilisateur;
        bool formatCarteBleueOk;
        bool conformiteCarteBleueOk;


        Console.WriteLine("Saisissez un numéro de carte bleue");
        saisieUtilisateur = Console.ReadLine() ?? "";

        formatCarteBleueOk = ControleRegex.ControleFormatCarteBleue(saisieUtilisateur);


        if (formatCarteBleueOk)
        {
            conformiteCarteBleueOk = AlgoLuhn.ConformiteCarteBleue(saisieUtilisateur);

            if(conformiteCarteBleueOk)
            {
                Console.WriteLine("Numéro de carte bleue valide.");
            }
            else
            {
                Console.WriteLine("Numéro de carte bleue invalide.");
            }
            
        }
        else
        {
            Console.WriteLine("Format de numéro de carte bleue invalide.");
        }

        



    }
}