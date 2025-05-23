using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace ClassLibraryTransaction
{
    public class Transaction
    {
        string nom;
        DateTime date;
        decimal montant;
        int codePostal;

        public Transaction(string _nom, DateTime _date, decimal _montant, int _codePostal)
        {
            nom = _nom;
            date = _date;
            montant = _montant;
            codePostal = _codePostal;
        }

        public override string ToString()
        {
            return "Nom : " + nom + "\n" +
                   "Date : " + date + "\n" +
                   "Montant : " + montant + "\n" +
                   "Code Postal : " + codePostal;
        }
    }
}
