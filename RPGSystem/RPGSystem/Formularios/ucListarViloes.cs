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
    public partial class ucListarViloes : UserControl
    {
        int idAlteracao;

        private void reloadGrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Atributos.ListarTodos();
            dgvLista.DataSource = bs;
            dgvLista.Columns[0].Visible = false;
        }

        public ucListarViloes()
        {
            InitializeComponent();
            reloadGrid();
            scListarViloes.Panel2Collapsed = true;


            List<Especie> DataCbx = new List<Especie>();
            DataCbx.Add(new Especie('I', "Integer"));
            DataCbx.Add(new Especie('S', "String"));

            cbxEspecie.DataSource = DataCbx;
            cbxEspecie.DisplayMember = "Desc";
            cbxEspecie.ValueMember = "Id";
            cbxEspecie.SelectedIndex = 0;
        }

        private void ReloadForm()
        {
            cbxEspecie.SelectedIndex = 0;
            tbDescricao.Clear();
            tbNome.Clear();
            tbAtaque.Clear();
            tbDefesa.Clear();
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                Viloes aux = Viloes.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index);

                bool found = false;
                for (int i = 0; i < cbxEspecie.Items.Count; i++)
                {
                    cbxEspecie.SelectedIndex = i;
                    if (Convert.ToString(cbxEspecie.SelectedValue) == aux.Especie)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    cbxEspecie.SelectedIndex = -1;
                }

                tbNome.Text = aux.Nome;
                tbDescricao.Text = aux.Descricao;
                idAlteracao = aux.IdVilao;
                scListarViloes.Panel2Collapsed = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reloadGrid();
        }

        public class Especie
        {
            public char Id { get; set; }
            public string Desc { get; set; }

            public Especie(char Aid, string Adesc)
            {
                this.Id = Aid;
                this.Desc = Adesc;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Viloes evil = new Viloes();
            evil.IdVilao = idAlteracao;
            evil.Especie = cbxEspecie.Text;
            evil.Nome = tbNome.Text;
            evil.Descricao = tbDescricao.Text;
            evil.Ataque = Convert.ToInt32(tbAtaque.Text);
            evil.Defesa = Convert.ToInt32(tbDefesa.Text);
            try
            {
                evil.Salvar();
                if (MessageBox.Show("Salvo com Sucesso!! \r Deseja incluir um novo?", "Sucesso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ReloadForm();
                }
                else
                {
                    ReloadForm();
                    btnCancelar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                //throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReloadForm();
            scListarViloes.Panel2Collapsed = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvLista_DoubleClick(dgvLista, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                Viloes.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index).Excluir();
                reloadGrid();
            }
        }
    }
}
