using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Prod_Fisico a = new Prod_Fisico();
            Pagamento P = new Pagamento();

            a.Nome = "Teste";
            a.Fornecedor = "teetessete";
            a.Preco = 2.5;
            a.Quantidade = 25;

           /* Console.WriteLine(a.Nome);
            Console.WriteLine(a.Preco);
            Console.WriteLine(a.Quantidade);
            */



            Console.WriteLine(P.Pagar(a));
            Console.ReadKey();

        }
    }
}
