namespace ProjetoEF
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnExcluir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 84);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowTemplate.Height = 25;
            this.Grid.Size = new System.Drawing.Size(776, 354);
            this.Grid.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAdicionar,
            this.toolStripSeparator1,
            this.BtnAlterar,
            this.toolStripSeparator2,
            this.Visualizar,
            this.toolStripSeparator3,
            this.BtnExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Image = global::ProjetoEF.Properties.Resources.btn_add_16;
            this.BtnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(78, 22);
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Image = global::ProjetoEF.Properties.Resources.btn_edit_16;
            this.BtnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(62, 22);
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Visualizar
            // 
            this.Visualizar.Image = global::ProjetoEF.Properties.Resources.btn_visualizar_16;
            this.Visualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(76, 22);
            this.Visualizar.Text = "Visualizar";
            this.Visualizar.Click += new System.EventHandler(this.Visualizar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = global::ProjetoEF.Properties.Resources.btn_excluir_16;
            this.BtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(62, 22);
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Grid);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Grid;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnAdicionar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnAlterar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Visualizar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BtnExcluir;
    }
}