namespace CalculNombresParfaits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombreAVerifier = 2;
            int moitie = nombreAVerifier / 2;
            int limiteNombresParfait = 0;
            int somme = 0;

            Console.WriteLine("Affichage des 4 premiers nombres parfaits : ");

            while ( limiteNombresParfait < 4)
            {
                for (int i = 1; i <= moitie; i++)
                {

                    if (nombreAVerifier % i == 0)
                    {
                        somme += i;
                    }

                }

                if (somme == nombreAVerifier)
                {
                    Console.WriteLine(nombreAVerifier + " est un nombre parfait.");
                    limiteNombresParfait++;
                }

                somme = 0;
                nombreAVerifier++;
                moitie = nombreAVerifier / 2;
            }
        }
    }
}
