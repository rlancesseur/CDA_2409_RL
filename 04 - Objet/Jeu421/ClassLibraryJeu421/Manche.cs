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
        List<De> mes3Des;

        public Manche()
        {
            nbrLanceEnCours = 0;
            mes3Des = new List<De>();

            for(int i = 0; i < 3; i++)
            {
                mes3Des.Add(new De());
            }
            nbrLanceEnCours++;
        }

        /// <summary>
        /// Lance un Dé (0, 1 ou 2)
        /// </summary>
        /// <param name="numeros"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void LancerNumDe(int[] numeros)
        {
            foreach (int i in numeros)
            {
                if (i < 0 || i >= mes3Des.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(i), "Numéro de dé invalide");
                }
                mes3Des[i].Jeter();
            }
            nbrLanceEnCours++;
        }

        public void LancerUnDe(int numeroDe)
        {
            LancerNumDe([numeroDe]);
        }

        public void LancerDeuxDes(int numeroDe1, int numeroDe2)
        {
            LancerNumDe([numeroDe1, numeroDe2]);
        }

        public void LancerTroisDes()
        {
            LancerNumDe([0, 1, 2]);
        }

        public string AfficherValeursDe()
        {
            string result = "";

            for(int i = 0; i < mes3Des.Count; i++)
            {
                result += "Dé " + (i+1) + " : " + mes3Des[i].Valeur + "; \n";
            }

            return result;
        }

        public void TrierDes()
        {
            mes3Des.Sort();
        }

        private bool VerifierValeursDes()
        {
            if (mes3Des[0].Valeur == 4 && mes3Des[1].Valeur == 2 && mes3Des[2].Valeur == 1)
            {
                return true;
            }
            return false;
        }

        private int LancerRestant()
        {
            return NbrLanceMax - nbrLanceEnCours;
        }

        public bool MancheEstGagnee()
        {
            if(VerifierValeursDes())
            {
                return true;
            }
            return false;
        }

        public bool MancheEstTerminee()
        {
            if (LancerRestant() == 0 || VerifierValeursDes())
            {
                return true;
            }
            return false;
        }
    }
}
