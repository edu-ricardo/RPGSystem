using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem {
    class InvalidEmailException : Exception {
        public InvalidEmailException() {
            
        }

        public InvalidEmailException(string message):base(message) {
                
        }
    }
}
