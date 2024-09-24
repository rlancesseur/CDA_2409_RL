using System;

namespace TriDeNombreBis
{
    public class TriDeNombreBis
    {
        static public void Main(string[] args)
        {
            int[] tableau = new int[3];

            for(int i = 0; i < tableau.Length; i++)
            {
                Console.Write("Saisissez un nombre : ");
                tableau[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(tableau);
            Array.Reverse(tableau);

            for(int i = 0; i < tableau.Length; i++)
            {
                Console.Write(tableau[i] + " ");
            }

        }
    }
}