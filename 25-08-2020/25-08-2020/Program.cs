using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace _25_08_2020 {
    class Program {
        static void Main(string[] args) {
            //ejercicio1();
            //ejercicio2();
            //ejercicio3();
            //ejercicio4();
            //ejercicio6();
            //ejercicio7();
            //ejercicio8();
            //ejercicio9();
            //ejercicio10();
            //ejercicio11();
            //ejercicio12();
            ejercicio16();
        }

        static void ejercicio1() {
            int[] enteros = new int[5];
            int promedio = 0;
            int max = 0;
            int min = 0;
            Console.WriteLine("Ingrese {0} numeros: ", enteros.Length);
            for (int i = 0; i < enteros.Length; i++) {
                enteros[i] = int.Parse(Console.ReadLine());
            }

            foreach (int numero in enteros) {
                promedio += numero;
                if (numero > max || numero == enteros[0]) {
                    max = numero;
                }
                if (numero < min || numero == enteros[0]) {
                    min = numero;
                }
            }
            Console.WriteLine("El numero maximo es {0}, el numero minimo es {1} y el promedio {2}", max, min, promedio / enteros.Length);
        }

        static void ejercicio2() {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            do {
                numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                    Console.WriteLine("Error. Reingresar numero");
            } while (numero == 0);
            Console.WriteLine("El cuadrado del numero es {0} y su cubo {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
        }

        static void ejercicio3() {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero > 0) {
                for (int i = 0; i < numero; i++) {
                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                    }
                }
            }
            else {
                Console.WriteLine("El numero ingresado es invalido.");
            }
        }

        static void ejercicio4() {
            int sum = 1;
            int contador = 0;
            for (int i = 2; i < 100000; i++) {
                for (int j = 2; j < i; j++) {
                    if (i % j == 0) {
                        sum += j;
                    }
                }
                if (sum == i) {
                    Console.WriteLine("Numero perfecto {0}", i);
                    contador++;
                }
                if (contador == 4) {
                    break;
                }
                sum = 1;
            }
            Console.ReadKey();
        }

        static void ejercicio6() {
            Console.WriteLine("Ingrese un anio de inicio");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un anio de fin");
            int fin = int.Parse(Console.ReadLine());
            for (int i = inicio; i <= fin; i++) {
                if (i % 4 == 0)
                    Console.WriteLine("El anio {0} es bisiesto", i);
            }
        }

        static void ejercicio7() {
            Console.WriteLine("Ingrese su fecha de nacimiento: ");
            Console.WriteLine("Anio ");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dia ");
            int dia = int.Parse(Console.ReadLine());

            DateTime birthdate = new DateTime(anio, mes, dia);
            DateTime hoy = DateTime.Now;

            Console.WriteLine("Dias vividos: {0}", (hoy - birthdate).TotalDays);


        }

        static void ejercicio8() {
            Console.WriteLine("Cuantos empleados desea cargar?");
            int cantEmpleados = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el valor de la hora?");
            int valorHora = int.Parse(Console.ReadLine());

            List<Persona> empleados = new List<Persona>();

            Persona persona;
            for (int i = 0; i < cantEmpleados; i++) {
                Console.WriteLine("Empleado numero {0}", i + 1);
                persona = new Persona();
                Console.WriteLine("Ingrese el nombre");
                persona.setNombre(Console.ReadLine());
                Console.WriteLine("Ingrese el apellido");
                persona.setApellido(Console.ReadLine());
                Console.WriteLine("Ingrese las horas trabajadas");
                persona.setHorasTrabajadas(int.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese su antiguedad");
                persona.setAntiguedad(int.Parse(Console.ReadLine()));
                empleados.Add(persona);
            }

            double sueldo;
            foreach (Persona empleado in empleados) {
                Console.WriteLine("Recibo de sueldo del empleado {0}, {1}", empleado.getApellido(), empleado.getNombre());
                sueldo = (((empleado.getHorasTrabajadas() * valorHora) + empleado.getAntiguedad() * 150) * 0.83);
                Console.WriteLine("Sueldo a cobrar: {0}", Math.Round(sueldo, 2));
            }

        }
        
        static void ejercicio9() {
            Console.WriteLine("Ingrese la altura de la piramide");
            int altura = int.Parse(Console.ReadLine());
            char asterisco = '*';
            for (int i = altura; i >= 1; i--) {
                for (int j = 1; j <= altura - i + 1; j++) {
                    Console.Write(asterisco);
                }
                Console.WriteLine("");
            }
        }

        static void ejercicio10() {
            Console.WriteLine("Ingrese la altura de la piramide");
            int altura = int.Parse(Console.ReadLine());
            char asterisco = '*';

            for (int i = 0; i <= altura; i++) {
                for (int j = 1; j <= altura - i; j++) {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++) {
                    Console.Write(asterisco);
                }
                Console.WriteLine("");
            }
        }
            
        static void ejercicio11() {
            int cantidad = 10;
            int max = 0;
            int min = 0;
            int total = 0;
            int valor;
            bool valido;
            Console.WriteLine("Ingrese 10 numeros enteros: ");
            for (int i = 0; i < cantidad; i++) {
                do {
                    valor = int.Parse(Console.ReadLine());
                    valido = Validacion.Validar(valor, -100, 100);
                    if (valido) {
                        if (max < valor || i == 0) {
                            max = valor;
                        }
                        if (min > valor || i == 0) {
                            min = valor;
                        }
                        total += valor;
                    }
                    else {
                        Console.WriteLine("Numero invalido, reintentar.");
                    }
                } while (!valido);
            }
            Console.WriteLine("El valor minimo es {0}, el valor maximo es {1} y el promedio {2}", min, max, total / cantidad);
        }
    
        static void ejercicio12() {
            bool continuar;
            int sum = 0;
            int valor;
            do {
                Console.WriteLine("Ingrese el numero a sumar");
                valor = int.Parse(Console.ReadLine());
                sum += valor;
                Console.WriteLine("Desea continuar? S/N");
                continuar = ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine()));
            } while (continuar);

            Console.WriteLine("El total es {0}", sum);
        }
    
        static void ejercicio16() {
            int legajoElegido;
            List<Alumno> alumnos = new List<Alumno>();
            int opcion; 
            do {
                Console.WriteLine("1. Cargar alumno");
                Console.WriteLine("2. Eliminar alumno");
                Console.WriteLine("3. Cargar nota");
                Console.WriteLine("4. Mostrar alumnos");
                Console.WriteLine("5. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        alumnos.Add(cargarAlumno());
                    break;
                    case 2:
                        Console.WriteLine("Ingrese su legajo");
                        legajoElegido = int.Parse(Console.ReadLine());
                        alumnos.Remove(eliminarAlumno(alumnos, legajoElegido));
                    break;
                    case 3:
                        Console.WriteLine("Ingrese su legajo");
                        legajoElegido = int.Parse(Console.ReadLine());
                        cargarNota(alumnos, legajoElegido);
                    break;
                    case 4:
                        mostrarAlumnos(alumnos);
                    break;
                }

            } while (opcion != 4);
        }

        public static Alumno eliminarAlumno(List<Alumno> alumnos, int legajo) {
            Alumno alumnoElegido = new Alumno() ;
            foreach(Alumno al in alumnos) {
                if(al.getLegajo() == legajo) {
                    alumnoElegido = al;
                }
            }
            return alumnoElegido;
        }

        public static Alumno cargarAlumno() {
            Alumno alum = new Alumno();
            Console.WriteLine("Ingrese el nombre");
            alum.setNombre(Console.ReadLine());
            Console.WriteLine("Ingrese el apellido");
            alum.setApellido(Console.ReadLine());
            Console.WriteLine("Ingrese el legajo");
            alum.setLegajo(int.Parse(Console.ReadLine()));
            return alum;
        }

        public static void mostrarAlumnos(List<Alumno> alumnos) {
            foreach(Alumno alum in alumnos) {
                alum.CalcularFinal();
                alum.Mostrar();
            }
        }
        public static void cargarNota(List<Alumno> alumnos, int legajo) {
            byte primeraNota;
            byte segundaNota;
            foreach (Alumno alum in alumnos) {
                if (alum.getLegajo() == legajo) {
                    Console.WriteLine("Primera nota");
                    primeraNota = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Segunda nota");
                    segundaNota = byte.Parse(Console.ReadLine());
                    alum.Estudiar(primeraNota, segundaNota);
                }
            }
        }
    }
}
