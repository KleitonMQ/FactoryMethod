using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Brinquedo : Produto
    {
        public override void Utilizar()
        {
            Console.WriteLine("Utilizando brinquedo para se divertir");
        }
    }
}
