using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSystem.Entidades;
using System.Data.SqlClient;

namespace RPGSystem.DAO {
    class ItemDAO : IDAO {
        DBAcces db = new DBAcces();

        public void Alterar(IEntidades obj, int id) {
            if (!(obj is Item))
                throw new InvalidCastException("Objeto não é um item");

            Item item = (obj as Item);

            string sql = "UPDATE Item set idEspecie = @idEspecie, nome = @nome, range = @range, attack = @attack " +
                         "WHERE idItem = @id";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            ParamsName.Add("@idEspecie");
            ParamsName.Add("@nome");
            ParamsName.Add("@range");
            ParamsName.Add("@attack");
            Params.Add(id);
            Params.Add(item.idEspecie);
            Params.Add(item.Nome);
            Params.Add(item.Range);
            Params.Add(item.Atack);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Criar(IEntidades obj) {
            if (!(obj is Item))
                throw new InvalidCastException("Objeto não é um item");

            Item item = (obj as Item);

            string sql = "INSERT INTO Item (idEspecie, nome, range, attack) " +
                         "VALUES(@idEspecie, @nome, @range, @attack)";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            
            ParamsName.Add("@idEspecie");
            ParamsName.Add("@nome");
            ParamsName.Add("@range");
            ParamsName.Add("@attack");            
            Params.Add(item.idEspecie);
            Params.Add(item.Nome);
            Params.Add(item.Range);
            Params.Add(item.Atack);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public void Excluir(int id) {
            string sql = "DELETE FROM Item WHERE idItem = @id";
            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();
            ParamsName.Add("@id");
            Params.Add(id);
            db.ExecQuery(sql, ParamsName, Params);
        }

        public List<IEntidades> Listar() {
            
            string sql = "SELECT * FROM Item";
            SqlDataReader Reader = db.Query(sql);

            List<IEntidades> ItemLst = new List<IEntidades>();

            while (Reader.Read()) {
                
                Item item = new Item(Convert.ToString(Reader["nome"]), 
                    Convert.ToInt32(Reader["range"]), Convert.ToInt32(Reader["atack"]), Convert.ToInt32(Reader["idEspecie"]));               
                item.IdItem = Convert.ToInt32(Reader["idItem"]);
                ItemLst.Add(item);
            }

            return ItemLst;
        }

        public List<Item> ListarItem() {
            string sql = "SELECT * FROM Item";
            SqlDataReader Reader = db.Query(sql);

            List<Item> ItemLst = new List<Item>();

            while (Reader.Read()) {
                Item item = new Item(Convert.ToString(Reader["nome"]),
                    Convert.ToInt32(Reader["range"]), Convert.ToInt32(Reader["attack"]), Convert.ToInt32(Reader["idEspecie"]));
                item.IdItem = Convert.ToInt32(Reader["idItem"]);
                item.DiscoverEspecie();
                ItemLst.Add(item);
            }

            return ItemLst;
        }
    }

}
