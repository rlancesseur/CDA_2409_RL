namespace PorteGarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PorteGarage maPorteDeGarage = new(true, false);

            Boolean verrouillerPorte = maPorteDeGarage.verrouillerPorte();
            if(verrouillerPorte)
            {
                Console.WriteLine("La porte a été vérrouillée.");
            }
            else
            {
                Console.WriteLine("La porte n'a pas pu être vérrouillée");
            }

            Boolean fermerPorte = maPorteDeGarage.fermerPorte();
            if(fermerPorte)
            {
                Console.WriteLine("La porte a pu se fermer.");
            }
            else
            {
                Console.WriteLine("La porte n'a pas pu se fermer.");
            }

            verrouillerPorte = maPorteDeGarage.verrouillerPorte();
            if (verrouillerPorte)
            {
                Console.WriteLine("La porte a été vérrouillée.");
            }
            else
            {
                Console.WriteLine("La porte n'a pas pu être vérrouillée");
            }

            Boolean deverrouillerPorte = maPorteDeGarage.deverrouillerPorte();
            if (deverrouillerPorte)
            {
                Console.WriteLine("La porte a été dévérrouillée.");
            }
            else
            {
                Console.WriteLine("La porte n'a pas pu être dévérrouillée.");
            }

        }
    }
}
