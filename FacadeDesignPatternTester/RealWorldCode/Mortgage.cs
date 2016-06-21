using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    class Mortgage
    {
        private Bank _bank = new Bank();
        private Credit _credit = new Credit();
        private Loan _loan = new Loan();

        public bool isEligible(Customer c, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", c.Name, amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficentSavings(c, amount))
            {
                eligible = false;
            }
            else if(!_loan.HasNoBadLoans(c))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(c))
            {
                eligible = false;
            }

            return eligible;
        }

    }
}