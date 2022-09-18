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
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
        }

        private void btnCalcularComissao_Click(object sender, EventArgs e)
        {
            var precoUnit = decimal.Parse(txtPrecoUnitPeca.Text);
            var quantidadeVendida = decimal.Parse(txtQuantVendaPeca.Text);
            var valorQuantidade = precoUnit * quantidadeVendida;
            var valorComissao = (5 * valorQuantidade) / 100;
            lblValorComissao.Text = valorComissao.ToString("C");
        }

        private void txtPrecoUnitPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Atenção! Este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Atenção! Este campo aceita somente uma virgula");
            }
        }
    }
}
