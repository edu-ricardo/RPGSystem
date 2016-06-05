using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem {
    class AccessNotDefined : Exception{
        public AccessNotDefined() {
        }

        public AccessNotDefined(string message) : base(message) {
        }
    }
}
