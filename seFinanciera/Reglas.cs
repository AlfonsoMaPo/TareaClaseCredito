using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seFinanciera
{
    public class Reglas
    {
        public Func<HashSet<string>, bool> Condicion { get; }
        public string Conclusion { get; }

        public Reglas(Func<HashSet<string>, bool> condicion, string conclusion)
        {
            Condicion = condicion;
            Conclusion = conclusion;
        }
    }
}
