using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryWinFormsExercices
{
    public class VerificationValidite
    {
        public static bool VerifierFormatDate(string _date)
        {
            DateTime dateDuJour = DateTime.Today;
            bool dateValide = DateTime.TryParse(_date, out DateTime dateUtilisateur);

            return (dateValide && dateUtilisateur > dateDuJour);
        }
    }
}
