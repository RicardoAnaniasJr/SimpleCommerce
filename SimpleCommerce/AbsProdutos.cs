using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{
    abstract class AbsProdutos : IProdutos
    {
        public virtual double Preco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string Fornecedor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual int Quantidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool confirmacao()
        {
            throw new NotImplementedException();
        }

        public bool download()
        {
            throw new NotImplementedException();
        }

        public bool enviar()
        {
            throw new NotImplementedException();
        }

        
    }
}
