using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.Entidades;

namespace RPGSystem.DAO {
    class ItemDAO : IDAO {
        DBAcces db = new DBAcces();

        public void Alterar(IEntidades obj, int id) {
            if (!(obj is Atributos))
                throw new InvalidCastException("Objeto não é um atributo");

            Atributos attr = (obj as Atributos);


        }

        public void Criar(IEntidades obj) {
            throw new NotImplementedException();
        }

        public void Excluir(int id) {
            throw new NotImplementedException();
        }

        public List<IEntidades> Listar() {
            throw new NotImplementedException();
        }
    }
}
