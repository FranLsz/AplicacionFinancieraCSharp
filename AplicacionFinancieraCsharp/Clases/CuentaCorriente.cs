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

        public override string Detalles()
        {
            throw new NotImplementedException();
        }

        public override string Ingresar()
        {
            throw new NotImplementedException();
        }

        public override string Sacar()
        {
            throw new NotImplementedException();
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
