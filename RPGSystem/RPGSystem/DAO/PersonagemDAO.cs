using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.Entidades;
using System.Data.SqlClient;

namespace RPGSystem.DAO
{
    class PersonagemDAO : IDAO
    {
        DBAcces db = new DBAcces();

        public void Alterar(IEntidades obj, int id)
        {
            if (!(obj is Personagem))
                throw new InvalidCastException("Objeto não é um Personagem");

            Personagem pers = (obj as Personagem);

            string sql = "UPDATE Personagem set especie = @Especie, nome = @Nome, genero = @Genero, ataque = @Ataque, defesa = @Defesa, nivel = @Nivel  " +
                         "WHERE IdPersonagem = @id";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            ParamsName.Add("@Especie");
            ParamsName.Add("@Nome");
            ParamsName.Add("@Genero");
            ParamsName.Add("@Ataque");
            ParamsName.Add("@Defesa");
            ParamsName.Add("@Nivel");
            Params.Add(id);
            Params.Add(pers.Especie);
            Params.Add(pers.Nome);
            Params.Add(pers.Genero);
            Params.Add(pers.Ataque);
            Params.Add(pers.Defesa);
            Params.Add(pers.Nivel);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Criar(IEntidades obj)
        {
            if (!(obj is Personagem))
                throw new InvalidCastException("Objeto não é um personagem");

            Personagem pers = (obj as Personagem);

            string sql = "INSERT INTO Personagem (especie ,nome ,genero, ataque, defesa, nivel) " +
                         "VALUES(@IdEspecie, @Nome, @Genero, @Ataque, @Defesa, @Nivel)";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@Especie");
            ParamsName.Add("@Nome");
            ParamsName.Add("@Genero");
            ParamsName.Add("@Ataque");
            ParamsName.Add("@Defesa");
            ParamsName.Add("@Nivel");
            Params.Add(pers.Especie);
            Params.Add(pers.Nome);
            Params.Add(pers.Genero);
            Params.Add(pers.Ataque);
            Params.Add(pers.Defesa);
            Params.Add(pers.Nivel);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM Personagem WHERE IdPersonagem = @id";
            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            Params.Add(id);
            db.ExecQuery(sql, ParamsName, Params);
        }

        public List<IEntidades> Listar()
        {
            string sql = "SELECT * FROM Personagem";
            SqlDataReader Reader = db.Query(sql);

            List<IEntidades> PersLst = new List<IEntidades>();

            while (Reader.Read())
            {
                PersLst.Add(new Personagem(Convert.ToInt32(Reader["IdPersonagem"]), Convert.ToString(Reader["Especie"]), Convert.ToString(Reader["Nome"]), Convert.ToBoolean(Reader["Genero"]), Convert.ToInt32(Reader["Ataque"]), Convert.ToInt32(Reader["Defesa"]), Convert.ToInt32(Reader["Nivel"]) ));
            }

            return PersLst;
        }

        public List<Personagem> ListarPersonagem()
        {
            string sql = "SELECT * FROM Personagem";
            SqlDataReader Reader = db.Query(sql);

            List<Personagem> PersLst = new List<Personagem>();

            while (Reader.Read())
            {
                Personagem PersAux = new Personagem(Convert.ToInt32(Reader["IdPersonagem"])   , Convert.ToString(Reader["Especie"])   , Convert.ToString(Reader["Nome"])   ,   Convert.ToBoolean(Reader["Genero"])   , Convert.ToInt32(Reader["Ataque"]), Convert.ToInt32(Reader["Defesa"]), Convert.ToInt32(Reader["Nivel"])));
                PersAux.IdPersonagem = Convert.ToInt32(Reader["IdPersonagem"]);
                PersAux.DiscoverEspecie();
                PersLst.Add(PersAux);
            }

            return PersLst;
        }

    }
}
