using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_09_2020 {
    static public class Jardin {
        static Docente[] arrayDocentes;
        static Alumno[] arrayAlumnos;
        static string nombreDelJardin;
        static int antiguedadDelJardin;
        static Jardin() {
            arrayDocentes = new Docente[5];
            arrayAlumnos = new Alumno[30];
        }

        /// <summary>
        /// Funcion estatica que agrega alumnos
        /// </summary>
        /// <param name="alu">Alumno a agregar</param>
        /// <returns>bool status del proceso</returns>
        public static bool AgregarAlumnos(Alumno alu) {
            bool status = false;
            for (int i = 0; i < arrayAlumnos.Length; i++) {
                if (arrayAlumnos[i] == null) {
                    arrayAlumnos[i] = alu;
                    status = true;
                    break;
                }
            }
            return status;
        }
        public static void SetearInfo(string nombre) {
            nombreDelJardin = nombre;
        }

        public static void SetearInfo(int edad) {
            antiguedadDelJardin = edad;
        }
    }
}
