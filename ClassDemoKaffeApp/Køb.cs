using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKaffeApp
{
    public class Køb
    {
        /*
         * Instans Felter
         */

        // Ingen attributter

        // MEN 2 associeringer
        private Kaffe _kaffe;
        private Kunde _kunde;

        /*
         * Properties
         */
        public Kaffe Kaffe
        {
            get { return _kaffe; }
            set { _kaffe = value; }
        }

        public Kunde Kunde
        {
            get { return _kunde; }
            set { _kunde = value; }
        }



        /*
         * Constructor
         */
        public Køb()
        {
            _kaffe = null;
            _kunde = null;

        }

        public Køb (Kaffe kaffe, Kunde kunde)
        {
            _kaffe = kaffe;
            _kunde = kunde;
        }

        public override string ToString()
        {
            return $"{{{nameof(Kaffe)}={Kaffe}, {nameof(Kunde)}={Kunde}}}";
        }
    }
}
