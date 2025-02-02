namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point point1 = new(10, 15);

            point1.deplacer(20, 25);
            point1.afficher();

        }
    }
}

