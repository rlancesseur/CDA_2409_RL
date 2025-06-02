using System;

namespace ClassLibraryRemboursement
{
    public class Remboursement
    {
        int capitalEmprunte;
        int tauxInteret;
        int dureeRemboursementEnMois;
        int periodicite;

        public Remboursement(int _capitalEmprunte, int _tauxInteret, int _dureeRemboursementEnMois, int _periodicite)
        {
            capitalEmprunte = _capitalEmprunte;
            tauxInteret = _tauxInteret;
            dureeRemboursementEnMois = _dureeRemboursementEnMois;
            periodicite = _periodicite;
        }

        public double CalculRemboursement()
        {
            double tauxParPeriode = ((double)tauxInteret / 100) / periodicite;
            double result = capitalEmprunte * (tauxParPeriode / (1 - Math.Pow(1 + tauxParPeriode, -CalculNombreRemboursement())));
            return result;
        }

        public int CalculNombreRemboursement()
        {
            return dureeRemboursementEnMois / periodicite;
        }
    }
}
