namespace Television
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television televisionDuSalon = new(false, 1, "Toshiba", "1080p", 27, 1);

            Boolean allumerTele = televisionDuSalon.allumer();
            if(allumerTele)
            {
                Console.WriteLine("La télé a été allumée.");
            }
            else
            {
                Console.WriteLine("La télé était déjà allumée.");
            }

            allumerTele = televisionDuSalon.allumer();
            if (allumerTele)
            {
                Console.WriteLine("La télé a été allumée.");
            }
            else
            {
                Console.WriteLine("La télé était déjà allumée.");
            }

            Boolean eteindreTele = televisionDuSalon.eteindre();
            if(eteindreTele)
            {
                Console.WriteLine("La télé a été éteinte.");
            }
            else
            {
                Console.WriteLine("La télé était déjà éteinte.");
            }

            televisionDuSalon.augmenterChaine();
            Console.WriteLine("Numéro de chaine : " + televisionDuSalon.chaine);

            televisionDuSalon.allumer();
            televisionDuSalon.augmenterChaine();
            Console.WriteLine("Numéro de chaine : " + televisionDuSalon.chaine);

            televisionDuSalon.diminuerChaine();
            televisionDuSalon.augmenterVolume();
            Console.WriteLine("Numéro de chaine : " + televisionDuSalon.chaine);
            Console.WriteLine("Volume : " + televisionDuSalon.volume);

            televisionDuSalon.changerChaine(15);
            Console.WriteLine("Numéro de chaine : " + televisionDuSalon.chaine);

            televisionDuSalon.eteindre();
            televisionDuSalon.changerChaine(30);
            Console.WriteLine("Numéro de chaine : " + televisionDuSalon.chaine);
        }
    }
}
