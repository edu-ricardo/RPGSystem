using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Entidades {
    class Capitulo : IEntidades {
        public int idCapitulo { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public Boolean startChapter { get; set; }
        public List<Item> Items { get; set; }
        public List<Viloes> Viloes { get; set; }



    }
}
