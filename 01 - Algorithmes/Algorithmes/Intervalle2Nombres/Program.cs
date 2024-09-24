using System;

namespace Intervalle2Nombres
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A;
            int B;

            Console.Write("A : ");
            A = int.Parse(Console.ReadLine());

            Console.Write("B : ");
            B = int.Parse(Console.ReadLine());

            if(A < B)
            {
                for(int i = A + 1; i < B; i++)
                {
                    Console.Write(i + " ");
                }
            }

            else if(A > B)
            {
                for(int i = A - 1; i > B; i--)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}