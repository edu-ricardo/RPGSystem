using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.Entidades;
using System.Data.SqlClient;

namespace RPGSystem.DAO
{
    class ViloesDAO: IDAO {
        DBAcces db = new DBAcces();

        public void Alterar(IEntidades obj, int id) {
            if (!(obj is Viloes))
                throw new InvalidCastException("Objeto não é um vilão");

            Viloes evil = (obj as Viloes);

            string sql = "UPDATE Vilao set especie = @especie, nome = @nome, descricao = @descricao, ataque = @ataque, defesa = @defesa  " +
                         "WHERE idVilao = @id";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            ParamsName.Add("@especie");
            ParamsName.Add("@nome");
            ParamsName.Add("@descricao");
            ParamsName.Add("@ataque");
            ParamsName.Add("@defesa");
            Params.Add(id);
            Params.Add(evil.Especie);
            Params.Add(evil.Nome);
            Params.Add(evil.Descricao);
            Params.Add(evil.Ataque);
            Params.Add(evil.Defesa);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Criar(IEntidades obj) {
            if (!(obj is Viloes))
                throw new InvalidCastException("Objeto não é um vilão");

            Viloes evil = (obj as Viloes);

            string sql = "INSERT INTO Vilao (especie ,nome ,descricao, ataque, defesa) " +
                         "VALUES(@especie, @nome, @descricao, @ataque, @defesa)";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@especie");
            ParamsName.Add("@nome");
            ParamsName.Add("@descricao");
            ParamsName.Add("@ataque");
            ParamsName.Add("@defesa");
            Params.Add(evil.Especie);
            Params.Add(evil.Nome);
            Params.Add(evil.Descricao);
            Params.Add(evil.Ataque);
            Params.Add(evil.Defesa);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Excluir(int id) {
            string sql = "DELETE FROM Vilao WHERE idVilao = @id";
            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            Params.Add(id);
            db.ExecQuery(sql, ParamsName, Params);
        }

        public List<IEntidades> Listar() {
            string sql = "SELECT * FROM Vilao";
            SqlDataReader Reader = db.Query(sql);

            List<IEntidades> evilLst = new List<IEntidades>();

            while (Reader.Read()) {
                evilLst.Add(new Viloes(Convert.ToString(Reader["especie"]), Convert.ToString(Reader["nome"]), Convert.ToString(Reader["descricao"]), Convert.ToInt32(Reader["ataque"]), Convert.ToInt32(Reader["defesa"])));
            }

            return evilLst;
        }

        public List<Viloes> ListarViloes() {
            string sql = "SELECT * FROM Vilao";
            SqlDataReader Reader = db.Query(sql);

            List<Viloes> EvilLst = new List<Viloes>();

            while (Reader.Read()) {
                Viloes EvilAux = new Viloes(Convert.ToString(Reader["especie"]), Convert.ToString(Reader["nome"]), Convert.ToString(Reader["descricao"]), Convert.ToInt32(Reader["ataque"]), Convert.ToInt32(Reader["defesa"]));
                EvilAux.IdVilao = Convert.ToInt32(Reader["idVilao"]);
                EvilLst.Add(EvilAux);
            }

            return EvilLst;
        }

    }
}
