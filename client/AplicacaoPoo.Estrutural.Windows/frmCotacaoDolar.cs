using System;
using AplicacaoPoo.Dominio.services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacaoPoo.Dominio.Helpers;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmCotacaoDolar : Form
    { 
        public frmCotacaoDolar()
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
        }
        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorEmDolar.Text == "")
                {
                    return;
                };
                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var moeda = new ConverterMoedaService();
                var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

                lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValorEmDolar.Focus();
            }
        }
    }
}
