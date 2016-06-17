using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.DAO;

namespace RPGSystem.Entidades
{
    class Item : IEntidades
    {
        public int IdItem { get; set; }

        public char Tipo { get; set; }

        public string Nome { get; set; }

        public int Range { get; set;  }

        public int Atack { get; set; }

        public Item(){
            this.IdItem = int.MaxValue;
        }

        public Item(String Tipo, String Nome, int Range, int Atack) {
            this.IdItem = int.MaxValue;
            this.Nome = Nome;
            this.Range = Range;
            this.Atack = Atack;
        }

        public void Excluir() {
            ItemDAO dao = new ItemDAO();

            if(IdItem != int.MaxValue) {
                dao.Excluir(this.IdItem);
            }else if()
        }

        public void Salvar() {

        }


    }
}
