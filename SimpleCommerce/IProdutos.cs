using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{
    interface IProdutos
    {
        double Preco { get; set; }
        string Fornecedor { get; set; }
        int Quantidade { get; set; }

    }
}
