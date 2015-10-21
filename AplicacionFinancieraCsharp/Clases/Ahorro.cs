using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinancieraCsharp.Clases
{
    public class Ahorro : Producto
    {
        public double Bonificacion { get; set; }
        public double Penalizacion { get; set; }

        public Ahorro() : base()
        {
            Bonificacion = 0;
            Penalizacion = 0;
        }

        public Ahorro(Cliente cliente, double saldo, double bonificacion, double penalizacion) : base(cliente, saldo)
        {
            Cliente = cliente;
            Saldo = saldo;
            Bonificacion = bonificacion;
            Penalizacion = penalizacion;
        }


        public override string Detalles()
        {
            return "\nTitular: " + Cliente.Nombre + "\nSaldo: " + Saldo + "\nTipo de cuenta: Ahorro";
        }

        public override void Ingresar(double cantidad)
        {
            Saldo += cantidad + (cantidad * Bonificacion);
        }

        public override void Sacar(double cantidad)
        {
            Saldo -= cantidad + (cantidad * Penalizacion);
        }

    }
}
