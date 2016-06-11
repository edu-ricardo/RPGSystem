using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.Entidades;
using System.Data.SqlClient;

namespace RPGSystem.DAO {
    class AtributoDAO : IDAO {
        DBAcces db = new DBAcces();

        public void Alterar(IEntidades obj, int id) {
            if (!(obj is Atributos))
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
            if (!(obj is Atributos))
                throw new InvalidCastException("Objeto não é um atributo");

            Atributos attr = (obj as Atributos);

            string sql = "INSERT INTO Atributo (tipo ,nome ,descricao) " +
                         "VALUES(@tipo, @nome, @descricao)";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@tipo");
            ParamsName.Add("@nome");
            ParamsName.Add("@descricao");
            Params.Add(attr.Tipo);
            Params.Add(attr.Nome);
            Params.Add(attr.Descricao);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Excluir(int id) {
            string sql = "DELETE FROM Atributo WHERE idAtributo = @id";
            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            Params.Add(id);
            db.ExecQuery(sql, ParamsName, Params);
        }

        public List<IEntidades> Listar() {
            string sql = "SELECT * FROM Atributo";
            SqlDataReader Reader = db.Query(sql);

            List<IEntidades> AttrLst = new List<IEntidades>();

            while (Reader.Read()) {
                AttrLst.Add(new Atributos(Convert.ToChar(Reader["tipo"]), Convert.ToString(Reader["nome"]),Convert.ToString(Reader["descricao"])));
            }

            return AttrLst;
        }

        public List<Atributos> ListarAtributos() {
            string sql = "SELECT * FROM Atributo";
            SqlDataReader Reader = db.Query(sql);

            List<Atributos> AttrLst = new List<Atributos>();

            while (Reader.Read()) {
                Atributos AttrAux = new Atributos(Convert.ToChar(Reader["tipo"]), Convert.ToString(Reader["nome"]), Convert.ToString(Reader["descricao"]));
                AttrAux.IdAtributo = Convert.ToInt32(Reader["idAtributo"]);
                AttrLst.Add(AttrAux);
            }

            return AttrLst;
        }

    }
}
