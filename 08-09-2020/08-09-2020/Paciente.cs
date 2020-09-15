using System;
using System.Collections.Generic;
using System.Text;

namespace _08_09_2020 {
    public class Paciente {
        string nombre;
        string apellido;
        string dni;
        string descripcion;
        Enfermedad dolencia;

        public Enfermedad Dolencia { set { dolencia = value; } get { return this.dolencia; } }

        public string Nombre { get { return this.nombre; } }
        public Paciente(string nombre, string apellido, string dni, string descripcion) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.descripcion = descripcion;
        }
    
        public void SetEnfermedad(Enfermedad dolencia) {
            this.dolencia = dolencia;
        }

        public static bool operator +(Paciente[] pacientes, Paciente paciente) {
            for (int i = 0; i < pacientes.Length; i++) {
                if (pacientes[i] == null) {
                    pacientes[i] = paciente;
                    return true;
                }
            }
            Array.Resize<Paciente>(ref pacientes, pacientes.Length + 1);
            pacientes[pacientes.Length - 1] = paciente;
            return true;
        }
    }
}
