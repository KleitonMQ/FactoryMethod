using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class CriadorEletronico : Criador
    {
        public override Produto CriarProduto()
        {
            Console.WriteLine("Criando produto do tipo Eletronico");
            return new Eletronico();
        }
    }
}
