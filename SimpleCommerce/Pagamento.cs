using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{
    class Pagamento 
    {
        public double Pagar(IProdutos p)
        {
            double result = p.Preco * p.Quantidade;
            return result;            
        }
        public Pagamento() { }
    }
}
