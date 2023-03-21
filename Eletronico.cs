using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Eletronico : Produto
    {
        public override void Utilizar()
        {
            Console.WriteLine("Utilizando produto eletrônico");
        }
    }
}
