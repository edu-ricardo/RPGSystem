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
    public partial class frmAdministrador : Form, ITela {
        public frmAdministrador() {
            InitializeComponent();
        }

        public frmAdministrador(Usuario AUser) {
            InitializeComponent();
        }

        public bool HasAccess() {
            throw new NotImplementedException();
        }

        public void SetUser(Usuario user) {
            throw new NotImplementedException();
        }
    }
}
