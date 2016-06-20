using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace RPGSystem.DAO {
    class CapituloDAO : IDAO {
        DBAcces db = new DBAcces();

        public void Alterar(IEntidades obj, int id) {
            if (!(obj is Capitulo))
                throw new InvalidCastException("Objeto não é um atributo");

            Capitulo cap = (obj as Capitulo);

            string sql = "UPDATE Capitulo SET Texto = @texto, titulo = @titulo,startChapter = @startCharpter ";

                if (cap.idHistoria != int.MaxValue)
                    sql += ",idHistoria = @idHistoria ";

                sql += "WHERE idCapitulo = " + Convert.ToString(id);

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();

            ParamsName.Add("@texto");
            ParamsName.Add("@titulo");
            ParamsName.Add("@startCharpter");
            if (cap.idHistoria != int.MaxValue)
                ParamsName.Add("@idHistoria");
            Params.Add(cap.Texto);
            Params.Add(cap.Titulo);
            Params.Add(Convert.ToInt32(cap.startChapter));

            if (cap.idHistoria != int.MaxValue)
                Params.Add(cap.idHistoria);


            db.ExecQuery(sql, ParamsName, Params);
            
            db.ExecQuery("DELETE FROM Item_Capitulo WHERE idCapitulo = "+Convert.ToString(cap.idCapitulo));

            if (cap.Items != null) {
                for (int i = 0; i < cap.Items.Count; i++) {
                    sql = "INSERT INTO Item_Capitulo (idCapitulo, idItem) " +
                          "VALUES (@idCapitulo, @idItem)";

                    Params.Clear();
                    ParamsName.Clear();

                    ParamsName.Add("@idCapitulo");
                    ParamsName.Add("@idItem");

                    Params.Add(cap.idCapitulo);
                    Params.Add(cap.Items.ElementAt(i).IdItem);

                    db.ExecQuery(sql, ParamsName, Params);
                }
            }

            db.ExecQuery("DELETE FROM Vilao_Capitulo WHERE idCapitulo = " + Convert.ToString(cap.idCapitulo));

            if (cap.Viloes != null) {
                for (int i = 0; i < cap.Viloes.Count; i++) {
                    sql = "INSERT INTO Vilao_Capitulo (idCapitulo, idVilao) " +
                          "VALUES (@idCapitulo, @idVilao)";

                    Params.Clear();
                    ParamsName.Clear();

                    ParamsName.Add("@idCapitulo");
                    ParamsName.Add("@idVilao");

                    Params.Add(cap.idCapitulo);
                    Params.Add(cap.Viloes.ElementAt(i).IdVilao);

                    db.ExecQuery(sql, ParamsName, Params);
                }
            }
        }

        public void Criar(IEntidades obj) {
            if (!(obj is Capitulo))
                throw new InvalidCastException("Objeto não é um atributo");

            Capitulo cap = (obj as Capitulo);

            string sql = "INSERT INTO Capitulo (Texto, titulo, startChapter ";
            if (cap.idHistoria != int.MaxValue)
                sql += ", idHistoria";

            sql += ") " +
                "VALUES(@texto, @titulo, @startCharpter ";

            if (cap.idHistoria != int.MaxValue)
                sql += ", @idHistoria";

                sql+= ")";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();

            ParamsName.Add("@texto");
            ParamsName.Add("@titulo");
            ParamsName.Add("@startCharpter");
            if (cap.idHistoria != int.MaxValue)
                ParamsName.Add("@idHistoria");

            Params.Add(cap.Texto);
            Params.Add(cap.Titulo);
            Params.Add(Convert.ToInt32(cap.startChapter));

            if (cap.idHistoria != int.MaxValue)
                Params.Add(Convert.ToInt32(cap.idHistoria));

            int id = db.ExecQueryReturning(sql, ParamsName, Params);

            if (cap.Items != null) {
                for (int i = 0; i < cap.Items.Count; i++) {
                    sql = "INSERT INTO Item_Capitulo (idCapitulo, idItem) " +
                          "VALUES (@idCapitulo, @idItem)";

                    Params.Clear();
                    ParamsName.Clear();

                    ParamsName.Add("@idCapitulo");
                    ParamsName.Add("@idItem");

                    Params.Add(id);
                    Params.Add(cap.Items.ElementAt(i).IdItem);
                    db.ExecQuery(sql, ParamsName, Params);
                }
            }

            if (cap.Viloes != null) {
                for (int i = 0; i < cap.Viloes.Count; i++) {
                    sql = "INSERT INTO Vilao_Capitulo (idCapitulo, idVilao) " +
                          "VALUES (@idCapitulo, @idVilao)";

                    Params.Clear();
                    ParamsName.Clear();

                    ParamsName.Add("@idCapitulo");
                    ParamsName.Add("@idVilao");

                    Params.Add(id);
                    Params.Add(cap.Viloes.ElementAt(i).IdVilao);
                    db.ExecQuery(sql, ParamsName, Params);
                }
            }
        }

        public void Excluir(int id) {
            db.ExecQuery("DELETE FROM Capitulo WHERE idCapitulo = " + Convert.ToString(id));
            db.ExecQuery("DELETE FROM Item_Capitulo WHERE idCapitulo = " + Convert.ToString(id));
            db.ExecQuery("DELETE FROM Vilao_Capitulo WHERE idCapitulo = " + Convert.ToString(id));
        }

        public List<IEntidades> Listar() {
            string sql = "SELECT * FROM Capitulo";
            SqlDataReader Reader = db.Query(sql);

            List<IEntidades> CapLst = new List<IEntidades>();

            while (Reader.Read()) {
                Capitulo cap = new Capitulo();
                cap.idCapitulo = Convert.ToInt32(Reader["idCapitulo"]);
                cap.Texto = Convert.ToString(Reader["Texto"]);
                cap.Titulo = Convert.ToString(Reader["titulo"]);
                cap.startChapter = Convert.ToBoolean(Reader["startChapter"]);
                SqlDataReader itemsR = db.Query("SELECT * FROM Item_Capitulo WHERE idCapitulo = " + Convert.ToString(cap.idCapitulo));
                while (itemsR.Read()) {
                    cap.Items.Add(Item.ListarTodos().Find(x => x.IdItem == Convert.ToInt32(itemsR["idItem"])));
                }

                SqlDataReader viloesR = db.Query("SELECT * FROM Vilao_Capitulo WHERE idCapitulo = " + Convert.ToString(cap.idCapitulo));
                while (viloesR.Read()) {
                    cap.Viloes.Add(Viloes.ListarTodos().Find(x => x.IdVilao == Convert.ToInt32(viloesR["idVilao"])));
                }
                CapLst.Add(cap);
            }

            return CapLst;
        }

        public List<Capitulo> ListarTodos() {
            string sql = "SELECT * FROM Capitulo";
            SqlDataReader Reader = db.Query(sql);

            List<Capitulo> CapLst = new List<Capitulo>();

            while (Reader.Read()) {
                Capitulo cap = new Capitulo();
                cap.idCapitulo = Convert.ToInt32(Reader["idCapitulo"]);
                cap.Texto = Convert.ToString(Reader["Texto"]);
                cap.Titulo = Convert.ToString(Reader["titulo"]);
                cap.startChapter = Convert.ToBoolean(Reader["startChapter"]);
                SqlDataReader itemsR = (new DBAcces()).Query("SELECT * FROM Item_Capitulo WHERE idCapitulo = " + Convert.ToString(cap.idCapitulo));
                while (itemsR.Read()) {
                    cap.Items.Add(Item.ListarTodos().Find(x => x.IdItem == Convert.ToInt32(itemsR["idItem"])));
                }

                SqlDataReader viloesR = (new DBAcces()).Query("SELECT * FROM Vilao_Capitulo WHERE idCapitulo = " + Convert.ToString(cap.idCapitulo));
                while (viloesR.Read()) {
                    cap.Viloes.Add(Viloes.ListarTodos().Find(x => x.IdVilao == Convert.ToInt32(viloesR["idVilao"])));
                }

                CapLst.Add(cap);
            }

            return CapLst;
        }
    }
}
