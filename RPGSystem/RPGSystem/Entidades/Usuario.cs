using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RPGSystem.DAO;

namespace RPGSystem.Entidades {
    public class Usuario {
        private string login;

        public string Login {
            get { return login; }
            set {
                if (value == null || value == "") {
                    throw new ArgumentNullException("Login", "Campo não foi preenchido!");
                }
                else {
                    login = value;
                }
            }
        }

        private string senha;

        public string Senha {            
            get { return senha; }
            set {
                if (value == null || value == "") {
                    throw new ArgumentNullException("Senha","Campo não foi preenchido!");
                }
                else {
                    senha = HashSenha(value);
                }
            }
        }

        public char Nivel { get; set; }

        private string email;

        public string Email {
            get { return email; }
            set {
                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

                if (rg.IsMatch(value)) {
                    email = value;
                }
                else {
                    throw new InvalidEmailException("Email inválido!");
                }
            }
        }

        private string HashSenha(string val) {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(val);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }

        public Usuario() {

        }

        public Usuario(string ALogin, string ASenha, char ANivel, string AEmail) {
            this.Login = ALogin;
            this.Senha = ASenha;
            this.Nivel = ANivel;
            this.Email = AEmail;
        }

        public void Cadastrar() {
            UsuarioDAO DAO = new UsuarioDAO();
            DAO.Cadastrar(this);
        }

        public Boolean Logar(out string Message) {
            Message = "";
            UsuarioDAO DAO = new UsuarioDAO();
            if (!DAO.UserExist(this)) {
                Message = "Usuário inexistente!";
                return false;
            }
            else if (!DAO.ValidPass(this)) {
                Message = "Senha incorreta!";
                return false;
            }
            else {
                return true;
            }
        }
    }
}
