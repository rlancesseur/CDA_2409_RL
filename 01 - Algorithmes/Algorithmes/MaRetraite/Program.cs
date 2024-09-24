using System;

namespace MaRetraite
{
    public class MaRetraite
    {
        public static void Main(string[] args)
        {
            int age;
            string result;

            Console.WriteLine("Quel âge avez-vous ?");
            age = Convert.ToInt32(Console.ReadLine());

            result = CombienAvantRetraite(age);
            Console.WriteLine(result);

        }

        public static string CombienAvantRetraite(int age)
        {
            int retraite = 60;
            int retraiteApres;
            int retraiteAvant;
            string result;

            if(age > retraite)
            {
                retraiteApres = age - retraite;
                result = "Vous êtes à la retraite depuis " + retraiteApres + " années.";
            }

            else if(age < retraite)
            {
                retraiteAvant = retraite - age;
                result = "Il vous reste " + retraiteAvant + " années avant la retraite.";
            }

            else if (age == retraite)
            {
                result = "C'est le moment de prendre sa retraite.";
            }

            else
            {
                result = "La valeur fournie n'est pas une âge valide.";
            }

            return result;
        }
    }
}