using System;

namespace FinalTest
{
    public struct BalanceN�gativeD�tect�e : IEvenementMetier
    {
        private readonly string _num�roDeCompte;
        private readonly Montant _montant;
        private readonly DateTime _dateRetrait;

        public BalanceN�gativeD�tect�e(string num�roDeCompte, Montant montant, DateTime dateRetrait)
        {
            _num�roDeCompte = num�roDeCompte;
            _montant = montant;
            _dateRetrait = dateRetrait;
        }
    }
}