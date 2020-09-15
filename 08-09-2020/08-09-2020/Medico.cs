using System;

namespace _08_09_2020 {
    public class Medico {
        string nombre;
        string apellido;
        string dni;
        string especialidad;
        public Medico(string nombre, string apellido, string dni, string especialidad) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.especialidad = especialidad;       
        }

        public static bool operator + (Medico[] medicos, Medico medico) {
            for(int i = 0; i < medicos.Length; i++) {
                if (medicos[i] == null) {
                    medicos[i] = medico;
                    return true;
                }
            }
            Array.Resize<Medico>(ref medicos, medicos.Length + 1);
            medicos[medicos.Length - 1] = medico;
            return true;
        }
    }
}
