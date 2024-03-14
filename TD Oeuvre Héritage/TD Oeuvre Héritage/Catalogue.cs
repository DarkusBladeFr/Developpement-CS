using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Oeuvre_Héritage
{
    class Catalogue
    {
        List<OeuvreEnVente> _lesOeuvres = new List<OeuvreEnVente>();
        public void consulter(int i)
        {
            string findTitre;
            char findEtat;
            if (i<_lesOeuvres.Count())
            {
                findTitre = _lesOeuvres[i].getTitre();
                findEtat = _lesOeuvres[i].getEtat();
                Console.WriteLine("Le titre de l'oeuvre est " + findTitre + " et il est " + findEtat);
            }
            else
                Console.WriteLine("Liste hors limite");
        }
        public bool ajouter(OeuvreEnVente uneOeuvre)
        {
            bool add = true;
            if (_lesOeuvres.Contains(uneOeuvre))
                add = false;
            else
                _lesOeuvres.Add(uneOeuvre);
            return add;
        }
        public bool retirer(OeuvreEnVente uneOeuvre)
        {
            bool rem = false;
            if (_lesOeuvres.Contains(uneOeuvre))
            {
                rem = true;
                _lesOeuvres.Remove(uneOeuvre);
                Console.WriteLine("Suppression effectué");
            }
            else
                Console.WriteLine("Echec de la suppression, l'élément n'existe pas");
            return rem;
        }
        public bool reserver(OeuvreEnVente uneOeuvre)
        {
            bool check = false;
            if(_lesOeuvres.Contains(uneOeuvre))
            {
                check = true;
                uneOeuvre.setReserve();
            }
            return check;
        }
        public bool reserver(int i)
        {
            bool check = false;
            if(i<_lesOeuvres.Count())
            {
                _lesOeuvres[i].setReserve();
                check = true;
            }
            return check;
        }
        public List<OeuvreEnVente> listeLibre()
        {
            List<OeuvreEnVente> lesOeuvreslibres = new List<OeuvreEnVente>();
            foreach (OeuvreEnVente uneOeuvre in _lesOeuvres)
            {
                if (uneOeuvre.getEtat() == 'L')
                    lesOeuvreslibres.Add((OeuvreEnVente)uneOeuvre);
            }
            return lesOeuvreslibres;
        }
    }
}
