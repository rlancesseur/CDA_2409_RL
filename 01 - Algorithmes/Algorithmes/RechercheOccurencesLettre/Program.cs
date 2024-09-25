namespace RechercheOccurencesLettre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            string lettre;
            char[] tableau;
            int occurrences = 0;

            Console.WriteLine("Saisir une phrase : ");
            phrase = Console.ReadLine();

            Console.WriteLine("Saisir une lettre : ");
            lettre = Console.ReadLine();

            tableau = phrase.ToCharArray();

            for(int i = 0; i < tableau.Length; i++)
            {
                if(lettre.Equals(tableau[i]))
                {
                    occurrences += 1;
                }
            }

            Console.WriteLine("La lettre " + lettre + " est présente " + occurrences + " dans la phrase.");

        }
    }
}
