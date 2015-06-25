using System;
using System.Collections.Generic;
using FinalTest;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly CompteCréé _compteCréé;
        private readonly DépotRéalisé _dépotRéalisé;

        public CompteBancaire(CompteCréé compteCréé )
        {
            _compteCréé = compteCréé;
        }

        public CompteBancaire(CompteCréé compteCréé, DépotRéalisé dépotRéalisé)
        {
            _compteCréé = compteCréé;
            _dépotRéalisé = dépotRéalisé;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(this._compteCréé._numéroDeCompte, montantDepot, dateDepot);
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            yield return new RetraitRéalisé(this._compteCréé._numéroDeCompte, montantRetrait, dateRetrait);
        }
    }
}