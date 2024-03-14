﻿using System;

namespace Boucles_4
{
    class Program
    {
        public static void appeler_menu()
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" Gestion des Notes de BTS");
            Console.WriteLine(" 1 - Remplir les tableaux MAT,ELEVE,NOTES");
            Console.WriteLine(" 2 - editer le tableau des matières ");
            Console.WriteLine(" 3 - editer la liste des eleves");
            Console.WriteLine(" 4 - editer le tableau des BTS");
            Console.WriteLine(" 5 - remplir un controle d'une matière dont on introduit le libellé"); 
            Console.WriteLine(" 6 - editer le détail d'un contrôle d'une matière dont on introduit le libellé "); 
            Console.WriteLine(" 7 -éditer liste des eleves (avec leur moyenne) et la moyenne de la classe "); 
            Console.WriteLine(" 10 - sortir");
        }
        public static void remplir(ref string[] tabMat, ref string[] tabEtud, ref double[,] tabNotes)
        {
            int i, j;
            tabMat[0] = "Bloc1"; tabMat[1] = "Bloc2"; tabMat[2] = "Bloc3"; tabMat[3] = "CEJM"; tabMat[4] = "Maths";
            tabMat[5] = "Francais"; tabMat[6] = "Anglais"; tabMat[7] = "AP";
            tabEtud[0] = "André"; tabEtud[1] = "Benard"; tabEtud[2] = "Bernier";
            tabEtud[3] = "Boulahbas"; tabEtud[4] = "Camier"; tabEtud[5] = "Chevreul";
            tabEtud[6] = "Debeauvais"; tabEtud[7] = "Demars"; tabEtud[8] = "Domart";
            tabEtud[9] = "Dubois";

            // tableau initialisé à 99 partout 
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    tabNotes[i, j] = 99;
                }
            }
            Console.WriteLine("les tableaux ont été remplis");
            Console.ReadLine();
        }
        public static void editerMat(string[] mat)
        {
            int i;
            for (i = 0; i < mat.Length; i++)
            {
                Console.WriteLine(mat[i]);
            }
        }
        public static void editerEtud(string[] Etud)
        {
            int i;
            for (i = 0; i < Etud.Length; i++)
            {
                Console.WriteLine(Etud[i]);
            }
        }
        public static void editerBts(string[] mat, string[] etud, double[,] notes)
        {
            int i, l, c;
            Console.Write("\t");
            for (i = 0; i < 8; i++)
            {
                Console.Write(mat[i] + " ");
            }
            Console.WriteLine();
            for (l = 0; l < 10; l++)
            {
                Console.Write(etud[l] + " ");
                for (c = 0; c < 8; c++)
                {
                    Console.Write(notes[l, c] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {


            string[] tabMat = new string[8];
            string[] tabEtud = new string[10];
            double[,] tabNotes = new double[10, 8];
            int choix;
            choix = 0;
            while (choix != 10)
            {
                appeler_menu();
                Console.WriteLine("Entrez votre choix?");
                choix = Int16.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        remplir(ref tabMat, ref tabEtud, ref tabNotes);
                        break;

                    case 2:
                        editerMat(tabMat);
                        Console.ReadLine();
                        break;

                    case 3:
                        editerEtud(tabEtud);
                        Console.ReadLine();
                        break;

                    case 4:
                        editerBts(tabMat, tabEtud, tabNotes);
                        Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
