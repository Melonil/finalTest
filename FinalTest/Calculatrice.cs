using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class Calculatrice
    {
        private IOperation[] iOperations;
        public Calculatrice(IOperation[] operations)
        {
            this.iOperations = operations;

        }


        public int Calculer(string p0)
        {
            if (iOperations[0].PeutCalculer(p0))
            {
                return iOperations[0].Calculer(p0);
            }
            else
            {
                return iOperations[1].Calculer(p0);
            }
        }
    }
}
