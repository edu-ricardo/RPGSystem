namespace RPGSystem.Formularios {
    partial class ucHistoria {
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Capitulos", System.Windows.Forms.HorizontalAlignment.Left);
            this.scHistoria = new System.Windows.Forms.SplitContainer();
            this.lvCapitulos = new System.Windows.Forms.ListView();
            this.Capitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Texto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.scHistoria)).BeginInit();
            this.scHistoria.Panel1.SuspendLayout();
            this.scHistoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // scHistoria
            // 
            this.scHistoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHistoria.Location = new System.Drawing.Point(0, 0);
            this.scHistoria.Name = "scHistoria";
            // 
            // scHistoria.Panel1
            // 
            this.scHistoria.Panel1.Controls.Add(this.lvCapitulos);
            this.scHistoria.Size = new System.Drawing.Size(1002, 584);
            this.scHistoria.SplitterDistance = 334;
            this.scHistoria.SplitterWidth = 5;
            this.scHistoria.TabIndex = 0;
            // 
            // lvCapitulos
            // 
            this.lvCapitulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Capitulo,
            this.Texto});
            this.lvCapitulos.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup1.Header = "Capitulos";
            listViewGroup1.Name = "listViewGroup1";
            this.lvCapitulos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvCapitulos.Location = new System.Drawing.Point(0, 0);
            this.lvCapitulos.MultiSelect = false;
            this.lvCapitulos.Name = "lvCapitulos";
            this.lvCapitulos.Size = new System.Drawing.Size(334, 309);
            this.lvCapitulos.TabIndex = 0;
            this.lvCapitulos.UseCompatibleStateImageBehavior = false;
            this.lvCapitulos.View = System.Windows.Forms.View.Tile;
            this.lvCapitulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvCapitulos_KeyDown);
            // 
            // ucHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scHistoria);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucHistoria";
            this.Size = new System.Drawing.Size(1002, 584);
            this.Load += new System.EventHandler(this.ucHistoria_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucHistoria_KeyPress);
            this.scHistoria.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scHistoria)).EndInit();
            this.scHistoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scHistoria;
        private System.Windows.Forms.ListView lvCapitulos;
        private System.Windows.Forms.ColumnHeader Capitulo;
        private System.Windows.Forms.ColumnHeader Texto;
    }
}
