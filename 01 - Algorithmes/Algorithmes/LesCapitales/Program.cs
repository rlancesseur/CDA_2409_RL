namespace LesCapitales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ?pays;
            string capital;

            Console.WriteLine("Saisissez un nom de pays");
            pays = Console.ReadLine();

            capital = CapitalCity(pays);

            Console.WriteLine(capital);

        }

        static string CapitalCity(string _pays)
        {
            /*
            if (_pays == "France")
            {
                return "Paris";
            }
            else if (_pays == "Allemagne")
            {
                return "Berlin";
            }
            else
            {
                return "Capital inconnue";
            }
            */

            switch(_pays)
            {
                case "France":
                    return "Paris";
                    break;
                case "Allemagne":
                    return "Berlin";
                    break;
                default:
                    return "Capitale inconnue";
            }

        }
    }
}
