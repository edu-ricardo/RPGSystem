namespace RPGSystem.Formularios
{
    partial class ucJogarHistoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEscolha1 = new System.Windows.Forms.Button();
            this.btnEscolha2 = new System.Windows.Forms.Button();
            this.lblCapitulo = new System.Windows.Forms.Label();
            this.lblHistoria = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEscolha2);
            this.panel1.Controls.Add(this.btnEscolha1);
            this.panel1.Location = new System.Drawing.Point(3, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 130);
            this.panel1.TabIndex = 0;
            // 
            // btnEscolha1
            // 
            this.btnEscolha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEscolha1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolha1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEscolha1.Location = new System.Drawing.Point(3, 0);
            this.btnEscolha1.Name = "btnEscolha1";
            this.btnEscolha1.Size = new System.Drawing.Size(601, 65);
            this.btnEscolha1.TabIndex = 1;
            this.btnEscolha1.Text = "\n";
            this.btnEscolha1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEscolha1.UseVisualStyleBackColor = true;
            // 
            // btnEscolha2
            // 
            this.btnEscolha2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEscolha2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolha2.Location = new System.Drawing.Point(3, 65);
            this.btnEscolha2.Name = "btnEscolha2";
            this.btnEscolha2.Size = new System.Drawing.Size(601, 65);
            this.btnEscolha2.TabIndex = 1;
            this.btnEscolha2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEscolha2.UseVisualStyleBackColor = true;
            // 
            // lblCapitulo
            // 
            this.lblCapitulo.AutoSize = true;
            this.lblCapitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCapitulo.Name = "lblCapitulo";
            this.lblCapitulo.Size = new System.Drawing.Size(45, 13);
            this.lblCapitulo.TabIndex = 1;
            this.lblCapitulo.Text = "Capitulo";
            // 
            // lblHistoria
            // 
            this.lblHistoria.AutoSize = true;
            this.lblHistoria.Location = new System.Drawing.Point(0, 24);
            this.lblHistoria.Name = "lblHistoria";
            this.lblHistoria.Size = new System.Drawing.Size(42, 13);
            this.lblHistoria.TabIndex = 2;
            this.lblHistoria.Text = "Historia";
            // 
            // ucJogarHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHistoria);
            this.Controls.Add(this.lblCapitulo);
            this.Controls.Add(this.panel1);
            this.Name = "ucJogarHistoria";
            this.Size = new System.Drawing.Size(610, 399);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEscolha2;
        public System.Windows.Forms.Button btnEscolha1;
        private System.Windows.Forms.Label lblCapitulo;
        private System.Windows.Forms.Label lblHistoria;
    }
}
