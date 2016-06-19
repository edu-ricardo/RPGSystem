using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.DAO;

namespace RPGSystem.Entidades {
    class Item : IEntidades {
        public int IdItem { get; set; }

        public int idEspecie { get; set; }

        public string Especie { get; set; }

        public string Nome { get; set; }

        public int Range { get; set; }

        public int Atack { get; set; }

        public Item() {
            this.IdItem = int.MaxValue;
        }

        public Item(String Nome, int Range, int Atack, int AIdEspecie) {
            this.IdItem = int.MaxValue;
            this.Nome = Nome;
            this.Range = Range;
            this.Atack = Atack;
            this.idEspecie = AIdEspecie;
        }

        public void Excluir() {
            ItemDAO dao = new ItemDAO();

            if (IdItem != int.MaxValue) {
                dao.Excluir(this.IdItem);
            }
            else if (dao.ListarItem().Exists(x => x.Nome == this.Nome)) {
                dao.Excluir(dao.ListarItem().Find(x => x.Nome == this.Nome).IdItem);
            }
            else {
                throw new ArgumentNullException("Item ainda não foi incluido e não pode ser excluido!");
            }
        }

        public void Salvar() {
            ItemDAO dao = new ItemDAO();

            if (this.IdItem != int.MaxValue && dao.ListarItem().Exists(x => x.IdItem == this.IdItem)) { 
                dao.Alterar(this, this.IdItem); // na tela, colocar confirmação
            }
            else {
                dao.Criar(this);
            }
        }

        public static List<Item> ListarTodos() {
            ItemDAO dao = new ItemDAO();
            return dao.ListarItem();
        }

        public void DiscoverEspecie() {            
            this.Especie = Entidades.Especie.ListarTodas().Find(x => x.idEspecie == this.idEspecie).nome;
        }
    }
}