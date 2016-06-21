using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'SubSystem ClassB' class
    /// </summary>
    class VerificaSeInodore
    {
        public bool isInodore(Acqua acqua)
        {
            if (acqua.Odore == "")
                return true;
            else
                return false;
        }
    }
}
