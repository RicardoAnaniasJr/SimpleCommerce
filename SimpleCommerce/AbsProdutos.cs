using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{
    class AbsProdutos : IProdutos
    {
        public virtual double Preco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string Fornecedor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual int Quantidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
