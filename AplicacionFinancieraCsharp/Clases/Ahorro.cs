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
    }
}
