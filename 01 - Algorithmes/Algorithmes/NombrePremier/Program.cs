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

            if (N == 1)
            {
                Console.WriteLine(N + " n'est pas un nombre premier");
            }

            else if (N == 2)
            {
                Console.WriteLine(N + " est un nombre premier");
            }


                for (int i = 2; i < N; i++)
                {
                    if (N % i == 0)
                    {
                        Console.Write(N + " n'est pas un nombre premier");
                        break;
                    }

                    else
                    {
                        Console.WriteLine(N + " est un nombre premier");
                    }
                }
        }
    }
}
