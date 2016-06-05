using RPGSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.DAO {
    public class UsuarioDAO {
        DBAcces db = new DBAcces();

        public void Cadastrar(Usuario user) {
            string sql = "insert into login (login, senha, nivel, email) values (@login, @senha, @nivel, @email)";
            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();

            ParamsName.Add("@login");
            ParamsName.Add("@senha");
            ParamsName.Add("@nivel");
            ParamsName.Add("@email");
            Params.Add(user.Login);
            Params.Add(user.Senha);
            Params.Add(user.Nivel);
            Params.Add(user.Email);

            db.ExecQuery(sql, ParamsName, Params);
        }

        public Boolean UserExist(Usuario user) {
            string sql = "select * from login where login = @login";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();

            ParamsName.Add("@login");
            Params.Add(user.Login);
            SqlDataReader res = db.Query(sql, ParamsName, Params);
            
            if (res.Read()) {
                return true;
            }
            else {
                return false;
            }
        }

        public Boolean ValidPass(Usuario user) {
            string sql = "select * from login where login = @login and senha = @senha";

            List<object> Params = new List<object>();
            List<string> ParamsName = new List<string>();

            ParamsName.Add("@login");
            ParamsName.Add("@senha");
            Params.Add(user.Login);
            Params.Add(user.Senha);
            SqlDataReader res = db.Query(sql, ParamsName, Params);

            if (res.Read()) {
                user.Nivel = Convert.ToChar(res["nivel"]);
                user.Email = Convert.ToString(res["email"]);
                return true;
            }
            else {
                return false;
            }
        }
        
    }

}
