namespace CalculNombrePersonnes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nbJeunes = 0;
            int nbVieux = 0;
            int nb20ans = 0;
            int[] echantillon = new int[20];

            for (int i = 0; i < echantillon.Length; i++)
            {
                Console.Write("Age de la personne " + (i + 1) + " : ");
                echantillon[i] = int.Parse(Console.ReadLine());

                if(echantillon[i] < 20)
                {
                    nbJeunes++;
                }
                else if (echantillon[i] == 20)
                {
                    nb20ans++;
                }
            }

            nbVieux = echantillon.Length - nbJeunes;

            if(nbJeunes == echantillon.Length)
            {
                Console.WriteLine("Toutes les personnes ont moins de 20ans.");
            }
            else if(nbJeunes == 0)
            {
                Console.WriteLine("Toutes les personnes ont plus de 20ans.");
            }
            else
            {
                Console.WriteLine("Dans cet échantillon, il y a " + nbJeunes + " personnes de moins de 20ans, " + nb20ans + " personnes de 20ans et " + nbVieux + " personnes de plus de 20ans.");
            }
            
        }
    }
}
