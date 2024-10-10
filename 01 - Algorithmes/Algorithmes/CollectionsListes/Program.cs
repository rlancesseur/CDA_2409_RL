namespace CollectionsListes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] utilisateurs = new string[] { };
            string[] tabTempo;
            string saisieNomPrenom;
            char saisieOuiNon = 'n';
            List<string> listUtilisateurs = new List<string>();

            /*
            do
            {
                Console.WriteLine("Saisissez votre nom et prénom : ");
                saisieNomPrenom = Console.ReadLine() ?? "";

                tabTempo = utilisateurs;
                utilisateurs = new string[utilisateurs.Length + 1];
                utilisateurs.CopyTo(utilisateurs, 0);
                utilisateurs[utilisateurs.Length - 1] = saisieNomPrenom;

                Console.WriteLine("Souhaitez vous ajouter un utilisateur ? (n/o)");
                saisieOuiNon = Console.ReadKey().KeyChar;
            }
            while (saisieOuiNon == 'o' || saisieOuiNon == 'O');
            */

            do
            {
                Console.WriteLine("Saisissez votre nom et prénom : ");
                saisieNomPrenom = Console.ReadLine() ?? "";

                listUtilisateurs.Add(saisieNomPrenom);

                Console.WriteLine("Souhaitez vous ajouter un utilisateur ? (n/o)");
                saisieOuiNon = Console.ReadKey(true).KeyChar;
            }
            while (saisieOuiNon == 'o' || saisieOuiNon == 'O');

            foreach(string s in listUtilisateurs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
