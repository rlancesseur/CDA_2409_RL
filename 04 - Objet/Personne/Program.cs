namespace Personne
{

    class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new("Lancesseur", "Rémi", 33, 2000, 500);
            Personne personne2 = new("Doe", "Jane", 25, 1500, 300);
            Personne personne3 = new("tata", "toto", 60, 2000, 500);
            Personne personne4 = new("srhrsh", "Jsrharne", 30, 5000, 3000);


            personne1.modifierRevenus(3000, 400);
            personne1.afficher();
            float charges = personne1.calculerCharges();
            Console.WriteLine("Charges : " + charges);

            Console.WriteLine("Nombre de personnes : " + Personne.nbPersonnes);
        }
    }
}
