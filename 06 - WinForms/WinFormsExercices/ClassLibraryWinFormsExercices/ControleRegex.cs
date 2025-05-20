using System.Text.RegularExpressions;

namespace ClassLibraryWinFormsExercices
{
    public class ControleRegex
    {
        public static bool VerifierNom(string _nom)
        {
            Regex rgx = new Regex("^[a-z]{2,32}$", RegexOptions.IgnoreCase);
            return rgx.IsMatch(_nom);
        }
    }
}
