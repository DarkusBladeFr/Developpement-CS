using System;

namespace TD_Tableau
{
    class Program
    {
        public static void RemplirPROD(string[] tableau_prod)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Saisissez les produits.");
                tableau_prod[i] = Console.ReadLine();
            }
        }
        public static void RemplirPRIX(double[] tableau_prix)
        {
            int a;
            for (a = 0; a < 10; a++)
            {
                Console.WriteLine("Saisissez maintenant leurs prix.");
                tableau_prix[a] = double.Parse(Console.ReadLine());
            }
        }
        public static void CountPrix(double[] tableau_prix, int compteur)
        {
            int a;
            compteur = 0;
            for(a=0;a<10;a++)
            {
                if(tableau_prix[a]>5)
                {
                    compteur = compteur + 1;
                }
            }
            Console.WriteLine("Il y a " + compteur + " articles supérieur à 5 euros.");
        }
        public static void SommePrix(double[] tableau_prix, out double somme)
        {
            int a;
            somme = 0;
            for (a = 0;a < 10; a++)
                {
                    somme = (double)somme + tableau_prix[a];
                }
            Console.WriteLine("La somme des prix est de " + somme + " euros.");
        }
        public static void MoyennePrix(double[] tableau_prix, double moyenne, double somme)
        {
            moyenne = (double)somme / 10;
            Console.WriteLine("La moyenne est de " + moyenne + " euros.");
        }
        public static void MaxPrix(double[] tableau_prix, string[] tableau_prod, string maximum)
        {
            int a;
            maximum = tableau_prod[0];
            for(a=1;a<9;a++)
            {
                if(tableau_prix[a-1]<tableau_prix[a])
                {
                    maximum = tableau_prod[a];
                }
            }
            Console.WriteLine("L'article au prix le plus élevé est " + maximum);
        }
        public static void RemplirTAB(string [] tableau_prod, double [] tableau_prix)
        {
            int b;
            Console.WriteLine("Nom du produit     Prix du produit");
            for (b = 0; b<10; b++)
            {
                Console.WriteLine(tableau_prod[b] + "    " + tableau_prix[b]);
            }
        }
        static void Main(string[] args)
        {
            int compteur;
            double moyenne, somme;
            string maximum;
            maximum = "calculez-moi";
            moyenne = 0;
            compteur = 0;
            String[] tableau_prod = new string[10];
            Double[] tableau_prix = new double[10];
            RemplirPROD(tableau_prod);
            RemplirPRIX(tableau_prix);
            RemplirTAB(tableau_prod, tableau_prix);
            //partie rajoutée pour la 4a).
            CountPrix(tableau_prix, compteur);
            //Partie rajoutée pour la 4b).
            SommePrix(tableau_prix, out somme);
            MoyennePrix(tableau_prix, moyenne, somme);
            //Partie rajoutée pour la 4c).
            MaxPrix(tableau_prix, tableau_prod, maximum);
            Console.ReadLine();
        }
    }
}
