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
    public partial class ucListarAtributos : UserControl {
        int idAlteracao;

        private void reloadGrid() {
            BindingSource bs = new BindingSource();
            bs.DataSource = Atributos.ListarTodos();            
            dgvLista.DataSource = bs;
            dgvLista.Columns[0].Visible = false;            
        }

        public ucListarAtributos() {
            InitializeComponent();
            reloadGrid();
            scListarAtributos.Panel2Collapsed = true;


            List<Tipo> DataCbx = new List<Tipo>();
            DataCbx.Add(new Tipo('I', "Integer"));
            DataCbx.Add(new Tipo('S', "String"));

            cbxTipo.DataSource = DataCbx;
            cbxTipo.DisplayMember = "Desc";
            cbxTipo.ValueMember = "Id";
            cbxTipo.SelectedIndex = 0;
        }

        private void ReloadForm() {
            cbxTipo.SelectedIndex = 0;
            tbDescricao.Clear();
            tbNome.Clear();
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e) {
            if (dgvLista.SelectedRows.Count > 0) {
                Atributos aux = Atributos.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index);

                bool found = false;
                for (int i = 0; i < cbxTipo.Items.Count; i++) {
                    cbxTipo.SelectedIndex = i;
                    if (Convert.ToChar(cbxTipo.SelectedValue) == aux.Tipo) {
                        found = true;
                        break;                        
                    }
                }

                if (!found) {
                    cbxTipo.SelectedIndex = -1;
                }

                tbNome.Text = aux.Nome;
                tbDescricao.Text = aux.Descricao;
                idAlteracao = aux.IdAtributo;
                scListarAtributos.Panel2Collapsed = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e) {
            reloadGrid();
        }

        public class Tipo {
            public char Id { get; set; }
            public string Desc { get; set; }

            public Tipo(char Aid, string Adesc) {
                this.Id = Aid;
                this.Desc = Adesc;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Atributos attr = new Atributos();
            attr.IdAtributo = idAlteracao;
            attr.Tipo = Convert.ToChar(cbxTipo.SelectedValue);
            attr.Nome = tbNome.Text;
            attr.Descricao = tbDescricao.Text;
            try {
                attr.Salvar();
                MessageBox.Show("Salvo com Sucesso!!");
                ReloadForm();
                btnCancelar.PerformClick();
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                //throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            ReloadForm();
            scListarAtributos.Panel2Collapsed = true;
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            dgvLista_DoubleClick(dgvLista, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvLista.SelectedRows.Count > 0) {
                Atributos.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index).Excluir();
                reloadGrid();
            }
        }
    }
}
