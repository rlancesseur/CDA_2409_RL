using System.Text.RegularExpressions;

namespace EnregistrementUtilisateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listeUtilisateurs = new List<string>();
            string[] utilisateur = new string[3];
            string saisieNomPrenom;
            Regex rgx = new Regex(@"^[a-zàâéèëêïîôöùüûçñ -]+$", RegexOptions.IgnoreCase);
            bool formatOk = false;
            DateOnly dateNaissance;
            int age;
            string? saisieUtilisateur = null;
            char ajouterUtilisateurOuiNon;

            do
            {
                do
                {
                    Console.WriteLine("Saisissez un nom et un prénom.");
                    saisieNomPrenom = Console.ReadLine() ?? "";
                    formatOk = rgx.IsMatch(saisieNomPrenom);

                    if(!formatOk) Console.WriteLine("Format invalide.");
                }
                while (!formatOk);


                Console.WriteLine("Saisissez votre date de naissance. (dd/mm/aa)");
                dateNaissance = DateOnly.Parse(Console.ReadLine());
                
                age = DateTime.Now.Year - dateNaissance.Year;

                if (DateTime.Now.Month < dateNaissance.Month)
                {
                    age -= 1;
                }

                    if (age >= 18)
                    {
                        Console.WriteLine("Quel est votre métier ?");
                        saisieUtilisateur = Console.ReadLine() ?? "";
                    }
                    else
                    {
                        Console.WriteLine("Quel est votre couleur préférée ?");
                        saisieUtilisateur = Console.ReadLine() ?? "";
                    }

                utilisateur[0] = saisieNomPrenom;
                utilisateur[1] = dateNaissance.ToLongDateString() + " (" + age.ToString() + "ans)";
                utilisateur[2] = saisieUtilisateur;


                Console.WriteLine(" ");
                Console.WriteLine("Voulez-vous ajouter une autre personne ? (n/o)");
                ajouterUtilisateurOuiNon = Console.ReadKey(true).KeyChar;
                Console.WriteLine(" ");

                for (int i = 0; i < utilisateur.Length; i++)
                {
                    listeUtilisateurs.Add(utilisateur[i]);
                }

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


