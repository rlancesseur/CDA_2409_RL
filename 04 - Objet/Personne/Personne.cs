using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    public class Personne
    {
        string nom;
        string prenom;
        int age;
        float salaire;
        float autreRevenus;
        public static int nbPersonnes = 0;

        public Personne()
        {
            nom = "Doe";
            prenom = "John";
            age = 18;
            salaire = 1000;
            autreRevenus = 200;
        }

        public Personne(string _nom, string _prenom, int _age, float _salaire, float _autreRevenus)
        {
            nom = _nom;
            prenom = _prenom;
            age = _age;
            salaire = _salaire;
            autreRevenus = _autreRevenus;

            nbPersonnes++;
        }

        public override string ToString()
        {
            return "Nom : " + this.nom + "Prénom : " + this.prenom + "Age : " + this.age + "Salaire : " + this.salaire + "Autre revenus : " + this.autreRevenus;
        }

        public void ModifierRevenus(float nouveauSalaire, float nouveauxAutresRevenus)
        {
            if(nouveauSalaire >= 0 && nouveauxAutresRevenus >= 0)
            {
                salaire = nouveauSalaire;
                autreRevenus = nouveauxAutresRevenus;
            }
        }

        public float CalculerCharges()
        {
            float result = ((salaire * 20) / 100) + ((autreRevenus * 15) / 100);
            
            if (age > 50)
            {
                result = ((salaire * 10) / 100) + ((autreRevenus * 7.5f) / 100);
            }

            return result;
        }
    }
}

