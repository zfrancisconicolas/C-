using System;
using System.Collections.Generic;
using System.Text;

namespace _25_08_2020 {
    class Persona {
        private int edad;
        private string nombre;
        private string apellido;
        private int horasTrabajadas;
        private int antiguedad;

        public void setEdad(int edad) {
            this.edad = edad;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
        public void setApellido(string apellido) {
            this.apellido = apellido;
        }

        public void setHorasTrabajadas(int horasTrabajadas) {
            this.horasTrabajadas = horasTrabajadas;
        }

        public void setAntiguedad(int antiguedad) {
            this.antiguedad = antiguedad;
        }

        public int getEdad() {
            return this.edad;
        }

        public string getNombre() {
            return this.nombre;
        }
        public string getApellido() {
            return this.apellido;
        }

        public int getHorasTrabajadas() {
            return this.horasTrabajadas;
        }

        public int getAntiguedad() {
            return this.antiguedad;
        }
    } 
}
