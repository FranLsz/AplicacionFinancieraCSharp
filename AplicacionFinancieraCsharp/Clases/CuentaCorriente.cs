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
            var s = Saldo - cantidad;

            if (s >= 0 || s < 0 && Math.Abs(s) <= Credito)
            {
                if (s < 0)
                    s += s * TipoInteres / 100;
                Saldo = s;
                Console.WriteLine("Operacion realizada, tu saldo es de " + Saldo + " Euros");
            }
            else
            {
                Console.WriteLine("No se puede retirar tanto saldo");
                Console.Read();
            }
        }


        public double Prima(double capital, int edad)
        {
            return 200000;
        }

        public double Cancelacion(double capital)
        {
            return 50000;
        }
    }
}
