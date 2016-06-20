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
    public partial class ucIncluirPersonagem : UserControl
    {
        public ucIncluirPersonagem()
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
            tbNome.Clear();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
           
            Personagem pers = new Personagem();

            pers.Especie = Convert.ToString(cbxEspecie.SelectedValue);
            pers.Nome = tbNome.Text;
            //pers.Genero = 
            


            try
            {
                pers.Salvar();
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
