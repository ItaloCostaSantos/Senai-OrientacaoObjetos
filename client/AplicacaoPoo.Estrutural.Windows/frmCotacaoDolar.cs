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
            lblSegundoValor.Text = $"5,27 {MoedaHelper.Real}";

            var list = new List<string>();

            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libras);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;
        }
        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            //calcularMoeda();
            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            var moeda = new ConverterMoedaService();
            var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
        }
        //----Meu codigo-----
        //private void cmbmoedas_selectedvaluechanged(object sender, eventargs e)
        //{
        //    calcularmoeda();
        //}
        #region Meu código
        private void calcularMoeda()
        {
            //while (cmbMoedas.SelectedIndex == 0)
            //{
            //    lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            //    lblSegundoValor.Text = $"5,27 {MoedaHelper.Real}";
            //    try
            //    {
            //        if (txtValorEmDolar.Text == "")
            //        {
            //            return;
            //        };
            //        var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            //        var moeda = new ConverterMoedaService();
            //        var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

            //        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("A cotação do dolar é um valor decimal");
            //        txtValorEmDolar.Focus();
            //    }
            //    break;
            //}
            //while (cmbMoedas.SelectedIndex == 1)
            //{
            //    lblPrimeiroValor.Text = $"1 {MoedaHelper.Euro} igual a";
            //    lblSegundoValor.Text = $"5,10 {MoedaHelper.Real}";
            //    try
            //    {
            //        if (txtValorEmDolar.Text == "")
            //        {
            //            return;
            //        };

            //        var valorEmEuro = decimal.Parse(txtValorEmDolar.Text);
            //        var moeda = new ConverterMoedaService();
            //        var resultado = moeda.ConverterEuroEmReal(valorEmEuro);

            //        lblPrimeiroValor.Text = $"{valorEmEuro} {MoedaHelper.Euro} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("A cotação do euro é um valor decimal");
            //        txtValorEmDolar.Focus();
            //    }
            //    break;
            //}
            //while (cmbMoedas.SelectedIndex == 2)
            //{
            //    lblPrimeiroValor.Text = $"1 {MoedaHelper.Libras} igual a";
            //    lblSegundoValor.Text = $"5,71 {MoedaHelper.Real}";
            //    try
            //    {
            //        if (txtValorEmDolar.Text == "")
            //        {
            //            return;
            //        };

            //        var valorEmLibra = decimal.Parse(txtValorEmDolar.Text);
            //        var moeda = new ConverterMoedaService();
            //        var resultado = moeda.ConverterLibraEmReal(valorEmLibra);

            //        lblPrimeiroValor.Text = $"{valorEmLibra} {MoedaHelper.Libras} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("A cotação da libra é um valor decimal");
            //        txtValorEmDolar.Focus();
            //    }
            //    break;
            //}
        }
        #endregion

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //atalho para comentar codigo CRTL + K + C
            //ATALHO PARA DESCOMENTAR CRTL + K + U
            if (txtValorEmDolar.Text == "") return;

            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            var moedaService = new ConverterMoedaService();
            switch (cmbMoedas.SelectedValue)
            {
                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = moedaService.ConverterDolarEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";                  
                        break;
                    }
                case MoedaHelper.Euro:
                    {
                        var valorConvertido = moedaService.ConverterEuroEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }
                case MoedaHelper.Libras:
                    {
                        var valorConvertido = moedaService.ConverterLibraEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libras} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }
            }
        }
    }
}
