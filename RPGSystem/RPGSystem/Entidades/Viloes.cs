using RPGSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Entidades{
    class Viloes : IEntidades    {
                
        public int IdVilao { get; set; }
        public string Especie { get; set; } // S: String | I: Integer
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }

        public Viloes() {
            this.IdVilao = int.MaxValue;
        }

        public Viloes(string AEspecie, string ANome, string ADescricao, int AAtaque, int ADefesa) {
            this.Especie = AEspecie;
            this.Nome = ANome;
            this.Descricao = ADescricao;
            this.IdVilao = int.MaxValue;
            this.Ataque = AAtaque;
            this.Defesa = ADefesa;

        }

        public void Excluir() {
            ViloesDAO dao = new ViloesDAO();
            if (IdVilao != int.MaxValue) {
                dao.Excluir(this.IdVilao);
            }
            else if (dao.ListarViloes().Exists(x => x.Nome == this.Nome)) {
                dao.Excluir(dao.ListarViloes().Find(x => x.Nome == this.Nome).IdVilao);
            }
            else {
                throw new ArgumentNullException("Vilão ainda não foi incluido e não pode ser excluido!");
            }
        }

        public void Salvar() {
            ViloesDAO dao = new ViloesDAO();

            if (this.IdVilao != int.MaxValue && dao.ListarViloes().Exists(x => x.IdVilao == this.IdVilao)) {
                dao.Alterar(this, this.IdVilao);
            }
            else {
                dao.Criar(this);
            }            
        }

        public static List<Viloes> ListarTodos() {
            ViloesDAO dao = new ViloesDAO();
            return dao.ListarViloes();
        }
    }
}

