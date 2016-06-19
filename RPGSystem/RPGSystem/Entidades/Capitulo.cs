using RPGSystem.DAO;
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
        public int idHistoria { get; set; }
        public Boolean startChapter { get; set; }
        public List<Item> Items { get; set; }
        public List<Viloes> Viloes { get; set; }

        public Capitulo() {
            Items = new List<Item>();
            Viloes = new List<Viloes>();
            idHistoria = int.MaxValue;
            idCapitulo = int.MaxValue;
        }

        public static List<Capitulo> ListarTodos() {
            return (new CapituloDAO()).ListarTodos();
        }

        public static List<Capitulo> ListarComFiltro(Func<Capitulo, bool> pred) {
            return (new CapituloDAO()).ListarTodos().Where(pred).ToList();
        }

        public void Excluir() {
            CapituloDAO dao = new CapituloDAO();
            if (idCapitulo != int.MaxValue) {
                dao.Excluir(this.idCapitulo);
            }
            else if (dao.ListarTodos().Exists(x => x.idCapitulo == this.idCapitulo)) {
                dao.Excluir(dao.ListarTodos().Find(x => x.idCapitulo == this.idCapitulo).idCapitulo);
            }
            else {
                throw new ArgumentNullException("Atributo ainda não foi incluido e não pode ser excluido!");
            }
        }

        public void Salvar() {
            CapituloDAO dao = new CapituloDAO();

            if (this.idCapitulo != int.MaxValue && dao.ListarTodos().Exists(x => x.idCapitulo == this.idCapitulo)) {
                dao.Alterar(this, this.idCapitulo); // na tela, colocar confirmação
            }
            else {
                dao.Criar(this);
            }
        }

    }
}
