namespace RPGSystem.Formularios {
    partial class ucListarCapitulos {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.scListarCapitulos = new System.Windows.Forms.SplitContainer();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.btnDelVil = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cbxItens = new System.Windows.Forms.ComboBox();
            this.btnAddVil = new System.Windows.Forms.Button();
            this.cbxViloes = new System.Windows.Forms.ComboBox();
            this.lbItens = new System.Windows.Forms.ListBox();
            this.lbViloes = new System.Windows.Forms.ListBox();
            this.chkStartChapter = new System.Windows.Forms.CheckBox();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scListarCapitulos)).BeginInit();
            this.scListarCapitulos.Panel1.SuspendLayout();
            this.scListarCapitulos.Panel2.SuspendLayout();
            this.scListarCapitulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // scListarCapitulos
            // 
            this.scListarCapitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scListarCapitulos.Location = new System.Drawing.Point(0, 0);
            this.scListarCapitulos.Name = "scListarCapitulos";
            // 
            // scListarCapitulos.Panel1
            // 
            this.scListarCapitulos.Panel1.Controls.Add(this.btnEditar);
            this.scListarCapitulos.Panel1.Controls.Add(this.btnExcluir);
            this.scListarCapitulos.Panel1.Controls.Add(this.btnReload);
            this.scListarCapitulos.Panel1.Controls.Add(this.dgvLista);
            // 
            // scListarCapitulos.Panel2
            // 
            this.scListarCapitulos.Panel2.Controls.Add(this.btnDelItem);
            this.scListarCapitulos.Panel2.Controls.Add(this.btnDelVil);
            this.scListarCapitulos.Panel2.Controls.Add(this.btnCancelar);
            this.scListarCapitulos.Panel2.Controls.Add(this.btnSalvar);
            this.scListarCapitulos.Panel2.Controls.Add(this.btnAddItem);
            this.scListarCapitulos.Panel2.Controls.Add(this.cbxItens);
            this.scListarCapitulos.Panel2.Controls.Add(this.btnAddVil);
            this.scListarCapitulos.Panel2.Controls.Add(this.cbxViloes);
            this.scListarCapitulos.Panel2.Controls.Add(this.lbItens);
            this.scListarCapitulos.Panel2.Controls.Add(this.lbViloes);
            this.scListarCapitulos.Panel2.Controls.Add(this.chkStartChapter);
            this.scListarCapitulos.Panel2.Controls.Add(this.tbTexto);
            this.scListarCapitulos.Panel2.Controls.Add(this.tbTitulo);
            this.scListarCapitulos.Panel2.Controls.Add(this.label5);
            this.scListarCapitulos.Panel2.Controls.Add(this.label4);
            this.scListarCapitulos.Panel2.Controls.Add(this.label3);
            this.scListarCapitulos.Panel2.Controls.Add(this.label1);
            this.scListarCapitulos.Size = new System.Drawing.Size(1162, 540);
            this.scListarCapitulos.SplitterDistance = 347;
            this.scListarCapitulos.TabIndex = 0;
            // 
            // btnDelItem
            // 
            this.btnDelItem.Location = new System.Drawing.Point(747, 371);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(51, 23);
            this.btnDelItem.TabIndex = 34;
            this.btnDelItem.Text = "-";
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // btnDelVil
            // 
            this.btnDelVil.Location = new System.Drawing.Point(747, 180);
            this.btnDelVil.Name = "btnDelVil";
            this.btnDelVil.Size = new System.Drawing.Size(51, 22);
            this.btnDelVil.TabIndex = 33;
            this.btnDelVil.Text = "-";
            this.btnDelVil.UseVisualStyleBackColor = true;
            this.btnDelVil.Click += new System.EventHandler(this.btnDelVil_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(723, 514);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(642, 514);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(694, 372);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(51, 22);
            this.btnAddItem.TabIndex = 30;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cbxItens
            // 
            this.cbxItens.FormattingEnabled = true;
            this.cbxItens.Location = new System.Drawing.Point(509, 372);
            this.cbxItens.Name = "cbxItens";
            this.cbxItens.Size = new System.Drawing.Size(179, 22);
            this.cbxItens.TabIndex = 29;
            // 
            // btnAddVil
            // 
            this.btnAddVil.Location = new System.Drawing.Point(692, 180);
            this.btnAddVil.Name = "btnAddVil";
            this.btnAddVil.Size = new System.Drawing.Size(51, 22);
            this.btnAddVil.TabIndex = 28;
            this.btnAddVil.Text = "+";
            this.btnAddVil.UseVisualStyleBackColor = true;
            this.btnAddVil.Click += new System.EventHandler(this.btnAddVil_Click);
            // 
            // cbxViloes
            // 
            this.cbxViloes.FormattingEnabled = true;
            this.cbxViloes.Location = new System.Drawing.Point(509, 180);
            this.cbxViloes.Name = "cbxViloes";
            this.cbxViloes.Size = new System.Drawing.Size(179, 22);
            this.cbxViloes.TabIndex = 27;
            // 
            // lbItens
            // 
            this.lbItens.FormattingEnabled = true;
            this.lbItens.ItemHeight = 14;
            this.lbItens.Location = new System.Drawing.Point(509, 207);
            this.lbItens.Name = "lbItens";
            this.lbItens.Size = new System.Drawing.Size(289, 158);
            this.lbItens.TabIndex = 26;
            // 
            // lbViloes
            // 
            this.lbViloes.FormattingEnabled = true;
            this.lbViloes.ItemHeight = 14;
            this.lbViloes.Location = new System.Drawing.Point(509, 14);
            this.lbViloes.Name = "lbViloes";
            this.lbViloes.Size = new System.Drawing.Size(289, 158);
            this.lbViloes.TabIndex = 25;
            // 
            // chkStartChapter
            // 
            this.chkStartChapter.AutoSize = true;
            this.chkStartChapter.Location = new System.Drawing.Point(78, 40);
            this.chkStartChapter.Name = "chkStartChapter";
            this.chkStartChapter.Size = new System.Drawing.Size(102, 18);
            this.chkStartChapter.TabIndex = 24;
            this.chkStartChapter.Text = "Capitulo Inicial";
            this.chkStartChapter.UseVisualStyleBackColor = true;
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(78, 79);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(356, 325);
            this.tbTexto.TabIndex = 23;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(78, 12);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(356, 22);
            this.tbTitulo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "Itens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "Vilões";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Texto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Titulo";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(7, 514);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Location = new System.Drawing.Point(169, 514);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.Location = new System.Drawing.Point(88, 514);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToOrderColumns = true;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLista.Location = new System.Drawing.Point(0, 0);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(347, 371);
            this.dgvLista.TabIndex = 4;
            this.dgvLista.DoubleClick += new System.EventHandler(this.dgvLista_DoubleClick);
            // 
            // ucListarCapitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scListarCapitulos);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucListarCapitulos";
            this.Size = new System.Drawing.Size(1162, 540);
            this.scListarCapitulos.Panel1.ResumeLayout(false);
            this.scListarCapitulos.Panel2.ResumeLayout(false);
            this.scListarCapitulos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scListarCapitulos)).EndInit();
            this.scListarCapitulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scListarCapitulos;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.Button btnDelVil;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cbxItens;
        private System.Windows.Forms.Button btnAddVil;
        private System.Windows.Forms.ComboBox cbxViloes;
        private System.Windows.Forms.ListBox lbItens;
        private System.Windows.Forms.ListBox lbViloes;
        private System.Windows.Forms.CheckBox chkStartChapter;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}
