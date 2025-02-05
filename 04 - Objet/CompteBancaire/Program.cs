namespace Banque
{
    public class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte1 = new(0001, "Dupont", 1000, -500);
            compte1.crediterMontant(500);
            Console.WriteLine(compte1.ToString());

            bool debit;
            debit = compte1.debiterMontant(3000);
            Console.WriteLine(debit ? "Débit réussi" : "Echec du débit");

            debit = compte1.debiterMontant(500);
            Console.WriteLine(debit ? "Débit réussi" : "Echec du débit");
            Console.WriteLine("Nouveau solde : " + compte1.solde);


            CompteBancaire compte2 = new(0002, "Lancesseur", 2000, -1000);
            compte1.transfererMontant(100, compte2);
            Console.WriteLine(compte1.ToString());

            if (compte1.comparerSolde(compte2))
            {
                Console.WriteLine("Le solde de " + compte1.nomProprietaire + " est plus grand que le solde de " + compte2.nomProprietaire);
            }
            else
            {
                Console.WriteLine("Le solde de " + compte2.nomProprietaire + " est plus grand que le solde de " + compte1.nomProprietaire);
            }

            Banque maBanque = new("Crédit Agricole", "Mulhouse");
            Console.WriteLine(maBanque.ToString());

            maBanque.AjouterCompte(0003, "Doe", 5000, -100);
            maBanque.AjouterCompte(compte2);

        }
    }
}
