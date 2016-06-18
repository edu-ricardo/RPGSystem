namespace RPGSystem.Formularios
{
    partial class ucIncluirViloes
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
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.lblDefesa = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbAtaque = new System.Windows.Forms.TextBox();
            this.tbDefesa = new System.Windows.Forms.TextBox();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.lblEspecie.Location = new System.Drawing.Point(58, 36);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(51, 16);
            this.lblEspecie.TabIndex = 0;
            this.lblEspecie.Text = "Especie";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(58, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(58, 115);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(63, 16);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.Location = new System.Drawing.Point(61, 338);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(48, 16);
            this.lblAtaque.TabIndex = 3;
            this.lblAtaque.Text = "Ataque";
            // 
            // lblDefesa
            // 
            this.lblDefesa.AutoSize = true;
            this.lblDefesa.Location = new System.Drawing.Point(61, 374);
            this.lblDefesa.Name = "lblDefesa";
            this.lblDefesa.Size = new System.Drawing.Size(47, 16);
            this.lblDefesa.TabIndex = 4;
            this.lblDefesa.Text = "Defesa";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(142, 77);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(366, 22);
            this.tbNome.TabIndex = 5;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(142, 115);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(366, 188);
            this.tbDescricao.TabIndex = 5;
            // 
            // tbAtaque
            // 
            this.tbAtaque.Location = new System.Drawing.Point(145, 338);
            this.tbAtaque.Name = "tbAtaque";
            this.tbAtaque.Size = new System.Drawing.Size(118, 22);
            this.tbAtaque.TabIndex = 5;
            // 
            // tbDefesa
            // 
            this.tbDefesa.Location = new System.Drawing.Point(145, 374);
            this.tbDefesa.Name = "tbDefesa";
            this.tbDefesa.Size = new System.Drawing.Size(118, 22);
            this.tbDefesa.TabIndex = 5;
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Location = new System.Drawing.Point(142, 33);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(366, 22);
            this.cbxEspecie.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(94, 427);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // ucIncluirViloes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbxEspecie);
            this.Controls.Add(this.tbDefesa);
            this.Controls.Add(this.tbAtaque);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblDefesa);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEspecie);
            this.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.Name = "ucIncluirViloes";
            this.Size = new System.Drawing.Size(588, 500);
            this.Load += new System.EventHandler(this.ucIncluirViloes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label lblDefesa;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbAtaque;
        private System.Windows.Forms.TextBox tbDefesa;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
    }
}
