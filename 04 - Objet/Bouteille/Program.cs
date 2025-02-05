using System.Linq.Expressions;

namespace Bouteille
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bouteille maBouteille = new(false, 1, 0.5f);

            bool ouvrirBouteille = maBouteille.Ouvrir();
            Console.WriteLine(ouvrirBouteille ? "Ouverte réussie" : "La bouteille était déjà ouverte");

            bool remplirBouteille = maBouteille.Remplir();
            Console.WriteLine(remplirBouteille ? "Remplissage réussi" : "La bouteille était fermée, ou déjà remplie");

            remplirBouteille = maBouteille.Remplir();
            Console.WriteLine(remplirBouteille ? "Remplissage réussi" : "La bouteille était fermée, ou déjà remplie");

            bool viderBouteille = maBouteille.Vider();
            Console.WriteLine(viderBouteille ? "La bouteille a pu être vidé" : "La bouteille était fermée, ou déjà vide.");

            viderBouteille = maBouteille.Vider();
            Console.WriteLine(viderBouteille ? "La bouteille a pu être vidé" : "La bouteille était fermée, ou déjà vide.");

            bool remplirQuantite = maBouteille.RemplirQuantite(0.8f);

            try
            {
                remplirQuantite = maBouteille.RemplirQuantite(-0.5f);
                Console.WriteLine(remplirQuantite ? "La bouteille a pu être remplie." : "La bouteille n'a pas pu être remplie.");
            }
            catch ( ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Erreur : " + e.Message);
            }

            remplirQuantite = maBouteille.RemplirQuantite(0.1f);
            Console.WriteLine(remplirQuantite ? "La bouteille a pu être remplie." : "La bouteille n'a pas pu être remplie.");

            try 
            {
                viderBouteille = maBouteille.ViderQuantite(-1);
                Console.WriteLine(viderBouteille ? "La bouteille a pu être vidé" : "La bouteille était fermée, ou déjà vide.");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Erreur : " + e.Message);
            }
            



        }
    }
}
