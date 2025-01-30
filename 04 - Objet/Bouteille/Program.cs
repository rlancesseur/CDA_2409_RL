namespace Bouteille
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bouteille maBouteille = new(false, 1, 0.5f);

            Boolean ouvrirBouteille = maBouteille.ouvrir();
            if(ouvrirBouteille)
            {
                Console.WriteLine("Ouverte réussie");
            }
            else
            {
                Console.WriteLine("La bouteille était déjà ouverte");
            }

            Boolean remplirBouteille = maBouteille.remplir();
            if(remplirBouteille)
            {
                Console.WriteLine("Remplissage réussi");
            }
            else
            {
                Console.WriteLine("La bouteille était fermée, ou déjà remplie");
            }

            remplirBouteille = maBouteille.remplir();
            if (remplirBouteille)
            {
                Console.WriteLine("Remplissage réussi");
            }
            else
            {
                Console.WriteLine("La bouteille était fermée, ou déjà remplie");
            }

            Boolean viderBouteille = maBouteille.vider();
            if(viderBouteille)
            {
                Console.WriteLine("La bouteille a pu être vidé");
            }
            else
            {
                Console.WriteLine("La bouteille était fermée, ou déjà vide.");
            }

            viderBouteille = maBouteille.vider();
            if (viderBouteille)
            {
                Console.WriteLine("La bouteille a pu être vidé");
            }
            else
            {
                Console.WriteLine("La bouteille était fermée, ou déjà vide.");
            }

            Boolean remplirQuantite = maBouteille.remplirQuantite(3);
            if (remplirQuantite)
            {
                Console.WriteLine("La bouteille a pu être remplie. Contenu : " + maBouteille.contenuEnL);
            }
            else
            {
                Console.WriteLine("La bouteille n'a pas pu être remplie.");
            }

            remplirQuantite = maBouteille.remplirQuantite(1);
            if (remplirQuantite)
            {
                Console.WriteLine("La bouteille a pu être remplie. Contenu : " + maBouteille.contenuEnL);
            }
            else
            {
                Console.WriteLine("La bouteille n'a pas pu être remplie.");
            }
        }
    }
}
