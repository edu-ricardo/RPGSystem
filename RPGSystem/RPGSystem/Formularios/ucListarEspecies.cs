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
    public partial class ucListarEspecies : UserControl {
        int idAlteracao;

        private void reloadGrid() {
            BindingSource bs = new BindingSource();
            bs.DataSource = Especie.ListarTodas();
            dgvLista.DataSource = bs;
            dgvLista.Columns[0].Visible = false;
        }

        public ucListarEspecies() {
            InitializeComponent();

            reloadGrid();
            scListarEspecies.Panel2Collapsed = true;
        }

        private void ReloadForm() {
            tbDescricao.Clear();
            tbNome.Clear();
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e) {
            if (dgvLista.SelectedRows.Count > 0) {
                Especie aux = Especie.ListarTodas().ElementAt(dgvLista.SelectedRows[0].Index);

                tbNome.Text = aux.nome;
                tbDescricao.Text = aux.descricao;
                idAlteracao = aux.idEspecie;
                scListarEspecies.Panel2Collapsed = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e) {
            reloadGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                Especie esp = new Especie();
                esp.idEspecie = idAlteracao;
                esp.nome = tbNome.Text;
                esp.descricao = tbDescricao.Text;

                esp.Salvar();
                MessageBox.Show("Salvo com Sucesso!!");
                btnCancelar.PerformClick();
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro ao Incluir a Espécie" + ex.Message);
            }
            reloadGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            ReloadForm();
            scListarEspecies.Panel2Collapsed = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvLista.SelectedRows.Count > 0) {
                Especie.ListarTodas().ElementAt(dgvLista.SelectedRows[0].Index).Excluir();
                reloadGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            dgvLista_DoubleClick(dgvLista, null);
        }
    }
}
