using RPGSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Formularios {
    class FactoryTelas {
        public static ITela GetScreen(Usuario user) {
            switch (user.Nivel) {
                case 'J':
                    return new frmJogador(user);                    
                case 'A':
                    return new frmAdministrador(user);                    
                case 'M':
                    return new frmMestre(user);                    
                default:
                    throw new AccessNotDefined("Acesso não definido para o usuario: " + user.Login);                    
            }
        }
    }
}
