using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionFinancieraCsharp.Interfaces;

namespace AplicacionFinancieraCsharp.Clases
{
    public class CuentaCorriente : Producto, ICalculoSeguro
    {
        public double Credito { get; set; }
        public double TipoInteres { get; set; }

        public CuentaCorriente() : base()
        {
            Credito = 0;
            TipoInteres = 0;
        }

        public CuentaCorriente(Cliente cliente, double saldo, double credito, double tipoInteres) : base(cliente, saldo)
        {
            Cliente = cliente;
            Saldo = saldo;
            Credito = credito;
            TipoInteres = tipoInteres;
        }

        public override string Detalles()
        {
            return "\nTitular: " + Cliente.Nombre + "\nSaldo: " + Saldo + "\nTipo de cuenta: Cuenta corriente";
        }

        public override void Ingresar(double cantidad)
        {
            Saldo += cantidad;
        }

        public override void Sacar(double cantidad)
        {
            Saldo -= cantidad;
        }


        public double Prima(double capital, int edad)
        {
            throw new NotImplementedException();
        }

        public double Cancelacion(double capital)
        {
            throw new NotImplementedException();
        }
    }
}
