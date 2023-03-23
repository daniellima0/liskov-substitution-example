using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRuim
{
    internal class Lobo
    {
        public int numDePatas = 4;
        public bool ehMamifero = true;
        public virtual void comunicar() {
            Console.WriteLine("*uivando*");
        }
    }
}
