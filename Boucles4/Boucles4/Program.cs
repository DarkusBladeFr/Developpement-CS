using System;

namespace Boucles4
{
    class Program
    {
        public static int Exo2(Int32 nChoisi, Int32 nEssai)
        {
            nEssai = 3;
            nChoisi = 300;
            while (nEssai > 0 && nChoisi > 255)
            {
                Console.WriteLine("Choisissez un nombre STRICTEMENT inférieur à 255");
                nChoisi = Int32.Parse(Console.ReadLine());
                nEssai = nEssai - 1;
            }
            if (nEssai > 0)
            {
                Console.WriteLine("Le nombre est " + nChoisi);
            }
            else
            {
                nChoisi = -1; //le nombre deviendra -1 comme demandé dans l'exercice.
            }
            return nChoisi;
        }
        static void main(string[] args)
        {
            int nChoisi, nEssai, resultat;
            nChoisi = 0;
            nEssai = 0;
            resultat = Exo2(nChoisi, nEssai);
            Console.ReadLine();
        }
    }
}
