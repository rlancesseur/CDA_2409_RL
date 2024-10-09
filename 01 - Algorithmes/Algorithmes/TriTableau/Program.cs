namespace TriTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pot;

            int[] tableau = { 128, 64, 8, 512, 16, 32, 256 };

            
            for (int i = 0; i < tableau.Length; i++)
            {
                for (int j = i; j < tableau.Length; j++)
                {
                    if(tableau[i] > tableau[j])
                    {
                        pot = tableau[i];
                        tableau[i] = tableau[j];
                        tableau[j] = pot;
                    }
                }
            }            

            foreach (int nbr in tableau)
            {
                Console.WriteLine(nbr + " ");
            }

        }
    }
}
