using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'SubSystem ClassA' class
    /// </summary>
    class VerificaSeIncolore
    {
        public bool isIncolore(Acqua acqua)
        {
            if (acqua.Colore == "")
                return true;
            else
                return false;
        }
    }
}
