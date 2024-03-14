using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc2SlamProj1
{
    class Matiere
    {
        string _NomMatiere;
        double _CoefficientMatiere;

        public string getNom_Matiere()
        {
            return _NomMatiere;
        }
        public double getCoefficient_Matiere()
        {
            return _CoefficientMatiere;
        }
        public void setNom_Matiere(string Name_Matiere)
        {
            _NomMatiere = Name_Matiere;
        }
        public void setCoefficient_Matiere(double Coef_Matiere)
        {
            _CoefficientMatiere = Coef_Matiere;
        }
        public void afficherMatiere()
        {
            Console.WriteLine("Nom de la matière : " + _NomMatiere);
            Console.WriteLine("Son coefficient : " + _CoefficientMatiere);
        }
        public Matiere(string Nom, double Coefficient)
        {
            _NomMatiere = Nom;
            _CoefficientMatiere = Coefficient;
        }
    }
}
