using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Oeuvre_Héritage
{
    class Oeuvre
    {
        private int _numeroOeuvre;
        private string _titreOeuvre;
        public Oeuvre(int unNumero, string unTitre)
        {
            _numeroOeuvre = unNumero;
            _titreOeuvre = unTitre;
        }
        public int getNumero()
        {
            return _numeroOeuvre;
        }
        public string getTitre()
        {
            return _titreOeuvre;
        }
        public void affiche()
        {
            Console.WriteLine("Le numéro de l'oeuvre est " + _numeroOeuvre);
            Console.WriteLine("Le titre de l'oeuvre est " + _titreOeuvre);
        }
    }
}
