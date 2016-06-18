namespace RPGSystem.Formularios
{
    partial class ucInculirItem
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.tckRange = new System.Windows.Forms.TrackBar();
            this.txtAtaque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tckRange)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(22, 95);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 16);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Range";
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.Location = new System.Drawing.Point(29, 263);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(48, 16);
            this.lblAtaque.TabIndex = 3;
            this.lblAtaque.Text = "Ataque";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 23);
            this.txtNome.TabIndex = 6;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(84, 95);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(140, 24);
            this.cbxTipo.TabIndex = 7;
            // 
            // tckRange
            // 
            this.tckRange.Location = new System.Drawing.Point(84, 175);
            this.tckRange.Name = "tckRange";
            this.tckRange.Size = new System.Drawing.Size(121, 45);
            this.tckRange.TabIndex = 8;
            // 
            // txtAtaque
            // 
            this.txtAtaque.Location = new System.Drawing.Point(84, 256);
            this.txtAtaque.Name = "txtAtaque";
            this.txtAtaque.Size = new System.Drawing.Size(116, 23);
            this.txtAtaque.TabIndex = 9;
            // 
            // ucInculirItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAtaque);
            this.Controls.Add(this.tckRange);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucInculirItem";
            this.Size = new System.Drawing.Size(576, 436);
            ((System.ComponentModel.ISupportInitialize)(this.tckRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.TrackBar tckRange;
        private System.Windows.Forms.TextBox txtAtaque;
    }
}
