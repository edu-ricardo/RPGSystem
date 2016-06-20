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
    public partial class ucMiniCapitulo : UserControl {
        Capitulo Cap;

        public ucMiniCapitulo() {
            InitializeComponent();
        }

        public ucMiniCapitulo(Capitulo ACapitulo) {
            InitializeComponent();
            Cap = ACapitulo;

            gpxCap.Text = Cap.Titulo;
            tbTexto.Text = Cap.Texto;
        }

    }
}
