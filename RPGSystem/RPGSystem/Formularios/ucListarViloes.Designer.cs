namespace RPGSystem.Formularios
{
    partial class ucListarViloes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scListarViloes = new System.Windows.Forms.SplitContainer();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbAtaque = new System.Windows.Forms.TextBox();
            this.tbDefesa = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scListarViloes)).BeginInit();
            this.scListarViloes.Panel1.SuspendLayout();
            this.scListarViloes.Panel2.SuspendLayout();
            this.scListarViloes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // scListarViloes
            // 
            this.scListarViloes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scListarViloes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scListarViloes.Location = new System.Drawing.Point(0, 0);
            this.scListarViloes.Name = "scListarViloes";
            // 
            // scListarViloes.Panel1
            // 
            this.scListarViloes.Panel1.Controls.Add(this.dgvLista);
            this.scListarViloes.Panel1.Controls.Add(this.btnReload);
            this.scListarViloes.Panel1.Controls.Add(this.btnEditar);
            this.scListarViloes.Panel1.Controls.Add(this.btnExcluir);
            // 
            // scListarViloes.Panel2
            // 
            this.scListarViloes.Panel2.Controls.Add(this.btnCancelar);
            this.scListarViloes.Panel2.Controls.Add(this.btnSalvar);
            this.scListarViloes.Panel2.Controls.Add(this.tbDefesa);
            this.scListarViloes.Panel2.Controls.Add(this.tbAtaque);
            this.scListarViloes.Panel2.Controls.Add(this.tbDescricao);
            this.scListarViloes.Panel2.Controls.Add(this.tbNome);
            this.scListarViloes.Panel2.Controls.Add(this.cbxEspecie);
            this.scListarViloes.Panel2.Controls.Add(this.label5);
            this.scListarViloes.Panel2.Controls.Add(this.label4);
            this.scListarViloes.Panel2.Controls.Add(this.label3);
            this.scListarViloes.Panel2.Controls.Add(this.label2);
            this.scListarViloes.Panel2.Controls.Add(this.label1);
            this.scListarViloes.Size = new System.Drawing.Size(858, 459);
            this.scListarViloes.SplitterDistance = 424;
            this.scListarViloes.SplitterWidth = 2;
            this.scListarViloes.TabIndex = 2;
            // 
            // dgvLista
            // 
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLista.Location = new System.Drawing.Point(3, 3);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(422, 371);
            this.dgvLista.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.Location = new System.Drawing.Point(84, 431);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(3, 431);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Location = new System.Drawing.Point(165, 431);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Defesa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ataque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Espécie";
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Location = new System.Drawing.Point(78, 3);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(172, 22);
            this.cbxEspecie.TabIndex = 8;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(78, 61);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(348, 22);
            this.tbNome.TabIndex = 9;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(78, 121);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(348, 240);
            this.tbDescricao.TabIndex = 11;
            // 
            // tbAtaque
            // 
            this.tbAtaque.Location = new System.Drawing.Point(78, 367);
            this.tbAtaque.Name = "tbAtaque";
            this.tbAtaque.Size = new System.Drawing.Size(172, 22);
            this.tbAtaque.TabIndex = 11;
            // 
            // tbDefesa
            // 
            this.tbDefesa.Location = new System.Drawing.Point(78, 395);
            this.tbDefesa.Name = "tbDefesa";
            this.tbDefesa.Size = new System.Drawing.Size(172, 22);
            this.tbDefesa.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(273, 432);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(354, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ucListarViloes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scListarViloes);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "ucListarViloes";
            this.Size = new System.Drawing.Size(858, 459);
            this.scListarViloes.Panel1.ResumeLayout(false);
            this.scListarViloes.Panel2.ResumeLayout(false);
            this.scListarViloes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scListarViloes)).EndInit();
            this.scListarViloes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scListarViloes;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDefesa;
        private System.Windows.Forms.TextBox tbAtaque;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}
