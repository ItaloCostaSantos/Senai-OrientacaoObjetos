using AplicacaoPoo.Dominio;
using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class FrmComissaoDeVenda : Form
    {
        public FrmComissaoDeVenda()
        {
            InitializeComponent();

            var produtoService = new ProdutoService();
            cmbSelecaoProduto.DataSource = produtoService.ListagemProdutosFake();
            cmbSelecaoProduto.DisplayMember = "Nome";
            cmbSelecaoProduto.ValueMember = "Id";

            var vendedorService = new VendedorService();
            cmbNomeVendedor.DataSource = vendedorService.ListagemVendedores();
            cmbNomeVendedor.DisplayMember = "NomeVendedor";
        }
        private void cmbSelecaoProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            var dado = new ProdutoService();
            var lista = dado.ListagemProdutosFake().ToList();
            var result = lista.Where(x => x.Id == int.Parse(cmbSelecaoProduto.ValueMember));
            //txtValorUnitario.Text = dado.ValorUnitario.ToString();
        }
        private void btnCalcularComissao_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtQuantProduto.Text == "")
            //    {
            //        return;
            //    }
            //    var quantProduto = decimal.Parse(txtQuantProduto.Text);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Informe um valor numérico no campo Quantidade de Peça");
            //}           
        }
    }
}
