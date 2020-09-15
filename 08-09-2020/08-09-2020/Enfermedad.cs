using System;
using System.Collections.Generic;
using System.Text;

namespace _08_09_2020 {
    public class Enfermedad {
        string nombre;
        string[] sintomas;
        private Enfermedad() {
            sintomas = new string[4];
        }

        public Enfermedad(string nombre) : this() {
            this.nombre = nombre;
        }
        public Enfermedad(string nombre, string[] sintomas) : this(nombre) {
            this.sintomas = sintomas;
        }
    }
}
