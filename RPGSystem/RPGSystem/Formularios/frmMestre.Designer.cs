namespace RPGSystem.Formularios {
    partial class frmMestre {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMestre));
            this.msMestre = new System.Windows.Forms.MenuStrip();
            this.históriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atributosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vilõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripInfoUser = new System.Windows.Forms.ToolStripComboBox();
            this.tcMestre = new System.Windows.Forms.TabControl();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMestre.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMestre
            // 
            this.msMestre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históriaToolStripMenuItem,
            this.atributosToolStripMenuItem,
            this.vilõesToolStripMenuItem,
            this.armasToolStripMenuItem,
            this.toolStripInfoUser});
            this.msMestre.Location = new System.Drawing.Point(0, 0);
            this.msMestre.Name = "msMestre";
            this.msMestre.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMestre.Size = new System.Drawing.Size(919, 27);
            this.msMestre.TabIndex = 0;
            this.msMestre.Text = "menuStrip1";
            // 
            // históriaToolStripMenuItem
            // 
            this.históriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capituloToolStripMenuItem,
            this.históriaToolStripMenuItem1});
            this.históriaToolStripMenuItem.Name = "históriaToolStripMenuItem";
            this.históriaToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.históriaToolStripMenuItem.Text = "&História";
            // 
            // capituloToolStripMenuItem
            // 
            this.capituloToolStripMenuItem.Name = "capituloToolStripMenuItem";
            this.capituloToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.capituloToolStripMenuItem.Text = "&Capitulo";
            // 
            // históriaToolStripMenuItem1
            // 
            this.históriaToolStripMenuItem1.Name = "históriaToolStripMenuItem1";
            this.históriaToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.históriaToolStripMenuItem1.Text = "História";
            // 
            // atributosToolStripMenuItem
            // 
            this.atributosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.atributosToolStripMenuItem.Name = "atributosToolStripMenuItem";
            this.atributosToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.atributosToolStripMenuItem.Text = "A&tributos";
            // 
            // vilõesToolStripMenuItem
            // 
            this.vilõesToolStripMenuItem.Name = "vilõesToolStripMenuItem";
            this.vilõesToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.vilõesToolStripMenuItem.Text = "&Vilões";
            // 
            // armasToolStripMenuItem
            // 
            this.armasToolStripMenuItem.Name = "armasToolStripMenuItem";
            this.armasToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.armasToolStripMenuItem.Text = "&Armas";
            // 
            // toolStripInfoUser
            // 
            this.toolStripInfoUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripInfoUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripInfoUser.Name = "toolStripInfoUser";
            this.toolStripInfoUser.Size = new System.Drawing.Size(140, 23);
            // 
            // tcMestre
            // 
            this.tcMestre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMestre.Location = new System.Drawing.Point(0, 27);
            this.tcMestre.Name = "tcMestre";
            this.tcMestre.SelectedIndex = 0;
            this.tcMestre.Size = new System.Drawing.Size(919, 489);
            this.tcMestre.TabIndex = 1;
            this.tcMestre.DoubleClick += new System.EventHandler(this.tcMestre_DoubleClick);
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // frmMestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 516);
            this.Controls.Add(this.tcMestre);
            this.Controls.Add(this.msMestre);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMestre;
            this.Name = "frmMestre";
            this.Text = "Mestre -Home";
            this.msMestre.ResumeLayout(false);
            this.msMestre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMestre;
        private System.Windows.Forms.ToolStripMenuItem históriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atributosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vilõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armasToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripInfoUser;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        public System.Windows.Forms.TabControl tcMestre;
    }
}