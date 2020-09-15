using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Producto {
        double precio;
        string descripcion;
        string codigo;
        int uStock;
        int uVendidas;

        public Producto(double precio, string desc, string codigo, int uStock, int uVendidas) {
            this.precio = precio;
            this.descripcion = desc;
            this.codigo = codigo;
            this.uStock = uStock;
            this.uVendidas = uVendidas;
        }

        public void setStock(int stock) {
            this.uStock = stock;
        }
        public int getStock() {
            return this.uStock;
        }
        public void setVendidas(int uVendidas) {
            this.uVendidas = uVendidas;
        }
        public int getVendidas() {
            return this.uVendidas;
        }

        public void setCodigo(string codigo) {
            this.codigo = codigo;
        }
        public string getCodigo() {
            return this.codigo;
        }

        public void setPrecio(double precio) {
            this.precio = precio;
        }

        public double getPrecio() {
            return this.precio;
        }

        public void setDescripcion(string descripcion) {
            this.descripcion = descripcion;
        }

        public string getDescripcion() {
            return this.descripcion;
        }
    }
}
