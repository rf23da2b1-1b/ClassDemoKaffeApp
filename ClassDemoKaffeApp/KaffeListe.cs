using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKaffeApp
{
    public class KaffeListe
    {
        // instans felt 
        private List<Kaffe> _liste;


        // evt property
        public List<Kaffe> Liste 
        { 
            get { return _liste; } 
            set { _liste = value; }
        }

        /*
         * Konstruktør
         */
        public KaffeListe()
        {
            _liste = new List<Kaffe>();
        }


        /*
         * Metoder
         */
        public void Tilføj(Kaffe kaffe)
        {
            _liste.Add(kaffe);
        }

        public List<Kaffe> HentAlleKaffer()
        {
            return _liste;
        }


        public List<Kaffe> HentFraLand(string land)
        {
            List<Kaffe> resultatListe = new List<Kaffe>();

            for (int i = 0; i < _liste.Count; i++)
            {
                if (_liste[i].Land == land)
                {
                    resultatListe.Add(_liste[i]);
                }
            }

            return resultatListe;
        }

    }
}
