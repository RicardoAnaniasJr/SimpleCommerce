using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{
    class Logistica
    {
        public void send(Cliente c , Endereco end)
        {
            Console.WriteLine(c.nome + c.cpf + end.cidade + end.bairro + end.rua);
           

        }
    }
}
