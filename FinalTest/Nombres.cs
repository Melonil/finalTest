using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> nombresPairs;
        private readonly IEnumerable<KeyValuePair<string, int>> texteNombresImpairs;
        private readonly IEnumerable<KeyValuePair<string, int>> premierNombreDontLeTexteContientPlusDe5Caractères;
        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this.nombresPairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get
            {
                return nombresPairs.Where(x => (x.Value % 2) == 0).Select(x => x.Value);
            }
        }

        public String TexteNombresImpairs
        {
            get
            {
                return nombresPairs.Where(x => (x.Value % 2) == 1).OrderByDescending(x => x.Value).Select(x => x.Key).Aggregate((x, y) => y + ", " + x);
            }
        }


        public String PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get
            {
                return nombresPairs.Where(x => (x.Key.Length > 5)).Select(x => x.Key).First(); 
            }  
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get
            {
                return nombresPairs.Where(x => x.Value >3).OrderBy(x => x.Value).Select(x => x.Value).Skip(0).Take(4);
            }
        }
    }
}
