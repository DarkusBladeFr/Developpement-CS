using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc2SlamProj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matiere Bloc1 = new Matiere("Bloc1", 3);
            Matiere Bloc2 = new Matiere("Bloc2", 3.5);
            Matiere Bloc3 = new Matiere("Bloc3", 4);
            Matiere Atelier_Pro = new Matiere("Atelier Pro", 2);
            Eleve e1 = new Eleve("Andrieu", "Thomas", "SIO");
            e1.afficherEleve();
            Bloc1.afficherMatiere();
            Bloc2.afficherMatiere();
            Bloc3.afficherMatiere();
            Atelier_Pro.afficherMatiere();
            Console.WriteLine();
            Eleve e2 = new Eleve("Cheval","Romain","SIO");
            e2.afficherEleve();
            Bloc1.afficherMatiere();
            Bloc2.afficherMatiere();
            Bloc3.afficherMatiere();
            Atelier_Pro.afficherMatiere();
            Console.WriteLine();
            Eleve e3 = new Eleve("Stalin-Renault", "Adrian", "SIO");
            e3.afficherEleve();
            Bloc1.afficherMatiere();
            Bloc2.afficherMatiere();
            Bloc3.afficherMatiere();
            Atelier_Pro.afficherMatiere();
            Console.WriteLine();
            Eleve e4 = new Eleve("Francois", "Edith", "Enseignant");
            e4.afficherEleve();
            Bloc1.afficherMatiere();
            Bloc2.afficherMatiere();
            Bloc3.afficherMatiere();
            Atelier_Pro.afficherMatiere();
            Console.ReadLine();
        }
    }
}
