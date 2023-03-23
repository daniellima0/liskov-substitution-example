using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRuim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lobo lobo = new Lobo();
            Cachorro cachorro = new Cachorro();

            lobo.comunicar();
            cachorro.comunicar();
        }
    }
}
