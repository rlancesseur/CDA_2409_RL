namespace FruitsEtLegumes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisieUtilisateur;
            ISet<string> fruitsLegumes = new HashSet<string>();

            do
            {
                Console.WriteLine("Saisissez le nom d'un légume ou d'un fruit, et son prix au kilo");
                saisieUtilisateur = Console.ReadLine();
                fruitsLegumes.Add(saisieUtilisateur);
            }
            while (saisieUtilisateur != "go");

            /*
            for (int i = 0; i < fruitsLegumes.Length; i++)
            {
                Console.WriteLine(fruitsLegumes[i]);
            }

            Console.WriteLine("Légume le moins cher au kilo : ");
            */
        }
    }
}
