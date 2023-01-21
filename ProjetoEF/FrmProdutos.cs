using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEF
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                //Grid.DataSource = (from produtos in context.Produtos select produtos).ToList();

                var lista = from produtos in context.Produtos
                            join setores in context.Setores
                            on produtos.IdSetor equals setores.IdSetor
                            into produtosGrupo
                            from setores in produtosGrupo.DefaultIfEmpty()
                            select new { setores, produtos };
                ConfigurarGrade();
                foreach(var item in lista)
                    Grid.Rows.Add(item.produtos.Id, item.produtos.Descricao, item.produtos.Un, item.produtos.Unitario.ToString("N2"), 
                        item.produtos.IdSetor, item.setores.Descricao);
            }
        }
        private void ConfigurarGrade()
        {
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            Grid.DefaultCellStyle.Font = new Font("Arial", 9);
            

            Grid.Columns.Add("id", "Id");
            Grid.Columns["Id"].Width = 50;

            Grid.Columns.Add("descricao", "Descrição");
            Grid.Columns["descricao"].Width = 250;

            Grid.Columns.Add("un", "UN"); 
            Grid.Columns["un"].Width = 60;
            //Grid.Columns["un"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Grid.Columns["un"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Grid.Columns.Add("unitario", "Unitario");
            Grid.Columns["unitario"].Width = 100;
            Grid.Columns["unitario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns["unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            


            Grid.Columns.Add("IdSetor", "IdSetor");
            Grid.Columns["idSetor"].Width = 80;
            Grid.Columns["idSetor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns["idSetor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Grid.Columns.Add("descricaoSetor", "Descrição do Setor");
            Grid.Columns["descricaoSetor"].Width = 150;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Grid.CurrentRow.Cells["Id"].Value);
            using (var form = new FrmProdutosCadastro(id))
                form.ShowDialog();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var form = new FrmProdutosCadastro(id))
                form.ShowDialog();
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Grid.CurrentRow.Cells["Id"].Value);
            using (var form = new FrmProdutosCadastro(id, "v"))
                form.ShowDialog();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Grid.CurrentRow.Cells["Id"].Value);
            using (var form = new FrmProdutosCadastro(id, "e"))
                form.ShowDialog();
        }
    }
}
