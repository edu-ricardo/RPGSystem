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


            List<Especie> DataCbx = Especie.ListarTodas();
            

            cbxEspecie.DataSource = DataCbx;
            cbxEspecie.DisplayMember = "nome";
            cbxEspecie.ValueMember = "idEspecie";
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
                    if (Convert.ToInt32(cbxEspecie.SelectedValue) == aux.idEspecie)
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

        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvLista_DoubleClick(dgvLista, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            reloadGrid();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                Viloes.ListarTodos().ElementAt(dgvLista.SelectedRows[0].Index).Excluir();
                reloadGrid();
            }

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Viloes evil = new Viloes();
            evil.IdVilao = idAlteracao;
            evil.idEspecie = Convert.ToInt32(cbxEspecie.SelectedValue);
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            ReloadForm();
            scListarViloes.Panel2Collapsed = true;
        }
    }
}
