using System;

namespace Exo4v2
{
    class Program
    {
        static void Main(string[] args)
        {
            double HT, TVA;            
            Console.WriteLine("Saisir le prix hors taxe de l'article");
            double HT = double.Parse(Console.ReadLine());

            Console.WriteLine("Saisir la TVA");
            double TVA = double.Parse(Console.ReadLine());

            Console.WriteLine("Saisir le prix hors taxe de l'article");
            Console.WriteLine("TTC = " + HT + TVA);
            Console.ReadLine();
        }
    }
}
