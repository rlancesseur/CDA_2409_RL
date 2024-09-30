namespace FruitsEtLegumes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string moinsCher;
            string saisieUtilisateur;
            string[] alphabet = "A B C D E F G H I J K L M N O P Q R S T U V W X Z".Split(" ");
            List<string> fruitsLegumes = new List<string>();

            do
            {
                Console.WriteLine("Saisissez le nom d'un légume ou d'un fruit, et son prix au kilo");
                saisieUtilisateur = Console.ReadLine();
                fruitsLegumes.Add(saisieUtilisateur);
            }
            while (saisieUtilisateur != "go");
            
            for (int i = 0; i < fruitsLegumes.Count - 1; i++)
            {

            }

            // Console.WriteLine("Légume le moins cher au kilo : ");
            
        }
    }
}
