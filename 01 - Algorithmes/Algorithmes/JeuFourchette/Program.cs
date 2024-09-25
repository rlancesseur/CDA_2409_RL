namespace JeuFourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random aleatoire = new Random();

            int nombreMystere = aleatoire.Next(0, 100);
            int saisieUtilisateur = 0;
            int essais = 0;

            while (saisieUtilisateur != nombreMystere)
            {
                essais += 1;
                Console.Write("Devine le nombre mystère : ");
                saisieUtilisateur = int.Parse(Console.ReadLine());
                
                if(saisieUtilisateur < nombreMystere)
                {
                    Console.WriteLine("Plus grand !");
                }

                else if(saisieUtilisateur > nombreMystere)
                {
                    Console.WriteLine("Plus petit !");
                }
            }

            Console.WriteLine("Bravo, vous avez trouvé en " + essais + " essais.");

        }
    }
}
