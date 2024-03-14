using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Oeuvre_Héritage
{
    class Program
    {
        static void Main(string[] args)
        {
            OeuvreEnVente Oeuvre1 = new OeuvreEnVente(5,"TitreCustomisé1",9875.58);
            OeuvreEnVente Oeuvre2 = new OeuvreEnVente(6,"TitreCustomisé2",1254);
            OeuvreEnVente Oeuvre3 = new OeuvreEnVente(7,"TitreCustomisé3",720);
            OeuvreEnVente Oeuvre4 = new OeuvreEnVente(8, "TitreCustomisé4",987);
            OeuvreEnVente Oeuvre5 = new OeuvreEnVente(9,"TitreCustomisé5",5487.56);
            Oeuvre1.setLibre();
            Oeuvre1.afficheOeuvre();
            Console.WriteLine();
            Oeuvre2.setReserve();
            Oeuvre2.afficheOeuvre();
            Console.WriteLine();
            Oeuvre3.setLibre();
            Oeuvre3.afficheOeuvre();
            Console.WriteLine();
            Oeuvre4.setReserve();
            Oeuvre4.afficheOeuvre();
            Console.WriteLine();
            Oeuvre5.setReserve();
            Oeuvre5.afficheOeuvre();
            Console.WriteLine();
            Catalogue Cat = new Catalogue();
            Cat.ajouter(Oeuvre1);
            Cat.ajouter(Oeuvre2);
            Cat.ajouter(Oeuvre3);
            Cat.ajouter(Oeuvre4);
            Cat.ajouter(Oeuvre5);
            Console.WriteLine("Consultation d'une oeuvre :");
            Cat.consulter(1);
            Console.WriteLine();
            Console.WriteLine("Réservation :");
            Console.WriteLine();
            if (Cat.reserver(Oeuvre1) == true)
            {
                Cat.reserver(Oeuvre1);
                Console.WriteLine("L'oeuvre a pu être réservée");
            }
            else
            {
                Console.WriteLine("L'oeuvre n'a pas pu être réservée");
            }
            Console.WriteLine();
            Console.WriteLine("Réservation par NumOeuvre non-réussie :");
            if (Cat.reserver(Oeuvre6) == true) //Oeuvre6 n'est pas encore dans la liste
            {
                Cat.reserver(Oeuvre6);
                Console.WriteLine("L'oeuvre a pu être réservée");
            }
            else
            {
                Console.WriteLine("L'oeuvre n'a pas pu être réservée");
            }
            Console.WriteLine();
            Console.WriteLine("Réservation par index réussie :");
            if (catalogue1.reserver(2) == true)
            {
                catalogue1.reserver(2);
                Console.WriteLine("L'oeuvre a pu être réservée");
            }
            else
            {
                Console.WriteLine("L'oeuvre n'a pas pu être réservée");
            }
            Console.WriteLine();
            Console.WriteLine("Réservation par index non-réussie :");
            Console.WriteLine();
            if (catalogue1.reserver(5) == true)
            {
                catalogue1.reserver(5);
                Console.WriteLine("L'oeuvre a pu être réservée");
            }
            else
            {
                Console.WriteLine("L'oeuvre n'a pas pu être réservée");
            }
            Console.WriteLine();
            Console.WriteLine("Ajout d'une 4ème oeuvre");
            Console.WriteLine();
            if (catalogue1.ajouter(oeuvre4))
            {
                catalogue1.ajouter(oeuvre4);
                Console.WriteLine("L'oeuvre a pu être ajoutée");
            }
            else
            {
                Console.WriteLine("L'oeuvre n'a pas pu être ajoutée");
            }
            Console.WriteLine();
            Console.WriteLine("Supression d'une oeuvre :");
            Console.WriteLine();
            if (catalogue1.retirer(oeuvre3))
            {
                catalogue1.retirer(oeuvre3);
                Console.WriteLine("L'oeuvre a pu être retirée");
            }
            else
            {
                Console.WriteLine("L'oeuvre n'a pu pas être retirée");
            }
            Console.WriteLine();
            oeuvre4.setLibre();
            Console.WriteLine("Affichage de la liste des oeuvres libres :");
            Console.WriteLine();
            List<OeuvreEnVente> listeOeuvresLibres = new List<OeuvreEnVente>();
            listeOeuvresLibres = catalogue1.listeLibre();
            foreach (OeuvreEnVente uneOeuvre in listeOeuvresLibres)
            {
                uneOeuvre.afficheOeuvre();
                Console.WriteLine();
            }

            /*
            lesOeuvreslibres = Catalogue1.listeLibre();
            foreach (OeuvreEnVente uneOeuvre in lesOeuvreslibres)
            {
                uneOeuvre.afficheOeuvre();
            }*/
            Console.ReadLine();

        }
    }
}
