using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class ConverterMoedaService
    {
        decimal CotacaoDolar = 5.41m;
        decimal CotacaoLibra = 5.76m;
        decimal CotacaoEuro = 5.19m;
        public decimal ConverterDolarEmReal(decimal valor)
        {
            return valor * CotacaoDolar;
        }
        public decimal ConverterLibraEmReal(decimal valor)
        {
            return valor * CotacaoLibra;
        }
        public decimal ConverterEuroEmReal(decimal valor)
        {
            return valor * CotacaoEuro;
        }
    }
}
