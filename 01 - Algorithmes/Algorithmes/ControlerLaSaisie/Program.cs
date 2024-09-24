using System;

namespace ControlerLaSaisie
{
    public class ControlerLaSaisie
    {
        static public void Main(string[] args)
        {
            string prenom;
            
            do 
            {
                Console.WriteLine("Quel est votre prénom ? ");
                prenom = Console.ReadLine();
            }
            while(prenom.Length < 2);

            Console.WriteLine("Bonjour " + prenom);
        }
    }
}