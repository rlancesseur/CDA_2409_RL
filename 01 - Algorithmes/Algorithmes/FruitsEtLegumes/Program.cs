using System.Globalization;

namespace FruitsEtLegumes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisieUtilisateur;
            List<string> fruitsLegumes = new List<string>();
            List<string> prix = new List<string>();
            List<double> prix2 = new List<double>();
            string[] split;

            do
            {
                Console.WriteLine("Saisissez le nom d'un légume ou d'un fruit (en un seul mot par pitié), et son prix au kilo");
                saisieUtilisateur = Console.ReadLine().Replace(".", ",");
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


            prix2 = prix.Select(x => double.Parse(x)).ToList();

            prix2.Sort();

            Console.WriteLine("Le légume le moins cher au kilo coute : " + prix2[0] + " euros.");
 
        }
    }
}
