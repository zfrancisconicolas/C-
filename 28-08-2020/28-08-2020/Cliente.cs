using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_08_2020 {
    class Cliente {
        string nombre;
        string apellido;
        string dni;
        string usuario;
        string clave;
        int numeroDeCuenta;
        double saldo;

        public void agregarSaldo(double dinero) {
            this.saldo += dinero;
        }

        public bool retirarSaldo(double dinero) {
            if(this.getSaldo() > dinero) {
                this.saldo -= dinero;
                return true;
            }
            return false;
        }

        public string getNombre() {
            return this.nombre;
        }
        public string getApellido() {
            return this.apellido;
        }

        public string getDni() {
            return this.dni;
        }

        public string getUsuario() {
            return this.usuario;
        }

        public string getClave() {
            return this.clave;
        }

        public int getNumeroDeCuenta() {
            return this.numeroDeCuenta;
        }

        public double getSaldo() {
            return this.saldo;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
        public void getApellido(string apellido) {
            this.apellido = apellido;
        }

        public void setDni(string dni) {
            this.dni = dni;
        }

        public void setUsuario(string usuario) {
            this.usuario = usuario;
        }

        public void setClave(string clave) {
            this.clave = clave;
        }

        public void setNumeroDeCuenta(int numero) {
            this.numeroDeCuenta = numero;
        }

        public void setSaldo(double saldo) {
            this.saldo = saldo;
        }
    }
}
