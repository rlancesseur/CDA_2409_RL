namespace NombrePremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool nombrePremier = true;

            Console.Write("N : ");
            N = int.Parse(Console.ReadLine());
            
            for(int i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    nombrePremier = false;
                }

                else
                {
                    nombrePremier = true;
                }
            }

            if (nombrePremier)
            {
                Console.WriteLine(N + " est un nombre premier");
            }
            else
            {
                Console.WriteLine(N + " n'est pas un nombre premier");
            }
        }
    }
}
