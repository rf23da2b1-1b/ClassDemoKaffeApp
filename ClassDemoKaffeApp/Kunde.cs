using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKaffeApp
{
    public class Kunde
    {
        /*
         * Instans felter
         */
        private string _navn;
        private string _tlf;

        /*
         * Properties
         */
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        /*
         * Constructor
         */
        public Kunde()
        {
            _navn = "";
            _tlf = "";
        }
        public Kunde(string navn, string tlf)
        {
            _navn = navn;
            _tlf = tlf;
        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
