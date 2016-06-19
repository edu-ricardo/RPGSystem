using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.Entidades;
using System.Data.SqlClient;

namespace RPGSystem.DAO {
    class EspecieDAO : IDAO {
        DBAcces db = new DBAcces();

        public void Alterar(IEntidades obj, int id) {
            if (!(obj is Especie))
                throw new InvalidCastException("Objeto não é um atributo");

            Especie attr = (obj as Especie);

            string sql = "UPDATE Especie set nome = @nome, descricao = @descricao " +
                         "WHERE idEspecie = @id";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            ParamsName.Add("@nome");
            ParamsName.Add("@descricao");
            Params.Add(id);
            Params.Add(attr.nome);
            Params.Add(attr.descricao);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Criar(IEntidades obj) {
            if (!(obj is Especie))
                throw new InvalidCastException("Objeto não é um atributo");

            Especie attr = (obj as Especie);

            string sql = "INSERT INTO Especie (nome ,descricao) " +
                         "VALUES(@nome, @descricao)";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();

            ParamsName.Add("@nome");
            ParamsName.Add("@descricao");

            Params.Add(attr.nome);
            Params.Add(attr.descricao);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Excluir(int id) {
            string sql = "DELETE FROM Especie WHERE idEspecie = @id";
            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            Params.Add(id);
            db.ExecQuery(sql, ParamsName, Params);
        }

        public List<IEntidades> Listar() {
            string sql = "SELECT * FROM Especie";
            SqlDataReader Reader = db.Query(sql);

            List<IEntidades> EspecieLst = new List<IEntidades>();

            while (Reader.Read()) {
                EspecieLst.Add(new Especie(Convert.ToString(Reader["nome"]), Convert.ToString(Reader["descricao"])));
            }

            return EspecieLst;
        }

        public List<Especie> ListarEspecie() {
            string sql = "SELECT * FROM Especie";
            SqlDataReader Reader = db.Query(sql);

            List<Especie> EspecieLst = new List<Especie>();

            while (Reader.Read()) {
                Especie aux = new Especie(Convert.ToString(Reader["nome"]), Convert.ToString(Reader["descricao"]));
                aux.idEspecie = Convert.ToInt32(Reader["idEspecie"]);
                EspecieLst.Add(aux);
            }

            return EspecieLst;
        }

    }
}
