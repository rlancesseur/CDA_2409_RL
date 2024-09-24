using System;

namespace EsTuMajeur
{
    public class EsTuMajeur
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Quel âge avez-vous ?");
            int age = Convert.ToInt32(Console.ReadLine());

            string result = QuelAge(age);
            Console.WriteLine(result);

        }
    
    public static string QuelAge(int age)
    {
        string result;
        if(age > 0 && age < 18)
            {
                result = "Vous êtes mineur";
            }
            else if(age >= 18)
            {
                result = "Vous êtes majeur";
            }
            else
            {
                result = "Vous n'êtes pas encore né.";
            }

        return result;
    }
    }
}