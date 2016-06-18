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
        public ucIncluirViloes() {
            InitializeComponent();

            List<Especie> DataCbx = new List<Especie>();
            DataCbx.Add(new Especie('I', "Integer"));
            DataCbx.Add(new Especie('S', "String"));

            cbxEspecie.DataSource = DataCbx;
            cbxEspecie.DisplayMember = "Desc";
            cbxEspecie.ValueMember = "Id";
            cbxEspecie.SelectedIndex = 0;
        }

        public class Especie {
            public char Id { get; set; }
            public string Desc { get; set; }

            public Especie(char Aid, string Adesc) {
                this.Id = Aid;
                this.Desc = Adesc;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if (Parent is TabPage) {
                ((Parent as TabPage).Parent as TabControl).TabPages.Remove(((Parent as TabPage).Parent as TabControl).SelectedTab);
            }
        }

        private void ReloadForm() {
            cbxEspecie.SelectedIndex = 0;
            tbDescricao.Clear();
            tbNome.Clear();
            tbAtaque.Clear();
            tbDefesa.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e) {
            Viloes evil = new Viloes();

            evil.Especie = Convert.ToString(cbxEspecie.SelectedValue);
            evil.Nome = tbNome.Text;
            evil.Descricao = tbDescricao.Text;
            try {
                evil.Salvar();
                if (MessageBox.Show("Incluido com Sucesso!! \r Deseja incluir um novo?", "Sucesso", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ReloadForm();
                }
                else {
                    btnCancelar.PerformClick();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro na inclusão: "+ex.Message);
                //throw;
            }
        }

        private void ucIncluirViloes_Load(object sender, EventArgs e)
        {

        }
    }
}
