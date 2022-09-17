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
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var valorAtualDolar = decimal.Parse(txtValorAtual.Text);
            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);

            var resultado = valorEmDolar * valorAtualDolar;

            MessageBox.Show($"Valor em Reais R${resultado.ToString()}");
        }
    }
}
