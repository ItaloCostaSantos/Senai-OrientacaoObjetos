namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        } 

        private void converterEmDolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoDolar();
            form.MdiParent = this;
            form.Show();
        }

        private void comissionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmComissaoDeVenda();
            form.MdiParent = this;
            form.Show();
        }
    }
}