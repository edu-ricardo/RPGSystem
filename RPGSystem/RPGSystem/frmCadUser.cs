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

namespace RPGSystem {
    public partial class frmCadUser : Form {
        public frmCadUser() {
            InitializeComponent();
        }

        private void frmCadUser_Load(object sender, EventArgs e) {
            cbxNivel.SelectedItem = cbxNivel.Items[0];
        }

        private void ClearForm() {
            for (int i = 0; i < this.Controls.Count; i++) {
                if (this.Controls[i] is TextBox) {
                    (this.Controls[i] as TextBox).Clear();
                }
                if (this.Controls[i] is ComboBox) {
                    (this.Controls[i] as ComboBox).SelectedItem = (this.Controls[i] as ComboBox).Items[0];
                }
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            try {
                Usuario user = new Usuario(tbLogin.Text, tbSenha.Text, cbxNivel.Text[0], tbEmail.Text);
                user.Cadastrar();
            }
            catch (InvalidEmailException iex) {
                MessageBox.Show(iex.Message);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro inesperado ao cadastrar: "+ ex.Message);
            }

            ClearForm();
        }
    }
}
