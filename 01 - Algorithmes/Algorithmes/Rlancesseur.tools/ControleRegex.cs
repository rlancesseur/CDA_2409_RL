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
            Regex rgx = new Regex("^[a-zàâéèëêïîôöùüûçñ]{2,32}$", RegexOptions.IgnoreCase);

            return rgx.IsMatch(_nom);
        }

        public static bool ControleMotDePasse(string _motDePasse)
        {
            if (_motDePasse.Length >= 20)
            {
                Regex rgx = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)([\W]?)^[a-zA-Z\d\W?]{20,}$");

                return rgx.IsMatch(_motDePasse);
            }

            else if (_motDePasse.Length >= 12)
            {

                Regex rgx = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W])^[a-zA-Z\d\W]{12,}$");

                return rgx.IsMatch(_motDePasse);
            }

            else
            {
                 return false;
            }
        }

        public static bool ControleFormatCarteBleue(string _carteBleue)
        {
           Regex rgx = new Regex(@"^([0-9]{4}[ -]?){4}$");

            return rgx.IsMatch(_carteBleue);
        }

        public static bool ControleNumeroTelephone(string _numeroTelephone)
        {
            Regex rgx = new Regex(@"^(0[ -]?[0-9]){1}([0-9]{2}[ -]?){4}$");

            return rgx.IsMatch(_numeroTelephone);
        }

        public static bool ControleMail(string _mail)
        {
            Regex rgx = new Regex(@"^(([\w.?-?]+@){5, 64}[\w]+.[\w]+){5, 320}$");

            return rgx.IsMatch(_mail);
        }
    }
}
