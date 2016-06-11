using RPGSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Entidades {
    class Atributos : IEntidades {

        public int IdAtributo { get; set; }
        public char Tipo { get; set; } // S: String | I: Integer
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Atributos() {
            this.IdAtributo = int.MaxValue;
        }

        public Atributos(char ATipo, string ANome, string ADescricao) {
            this.Tipo = ATipo;
            this.Nome = ANome;
            this.Descricao = ADescricao;
            this.IdAtributo = int.MaxValue;
        }

        public void Excluir() {
            AtributoDAO dao = new AtributoDAO();
            if (IdAtributo != int.MaxValue) {
                dao.Excluir(this.IdAtributo);
            }
            else if (dao.ListarAtributos().Exists(x => x.Nome == this.Nome)) {
                dao.Excluir(dao.ListarAtributos().Find(x => x.Nome == this.Nome).IdAtributo);
            }
            else {
                throw new ArgumentNullException("Atributo ainda não foi incluido e não pode ser excluido!");
            }
        }

        public void Salvar() {
            AtributoDAO dao = new AtributoDAO();

            if (dao.ListarAtributos().Exists(x => x.Nome == this.Nome)) {
                dao.Alterar(this, this.IdAtributo);
            }
            else {
                dao.Criar(this);
            }            
        }

        public static List<Atributos> ListarTodos() {
            AtributoDAO dao = new AtributoDAO();
            return dao.ListarAtributos();
        }
    }
}
