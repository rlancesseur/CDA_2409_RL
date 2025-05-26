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

        public float CalculRemboursement()
        {
            return (float)(capitalEmprunte * (tauxInteret / (1 - Math.Pow(1 + tauxInteret, -dureeRemboursementEnMois))));
        }

        public int CalculNombreMoisRemboursement()
        {
            return dureeRemboursementEnMois / periodicite;
        }
    }
}
