using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> nombresPairs;
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

    }
}
