using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_09_2020 {
    public class Alumno {
        string nombre;
        string apellido;
        int dni;
        string direccion;
        int alturaEnCm;

        public static bool operator == (Alumno[] arrayEst, Alumno est) {
            foreach(Alumno estud in arrayEst) {
                if(estud.dni == est.dni) {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Alumno[] arrayEst, Alumno est) {
            return !(arrayEst == est);
        }

        public Alumno(string nombre, string apellido, int dni) : this(nombre, apellido) {
            this.dni = dni;
        }

        public Alumno(string nombre, string apellido) : this() {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Alumno() {
            this.nombre = "default";
            this.apellido = "default";
            this.dni = -1;
            this.direccion = "default";
            this.alturaEnCm = -1;
        }
    }
}
