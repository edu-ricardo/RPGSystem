namespace RPGSystem.Formularios {
    partial class ucMiniCapitulo {
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
            this.gpxCap = new System.Windows.Forms.GroupBox();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.gpxCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxCap
            // 
            this.gpxCap.Controls.Add(this.tbTexto);
            this.gpxCap.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpxCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpxCap.Location = new System.Drawing.Point(0, 0);
            this.gpxCap.Name = "gpxCap";
            this.gpxCap.Size = new System.Drawing.Size(250, 216);
            this.gpxCap.TabIndex = 0;
            this.gpxCap.TabStop = false;
            this.gpxCap.Text = "Capitulo_Titulo";
            // 
            // tbTexto
            // 
            this.tbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTexto.Location = new System.Drawing.Point(3, 18);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.ReadOnly = true;
            this.tbTexto.Size = new System.Drawing.Size(244, 195);
            this.tbTexto.TabIndex = 0;
            // 
            // ucMiniCapitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpxCap);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucMiniCapitulo";
            this.Size = new System.Drawing.Size(250, 216);
            this.gpxCap.ResumeLayout(false);
            this.gpxCap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxCap;
        private System.Windows.Forms.TextBox tbTexto;
    }
}
