namespace RPGSystem.Formularios {
    partial class ucListarItem {
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
            this.components = new System.ComponentModel.Container();
            this.scListarItens = new System.Windows.Forms.SplitContainer();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbAtaque = new System.Windows.Forms.TextBox();
            this.tckRange = new System.Windows.Forms.TrackBar();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.ttEspecie = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scListarItens)).BeginInit();
            this.scListarItens.Panel1.SuspendLayout();
            this.scListarItens.Panel2.SuspendLayout();
            this.scListarItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckRange)).BeginInit();
            this.SuspendLayout();
            // 
            // scListarItens
            // 
            this.scListarItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scListarItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scListarItens.Location = new System.Drawing.Point(0, 0);
            this.scListarItens.Name = "scListarItens";
            // 
            // scListarItens.Panel1
            // 
            this.scListarItens.Panel1.Controls.Add(this.dgvLista);
            this.scListarItens.Panel1.Controls.Add(this.btnExcluir);
            this.scListarItens.Panel1.Controls.Add(this.btnReload);
            this.scListarItens.Panel1.Controls.Add(this.btnEditar);
            // 
            // scListarItens.Panel2
            // 
            this.scListarItens.Panel2.Controls.Add(this.tbAtaque);
            this.scListarItens.Panel2.Controls.Add(this.tckRange);
            this.scListarItens.Panel2.Controls.Add(this.cbxTipo);
            this.scListarItens.Panel2.Controls.Add(this.tbNome);
            this.scListarItens.Panel2.Controls.Add(this.btnCancelar);
            this.scListarItens.Panel2.Controls.Add(this.btnIncluir);
            this.scListarItens.Panel2.Controls.Add(this.lblAtaque);
            this.scListarItens.Panel2.Controls.Add(this.label1);
            this.scListarItens.Panel2.Controls.Add(this.lblTipo);
            this.scListarItens.Panel2.Controls.Add(this.lblNome);
            this.scListarItens.Size = new System.Drawing.Size(858, 459);
            this.scListarItens.SplitterDistance = 424;
            this.scListarItens.SplitterWidth = 2;
            this.scListarItens.TabIndex = 2;
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
            this.dgvLista.Size = new System.Drawing.Size(422, 371);
            this.dgvLista.TabIndex = 8;
            this.dgvLista.DoubleClick += new System.EventHandler(this.dgvLista_DoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Location = new System.Drawing.Point(165, 431);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(3, 431);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbAtaque
            // 
            this.tbAtaque.Location = new System.Drawing.Point(79, 282);
            this.tbAtaque.Name = "tbAtaque";
            this.tbAtaque.Size = new System.Drawing.Size(239, 22);
            this.tbAtaque.TabIndex = 12;
            // 
            // tckRange
            // 
            this.tckRange.LargeChange = 2;
            this.tckRange.Location = new System.Drawing.Point(79, 178);
            this.tckRange.Name = "tckRange";
            this.tckRange.Size = new System.Drawing.Size(238, 45);
            this.tckRange.TabIndex = 10;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(79, 101);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(238, 22);
            this.cbxTipo.TabIndex = 8;
            this.ttEspecie.SetToolTip(this.cbxTipo, "Especie que pode usar o item.\r\n");
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(79, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(238, 22);
            this.tbNome.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(353, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Location = new System.Drawing.Point(275, 432);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 14;
            this.btnIncluir.Text = "Salvar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.Location = new System.Drawing.Point(10, 262);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(47, 14);
            this.lblAtaque.TabIndex = 13;
            this.lblAtaque.Text = "Ataque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Range";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(11, 104);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 14);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Especie";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 14);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // ucListarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scListarItens);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucListarItem";
            this.Size = new System.Drawing.Size(858, 459);
            this.scListarItens.Panel1.ResumeLayout(false);
            this.scListarItens.Panel2.ResumeLayout(false);
            this.scListarItens.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scListarItens)).EndInit();
            this.scListarItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckRange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer scListarItens;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox tbAtaque;
        private System.Windows.Forms.TrackBar tckRange;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ToolTip ttEspecie;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
    }
}