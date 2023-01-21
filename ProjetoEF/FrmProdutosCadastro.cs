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
    public partial class FrmProdutosCadastro : Form
    {
        public FrmProdutosCadastro(int id, string operacao = "a")
        {
            InitializeComponent();

            PopularSetores();

            if (id != 0)
            {
                ObterProduto(id);

                // Visualizar
                if (operacao == "v")
                {
                    Text = "Visualizar produto";
                    BtnAdd.Visible = false;
                    TravarFormulario();
                }
                else if (operacao == "e")
                {
                    Text = "Excluir produto";
                    BtnAdd.Visible = false;
                    BtnExcluir.Visible = true;
                    TravarFormulario();
                }                                
            }
        }

        private void TravarFormulario()
        {
            txtDescricao.ReadOnly= true;
            txtUnitario.ReadOnly= true;
            txtUn.ReadOnly= true;
            CbSetor.Enabled= false;
        }

        private void PopularSetores()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var listaSetores = from setores in context.Setores select setores;

                    CbSetor.DataSource= listaSetores.ToList();
                    CbSetor.DisplayMember = "Descricao";
                    CbSetor.ValueMember = "IdSetor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar Setores.\n" + ex.Message);
            }
        }


        private void ObterProduto(int id) 
        {
            txtId.Text = id.ToString();
            try
            {
                using (var context = new DataContext())
                {
                    var produto = context.Produtos.Find(id);
                    if (produto != null) 
                    {
                        txtDescricao.Text = produto.Descricao;
                        txtUn.Text = produto.Un;
                        txtUnitario.Text = produto.Unitario.ToString("N2");
                        CbSetor.SelectedValue = produto.IdSetor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar.\n" + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                Close();
            }
        }

        private bool Salvar()
        {
            var produto = new Produtos();

            produto.Id = Convert.ToInt32("0" + txtId.Text);
            produto.Descricao = txtDescricao.Text;
            produto.Un = txtUn.Text;
            produto.Unitario = Convert.ToDecimal(txtUnitario.Text);
            produto.IdSetor = Convert.ToInt32(CbSetor.SelectedValue);

            try
            {
                using (var context = new DataContext())
                {
                    if (produto.Id == 0)
                    {
                        context.Produtos.Add(produto);
                    }
                    else
                    {
                        context.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                    }
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar.\n" + ex.Message);
                return false;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (Excluir())
            {
                Close();
            }
        }

        private bool Excluir()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var produto = new Produtos();
                    produto.Id = Convert.ToInt32(txtId.Text);
                    var entry = context.Entry(produto);

                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        context.Produtos.Attach(produto);
                    }
                    context.Produtos.Remove(produto);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir.\n" + ex.Message);
                return false;
            }
        }
    }
}
