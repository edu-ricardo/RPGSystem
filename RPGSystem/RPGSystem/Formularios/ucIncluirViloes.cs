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
    public partial class ucIncluirViloes : UserControl
    {
        public ucIncluirViloes()
        {
            InitializeComponent();

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


        private void ucIncluirViloes_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            Viloes evil = new Viloes();

            evil.idEspecie = Convert.ToInt32(cbxEspecie.SelectedValue);
            evil.Nome = tbNome.Text;
            evil.Descricao = tbDescricao.Text;
            evil.Ataque = Convert.ToInt32(tbAtaque.Text);
            evil.Defesa = Convert.ToInt32(tbDefesa.Text);

            try
            {
                evil.Salvar();
                if (MessageBox.Show("Incluido com Sucesso!! \r Deseja incluir um novo?", "Sucesso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ReloadForm();
                }
                else
                {
                    btnCancelar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na inclusão: " + ex.Message);
                //throw;
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (Parent is TabPage)
            {
                ((Parent as TabPage).Parent as TabControl).TabPages.Remove(((Parent as TabPage).Parent as TabControl).SelectedTab);
            }

        }
    }
}
