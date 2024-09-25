namespace RechercheNombreTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 8, 16, 32, 64, 128, 256, 512 };
            int N;
            int indice = -1;
            bool trouve = true;

            Console.Write("N : ");
            N = int.Parse(Console.ReadLine());


            for(int i = 0; i < tableau.Length; i++)
            {
                indice += 1;

                if (N == tableau[i])
                {
                    trouve = true;
                    break;
                }
                else
                {
                    trouve = false;
                }
            }

            if (trouve)
            {
                Console.WriteLine("Nombre trouvé à l'index " + indice);
            }
            else
            {
                Console.WriteLine("Nombre non trouvé");
            }

        }
    }
}
