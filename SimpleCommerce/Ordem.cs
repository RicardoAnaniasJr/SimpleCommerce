using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{
    class Ordem
    {
        public void NotaFiscal(Cliente c , IProdutos prod)
        {
            Console.WriteLine( "Nome: "+ c.nome + " , " +"Cpf: " + c.cpf + " , "  + " Sua compra foi " + "Produto: "+ prod.Nome + " , " + "Quantidade: " + prod.Quantidade + " , " + "Preco: " + prod.Preco + " sera enviado neste email: " + c.email + " Obrigado."  );

        }
    }
}
