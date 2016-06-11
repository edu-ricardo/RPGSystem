using RPGSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.DAO {
    // 
    // Summary: Interface padrão de Data Access objects
    //
    interface IDAO {
        void Criar(IEntidades obj);
        void Alterar(IEntidades obj, int id);
        void Excluir(int id);
        List<IEntidades> Listar();
    }
}
