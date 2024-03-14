using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc2SlamProj1
{
    class Section
    {
        string _NomSection;
        public string getNom_Section()
        {
            return _NomSection;
        }
        public void setSection(string nouvelleSection)
        {
            _NomSection = nouvelleSection;
        }
        string Nom_Section;
        List<Matiere> Mes_Matieres = new List<Matiere>();
        public void afficherMaSection()
        {
            Console.WriteLine("La matière est : " + Mes_Matieres);
            Console.WriteLine("La liste des matières associées à cette section sont :");
            foreach (Matiere put in Mes_Matieres)
            {
                put.afficherMatiere();
            }
        }
    }
}
