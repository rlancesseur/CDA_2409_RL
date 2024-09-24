namespace RechercheDiviseurNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;      

            Console.WriteLine("Saisissez un nombre");
            A = int.Parse(Console.ReadLine());


            for (int i = 2; i < A; i++)
            {
                if (A % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
