using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    public class Personne
    {
        public string nom;
        public string prenom;
        public int age;
        public float salaire;
        public float autreRevenus;
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
            this.nom = _nom;
            this.prenom = _prenom;
            this.age = _age;
            this.salaire = _salaire;
            this.autreRevenus = _autreRevenus;

            nbPersonnes++;
        }

        public void afficher()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Prénom : " + this.prenom);
            Console.WriteLine("Age : " + this.age);
            Console.WriteLine("Salaire : " + this.salaire);
            Console.WriteLine("Autre revenus : " + this.autreRevenus);
        }

        public void modifierRevenus(float nouveauSalaire, float nouveauxAutresRevenus)
        {
            this.salaire = nouveauSalaire;
            this.autreRevenus = nouveauxAutresRevenus;
        }

        public float calculerCharges()
        {
            float result = ((this.salaire * 20) / 100) + ((this.autreRevenus * 15) / 100);
            if (this.age > 50)
            {
                result = ((this.salaire * 10) / 100) + ((this.autreRevenus * 7.5f) / 100);
            }

            return result;
        }
    }
}

