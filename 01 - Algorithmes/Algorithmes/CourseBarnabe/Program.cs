namespace CourseBarnabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S;
            double moitieS;
            int nombreMagasin = 0;

            Console.WriteLine("Somme dont Barnabé dispose : ");
            S = int.Parse(Console.ReadLine());

            while (S != 0)
            {
                moitieS = S / 2;
                S = moitieS - 1;
                
                if(S < 0)
                {
                    S = 0;
                }

                nombreMagasin += 1;
            }

            Console.WriteLine("Barnabé a fait ses courses dans " + nombreMagasin + " magasins.");

        }
    }
}
