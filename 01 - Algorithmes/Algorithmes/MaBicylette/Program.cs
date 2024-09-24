using System;

namespace MaBicyclette
{
    public class MaBicyclette
    {
        public static void Main(string[] args)
        {
            bool beauTemps;
            bool etatVelo;
            bool repImmediate;
            bool livrePossede;
            bool livreDispo;

            Console.WriteLine("Est-ce qu'il fait beau ?");
            beauTemps = Convert.ToBoolean(Console.ReadLine());

            if(beauTemps == true)
            {
                Console.WriteLine("Ect-ce que le vélo est en état de fonctionner ?");
                etatVelo = Convert.ToBoolean(Console.ReadLine());

                if(etatVelo == true)
                {
                    Console.WriteLine("Je vais faire une balade à bicyclette");
                }
                if(etatVelo == false)
                {
                    Console.WriteLine("Est-ce que les réparations sont immédiates ?");
                    repImmediate = Convert.ToBoolean(Console.ReadLine());

                    if(repImmediate == true)
                    {
                        Console.WriteLine("Je vais faire une balade à bicyclette");
                    }
                    else
                    {
                        Console.WriteLine("Je vais à pied jusqu'à l'étang pour cueillir les joncs");
                    }
                }
            }
            if(beauTemps == false)
            {
                Console.WriteLine("Je vais consacrer ma journée à la lecture");

                Console.WriteLine("Est-ce que je possède le 1er tome de Game of Thrones ?");
                livrePossede = Convert.ToBoolean(Console.ReadLine());

                if(livrePossede == true)
                {
                    Console.WriteLine("Je vais lire Game of Thrones");
                }
                if(livrePossede == false)
                {
                    Console.WriteLine("J'irai l'emprunter à la bibliothèque municipale");

                    Console.WriteLine("Est-ce que le livre est disponible à la bibliothèque ?");
                    livreDispo = Convert.ToBoolean(Console.ReadLine());

                    if(livreDispo == true)
                    {
                        Console.WriteLine("Je rentre directement à la maison pour le lire");
                    }
                    else
                    {
                        Console.WriteLine("J'emprunte un roman policier et rentre à la maison pour le lire");
                    }
                }
            }
        }
    }
}