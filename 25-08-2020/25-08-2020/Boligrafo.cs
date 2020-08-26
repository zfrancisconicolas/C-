using System;
using System.Collections.Generic;
using System.Text;

namespace _25_08_2020 {
    public class Boligrafo {
        short cantidadTintaMaxima = 100;
        short tinta;
        ConsoleColor color;

        public Boligrafo(short tinta, ConsoleColor color) {

        }

        public ConsoleColor GetColor() {
            return this.color;
        }

        public short GetTinta() {
            return this.tinta;
        }

        //public bool Pintar(short gasto, out string dibujo) {

        //    return true;
        //}

        public void Recargar() {

        }

        public void SetTinta(short tinta) {

        }

    }
}
