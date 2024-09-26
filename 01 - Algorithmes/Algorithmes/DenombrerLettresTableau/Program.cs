namespace DenombrerLettresTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            char[] tableauPhrase;
            char[] alphabet;
            int[] compteur;

            Console.WriteLine("Saisir une phrase d'au moins 120 caractères");
            phrase = Console.ReadLine();

            while(phrase.Length < 120)
            {
                Console.WriteLine("Votre phrase contient moins de 120 caractères, veuillez recommencer.");
                phrase = Console.ReadLine();
            }

            tableauPhrase = phrase.ToCharArray();

            alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            compteur = new int[phrase.Length];

            for (int i = 0; i < tableauPhrase.Length; i++)
            {
                for(int j = 0; j < alphabet.Length; j++)
                {
                    if (tableauPhrase[i].Equals(alphabet[j]))
                    {
                        compteur[j] += 1;
                    }
                }
            }

            for(int i = 0; i < alphabet.Length; i++)
            {
                Console.WriteLine("La lettre " + alphabet[i] + " apparait " + compteur[i] + " fois.");
            }

        }
    }
}
