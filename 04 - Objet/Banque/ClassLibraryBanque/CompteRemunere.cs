using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    public class CompteRemunere : CompteAvecDecouvert
    {
        DateOnly dateOuverture;
        float tauxRemuneration = 5;

        public CompteRemunere(uint _numero, string _nomProprietaire, float _solde, float _decouvertAutorise, DateOnly _dateOuverture) 
            : base(_numero, _nomProprietaire, _solde, _decouvertAutorise)
        {
            if (_dateOuverture > DateOnly.FromDateTime(DateTime.Now))
            {
                throw new ArgumentOutOfRangeException(nameof(_dateOuverture), "La date d'ouverture ne peut pas être dans le futur.");
            }
            dateOuverture = _dateOuverture;
        }

        public float CalculerInterets()
        {
            return solde * tauxRemuneration / 100;
        }

        public override string ToString()
        {
            return base.ToString() + "; Numéro du compte: " + numero + "; Nom : " + nomProprietaire + "; Solde : " + (solde+CalculerInterets()) + 
                "; Découvert autorisé : " + decouvertAutorise + "; Date d'ouverture : " + dateOuverture + "; Taux de rémunération : " + tauxRemuneration;
        }
    }
}
