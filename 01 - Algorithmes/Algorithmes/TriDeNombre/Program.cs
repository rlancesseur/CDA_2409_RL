﻿using System;

namespace TriNombre
{
    public class TriNombre
    {
        public static void Main(string[] args)
        {
            int A;
            int B;
            int C;

            Console.Write("A : ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("B : ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("C : ");
            C = Convert.ToInt32(Console.ReadLine());

            string resultat = OrdreCroissant(A, B, C);
            Console.WriteLine(resultat);

        }

        public static string OrdreCroissant(int A, int B, int C)
            {
                string result;

                if(A < B && B < C)
                {
                result = A + " " + B + " " + C;
                }

                else if(A < C && C < B)
                {
                result = A + " " + C + " " + B;
                }

                else if(B < A && A < C)
                {
                result = B + " " + A + " " + C;
                }

                else if(B < C && C < A)
                {
                result = B + " " + C + " " + A;
                }

                else if(C < A && A < B)
                {
                result = C + " " + A + " " + B;
                }

                else if(C < B && B < A)
                {
                result = C + " " + B + " " + A;
                }

                else
                {
                    result = "Nombres invalides";
                }

                return result;
            }
    }
}