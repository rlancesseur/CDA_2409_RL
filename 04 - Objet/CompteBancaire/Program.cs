namespace CompteBancaire
{
    internal class Program
    {

        static bool debit = false;

        static void Main(string[] args)
        {
            CompteBancaire compte1 = new(1, "Dupont", 1000, 500);
            compte1.crediterMontant(500);
            compte1.afficherContenu();


            debit = compte1.debiterMontant(2000);
            Console.WriteLine(debit ? "Débit réussi" : "Echec du débit");

            debit = compte1.debiterMontant(500);
            Console.WriteLine(debit ? "Débit réussi" : "Echec du débit");
            Console.WriteLine("Nouveau solde : " + compte1.solde);


            CompteBancaire compte2 = new(2, "Lancesseur", 2000, 1000);
            compte1.transfererMontant(100, compte2);
            compte1.afficherContenu();

            if (compte1.comparerSolde(compte2))
            {
                Console.WriteLine("Le solde de " + compte1.nomProprietaire + " est plus grand que le solde de " + compte2.nomProprietaire);
            }
            else
            {
                Console.WriteLine("Le solde de " + compte2.nomProprietaire + " est plus grand que le solde de " + compte1.nomProprietaire);
            }
        }
    }
}
