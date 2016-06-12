using RPGSystem.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RPGSystem.Formularios {
    public partial class frmMestre : Form, ITela {
        Usuario user;

        public frmMestre() {
            InitializeComponent();
        }

        public frmMestre(Usuario AUser) {
            InitializeComponent();
            SetUser(AUser);
            if (!HasAccess()) {
                throw new AccessNotDefined("Acesso Negado a Tela de Mestre!");
            }
        }

        public bool HasAccess() {
            if (user.Nivel != 'M') {
                return false;
            }
            else {
                return true;
            }
        }

        public void SetUser(Usuario user) {
            this.user = user;
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e) {
            TabPage tpIncluirAttributo = new TabPage("Incluir Atributo");
            ucIncluirAtributo TelaIncAttr = new ucIncluirAtributo();
            TelaIncAttr.Parent = this;
            TelaIncAttr.Dock = DockStyle.Fill;
            tpIncluirAttributo.Controls.Add(TelaIncAttr);
            if (this.WindowState == FormWindowState.Normal) {
                tpIncluirAttributo.AutoScroll = true;
                tpIncluirAttributo.AutoScrollMargin = new System.Drawing.Size(20, 20);
                tpIncluirAttributo.AutoScrollMinSize = new System.Drawing.Size(this.Width, this.Height);
            }            
            tcMestre.TabPages.Add(tpIncluirAttributo);
        }

        private void tcMestre_DoubleClick(object sender, EventArgs e) {
            tcMestre.TabPages.Remove(tcMestre.SelectedTab);
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e) {
            TabPage tpListAttributo = new TabPage("Listar Atributo");
            ucListarAtributos TelaListAttr = new ucListarAtributos();
            TelaListAttr.Parent = this;
            TelaListAttr.Dock = DockStyle.Fill;
            tpListAttributo.Controls.Add(TelaListAttr);
            if (this.WindowState == FormWindowState.Normal) {
                tpListAttributo.AutoScroll = true;
                tpListAttributo.AutoScrollMargin = new System.Drawing.Size(20, 20);
                tpListAttributo.AutoScrollMinSize = new System.Drawing.Size(this.Width, this.Height);
            }
            tcMestre.TabPages.Add(tpListAttributo);
        }
    }
}
