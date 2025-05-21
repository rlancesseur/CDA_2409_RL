using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryWinFormsExercices
{
    public class VerificationValidite
    {
        public static bool DatePosterieur(string _date)
        {
            DateTime dateDuJour = DateTime.Today;
            DateTime dateUtilisateur = DateTime.Parse(_date);

            return dateUtilisateur > dateDuJour;
        }
    }
}
