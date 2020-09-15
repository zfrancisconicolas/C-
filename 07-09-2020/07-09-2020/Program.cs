using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace _07_09_2020 {
    class Program {
        static void Main(string[] args) {
            int opcion = 0;
            string nombreCliente;
            string codigoProducto;
            int cantidadProductos;

            //Hardcodeo de inventario
            Inventario.agregarProducto(new Producto(150.50, "Canilla", "123", 10, 0)); 
            Inventario.agregarProducto(new Producto(250.50, "Precintos", "124", 10, 0)); 
            Inventario.agregarProducto(new Producto(550.50, "Cinta 3M", "125", 10, 0)); 
            Inventario.agregarProducto(new Producto(350.50, "Llave 10", "126", 10, 0));
            ItemFactura[] itemsFactura = new ItemFactura[40];
            do {
                Console.WriteLine("3- Agregar producto.\n8- Nueva venta\n9- Mostrar factura\n10- Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) {
                    case 8:
                        Console.WriteLine("Ingrese el nombre del cliente.");
                        nombreCliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el codigo del producto.");
                        codigoProducto = Console.ReadLine();
                        Console.WriteLine("Ingrese cantidad de productos.");
                        cantidadProductos = int.Parse(Console.ReadLine());
                        for(int i = 0; i < itemsFactura.Length; i++) {
                            if(itemsFactura[i] == null) {
                                itemsFactura[i] = new ItemFactura(codigoProducto, cantidadProductos, Inventario.productos, nombreCliente);
                            }
                        }
                    break;
                    case 9:
                        Console.WriteLine("Ingrese el nombre del cliente de la factura a imprimir");
                        nombreCliente = Console.ReadLine();
                        Factura.crearFactura(nombreCliente, itemsFactura);
                    break;
                }


            } while (opcion != 10);
        }
    }
}
