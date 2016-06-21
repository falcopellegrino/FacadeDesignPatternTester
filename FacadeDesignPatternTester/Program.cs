using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = FacadeDesignPatternTester.StructuralCode;
using Real = FacadeDesignPatternTester.RealWorldCode;
using My = FacadeDesignPatternTester.MyCode;

namespace FacadeDesignPatternTester
{

    // Definition
    // Provide a unified interface to a set of interfaces in a subsystem.
    // Façade defines a higher-level interface that makes the subsystem easier to use. 

    // Participants
    // The classes and objects participating in this pattern are:
    //  - Facade (MortgageApplication)
    //       - knows which subsystem classes are responsible for a request.
    //       - delegates client requests to appropriate subsystem objects. 
    //  - Subsystem classes (Bank, Credit, Loan)
    //       - implement subsystem functionality.
    //       - handle work assigned by the Facade object.
    //       - have no knowledge of the facade and keep no reference to it. 

    /// <summary>
    /// Mainapp startup class for
    /// Facade Design Pattern
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application
        /// </summary>
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Facade pattern which provides a simplified and uniform interface to a large subsystem of classes.
            Structural.Facade f = new Structural.Facade();

            f.MethodA();
            f.MethodB();

            // Wait for user
            Console.ReadKey();
            #endregion

            #region Real world code in C#
            // Facade
            Real.Mortgage m = new Real.Mortgage();

            // Evaluate mortgage eligibility for customer
            Real.Customer c = new Real.Customer("Ann McKinsey");
            bool eligible = m.isEligible(c, 10000);

            Console.WriteLine("\n" + c.Name + " has been " + (eligible ? "approved" : "rejected"));

            // Wait for user
            Console.ReadKey();
            #endregion

            #region My code in C#
            My.VerificaAcquaPotabileFacade v = new My.VerificaAcquaPotabileFacade();

            Console.WriteLine("\nVerifica acqua 1:");
            v.isAcquaPotabile(new My.Acqua("", "", ""));
            Console.WriteLine("\nVerifica acqua 2:");
            v.isAcquaPotabile(new My.Acqua("rame", "rame", "rame"));
            
            // Wait for user
            Console.ReadKey();
            #endregion
        }
    }
}










