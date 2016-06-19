using RPGSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Entidades
{
    class Especie :IEntidades
    {
        public int idEspecie { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public Especie() {
            idEspecie = int.MaxValue;
        }

        public Especie(string ANome, string ADescricao) {
            idEspecie = int.MaxValue;
            nome = ANome;
            descricao = ADescricao;
        }

        public void Excluir() {
            EspecieDAO dao = new EspecieDAO();
            if (idEspecie != int.MaxValue) {
                dao.Excluir(this.idEspecie);
            }
            else if (dao.ListarEspecie().Exists(x => x.nome == this.nome)) {
                dao.Excluir(dao.ListarEspecie().Find(x => x.nome == this.nome).idEspecie);
            }
            else {
                throw new ArgumentNullException("Atributo ainda não foi incluido e não pode ser excluido!");
            }
        }

        public void Salvar() {
            EspecieDAO dao = new EspecieDAO();

            if (this.idEspecie != int.MaxValue && dao.ListarEspecie().Exists(x => x.idEspecie == this.idEspecie)) {
                dao.Alterar(this, this.idEspecie); // na tela, colocar confirmação
            }
            else {
                dao.Criar(this);
            }
        }

        public static List<Especie> ListarTodas()
        {
            return (new EspecieDAO()).ListarEspecie();
        }
    }
}
