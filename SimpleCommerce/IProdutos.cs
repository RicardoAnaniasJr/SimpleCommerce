using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{
    interface IProdutos
    {
        string Nome { get; set; }
        double Preco { get; set; }
        string Fornecedor { get; set; }
        int Quantidade { get; set; }



        
        string Confirmacao();
        string Enviar();
        string Download();

    }
}
