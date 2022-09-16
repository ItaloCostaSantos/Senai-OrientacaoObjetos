using AplicacaoPoo.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Windows
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            var cliente = new Cliente();
            cliente.Nome = "Italo Costa";
            txtNome.Text = cliente.Nome;
            txtCPF.Text = "123.456.789-00";
            lblSaldoInicial.Text = "1000";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var credito = new Credito();
        }
    }
}
