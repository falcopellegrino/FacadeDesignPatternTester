using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    class VerificaAcquaPotabileFacade
    {
        private VerificaSeIncolore _c;
        private VerificaSeInodore _o;
        private VerificaSeInsapore _s;

        public VerificaAcquaPotabileFacade()
        {
            _c = new VerificaSeIncolore();
            _o = new VerificaSeInodore();
            _s = new VerificaSeInsapore();
        }

        public void isAcquaPotabile(Acqua acqua)
        {
            if (
                _c.isIncolore(acqua)
                && _o.isInodore(acqua)
                && _s.isInsapore(acqua)
                )
            {
                Console.WriteLine("\nAcqua potabile!");
            }
            else
            {
                Console.WriteLine("\nAcqua non potabile!");

            }
        }
    }
}