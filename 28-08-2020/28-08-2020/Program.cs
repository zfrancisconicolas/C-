using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_08_2020 {
    class Program {
        static void Main(string[] args) {
            ejercicio1();
            ejercicioBonusTrack();
        }

        public static void ejercicio1() {
            Cliente fran = new Cliente();
            fran.setClave("frantest123");
            fran.setDni("12345");
            fran.setNombre("Francisco");
            fran.setNumeroDeCuenta(45);
            fran.setSaldo(3752.5);
            fran.setUsuario("fzanotti");

            Console.WriteLine("Ingrese su usuario:");
            string user = Console.ReadLine();
            Console.WriteLine("Ingrese la password:");
            string pw = Console.ReadLine();

            if (String.IsNullOrEmpty(pw) || !userCheck(fran, user, pw)) {
                Console.WriteLine("Informacion incorrecta");
            }
            else {
                Console.WriteLine("Informacion correcta");
                mostrarInformacionBancaria(fran);

            }
            Console.WriteLine("Gracias, vuelva prontos.");
        }

        public static void ejercicioBonusTrack() {
            Mascota[] mascotas = new Mascota[4];
            Console.WriteLine("Carga de mascotas en sistema");
            bool statusTipoMascota;
            bool statusEdadMascota;
            bool statusPesoMascota;

            Mascota mascota;
            string nombre;
            string tipo;
            int peso;
            int edad;
            bool ret;
            for (int i = 0; i < mascotas.Length; i++) {
                mascota = new Mascota();
                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
                mascota.setNombre(nombre);
                Console.WriteLine("Ingrese el tipo");
                tipo = Console.ReadLine();
                statusTipoMascota = mascota.setTipo(tipo);
                Console.WriteLine("Ingrese el peso");
                ret = int.TryParse(Console.ReadLine(), out peso);
                statusPesoMascota = mascota.setPeso(peso, 0, 100);
                Console.WriteLine("Ingrese la edad");
                ret = int.TryParse(Console.ReadLine(), out edad);
                statusEdadMascota = mascota.setEdad(edad, 1, 25);
                if (!statusEdadMascota || !statusPesoMascota || !statusTipoMascota) {
                    Console.WriteLine("Ocurrio un error al guardar la mascota por dato invalido.");
                    i--;
                }
                else {
                    Console.WriteLine("Mascota cargada con exito");
                    mascotas[i] = mascota;
                }

            }
            Console.WriteLine("1. Estadistica de mascotas\n2.Buscar mascota por nombre");
            int opcionMenu;
            ret = int.TryParse(Console.ReadLine(), out opcionMenu);
            switch (opcionMenu) {
                case 1:
                    mostrarEstadisticas(mascotas);
                    break;
                case 2:
                    Mascota mascotaEncontrada = buscarMascotaPorNombre(mascotas);
                    if (mascotaEncontrada != null) {
                        Console.WriteLine("Nombre: {0}\nTipo: {1}\nEdad: {2}\nPeso: {3}\n", mascotaEncontrada.getNombre(), mascotaEncontrada.getTipo(), mascotaEncontrada.getEdad(), mascotaEncontrada.getPeso());
                    }
                    else {
                        Console.WriteLine("No se encontro una mascota con ese nombre");
                    }
                    break;
            }
            Console.WriteLine("Gracias, vuelva prontos.");
            Console.ReadKey();
        }

        private static Mascota buscarMascotaPorNombre(Mascota[] mascotas) {
            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();
            foreach(Mascota mascota in mascotas){
                if(mascota.getNombre() == nombre) {
                    return mascota;
                }
            }
            return null;
        }

        private static void mostrarEstadisticas(Mascota[] mascotas) {
            int pesoTotal = 0;
            string nombrePerroMasViejo = "";
            int edadPerroMasViejo = 0;
            Mascota[] menorDiezKgDiezAnios = new Mascota[mascotas.Length];
            int i = 0;
            foreach(Mascota mascota in mascotas) {
                if(mascota.getEdad() > edadPerroMasViejo && mascota.getTipo().ToLower() == "perro") {
                    edadPerroMasViejo = mascota.getEdad();
                    nombrePerroMasViejo = mascota.getNombre();
                }
                if(mascota.getPeso() < 10 && mascota.getEdad() > 10) {
                    menorDiezKgDiezAnios[i] = mascota;
                }
                pesoTotal += mascota.getPeso();
                i++;
            }
            Console.WriteLine("Promedio de pesos totales {0}\nNombre del perro mas viejo {1}", (pesoTotal / mascotas.Length), nombrePerroMasViejo);
            Console.WriteLine("Nombre y tipo de los animales menores a 10 kg y mayores a 10 anios");
            foreach(Mascota mascota in menorDiezKgDiezAnios) {
                if(mascota != null) {
                    Console.WriteLine("Nombre {0}, Tipo {1}", mascota.getNombre(), mascota.getTipo());
                }
            }
        }

        private static bool userCheck(Cliente client, string user, string pw) {
            if(client.getUsuario() == user && client.getClave() == pw) {
                return true;
            }
            return false;
        }

        private static void mostrarInformacionBancaria(Cliente client) {
            Console.WriteLine("Saldo: {0}\n", client.getSaldo());
            Console.WriteLine("1. Agregar dinero.");
            Console.WriteLine("2. Retirar dinero.");
            int opcion;
            double valor;
            bool retira;
            bool ret = int.TryParse(Console.ReadLine(), out opcion);
            if (ret) {
                switch (opcion) {
                    case 1:
                        Console.WriteLine("Ingrese el valor:");
                        ret = double.TryParse(Console.ReadLine(), out valor);
                        client.agregarSaldo(valor);
                        Console.WriteLine("Saldo total {0}", client.getSaldo());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el valor:");
                        ret = double.TryParse(Console.ReadLine(), out valor);
                        retira = client.retirarSaldo(valor);
                        if (retira) {
                            Console.WriteLine("Operacion realizada con exito.");
                            Console.WriteLine("Saldo restante {0}", client.getSaldo());
                        }
                        else {
                            Console.WriteLine("No tiene suficientes fondos.");
                        }
                    break;
                }
            }
        }
    }
}
