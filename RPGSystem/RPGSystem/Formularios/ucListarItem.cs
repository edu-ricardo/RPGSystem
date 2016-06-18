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
    public partial class ucListarItem : UserControl {

        private void reloadGrid() {
            BindingSource bs = new BindingSource();
            bs.DataSource = Item.ListarTodos();
            dgvLista.DataSource = bs;
            dgvLista.Columns[0].Visible = false;
        }

        public ucListarItem() {
            InitializeComponent();
            reloadGrid();

            List<Tipo> DataCbx = new List<Tipo>();

        }

        private void btnReload_Click(object sender, EventArgs e) {

        }
    }
}


