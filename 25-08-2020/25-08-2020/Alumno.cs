using System;
using System.Collections.Generic;
using System.Text;

namespace _25_08_2020 {
    class Alumno {
        byte nota1;
        byte nota2;
        float notaFinal = -1;
        public string apellido;
        public int legajo;
        public string nombre;
        public Random rm = new Random();

        public string Mostrar() {
            Console.WriteLine("Alumno {0}, {1}", this.getApellido(), this.getNombre());
            Console.WriteLine("Legajo {0}", this.getLegajo());
            Console.WriteLine("Primera nota {0}, Segunda nota {1}", this.nota1, this.nota2);
            if(notaFinal != -1) {
                Console.WriteLine("Nota final: {0}\n", this.notaFinal);
            }
            else {
                Console.WriteLine("Alumno desaprobado.\n");
            }
            return "r";
        }

        public void Estudiar(byte notaUno, byte notaDos) {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal() {
            if(this.nota1 >= 4 && this.nota2 >= 4) {
                this.notaFinal = rm.Next(4, 10);
            }
        }

        public void setLegajo(int legajo) {
            this.legajo = legajo;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
        public void setApellido(string apellido) {
            this.apellido = apellido;
        }

        public int getLegajo() {
            return this.legajo;
        }

        public string getNombre() {
            return this.nombre;
        }
        public string getApellido() {
            return this.apellido;
        }
    }
}
