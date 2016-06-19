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

            tcMestre.SelectedIndex = tcMestre.TabCount - 1;
        }

        private void tcMestre_DoubleClick(object sender, EventArgs e) {
            tcMestre.TabPages.Remove(tcMestre.SelectedTab);
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e) {
            TabPage tpListAttributo = new TabPage("Listar/Alterar Atributo");
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
            tcMestre.SelectedIndex = tcMestre.TabCount - 1;
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e) {
            TabPage tpIncluirItem = new TabPage("Incluir Item");
            ucIncluirItem TelaIncItem = new ucIncluirItem();
            TelaIncItem.Parent = this;
            TelaIncItem.Dock = DockStyle.Fill;
            tpIncluirItem.Controls.Add(TelaIncItem);
            if (this.WindowState == FormWindowState.Normal) {
                tpIncluirItem.AutoScroll = true;
                tpIncluirItem.AutoScrollMargin = new System.Drawing.Size(20, 20);
                tpIncluirItem.AutoScrollMinSize = new System.Drawing.Size(this.Width, this.Height);
            }
            tcMestre.TabPages.Add(tpIncluirItem);
            tcMestre.SelectedIndex = tcMestre.TabCount - 1;
        }

        private void incluirToolStripMenuItem2_Click(object sender, EventArgs e) {
            TabPage tpIncluirViloes = new TabPage("Incluir Vilões");
            ucIncluirViloes TelaIncViloes = new ucIncluirViloes();
            TelaIncViloes.Parent = this;
            TelaIncViloes.Dock = DockStyle.Fill;
            tpIncluirViloes.Controls.Add(TelaIncViloes);
            if (this.WindowState == FormWindowState.Normal) {
                tpIncluirViloes.AutoScroll = true;
                tpIncluirViloes.AutoScrollMargin = new System.Drawing.Size(20, 20);
                tpIncluirViloes.AutoScrollMinSize = new System.Drawing.Size(this.Width, this.Height);
            }
            tcMestre.TabPages.Add(tpIncluirViloes);
            tcMestre.SelectedIndex = tcMestre.TabCount - 1;
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e) {
            TabPage tpAlterarViloes = new TabPage("Listar/Alterar Vilões");
            ucListarViloes TelaListViloes = new ucListarViloes();
            TelaListViloes.Parent = this;
            TelaListViloes.Dock = DockStyle.Fill;
            tpAlterarViloes.Controls.Add(TelaListViloes);
            if (this.WindowState == FormWindowState.Normal) {
                tpAlterarViloes.AutoScroll = true;
                tpAlterarViloes.AutoScrollMargin = new System.Drawing.Size(20, 20);
                tpAlterarViloes.AutoScrollMinSize = new System.Drawing.Size(this.Width, this.Height);
            }
            tcMestre.TabPages.Add(tpAlterarViloes);
            tcMestre.SelectedIndex = tcMestre.TabCount - 1;
        }

        private void incluirToolStripMenuItem4_Click(object sender, EventArgs e) {
            TabPage tpIncluirEspecies = new TabPage("Incluir Especies");
            ucIncluirEspecies TelaIncEsp = new ucIncluirEspecies();
            TelaIncEsp.Parent = this;
            TelaIncEsp.Dock = DockStyle.Fill;
            tpIncluirEspecies.Controls.Add(TelaIncEsp);
            if (this.WindowState == FormWindowState.Normal) {
                tpIncluirEspecies.AutoScroll = true;
                tpIncluirEspecies.AutoScrollMargin = new System.Drawing.Size(20, 20);
                tpIncluirEspecies.AutoScrollMinSize = new System.Drawing.Size(this.Width, this.Height);
            }
            tcMestre.TabPages.Add(tpIncluirEspecies);
            tcMestre.SelectedIndex = tcMestre.TabCount - 1;
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e) {
            TabPage tpListarEspecies = new TabPage("Listar/Alterar Especies");
            ucListarEspecies TelaListEsp = new ucListarEspecies();
            TelaListEsp.Parent = this;
            TelaListEsp.Dock = DockStyle.Fill;
            tpListarEspecies.Controls.Add(TelaListEsp);
            if (this.WindowState == FormWindowState.Normal) {
                tpListarEspecies.AutoScroll = true;
                tpListarEspecies.AutoScrollMargin = new System.Drawing.Size(20, 20);
                tpListarEspecies.AutoScrollMinSize = new System.Drawing.Size(this.Width, this.Height);
            }
            tcMestre.TabPages.Add(tpListarEspecies);
            tcMestre.SelectedIndex = tcMestre.TabCount - 1;
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e) {
            TabPage tpListarItens = new TabPage("Listar/Alterar Itens");
            ucListarItem TelaListItem = new ucListarItem();
            TelaListItem.Parent = this;
            TelaListItem.Dock = DockStyle.Fill;
            tpListarItens.Controls.Add(TelaListItem);
            if (this.WindowState == FormWindowState.Normal) {
                tpListarItens.AutoScroll = true;
                tpListarItens.AutoScrollMargin = new System.Drawing.Size(20, 20);
                tpListarItens.AutoScrollMinSize = new System.Drawing.Size(this.Width, this.Height);
            }
            tcMestre.TabPages.Add(tpListarItens);
            tcMestre.SelectedIndex = tcMestre.TabCount - 1;
        }
    }
}
