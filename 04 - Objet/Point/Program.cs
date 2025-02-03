namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point point1 = new(10, 15);

            point1.deplacer(20, 25);
            point1.afficher();

            Point point2 = point1.symetrieX();
            point2.afficher();

            Point point3 = point1.symetrieY();
            point3.afficher();

            Point point4 = point3.symetriePoint();
            point4.afficher();

            point4.permuter();
            point4.afficher();

            point4.deplacer(-30, 30);
            point4.afficher();

        }
    }
}

