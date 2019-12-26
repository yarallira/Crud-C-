namespace Crud_C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÕESToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÕESToolStripMenuItem
            // 
            this.oPÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFuncionárioToolStripMenuItem});
            this.oPÇÕESToolStripMenuItem.Name = "oPÇÕESToolStripMenuItem";
            this.oPÇÕESToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.oPÇÕESToolStripMenuItem.Text = "OPÇÕES";
            // 
            // addFuncionárioToolStripMenuItem
            // 
            this.addFuncionárioToolStripMenuItem.Name = "addFuncionárioToolStripMenuItem";
            this.addFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addFuncionárioToolStripMenuItem.Text = "add Funcionário";
            this.addFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.addFuncionárioToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 381);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}

