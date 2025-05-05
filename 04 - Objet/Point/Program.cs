namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point point1 = new(10, 15);

            point1.Deplacer(20, 25);
            Console.WriteLine(point1.ToString());

            Point point2 = point1.SymetrieX();
            Console.WriteLine(point2.ToString());

            Point point3 = point1.SymetrieY();
            Console.WriteLine(point3.ToString());

            Point point4 = point3.SymetrieXY();
            Console.WriteLine(point4.ToString());

            point4.Permuter();
            Console.WriteLine(point4.ToString());

            point4.Deplacer(-30, 30);
            Console.WriteLine(point4.ToString());

        }
    }
}

