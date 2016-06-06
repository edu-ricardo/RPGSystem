using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Entidades {
    interface ITela {
        void SetUser(Usuario user);
        Boolean HasAccess();
    }
}
