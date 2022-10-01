using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class VendedorService
    {
        public List<Vendedor> ListagemVendedores()
        {
            var listaVendedor = new List<Vendedor>();

            listaVendedor.Add(new Vendedor()
            {
                IdVendedor = 1,
                NomeVendedor = "Vendedor X"
            });
            listaVendedor.Add(new Vendedor()
            {
                IdVendedor = 2,
                NomeVendedor = "Vendedor Y"
            });
            listaVendedor.Add(new Vendedor()
            {
                IdVendedor = 3,
                NomeVendedor = "Vendedor Z"
            });
            return listaVendedor;
        }
    }
}
