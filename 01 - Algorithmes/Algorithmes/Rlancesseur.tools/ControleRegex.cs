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
            Regex rgx = new Regex("^[a-zàâéèëêïîôöùüûç]{2,32}$", RegexOptions.IgnoreCase);

            return rgx.IsMatch(_nom);
        }

        public static bool ControleMotDePasse(string _motDePasse)
        {
            Regex rgx = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W])^[a-zA-Z\d\W]{12,}$");

            return rgx.IsMatch(_motDePasse);
        }

        public static bool ControleMotDePassePlus20(string _motDePasse)
        {
            Regex rgx = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)([\W]?)^[a-zA-Z\d\W?]{20,}$");

            return rgx.IsMatch(_motDePasse);
        }

        public static bool ControleFormatCarteBleue(string _carteBleue)
        {
           Regex rgx = new Regex(@"^([0-9]{4}[ -]?){4}$");

            return rgx.IsMatch(_carteBleue);
        }

        public static bool ControleNumeroTelephone(string _numeroTelephone)
        {
            Regex rgx = new Regex(@"^([0-9]{2}[ -]?){5}$");

            return rgx.IsMatch(_numeroTelephone);
        }

        public static bool ControleMail(string _mail)
        {
            Regex rgx = new Regex(@"^([a-z0-9.?-?]{1, })(@{1}){5, 64}([a-z]{1, })(.{1})([a-z]{2-10}){5, 320}$");

            return rgx.IsMatch(_mail);
        }
    }
}
