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
    public partial class frmCotacaoDolar : Form
    {
        
        public frmCotacaoDolar()
        {
            InitializeComponent();
            btnConverter.Enabled = false;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var valorAtualDolar = decimal.Parse(txtValorAtual.Text);
            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);

            var resultado = valorEmDolar * valorAtualDolar;

            MessageBox.Show($"Valor em Reais: {resultado.ToString("C")}");
        }

        /*private void txtValorAtual_KeyPress(object sender, KeyPressEventArgs e)
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
        }*/

        private void txtValorAtual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorAtual.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValorAtual.Focus();
                throw;
            }
        }

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorEmDolar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValorEmDolar.Focus();
                throw;
            }
        }
    }
}
