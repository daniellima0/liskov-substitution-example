using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRuim
{
    internal class Cachorro : Lobo
    {
        public override void comunicar()
        {
            Console.WriteLine("*latindo*");
        }
    }
}
