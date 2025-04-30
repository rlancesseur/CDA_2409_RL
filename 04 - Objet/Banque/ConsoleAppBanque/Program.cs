using ClassLibraryBanque;

namespace ConsoleAppBanque
{
    public class Program
    {
        static void Main(string[] args)
        {
            Compte compte1 = new(0001, "Dupont", 1000, -500);
            compte1.CrediterMontant(500);
            Console.WriteLine(compte1.ToString());

            bool debit;
            debit = compte1.DebiterMontant(3000);
            Console.WriteLine(debit ? "Débit réussi" : "Echec du débit");

            debit = compte1.DebiterMontant(500);
            Console.WriteLine(debit ? "Débit réussi" : "Echec du débit");


            Compte compte2 = new(0002, "Lancesseur", 2000, -1000);
            compte1.TransfererMontant(100, compte2);
            Console.WriteLine(compte1.ToString());
            Console.WriteLine(compte2.ToString());


            Console.WriteLine(compte1.CompareTo(compte2));


            Banque maBanque = new("Crédit Agricole", "Mulhouse");
            maBanque.AjouterCompte(0003, "Doe", 5000, -100);
            maBanque.AjouterCompte(compte1);
            maBanque.AjouterCompte(compte2);
            Console.WriteLine(maBanque.ToString());

            maBanque.CompteAuSoldeLePlusGrand();

            maBanque.RendCompte(0001);
            maBanque.RendCompte(0005);


            Console.WriteLine(maBanque.Transferer(0001, 0002, 100) ? "Transfert Réussi" : "Transfert impossible");

        }
    }
}
