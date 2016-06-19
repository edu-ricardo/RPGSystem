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
    public partial class ucIncluirCapitulo : UserControl {
        public ucIncluirCapitulo() {
            InitializeComponent();

            cbxItens.DataSource = Item.ListarTodos();

            cbxItens.DisplayMember = "Nome";
            cbxItens.ValueMember = "idItem";
        }
    }
}
