using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.Entidades;

namespace RPGSystem.DAO {
    class CapituloDAO : IDAO {
        public void Alterar(IEntidades obj, int id) {
            if (!(obj is Capitulo))
                throw new InvalidCastException("Objeto não é um atributo");

            Atributos attr = (obj as Atributos);

            string sql = "UPDATE Atributo set tipo = @tipo, nome = @nome, descricao = @descricao " +
                         "WHERE idAtributo = @id";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            ParamsName.Add("@tipo");
            ParamsName.Add("@nome");
            ParamsName.Add("@descricao");
            Params.Add(id);
            Params.Add(attr.Tipo);
            Params.Add(attr.Nome);
            Params.Add(attr.Descricao);

            db.ExecQuery(sql, ParamsName, Params);
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
