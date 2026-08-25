using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal interface IMetodoPago
    {
        bool ProcesarPago(double monto);
        void Reembolsar(double monto);
        string ObtenerComprobante();
    }
}
