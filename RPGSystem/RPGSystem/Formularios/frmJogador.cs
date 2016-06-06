using RPGSystem.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGSystem.Formularios {
    public partial class frmJogador : Form, ITela {
        Usuario user;

        public frmJogador() {

            InitializeComponent();
        }

        public frmJogador(Usuario AUser) {
            SetUser(AUser);

            InitializeComponent();
        }

        public bool HasAccess() {
            if (user != null && user.Nivel == 'J') {
                return true;
            }
            else {
                return false;
            }
        }

        public void SetUser(Usuario user) {
            this.user = user;
        }

        private void frmJogador_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
