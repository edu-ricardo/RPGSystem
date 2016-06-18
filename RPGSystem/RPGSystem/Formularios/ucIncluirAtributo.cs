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
    public partial class ucIncluirAtributo : UserControl
    {
        public ucIncluirAtributo()
        {
            InitializeComponent();

            List<Tipo> DataCbx = new List<Tipo>();
            DataCbx.Add(new Tipo('I', "Integer"));
            DataCbx.Add(new Tipo('S', "String"));

            cbxTipo.DataSource = DataCbx;
            cbxTipo.DisplayMember = "Desc";
            cbxTipo.ValueMember = "Id";
            cbxTipo.SelectedIndex = 0;
        }

        public class Tipo
        {
            public char Id { get; set; }
            public string Desc { get; set; }

            public Tipo(char Aid, string Adesc)
            {
                this.Id = Aid;
                this.Desc = Adesc;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Parent is TabPage)
            {
                ((Parent as TabPage).Parent as TabControl).TabPages.Remove(((Parent as TabPage).Parent as TabControl).SelectedTab);
            }
        }

        private void ReloadForm()
        {
            cbxTipo.SelectedIndex = 0;
            tbDescricao.Clear();
            tbNome.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Atributos attr = new Atributos();

            attr.Tipo = Convert.ToChar(cbxTipo.SelectedValue);
            attr.Nome = tbNome.Text;
            attr.Descricao = tbDescricao.Text;
            try
            {
                attr.Salvar();
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
    }
}
