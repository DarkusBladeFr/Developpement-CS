using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc2SlamProj1
{
    class Eleve
    {
        string _NomEleve;
        string _PrenomEleve;
        string _NomSection;

        public string getNom_Eleve()
        {
            return _NomEleve;
        }
        public string getPrenom_Eleve()
        {
            return _PrenomEleve;
        }
        public string getNom_Section()
        {
            return _NomSection;
        }
        public void setNom_Eleve(string Name_Eleve)
        {
            _NomEleve = Name_Eleve;
        }
        public void setPrenom_Eleve(string FirstName_Eleve)
        {
            _PrenomEleve = FirstName_Eleve;
        }
        public void setNom_Section(string Section_Eleve)
        {
            _NomSection = Section_Eleve;
        }
        public void afficherEleve()
        {
            Console.WriteLine(_NomEleve + " " + _PrenomEleve + " " + _NomSection);
        }
        public Eleve(string Nom, string Prenom, string Section)
        {
            _NomEleve = Nom;
            _PrenomEleve = Prenom;
            _NomSection = Section;
        }
    }
}
