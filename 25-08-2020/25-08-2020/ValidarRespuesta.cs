using System;
using System.Collections.Generic;
using System.Text;

namespace _25_08_2020 {
    public class ValidarRespuesta {
        public static bool ValidaS_N(char c) {
            if (Char.ToLower(c) == 's')
                return true;
            else if (Char.ToLower(c) == 'n')
                return false;
            return false;
        }
    }
}
