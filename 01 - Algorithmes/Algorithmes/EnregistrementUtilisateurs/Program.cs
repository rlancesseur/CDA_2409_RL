using System.Text.RegularExpressions;

namespace EnregistrementUtilisateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string[]> listeUtilisateurs = new List<string[]>();
            string saisieNomPrenom;
            Regex rgx = new Regex(@"^[a-zàâéèëêïîôöùüûçñ -]+$", RegexOptions.IgnoreCase);
            bool formatOk = false;
            string saisieDateNaissance;
            DateTime dateDeNaissance;
            bool isDateOk;
            TimeSpan intervalle;
            int age;
            string? saisieUtilisateur = null;
            ConsoleKey ajouterUtilisateurOuiNon;

            do
            {
                do
                {
                    Console.WriteLine("Saisissez un nom et un prénom.");
                    saisieNomPrenom = Console.ReadLine() ?? "";
                    formatOk = rgx.IsMatch(saisieNomPrenom);

                    if (!formatOk) Console.WriteLine("Format invalide.");
                }
                while (!formatOk);

                do
                {
                    Console.WriteLine("Saisissez votre date de naissance. (dd/mm/aa)");
                    saisieDateNaissance = Console.ReadLine();

                    isDateOk = DateTime.TryParse(saisieDateNaissance, out dateDeNaissance);
                }
                while (!formatOk);


                intervalle = DateTime.Now - dateDeNaissance;

                age = (int)(intervalle.Days / 365.25);

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

                string[] utilisateur = [saisieNomPrenom, dateDeNaissance.ToLongDateString() + " (" + age.ToString() + "ans)", saisieUtilisateur];

                Console.WriteLine(" ");
                Console.WriteLine("Voulez-vous ajouter une autre personne ? (n/o)");
                ajouterUtilisateurOuiNon = Console.ReadKey(true).Key;
                Console.WriteLine(" ");

                listeUtilisateurs.Add(utilisateur);

                utilisateur = new string[3];

            }

            while (ajouterUtilisateurOuiNon == ConsoleKey.O);
            
            foreach (string[] s in listeUtilisateurs)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("");
            Console.WriteLine("Merci !");

        }
    }
}


