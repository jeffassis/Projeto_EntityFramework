namespace ProjetoEF
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSetores = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSetores
            // 
            this.BtnSetores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSetores.Location = new System.Drawing.Point(38, 54);
            this.BtnSetores.Name = "BtnSetores";
            this.BtnSetores.Size = new System.Drawing.Size(90, 43);
            this.BtnSetores.TabIndex = 0;
            this.BtnSetores.Text = "Setores";
            this.BtnSetores.UseVisualStyleBackColor = true;
            this.BtnSetores.Click += new System.EventHandler(this.BtnSetores_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnProdutos.Location = new System.Drawing.Point(166, 54);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(90, 43);
            this.BtnProdutos.TabIndex = 1;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 168);
            this.Controls.Add(this.BtnProdutos);
            this.Controls.Add(this.BtnSetores);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSetores;
        private Button BtnProdutos;
    }
}