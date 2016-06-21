using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'SubSystem ClassC' class
    /// </summary>
    class VerificaSeInsapore
    {
        public bool isInsapore(Acqua acqua)
        {
            if (acqua.Sapore == "")
                return true;
            else
                return false;
        }
    }
}
