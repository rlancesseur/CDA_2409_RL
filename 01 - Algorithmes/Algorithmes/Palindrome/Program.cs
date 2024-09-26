namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisieUtilisateur;
            char[] palindrome;
            char[] palindromeReverse;
            bool estUnPalindrome = true;

            Console.WriteLine("Saisissez une phrase");
            saisieUtilisateur = Console.ReadLine().Replace(" ", "").ToLower();

            while (saisieUtilisateur.Length < 1)
            {
                Console.WriteLine("La phrase est vide. Veuillez recommencer.");
                saisieUtilisateur = Console.ReadLine().Replace(" ", "").ToLower();
            }

            palindrome = saisieUtilisateur.ToCharArray();

            palindromeReverse = saisieUtilisateur.ToCharArray();

            Array.Reverse(palindromeReverse);

            for(int i = 0; i < palindrome.Length; i++)
            {
                if(palindrome[i] == palindromeReverse[i])
                {
                    estUnPalindrome = true;
                }
                else
                {
                    estUnPalindrome = false;
                    break;
                }
            }

            if(estUnPalindrome)
            {
                Console.WriteLine(saisieUtilisateur + " est un palindrome.");
            }
            else
            {
                Console.WriteLine(saisieUtilisateur + " n'est pas un palindrome.");
            }

        }
    }
}
