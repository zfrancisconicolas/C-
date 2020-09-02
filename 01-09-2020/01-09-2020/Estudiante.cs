using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_09_2020 {
    class Estudiante {

        string nombre;
        string apellido;
        int legajo;

        public Estudiante() {
            this.nombre = "sin nombre";
            this.apellido = "sin apellido";
            this.legajo = -1;

        }

        public Estudiante(string nomb, string ape, int leg) {
            this.apellido = ape;
            this.nombre = nomb;
            this.legajo = leg;

        }
        public Estudiante(string nomb, int leg) {
            this.nombre = nomb;
            this.legajo = leg;
        }

        public Estudiante(string nomb, string ape) {
            this.nombre = nomb;
            this.apellido = ape;
        }

        //Este constructor va a llamar al constructor anterior para evitar reutilizar codigo
        public Estudiante(int leg, string nomb, string ape) : this(nomb, ape) { 
            this.legajo = leg;
        }


        public string GetNombreYApellido() {
            return this.apellido + "," + this.nombre;
        }

        public int GetLegajo() {
            return this.legajo;

        }


    }
}
