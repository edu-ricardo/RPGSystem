using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGSystem.Entidades;

namespace RPGSystem.Formularios {
    public partial class ucHistoria : UserControl {
        public ucHistoria() {
            InitializeComponent();
        }

        public void reloadGrid() {
            lvCapitulos.Items.Clear();

            List<Capitulo> ListaCapitulos = Entidades.Capitulo.ListarTodos();

            for (int i = 0; i < ListaCapitulos.Count; i++) {
                ListViewItem lv = new ListViewItem(ListaCapitulos[i].Titulo);
                lv.Tag = Convert.ToString(ListaCapitulos[i].idCapitulo);
                lv.SubItems.Add(ListaCapitulos[i].Texto);
                lvCapitulos.Items.Add(lv);
            }
        }

        private void ucHistoria_Load(object sender, EventArgs e) {
            reloadGrid();
        }

        private void ucHistoria_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void lvCapitulos_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F5) {
                reloadGrid();
            }
        }
    }
}
