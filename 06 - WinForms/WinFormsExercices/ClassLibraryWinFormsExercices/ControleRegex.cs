using System.Globalization;
using System.Text.RegularExpressions;

namespace ClassLibraryWinFormsExercices
{
    public class ControleRegex
    {
        public static bool VerifierNom(string _nom)
        {
            Regex rgx = new Regex("^[a-zàâéèëêïîôöùüûçñ]{2,30}$", RegexOptions.IgnoreCase);
            return rgx.IsMatch(_nom);
        }

        public static bool VerifierDate(string _date)
        {
            Regex rgx = new Regex("^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$");
            return rgx.IsMatch(_date);
            //return DateTime.TryParseExact(_date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime return DateTime.TryParse(_date, out DateTime dateUtilisateur));
            //return DateTime.TryParse(_date, out DateTime dateUtilisateur);
        }

        public static bool VerifierMontant(string _montant)
        {
            Regex rgx = new Regex("^[0-9]+([.][0-9]+)?$");
            return rgx.IsMatch(_montant);
        }

        public static bool VerifierCodePostal(string _codePostal)
        {
            Regex rgx = new Regex("^[0-9]{5}$");
            return rgx.IsMatch(_codePostal);
        }
    }
}
