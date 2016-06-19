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

namespace RPGSystem.Formularios
{
    public partial class ucIncluirItem : UserControl
    {
        public ucIncluirItem()
        {
            InitializeComponent();

            cbxTipo.DataSource = Especie.ListarTodas();
            cbxTipo.DisplayMember = "nome";
            cbxTipo.ValueMember = "idEspecie";
        }

        public void ReloadForm() {
            tbAtaque.Clear();
            tbNome.Clear();
            cbxTipo.SelectedIndex = 0;
            tckRange.Value = 0;
        }

        private void btnIncluir_Click(object sender, EventArgs e) {
            Item it = new Item();

            it.idEspecie = Convert.ToChar(cbxTipo.SelectedValue);
            it.Nome = tbNome.Text;
            it.Range = tckRange.Value;
            it.Atack = Convert.ToInt32(tbAtaque.Text);
            try {
                it.Salvar();
                if (MessageBox.Show("Incluido com Sucesso!! \r Deseja incluir um novo?", "Sucesso", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ReloadForm();
                }
                else {
                    btnCancelar.PerformClick();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro na inclusão: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if (Parent is TabPage) {
                ((Parent as TabPage).Parent as TabControl).TabPages.Remove(((Parent as TabPage).Parent as TabControl).SelectedTab);
            }
        }
    }
}
