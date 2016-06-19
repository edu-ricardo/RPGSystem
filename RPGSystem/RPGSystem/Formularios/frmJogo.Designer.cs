namespace RPGSystem.Formularios
{
    partial class frmJogo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarÚltimoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarESairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcJogo = new System.Windows.Forms.TabControl();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoJogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.inventárioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventárioToolStripMenuItem1,
            this.statusToolStripMenuItem1});
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.inventárioToolStripMenuItem.Text = "Jogador";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem1,
            this.carregarÚltimoSaveToolStripMenuItem,
            this.salvarESairToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.statusToolStripMenuItem.Text = "Opções";
            // 
            // inventárioToolStripMenuItem1
            // 
            this.inventárioToolStripMenuItem1.Name = "inventárioToolStripMenuItem1";
            this.inventárioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.inventárioToolStripMenuItem1.Text = "Inventário";
            // 
            // statusToolStripMenuItem1
            // 
            this.statusToolStripMenuItem1.Name = "statusToolStripMenuItem1";
            this.statusToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.statusToolStripMenuItem1.Text = "Status";
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.salvarToolStripMenuItem1.Text = "Salvar";
            // 
            // carregarÚltimoSaveToolStripMenuItem
            // 
            this.carregarÚltimoSaveToolStripMenuItem.Name = "carregarÚltimoSaveToolStripMenuItem";
            this.carregarÚltimoSaveToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.carregarÚltimoSaveToolStripMenuItem.Text = "Carregar último save";
            // 
            // salvarESairToolStripMenuItem
            // 
            this.salvarESairToolStripMenuItem.Name = "salvarESairToolStripMenuItem";
            this.salvarESairToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salvarESairToolStripMenuItem.Text = "Salvar e sair";
            // 
            // tcJogo
            // 
            this.tcJogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcJogo.Location = new System.Drawing.Point(0, 24);
            this.tcJogo.Name = "tcJogo";
            this.tcJogo.SelectedIndex = 0;
            this.tcJogo.Size = new System.Drawing.Size(919, 492);
            this.tcJogo.TabIndex = 2;
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoJogarToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // comoJogarToolStripMenuItem
            // 
            this.comoJogarToolStripMenuItem.Name = "comoJogarToolStripMenuItem";
            this.comoJogarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.comoJogarToolStripMenuItem.Text = "Como jogar";
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 516);
            this.Controls.Add(this.tcJogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmJogo";
            this.Text = "Ultimate RPG";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carregarÚltimoSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarESairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem1;
        public System.Windows.Forms.TabControl tcJogo;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoJogarToolStripMenuItem;
    }
}