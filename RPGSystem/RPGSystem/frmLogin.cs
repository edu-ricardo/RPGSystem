using RPGSystem.Entidades;
using RPGSystem.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGSystem {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void llbCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmCadUser CadUser = new frmCadUser();
            CadUser.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Usuario user = new Usuario();
            user.Login = tbLogin.Text;
            user.Senha = tbSenha.Text;
            string MessageLogin;
            if (user.Logar(out MessageLogin)) {
                ITela TelaUser = FactoryTelas.GetScreen(user);
                this.Hide();
                (TelaUser as Form).ShowDialog(this);
                this.Close();
            }
            else {
                MessageBox.Show(MessageLogin);
            }
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }
    }
}
