using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    internal class Manche
    {
        const int NbrLanceMax = 3;
        int nbrLanceEnCours;
        List<De> mes3Des;

        /// <summary>
        /// Constructeur par défaut qui instancie un liste de 3 dés
        /// </summary>
        public Manche()
        {
            nbrLanceEnCours = 0;
            mes3Des = new List<De>();

            for(int i = 0; i < 3; i++)
            {
                mes3Des.Add(new De());
            }
            mes3Des.Sort();
            nbrLanceEnCours++;
        }

        /// <summary>
        /// Lance un ou plusieurs Dés (1, 2 ou 3)
        /// </summary>
        /// <param name="numeros"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void LancerNumDe(int[] numeros)
        {
            foreach (int i in numeros)
            {
                if (i < 1 || i > mes3Des.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(i), "Numéro de dé invalide");
                }
                mes3Des[i - 1].Jeter();
            }
            nbrLanceEnCours++;
        }

        /// <summary>
        /// Lance un dé (précisé en paramètre)
        /// </summary>
        /// <param name="numeroDe"></param>
        public void LancerUnDe(int numeroDe)
        {
            LancerNumDe([numeroDe]);
            mes3Des.Sort();
        }

        /// <summary>
        /// Lance deux dés (précisés en paramètre)
        /// </summary>
        /// <param name="numeroDe1"></param>
        /// <param name="numeroDe2"></param>
        /// <exception cref="ArgumentException"></exception>
        public void LancerDeuxDes(int numeroDe1, int numeroDe2)
        {
            if(numeroDe1 == numeroDe2)
            {
                throw new ArgumentException("Les deux dés à relancer doivent être différents");
            }
            LancerNumDe([numeroDe1, numeroDe2]);
            mes3Des.Sort();
        }

        /// <summary>
        /// Lance les trois dés
        /// </summary>
        public void LancerTroisDes()
        {
            LancerNumDe([1, 2, 3]);
            mes3Des.Sort();
        }

        /// <summary>
        /// Affiche la valeurs des trois dés
        /// </summary>
        /// <returns></returns>
        public string AfficherValeursDe()
        {
            string result = "";

            for(int i = 0; i < mes3Des.Count; i++)
            {
                result += "Dé " + (i+1) + " : " + mes3Des[i].Valeur + "; \n";
            }

            return result;
        }

        /// <summary>
        /// Vérifie si la liste retourne [4, 2, 1]
        /// </summary>
        /// <returns></returns>
        private bool VerifierValeursDes()
        {
            if (mes3Des[0].Valeur == 4 && mes3Des[1].Valeur == 2 && mes3Des[2].Valeur == 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retourne le nombre de lancer restant
        /// </summary>
        /// <returns></returns>
        private int LancerRestant()
        {
            return NbrLanceMax - nbrLanceEnCours;
        }

        /// <summary>
        /// Retourne true si la manche est gagnée
        /// </summary>
        /// <returns></returns>
        public bool MancheEstGagnee()
        {
            if(VerifierValeursDes())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retourne true si la manche est terminé (s'il ne reste plus de lancer, ou si l'utilisateur a fait 421)
        /// </summary>
        /// <returns></returns>
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
