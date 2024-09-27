namespace FruitsEtLegumes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string moinsCher;
            string saisieUtilisateur;
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
                Console.WriteLine(fruitsLegumes[i]);

                /*
                if(fruitsLegumes[i] < moinsCher)
                {
                    moinsCher = fruitsLegumes[i];
                }
                */
            }

            Console.WriteLine("Légume le moins cher au kilo : ");
            
        }
    }
}
