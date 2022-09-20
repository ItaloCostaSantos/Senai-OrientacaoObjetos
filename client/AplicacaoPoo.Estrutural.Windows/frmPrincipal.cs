namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoDolar();
            form.Show();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            var form = new FrmComissaoDeVenda();
            form.Show();
        }
    }
}