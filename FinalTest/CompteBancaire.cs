using System;
using System.Collections.Generic;
using FinalTest;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly CompteCréé _compteCréé;

        public CompteBancaire(CompteCréé compteCréé)
        {
            _compteCréé = compteCréé;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(this._compteCréé._numéroDeCompte, montantDepot, dateDepot);
        }
    }
}