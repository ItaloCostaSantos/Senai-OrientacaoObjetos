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
        private bool CotacaoEhValido;
        private bool ValorEmDolarEhValido;
        public frmCotacaoDolar()
        {
            InitializeComponent();
            HabilitarOuDesabilitarBotaoCalcularConversao();        
        }
        private void btnConverter_Click(object sender, EventArgs e)
        {
            var valorAtualDolar = decimal.Parse(txtValorAtual.Text);
            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);

            var resultado = valorEmDolar * valorAtualDolar;
            MessageBox.Show($"Valor em Reais: {resultado.ToString("C")}");
        }
        private void txtValorAtual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorAtual.Text);
                CotacaoEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValorAtual.Focus();
                CotacaoEhValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
        }

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorEmDolar.Text);
                ValorEmDolarEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValorEmDolar.Focus();
                ValorEmDolarEhValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
        }
        private void HabilitarOuDesabilitarBotaoCalcularConversao()
        {
            if (ValorEmDolarEhValido && CotacaoEhValido)
            {
                btnConverter.Enabled = true;
            }
            else
            {
                btnConverter.Enabled = false;
            }
        }
    }
}
