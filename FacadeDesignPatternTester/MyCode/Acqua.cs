using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternTester.MyCode
{
    class Acqua
    {
        public string Colore { get; set; }
        public string Odore { get; set; }
        public string Sapore { get; set; }

        public Acqua(string c, string o, string s)
        {
            Colore = c;
            Odore = o;
            Sapore = s;
        }
    }
}
