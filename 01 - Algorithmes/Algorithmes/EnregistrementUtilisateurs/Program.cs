namespace EnregistrementUtilisateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listeUtilisateurs = new List<string>();
            string? utilisateur = null;
            string saisieNomPrenom;
            DateOnly dateNaissance;
            int age;
            string metier;
            string couleurPreferee;
            char ajouterUtilisateurOuiNon;

            do
            {
                Console.WriteLine("Saisissez un nom et un prénom.");
                saisieNomPrenom = Console.ReadLine() ?? "";

                utilisateur += saisieNomPrenom; 

                Console.WriteLine("Saisissez votre date de naissance. (dd/mm/aa)");
                dateNaissance = DateOnly.Parse(Console.ReadLine());

                utilisateur += " " + dateNaissance;
                
                age = DateTime.Now.Year - dateNaissance.Year;

                if(DateTime.Now.Month < dateNaissance.Month)
                {
                    age -= 1;
                }

                utilisateur += " " + age;

                    if (age >= 18)
                    {
                        Console.WriteLine("Quel est votre métier ?");
                        metier = Console.ReadLine() ?? "";

                    utilisateur += " " + metier;
                    }
                    else if (age < 18)
                    {
                        Console.WriteLine("Quel est votre couleur préférée ?");
                        couleurPreferee = Console.ReadLine() ?? "";

                    utilisateur += " " + couleurPreferee;
                    }

                Console.WriteLine(" ");
                Console.WriteLine("Voulez-vous ajouter une autre personne ? (n/o)");
                ajouterUtilisateurOuiNon = Console.ReadKey(true).KeyChar;
                Console.WriteLine(" ");

                listeUtilisateurs.Add(utilisateur);
                utilisateur = null;
            }

            while (ajouterUtilisateurOuiNon == 'o' || ajouterUtilisateurOuiNon == 'O');
            
            foreach (string s in listeUtilisateurs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
            Console.WriteLine("Merci !");

        }
    }
}


