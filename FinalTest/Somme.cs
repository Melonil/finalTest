using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class Somme : IOperation
    {
        public Boolean PeutCalculer(string chaine)
        {
            string[] test = chaine.Split('+');

            return test.Length > 1;
        }

        public int Calculer(string s)
        {
            string[] test = s.Split('+');
            return Convert.ToInt32(test[0]) + Convert.ToInt32(test[1]);
        }
    }
}
