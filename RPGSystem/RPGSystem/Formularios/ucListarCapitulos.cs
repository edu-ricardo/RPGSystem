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
    public partial class ucListarCapitulos : UserControl {
        int idAlteracao;

        private void reloadGrid() {
            BindingSource bs = new BindingSource();
            bs.DataSource = Capitulo.ListarTodos();
            dgvLista.DataSource = bs;
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[3].Visible = false;
        }

        public ucListarCapitulos() {
            InitializeComponent();
            reloadGrid();

            scListarCapitulos.Panel2Collapsed = true;

            cbxItens.DataSource = Item.ListarTodos();

            cbxItens.DisplayMember = "Nome";
            cbxItens.ValueMember = "idItem";

            cbxViloes.DataSource = Viloes.ListarTodos();

            cbxViloes.DisplayMember = "Nome";
            cbxViloes.ValueMember = "idVilao";

            lbViloes.DisplayMember = "Nome";
            lbItens.DisplayMember = "Nome";
        }

        private void ReloadForm() {
            tbTexto.Clear();
            tbTitulo.Clear();
            chkStartChapter.Checked = false;
            lbViloes.Items.Clear();
            lbItens.Items.Clear();
            cbxItens.SelectedIndex = 0;
            cbxViloes.SelectedIndex = 0;
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e) {            
            if (dgvLista.SelectedRows.Count > 0) {
                ReloadForm();

                Capitulo aux = Capitulo.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index);

                tbTexto.Text = aux.Texto;
                tbTitulo.Text = aux.Titulo;
                chkStartChapter.Checked = aux.startChapter;
                idAlteracao = aux.idCapitulo;
                for (int i = 0; i < aux.Items.Count; i++) {
                    lbItens.Items.Add(aux.Items[i]);
                }

                for (int i = 0; i < aux.Viloes.Count; i++) {
                    lbViloes.Items.Add(aux.Viloes[i]);
                }

                scListarCapitulos.Panel2Collapsed = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e) {
            reloadGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvLista.SelectedRows.Count > 0) {
                Capitulo.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index).Excluir();
                reloadGrid();
            }
        }

        private void btnAddVil_Click(object sender, EventArgs e) {
            if (cbxViloes.SelectedIndex != -1) {
                Boolean found = false;
                for (int i = 0; i < lbViloes.Items.Count; i++) {
                    if ((lbViloes.Items[i] as Viloes).IdVilao == Convert.ToInt32(cbxViloes.SelectedValue)) {
                        found = true;
                        break;
                    }
                }

                if (found) {
                    MessageBox.Show("Vilão já está na lista!!");
                }
                else {
                    lbViloes.Items.Add(Viloes.ListarTodos().Find(x => x.IdVilao == Convert.ToInt32(cbxViloes.SelectedValue)));
                }
            }
        }

        private void btnDelVil_Click(object sender, EventArgs e) {
            if (lbViloes.SelectedIndex != -1) {
                lbViloes.Items.RemoveAt(lbViloes.SelectedIndex);
            }
            else {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            if (cbxItens.SelectedIndex != -1) {
                Boolean found = false;
                for (int i = 0; i < lbItens.Items.Count; i++) {
                    if ((lbItens.Items[i] as Item).IdItem == Convert.ToInt32(cbxItens.SelectedValue)) {
                        found = true;
                        break;
                    }
                }

                if (found) {
                    MessageBox.Show("Item já está na lista!!");
                }
                else {
                    lbItens.Items.Add(Item.ListarTodos().Find(x => x.IdItem == Convert.ToInt32(cbxItens.SelectedValue)));
                }
            }
        }

        private void btnDelItem_Click(object sender, EventArgs e) {
            if (lbItens.SelectedIndex != -1) {
                lbItens.Items.RemoveAt(lbItens.SelectedIndex);
            }
            else {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            ReloadForm();
            scListarCapitulos.Panel2Collapsed = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Capitulo cap = new Capitulo();

            cap.Titulo = tbTitulo.Text;
            cap.Texto = tbTexto.Text;
            cap.idCapitulo = idAlteracao;
            cap.startChapter = chkStartChapter.Checked;
            for (int i = 0; i < lbItens.Items.Count; i++) {
                cap.Items.Add((lbItens.Items[i] as Item));
            }

            for (int i = 0; i < lbViloes.Items.Count; i++) {
                cap.Viloes.Add((lbViloes.Items[i] as Viloes));
            }

            try {
                cap.Salvar();
                MessageBox.Show("Salvo com Sucesso!!");
                ReloadForm();
                btnCancelar.PerformClick();                
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro na inclusão: " + ex.Message);
            }
        }
    }
}
