using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rlancesseur.tools
{
    public class ControleRegex
    {
        public static bool ControleNom(string _nom)
        {
            string formatNom = "^[a-zàâéèëêïîôöùüûç]{2,32}$";

            return Regex.IsMatch(_nom, formatNom, RegexOptions.IgnoreCase);
        }

        public static bool ControleMotDePasse(string _motDePasse)
        {
            string formatMotDepasse = "^([a-z]+)([A-Z]+)([0-9]+)([^a-zA-Z0-9]+){12, }$";

            return (Regex.IsMatch(_motDePasse, formatMotDepasse));
        }

        public static bool ControleFormatCarteBleue(string _carteBleue)
        {
           string formatCarteBleue = @"^([0-9]{4}[ -]?){4}$";

            return (Regex.IsMatch(_carteBleue, formatCarteBleue));
        }

        public static bool ControleNumeroTelephone(string _numeroTelephone)
        {
            string formatNumeroTelephone = @"^([0-9]{1}[ -]?){10}$";

            return Regex.IsMatch(_numeroTelephone, formatNumeroTelephone);
        }

        public static bool ControleMail(string _mail)
        {
            string formatMail = @"^([a-z0-9.?-?]{1, })(@{1}){5, 64}([a-z]{1, })(.{1})([a-z]{2-10}){5, 320}$";

            return Regex.IsMatch(_mail, formatMail);
        }
    }
}
