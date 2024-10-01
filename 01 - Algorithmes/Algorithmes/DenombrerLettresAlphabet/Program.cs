namespace DenombrerLettresAlphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisieUtilisateur;
            string[] voyelles = "A E I O U Y".Split(" ");
            string[] consonnes = "B C D F G H J K L M N P Q R S T V W X Z".Split(" ");
            int nbConsonnes = 0;
            int nbVoyelles = 0;
            int nbChiffres = 0;
            double moyenne = 0;

            Console.WriteLine("Saisir une chaine de caractère d'au moins 100 caractères.");
             saisieUtilisateur = Console.ReadLine();

             while(saisieUtilisateur.Length  < 100)
             {
                 Console.WriteLine("Votre chaine de caractère contient moins de 100 caractères. Veuillez recommencer.");
                 saisieUtilisateur = Console.ReadLine();
             }


            for (int i = 0; i < saisieUtilisateur.Length; i++)
            {

                if(voyelles.Contains(saisieUtilisateur[i].ToString().ToUpper()))
                {
                    nbVoyelles++;
                }

                else if (consonnes.Contains(saisieUtilisateur[i].ToString().ToUpper()))
                {
                    nbConsonnes++;
                }

                else if (char.IsDigit(saisieUtilisateur[i]))
                {
                    nbChiffres++;
                    moyenne += saisieUtilisateur[i];
                }

            }
            

            Console.WriteLine("Nombre de consonnes : " + nbConsonnes);
            Console.WriteLine("Nombre de voyelles : " + nbVoyelles);
            

            if(nbChiffres == 0)
            {
                Console.WriteLine("Aucun chiffre présent dans la chaine de caractère");
            }
            else
            {
                moyenne = moyenne / nbChiffres;
                Console.WriteLine("Nombre de chiffres : " + nbChiffres);
                Console.WriteLine("Moyenne des chiffres : " + moyenne);
            }
            
        }
    }
}
