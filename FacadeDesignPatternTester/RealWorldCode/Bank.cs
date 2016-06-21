using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'SubSystem ClassA' class
    /// </summary>
    class Bank
    {
        public bool HasSufficentSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
