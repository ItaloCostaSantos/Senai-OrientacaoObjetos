﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class Debito
    {
        Pagamento Pagamento { get; set; }
        double Desconto { get; set; }
    }
}
