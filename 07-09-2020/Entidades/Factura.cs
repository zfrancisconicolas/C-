using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Factura {
        string cliente;
        string empresa;
        ItemFactura[] items;
        static int numero = 0;
        int numeroFactura;
        float total;
        static int cantidadFacturas;
        public static void crearFactura(string nombreCliente, ItemFactura[] items) {
            ItemFactura[] itemsCliente = new ItemFactura[50];
            foreach(ItemFactura item in items) {
                if(item.getNombreCliente() == nombreCliente) {
                    for(int i = 0; i < itemsCliente.Length; i++) {
                        if(itemsCliente[i] == null) {
                            itemsCliente[i] = item;
                        }
                    }
                }
            }
            Factura fc = new Factura(nombreCliente, null, itemsCliente, numero);
            //Console.WriteLine("Factura numero cliente {1}", fc.getCliente()) ;
            Console.WriteLine("*******************************************");
            foreach(ItemFactura item in fc.items) {
                if(item != null) {
                    Console.WriteLine("Producto {0} cantidad {1} precio unitario {2}", item.getProducto().getDescripcion(), item.getCantidad(), item.getProducto().getPrecio());
                }
            }
            Console.WriteLine("*******************************************");
        }

        public Factura() {
            numero++;
        }
        public Factura(string cliente, string empresa, ItemFactura[] itemsFactura, int numero) : this() {
            this.cliente = cliente;
            this.empresa = empresa;
            this.items = itemsFactura;
            this.numeroFactura = numero;
        }

        public void setTotal(float total) {
            this.total = total;
        }

        public float getTotal() {
            return this.total;
        }

        public void setNumero(int numero) {
            this.numeroFactura = numero;
        }

        public int getNumero() {
            return this.numeroFactura;
        }

        public void setItems(ItemFactura[] items) {
            this.items = items;
        }
        public ItemFactura[] getItems() {
            return this.items;
        }

        public void setCliente(string cliente) {
            this.cliente = cliente;
        }

        public string getCliente() {
            return this.cliente;
        }

        public void setEmpresa(string empresa) {
            this.empresa = empresa;
        }

        public string getEmpresa() {
            return this.empresa;
        }
    }
}
