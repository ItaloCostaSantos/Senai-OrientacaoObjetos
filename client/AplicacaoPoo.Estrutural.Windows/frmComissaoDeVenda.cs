using AplicacaoPoo.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class FrmComissaoDeVenda : Form
    {
        public FrmComissaoDeVenda()
        {
            InitializeComponent();
            
            var list = new List<string>();
            list.Add(VendedorHelper.Vendedor0);
            list.Add(VendedorHelper.Vendedor01);
            list.Add(VendedorHelper.Vendedor02);
            list.Add(VendedorHelper.Vendedor03);
            list.Add(VendedorHelper.Vendedor04);
            cmbNomeVendedor.DataSource = list;
            cmbNomeVendedor.SelectedIndex = 0;
        }

        private void btnCalcularComissao_Click(object sender, EventArgs e)
        {
            
        }

        /*private void CalculoDaComissao()
{
   var idVendedor = decimal.Parse(txtIdVendedor.Text);

   if (txtIdVendedor.Text == "")
   {
       return;
       btnCalcularComissao.Enabled = true;
   }          
   var precoUnit = decimal.Parse(txtPrecoUnitPeca.Text);
   var quantidadeVendida = decimal.Parse(txtQuantVendaPeca.Text);
   var valorComissao = ((precoUnit * quantidadeVendida) * 5) / 100;                     

   lblValorComissao.Text = valorComissao.ToString("C");


}*/
    }
}
