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
            Prod_Digi d = new Prod_Digi();
            Prod_Serv s = new Prod_Serv();
            Prod_Fisico f = new Prod_Fisico();
            Pagamento P = new Pagamento();
            Logistica log = new Logistica();



            Endereco end = new Endereco();
            end.cidade = "Sao teste";
            end.bairro = "Capao do teste";
            end.rua = "Avenida teste";

            Cliente cli = new Cliente();
            cli.cpf = 1235;
            cli.email = "teste@teste.com";
            cli.nome = "Roberium";

            Ordem ord = new Ordem();






            //TEST Prod_Digi
             d.Nome = "TesteDigi";
             d.Fornecedor = "FornecStore";
             d.Preco = 2500.00;


            //DEBUG
            /*Console.WriteLine(d.Nome);
            Console.WriteLine(d.Preco);
            Console.WriteLine(d.Quantidade);
            Console.WriteLine(d.Fornecedor);
            */

            //TEST Prod_Serv
            /*s.Nome = "TesteServico";
            s.Fornecedor = "Fornec";
            s.Preco = 250.00;
            s.Quantidade = 2;
            s.Tempo_Serv = 24;

            //DEBUG
             Console.WriteLine(s.Nome);
             Console.WriteLine(s.Preco);
             Console.WriteLine(s.Quantidade);
             Console.WriteLine(s.Fornecedor);
             Console.WriteLine(s.Tempo_Serv);
           */


            //TEST Prod_fisico
            /*f.Nome = "Teste";
            f.Fornecedor = "teetessete";
            f.Preco = 2.5;
            f.Quantidade = 25;


            //DEBUG
            Console.WriteLine(a.Nome);
            Console.WriteLine(a.Preco);
            Console.WriteLine(a.Quantidade);
            */

            ord.NotaFiscal(cli, d);
            //log.send(cli, end);

            //Console.WriteLine(P.Pagar(d));
            Console.ReadKey();


        }
    }
}
