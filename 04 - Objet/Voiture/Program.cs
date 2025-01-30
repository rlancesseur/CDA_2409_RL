namespace Voiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture maVoiture = new("Renault", 80, false, false);

            Boolean allumerPhares = maVoiture.allumerPhares();
            if(allumerPhares)
            {
                Console.WriteLine("Les phares se sont allumés.");
            }
            else
            {
                Console.WriteLine("Les phares étaient déjà allumés, ou la voiture n'a plus de batterie.");
            }

            allumerPhares = maVoiture.allumerPhares();
            if (allumerPhares)
            {
                Console.WriteLine("Les phares se sont allumés.");
            }
            else
            {
                Console.WriteLine("Les phares étaient déjà allumés, ou la voiture n'a plus de batterie.");
            }

            Boolean eteindrePhares = maVoiture.eteindrePhares();
            if (eteindrePhares)
            {
                Console.WriteLine("Les phares se sont éteints.");
            }
            else
            {
                Console.WriteLine("Les phares étaient déjà éteints.");
            }

            eteindrePhares = maVoiture.eteindrePhares();
            if (eteindrePhares)
            {
                Console.WriteLine("Les phares se sont éteints.");
            }
            else
            {
                Console.WriteLine("Les phares étaient déjà éteints.");
            }

            Boolean fermerPorte = maVoiture.fermerPorte();
            if(fermerPorte)
            {
                Console.WriteLine("La porte s'est fermée.");
            }
            else
            {
                Console.WriteLine("La porte était déjà fermée.");
            }

            Boolean ouvrirPorte = maVoiture.ouvrirPorte();
            if(ouvrirPorte)
            {
                Console.WriteLine("La porte s'est ouverte.");
            }
            else
            {
                Console.WriteLine("La porte était déjà ouverte.");
            }

            ouvrirPorte = maVoiture.ouvrirPorte();
            if (ouvrirPorte)
            {
                Console.WriteLine("La porte s'est ouverte.");
            }
            else
            {
                Console.WriteLine("La porte était déjà ouverte.");
            }

        }
    }
}
