namespace Bouteille
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bouteille maBouteille = new(false, 1, 0.5f);

            bool ouvrirBouteille = maBouteille.ouvrir();
            Console.WriteLine(ouvrirBouteille ? "Ouverte réussie" : "La bouteille était déjà ouverte");

            bool remplirBouteille = maBouteille.remplir();
            Console.WriteLine(remplirBouteille ? "Remplissage réussi" : "La bouteille était fermée, ou déjà remplie");

            remplirBouteille = maBouteille.remplir();
            Console.WriteLine(remplirBouteille ? "Remplissage réussi" : "La bouteille était fermée, ou déjà remplie");

            bool viderBouteille = maBouteille.vider();
            Console.WriteLine(viderBouteille ? "La bouteille a pu être vidé" : "La bouteille était fermée, ou déjà vide.");

            viderBouteille = maBouteille.vider();
            Console.WriteLine(viderBouteille ? "La bouteille a pu être vidé" : "La bouteille était fermée, ou déjà vide.");

            bool remplirQuantite = maBouteille.remplirQuantite(3);
            Console.WriteLine(remplirQuantite ? "La bouteille a pu être remplie." : "La bouteille n'a pas pu être remplie.");

            remplirQuantite = maBouteille.remplirQuantite(1);
            Console.WriteLine(remplirQuantite ? "La bouteille a pu être remplie." : "La bouteille n'a pas pu être remplie.");
        }
    }
}
