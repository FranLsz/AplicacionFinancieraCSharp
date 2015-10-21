using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinancieraCsharp.Interfaces
{
    public interface ICalculoSeguro
    {
        double Prima(double capital, int edad);
        double Cancelacion(double capital);
    }
}
