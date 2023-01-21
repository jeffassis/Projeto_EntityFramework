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
    public partial class FrmSetores : Form
    {
        public FrmSetores()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                Grid.DataSource = (from setores in context.Setores select setores).ToList();
            }
            ConfigurarGrade();
        }

        private void ConfigurarGrade()
        {
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            Grid.DefaultCellStyle.Font = new Font("Arial", 9);
            //Grid.RowHeadersWidth = 25;

            Grid.Columns["idSetor"].HeaderText = "Id";
            Grid.Columns["idSetor"].Width = 80;
            Grid.Columns["idSetor"].HeaderCell.Style.Alignment= DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns["idSetor"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;

            Grid.Columns["descricao"].HeaderText= "Descrção";
            Grid.Columns["descricao"].Width = 250;
        }
    }
}
