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
    public partial class ucIncluirEspecies : UserControl {
        public ucIncluirEspecies() {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e) {
            try {
                Especie esp = new Especie();

                esp.nome = tbNome.Text;
                esp.descricao = tbDescricao.Text;

                esp.Salvar();

                if (MessageBox.Show("Incluido com Sucesso!! \r Deseja incluir um novo?", "Sucesso", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ReloadForm();
                }
                else {
                    btnCancelar.PerformClick();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro ao Incluir a Espécie" + ex.Message);
            }
           
        }

        private void ReloadForm() {
            tbDescricao.Clear();
            tbNome.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if (Parent is TabPage) {
                ((Parent as TabPage).Parent as TabControl).TabPages.Remove(((Parent as TabPage).Parent as TabControl).SelectedTab);
            }
        }
    }
}
