using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class ItemFactura {
        Producto producto;
        int cantidad;
        double precioUnitario;
        string nombreCliente;

        public ItemFactura(string codigoProd, int cant, Producto[] inventario, string nombreCliente) {
            foreach(Producto product in inventario){
                if(product.getCodigo() == codigoProd) {
                    this.producto = product;
                    this.precioUnitario = product.getPrecio() * cant;
                    break;
                }
            }
            this.nombreCliente = nombreCliente;
            this.cantidad = cant;
        }

        public string getNombreCliente() {
            return this.nombreCliente;
        }

        public void setProducto(Producto prod) {
            this.producto = prod;
        }

        public Producto getProducto() {
            return this.producto;
        }

        public void setCantidad(int cantidad) {
            this.cantidad = cantidad;
        }

        public int getCantidad() {
            return this.cantidad;
        }

    }
}
