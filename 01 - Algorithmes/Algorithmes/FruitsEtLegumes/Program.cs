namespace FruitsEtLegumes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string moinsCher;
            string saisieUtilisateur;
            List<string> fruitsLegumes = new List<string>();
            List<string> prix = new List<string>();
            string[] split;


            do
            {
                Console.WriteLine("Saisissez le nom d'un légume ou d'un fruit, et son prix au kilo");
                saisieUtilisateur = Console.ReadLine();
                split = saisieUtilisateur.Split(" ");

                for (int i = 0; i < split.Length - 1; i++)
                {
                    fruitsLegumes.Add(split[i]);
                    prix.Add(split[i + 1]);
                }
            }

            while (saisieUtilisateur != "go");

            
            for (int i = 0; i < fruitsLegumes.Count; i++)
            {
                Console.WriteLine("1 kilogramme de " + fruitsLegumes[i] + " coute " + prix[i] + " euros.");
            }
 
        }
    }
}
