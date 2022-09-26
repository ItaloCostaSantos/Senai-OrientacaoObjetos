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
            cmbMoedas.Enabled = false;
        }
        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            cmbMoedas.Enabled = true;
            try
            {
                if (txtValorEmDolar.Text == "")
                {
                    return;
                };
                
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValorEmDolar.Focus();
            }
        }
        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (cmbMoedas.SelectedIndex == 0)
            {
                lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
                lblSegundoValor.Text = $"5,27 {MoedaHelper.Real}";
                try
                {
                    if (txtValorEmDolar.Text == "")
                    {
                        return;
                    };

                    while (txtValorEmDolar.Text != "")
                    {
                        var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                        var moeda = new ConverterMoedaService();
                        var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
                        break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("A cotação do dolar é um valor decimal");
                    txtValorEmDolar.Focus();
                }
                break;
            }
            while (cmbMoedas.SelectedIndex == 1)
            {
                lblPrimeiroValor.Text = $"1 {MoedaHelper.Euro} igual a";
                lblSegundoValor.Text = $"5,10 {MoedaHelper.Real}";
                try
                {
                    if (txtValorEmDolar.Text == "")
                    {
                        return;
                    };
                    while (txtValorEmDolar.Text != "")
                    {
                        var valorEmEuro = decimal.Parse(txtValorEmDolar.Text);
                        var moeda = new ConverterMoedaService();
                        var resultado = moeda.ConverterEuroEmReal(valorEmEuro);

                        lblPrimeiroValor.Text = $"{valorEmEuro} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
                        break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("A cotação do euro é um valor decimal");
                    txtValorEmDolar.Focus();
                }
                break;
            }
            while (cmbMoedas.SelectedIndex == 2)
            {
                lblPrimeiroValor.Text = $"1 {MoedaHelper.Libras} igual a";
                lblSegundoValor.Text = $"5,71 {MoedaHelper.Real}";
                try
                {
                    if (txtValorEmDolar.Text == "")
                    {
                        return;
                    };
                    while (txtValorEmDolar.Text != "")
                    {
                        var valorEmLibra = decimal.Parse(txtValorEmDolar.Text);
                        var moeda = new ConverterMoedaService();
                        var resultado = moeda.ConverterLibraEmReal(valorEmLibra);

                        lblPrimeiroValor.Text = $"{valorEmLibra} {MoedaHelper.Libras} igual a";
                        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
                        break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("A cotação da libra é um valor decimal");
                    txtValorEmDolar.Focus();
                }
                break;
            }
        }
    }
}
