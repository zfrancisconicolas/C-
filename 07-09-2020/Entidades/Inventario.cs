using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades {
    public static class Inventario {
        public static Producto[] productos = new Producto[50];

        public static void agregarProducto(Producto prod) {
            for(int i = 0; i < productos.Length; i++){
                if(productos[i] == null) {
                    productos[i] = prod;
                }
            }
        }
    }
}
