using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest.Tests
{
    public class TypeReference
    {
        private int valeur;
        public TypeReference(int i)
        {
            this.valeur = i;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false; if (obj.GetType() != this.GetType()) return false; TypeReference other = (TypeReference)obj; return other.valeur == this.valeur;
        }

    }


}
