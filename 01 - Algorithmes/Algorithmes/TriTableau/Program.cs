namespace TriTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pot;

            int[] tableau = { 128, 64, 8, 512, 16, 32, 256 };

            /*
            for (int i = 0; i < tableau.Length; i++)
            {
                for (int j = 0; j < tableau.Length; j++)
                {
                    if(tableau[i] > tableau[j])
                    {
                        pot = tableau[j];
                        tableau[i] = tableau[j];
                        tableau[j] = pot;
                    }
                }
            }
            */

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }
    }
}
