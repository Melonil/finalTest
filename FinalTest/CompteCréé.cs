using System;
using System.Collections;

namespace FinalTest
{
    public struct CompteCréé : IEvenementMetier
    {
        private readonly string _numéroDeCompte;
        private readonly int _autorisationDeCrédit;

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            _numéroDeCompte = numéroDeCompte;
            _autorisationDeCrédit = autorisationDeCrédit;
        }
    }
}