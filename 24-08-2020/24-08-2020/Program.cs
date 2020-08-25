using System;
using System.Collections.Generic;

namespace _24_08_2020{
    class Program{
        static void Main(string[] args){
            //int sum = 0;
            //DateTime ahora = DateTime.Now;
            //if(ahora.Second > 25 || ahora.Minute > 25) {
            //    sum = suma(ahora.Minute, ahora.Second);
            //    Console.WriteLine("Los segundos son {0} y los minutos {1}. La suma es: {2}", ahora.Second, ahora.Minute, sum);
            //}

            //Pedir 5 nombres y mostrarlos en pantalla

            string[] nombres = new string[5];
            Console.WriteLine("Ingrese 5 nombres: ");
            for(int i = 0; i < nombres.Length ; i++) {
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("Nombres ingresados: ");
            foreach(string nombre in nombres) {
                Console.WriteLine(nombre);
            }
        }

        public static int suma(int sumando1, int sumando2) {
            return sumando1 + sumando2;
        }
    }
}
