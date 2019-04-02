﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce
{

    class Prod_Serv : AbsProdutos
    {
        public override string Nome { get; set; }
        public override double Preco { get; set; }
        public override string Fornecedor { get; set; }
        public override int Quantidade { get; set; }
        public int Tempo_Serv { get; set; }
        public override string Confirmacao()
        {
            return base.Confirmacao();
        }
    }
}
