namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
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
            var form = new frmComissao();
            form.Show();
        }
    }
}