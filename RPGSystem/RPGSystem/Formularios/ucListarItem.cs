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

        int idAlteracao;

        private void reloadGrid() {
            BindingSource bs = new BindingSource();
            bs.DataSource = Item.ListarTodos();
            dgvLista.DataSource = bs;
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[1].Visible = false;
        }

        public void ReloadForm() {
            tbAtaque.Clear();
            tbNome.Clear();
            cbxTipo.SelectedIndex = 0;
            tckRange.Value = 0;
        }

        public ucListarItem() {
            InitializeComponent();
            reloadGrid();

            scListarItens.Panel2Collapsed = true;

            cbxTipo.DataSource = Especie.ListarTodas();
            cbxTipo.DisplayMember = "nome";
            cbxTipo.ValueMember = "idEspecie";
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e) {
            if (dgvLista.SelectedRows.Count > 0) {
                Item aux = Item.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index);

                bool found = false;
                for (int i = 0; i < cbxTipo.Items.Count; i++) {
                    cbxTipo.SelectedIndex = i;
                    if (Convert.ToChar(cbxTipo.SelectedValue) == aux.idEspecie) {
                        found = true;
                        break;
                    }
                }

                if (!found) {
                    cbxTipo.SelectedIndex = -1;
                }

                tbNome.Text = aux.Nome;
                tbAtaque.Text = Convert.ToString(aux.Atack);
                tckRange.Value = aux.Range;
                idAlteracao = aux.IdItem;
                scListarItens.Panel2Collapsed = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e) {
            reloadGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            dgvLista_DoubleClick(dgvLista, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvLista.SelectedRows.Count > 0) {
                Item.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index).Excluir();
                reloadGrid();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e) {
            Item it = new Item();

            it.idEspecie = Convert.ToChar(cbxTipo.SelectedValue);
            it.Nome = tbNome.Text;
            it.Range = tckRange.Value;
            it.Atack = Convert.ToInt32(tbAtaque.Text);
            it.IdItem = idAlteracao;
            try {
                it.Salvar();
                MessageBox.Show("Alterado com Sucesso!!");
                ReloadForm();
                btnCancelar.PerformClick();                
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro na inclusão: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            ReloadForm();
            reloadGrid();
            scListarItens.Panel2Collapsed = true;
        }
    }
}


