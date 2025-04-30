using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    public class ComparerCompteByNomProprietaire : IComparer<Compte>
    {
        public int Compare(Compte? x, Compte? y)
        {
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x), "Le compte n'existe pas");
            }
            if (y == null)
            {
                throw new ArgumentNullException(nameof(y), "Le compte n'existe pas");
            }

            return x.nomProprietaire.CompareTo(y.nomProprietaire);
        }
    }
}
