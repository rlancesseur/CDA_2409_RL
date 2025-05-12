using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    public class Manche
    {
        const int NbrLanceMax = 3;
        int nbrLanceEnCours;
        bool mancheEstTerminee;
        List<De> mes3Des;

        public bool MancheEstTerminee { get => mancheEstTerminee; /*set => mancheEstTerminee = value;*/ }

        public Manche()
        {
            nbrLanceEnCours = 0;
            mancheEstTerminee = false;
            mes3Des = new List<De>();

            for(int i = 0; i < 3; i++)
            {
                mes3Des.Add(new De());
            }
        }

        /// <summary>
        /// Lance un dé (1, 2 ou 3)
        /// </summary>
        /// <param name="numeroDe"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void LancerUnDeSansComptage(int numeroDe)
        {
            if (numeroDe < 1 || numeroDe > mes3Des.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(numeroDe), "Numéro de dé invalide");
            }

            mes3Des[numeroDe - 1].Jeter();
        }

        public void LancerUnDe(int numeroDe)
        {
            LancerUnDeSansComptage(numeroDe);
            nbrLanceEnCours++;
            VerifierFinManche();
        }

        public void LancerDeuxDes(int numeroDe1, int numeroDe2)
        {
            LancerUnDe(numeroDe1);
            LancerUnDe(numeroDe2);
            nbrLanceEnCours++;
            VerifierFinManche();
        }

        public void LancerTroisDes()
        {
            if (!mancheEstTerminee)
            {
                foreach (De de in mes3Des)
                {
                    de.Jeter();
                }
                nbrLanceEnCours++;
                VerifierFinManche();
            }
        }

        public string AfficherValeursDe()
        {
            string result = "";

            for(int i = 0; i < mes3Des.Count; i++)
            {
                result += "Dé " + (i+1) + " : " + mes3Des[i].Valeur + "; ";
            }

            return result;
        }

        private bool VerifierValeursDes()
        {
            mes3Des.Sort();
            if (mes3Des[0].Valeur == 4 && mes3Des[1].Valeur == 2 && mes3Des[2].Valeur == 1)
            {
                return true;
            }
            return false;
        }

        private void VerifierFinManche()
        {
            if (NbrLanceMax == nbrLanceEnCours || VerifierValeursDes())
            {
                mancheEstTerminee = true;
            }
        }
    }
}
