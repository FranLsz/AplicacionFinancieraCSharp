using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinancieraCsharp.Clases
{
    public abstract class Producto
    {
        public Cliente Cliente { get; set; }
        public double Saldo { get; set; }

        protected Producto()
        {
            Cliente = null;
            Saldo = 0;
        }

        protected Producto(Cliente cliente, double saldo)
        {
            Cliente = cliente;
            Saldo = saldo;
        }


        public abstract string Detalles();
        public abstract void Ingresar(double cantidad);
        public abstract void Sacar(double cantidad);


    }
}
