namespace RPGSystem.Formularios {
    partial class ucIncluirCapitulo {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.chkStartChapter = new System.Windows.Forms.CheckBox();
            this.lbViloes = new System.Windows.Forms.ListBox();
            this.lbItens = new System.Windows.Forms.ListBox();
            this.cbxViloes = new System.Windows.Forms.ComboBox();
            this.btnAddVil = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cbxItens = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDelVil = new System.Windows.Forms.Button();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Texto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vilões";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Itens";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(66, 32);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(412, 22);
            this.tbTitulo.TabIndex = 5;
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(66, 99);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(412, 325);
            this.tbTexto.TabIndex = 6;
            // 
            // chkStartChapter
            // 
            this.chkStartChapter.AutoSize = true;
            this.chkStartChapter.Location = new System.Drawing.Point(66, 60);
            this.chkStartChapter.Name = "chkStartChapter";
            this.chkStartChapter.Size = new System.Drawing.Size(102, 18);
            this.chkStartChapter.TabIndex = 7;
            this.chkStartChapter.Text = "Capitulo Inicial";
            this.chkStartChapter.UseVisualStyleBackColor = true;
            // 
            // lbViloes
            // 
            this.lbViloes.FormattingEnabled = true;
            this.lbViloes.ItemHeight = 14;
            this.lbViloes.Location = new System.Drawing.Point(551, 35);
            this.lbViloes.Name = "lbViloes";
            this.lbViloes.Size = new System.Drawing.Size(289, 158);
            this.lbViloes.TabIndex = 8;
            // 
            // lbItens
            // 
            this.lbItens.FormattingEnabled = true;
            this.lbItens.ItemHeight = 14;
            this.lbItens.Location = new System.Drawing.Point(551, 228);
            this.lbItens.Name = "lbItens";
            this.lbItens.Size = new System.Drawing.Size(289, 158);
            this.lbItens.TabIndex = 9;
            // 
            // cbxViloes
            // 
            this.cbxViloes.FormattingEnabled = true;
            this.cbxViloes.Location = new System.Drawing.Point(551, 201);
            this.cbxViloes.Name = "cbxViloes";
            this.cbxViloes.Size = new System.Drawing.Size(179, 22);
            this.cbxViloes.TabIndex = 10;
            // 
            // btnAddVil
            // 
            this.btnAddVil.Location = new System.Drawing.Point(734, 201);
            this.btnAddVil.Name = "btnAddVil";
            this.btnAddVil.Size = new System.Drawing.Size(51, 22);
            this.btnAddVil.TabIndex = 11;
            this.btnAddVil.Text = "+";
            this.btnAddVil.UseVisualStyleBackColor = true;
            this.btnAddVil.Click += new System.EventHandler(this.btnAddVil_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(736, 393);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(51, 22);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cbxItens
            // 
            this.cbxItens.FormattingEnabled = true;
            this.cbxItens.Location = new System.Drawing.Point(551, 393);
            this.cbxItens.Name = "cbxItens";
            this.cbxItens.Size = new System.Drawing.Size(179, 22);
            this.cbxItens.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(10, 485);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(91, 485);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDelVil
            // 
            this.btnDelVil.Location = new System.Drawing.Point(789, 201);
            this.btnDelVil.Name = "btnDelVil";
            this.btnDelVil.Size = new System.Drawing.Size(51, 22);
            this.btnDelVil.TabIndex = 16;
            this.btnDelVil.Text = "-";
            this.btnDelVil.UseVisualStyleBackColor = true;
            this.btnDelVil.Click += new System.EventHandler(this.btnDelVil_Click);
            // 
            // btnDelItem
            // 
            this.btnDelItem.Location = new System.Drawing.Point(789, 392);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(51, 23);
            this.btnDelItem.TabIndex = 17;
            this.btnDelItem.Text = "-";
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // ucIncluirCapitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelItem);
            this.Controls.Add(this.btnDelVil);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cbxItens);
            this.Controls.Add(this.btnAddVil);
            this.Controls.Add(this.cbxViloes);
            this.Controls.Add(this.lbItens);
            this.Controls.Add(this.lbViloes);
            this.Controls.Add(this.chkStartChapter);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucIncluirCapitulo";
            this.Size = new System.Drawing.Size(880, 511);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.CheckBox chkStartChapter;
        private System.Windows.Forms.ListBox lbViloes;
        private System.Windows.Forms.ListBox lbItens;
        private System.Windows.Forms.ComboBox cbxViloes;
        private System.Windows.Forms.Button btnAddVil;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cbxItens;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDelVil;
        private System.Windows.Forms.Button btnDelItem;
    }
}
