namespace RechercheOccurencesLettre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            char lettre;
            char[] tableau;
            int occurrences = 0;

            Console.WriteLine("Saisir une phrase : ");
            phrase = Console.ReadLine();

            while (phrase.Length < 1)
            {
                Console.WriteLine("La phrase est vide. Veuillez recommencer.");
                phrase = Console.ReadLine();
            }

            Console.WriteLine("Saisir une lettre : ");
            lettre = char.Parse(Console.ReadLine());

            tableau = phrase.ToCharArray();


            for(int i = 0; i < tableau.Length; i++)
            {
                if(tableau[i].Equals(lettre))
                {
                    occurrences += 1;
                }
            }

            if (occurrences > 0)
            {
                Console.WriteLine("La lettre " + lettre + " est présente " + occurrences + " dans la phrase.");
            }
            else
            {
                Console.WriteLine("La lettre n'est pas présente.");
            }

        }
    }
}
