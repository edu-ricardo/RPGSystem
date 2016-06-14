using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Item(int IdItem, String Tipo, String Nome, int Range, int Atack) {
            this.IdItem = IdItem;
            this.Nome = Nome;
            this.Range = Range;
            this.Atack = Atack;
        }



    }
}
