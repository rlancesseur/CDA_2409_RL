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

            if(Regex.IsMatch(_nom, formatNom, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
