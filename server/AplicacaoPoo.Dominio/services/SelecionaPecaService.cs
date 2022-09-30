using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class SelecionaPecaService
    {
        decimal produto01 = 29.90m;
        decimal produto02 = 75.50m;
        decimal produto03 = 90.00m;
        decimal produto04 = 13.99m;

        public decimal SelecionaProduto01(decimal quantPeca)
        {
            return quantPeca * produto01 * (5.0m / 100);
        }
        public decimal SelecionaProduto02(decimal quantPeca)
        {
            return quantPeca * produto02 * (5.0m / 100);
        }
        public decimal SelecionaProduto03(decimal quantPeca)
        {
            return quantPeca * produto03 * (5.0m / 100);
        }
        public decimal SelecionaProduto04(decimal quantPeca)
        {
            return quantPeca * produto04 * (5.0m / 100);
        }
    }
}
