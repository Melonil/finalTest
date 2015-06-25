using System;
using System.Collections;

namespace FinalTest
{
    public struct CompteCréé : IEvenementMetier
    {
        internal readonly string _numéroDeCompte;
        internal readonly int _autorisationDeCrédit;

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            _numéroDeCompte = numéroDeCompte;
            _autorisationDeCrédit = autorisationDeCrédit;
        }
    }
}