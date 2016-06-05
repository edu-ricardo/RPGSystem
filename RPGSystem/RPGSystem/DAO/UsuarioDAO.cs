using RPGSystem.Entidades;
using System;
using System.Collections.Generic;
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
    }
}
