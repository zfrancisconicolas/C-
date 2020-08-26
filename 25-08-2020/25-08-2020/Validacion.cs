using System;
using System.Collections.Generic;
using System.Text;

namespace _25_08_2020 {
    public class Validacion {
        public static bool Validar(int valor, int min, int max) {
            if (valor >= min && valor <= max)
                return true;
            return false;
        }
    }
}
