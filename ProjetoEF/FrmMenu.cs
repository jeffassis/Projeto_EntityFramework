namespace ProjetoEF
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnSetores_Click(object sender, EventArgs e)
        {
            using (var form = new FrmSetores())
                form.ShowDialog();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            using (var form = new FrmProdutos())
                form.ShowDialog();
        }
    }
}