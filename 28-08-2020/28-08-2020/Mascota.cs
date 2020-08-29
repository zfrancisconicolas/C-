using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_08_2020 {
    class Mascota {
        string tipo;
        int edad;
        int peso;
        string nombre;

        public int getEdad() {
            return this.edad;
        }
        public bool setEdad(int edad, int min, int max) {
            if (edad >= min && edad <= max) {
                this.edad = edad;
                return true;
            }
            return false;
        }

        public int getPeso() {
            return this.peso;
        }
        public bool setPeso(int peso, int min, int max) {
            if(peso >= min && peso <= max) {
                this.peso = peso;
                return true;
            }
            return false;
        }

        public string getNombre() {
            return this.nombre;
        }
        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public string getTipo() {
            return this.tipo;
        }
        public bool setTipo(string tipo) {
            if (tipo.ToLower() == "gato" || tipo.ToLower() == "perro") {
                this.tipo = tipo;
                return true;
            }
            return false;
        }
    }
}
