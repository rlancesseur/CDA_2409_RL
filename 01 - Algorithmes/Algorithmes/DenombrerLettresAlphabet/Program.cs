namespace DenombrerLettresAlphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisieUtilisateur = "Le Lorem Ipsum est s158918161616515implement du faux texte25 employé dans la composition e786t la mise en page av78ant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.\r\n\r\n";
            string[] voyelles = "A E I O U Y".Split(" ");
            string[] consonnes = "B C D F G H J K L M N P Q R S T V W X Z".Split(" ");
            int nbConsonnes = 0;
            int nbVoyelles = 0;
            int nbChiffres = 0;
            double moyenne = 0;

            /* Console.WriteLine("Saisir une chaine de caractère d'au moins 100 caractères.");
             saisieUtilisateur = Console.ReadLine();

             while(saisieUtilisateur.Length  < 100)
             {
                 Console.WriteLine("Votre chaine de caractère contient moins de 100 caractères. Veuillez recommencer.");
                 saisieUtilisateur = Console.ReadLine();
             }*/


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

                else if (int.TryParse(saisieUtilisateur, out nbChiffres))
                {
                    nbChiffres++;
                    moyenne += saisieUtilisateur[i];
                }

            }

            moyenne = moyenne / nbChiffres;

            Console.WriteLine("Nombre de consonnes : " + nbConsonnes);
            Console.WriteLine("Nombre de voyelles : " + nbVoyelles);
            Console.WriteLine("Nombre de chiffres : " + nbChiffres);
            Console.WriteLine("Moyenne des chiffres : " + moyenne);
        }
    }
}
