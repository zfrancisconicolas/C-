using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_09_2020 {
    class Program {
        static void Main(string[] args) {

            //Establecimiento.SetearNombreJardin("Los pipis");

            //Establecimiento.AgregarAlumno(new Estudiante("pepito", "juancito", 123));
            //Establecimiento.AgregarAlumno(new Estudiante("asd", "asdadsad", 321));

            //Console.WriteLine(Establecimiento.MostrarAlumnos());

            Estudiante[] arrayEstudiantes = new Estudiante[5];
            arrayEstudiantes[0] = new Estudiante("Francisco", "Zanotti", 0);
            arrayEstudiantes[1] = new Estudiante("Francisco", "Zanotti", 1);
            arrayEstudiantes[2] = new Estudiante("Francisco", "Zanotti", 2);
            arrayEstudiantes[3] = new Estudiante("Francisco", "Zanotti", 3);
            arrayEstudiantes[4] = new Estudiante("Francisco", "Zanotti", 4);


            Jardin.AgregarAlumnos(new Alumno("Francisco", "Zanotti", 1234567));

            Console.ReadKey();

        }
    }
}
