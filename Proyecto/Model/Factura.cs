using System;

namespace Model
{
    public class Factura
    {
        private string codFactura;
        private DateTime fechaFacturacion;
        private Sucursal codSucursal;
        private string nrcDueno;
        private Empleado codEmpleado;
        private Clientes codCliente;
        private string descripcion;
        private TipoPago codTipoPago;
        private string numeroTarjeta;
        private decimal descuento;
        private decimal total;
        private decimal IVA;
        private EstadoFactura codEstado;
        public string CodFactura
        {
            get
            {
                return codFactura;
            }

            set
            {
                codFactura = value;
            }
        }

        public DateTime FechaFacturacion
        {
            get
            {
                return fechaFacturacion;
            }

            set
            {
                fechaFacturacion = value;
            }
        }

        internal Sucursal CodSucursal
        {
            get
            {
                return codSucursal;
            }

            set
            {
                codSucursal = value;
            }
        }

        public string NrcDueno
        {
            get
            {
                return nrcDueno;
            }

            set
            {
                nrcDueno = value;
            }
        }

        internal Empleado CodEmpleado
        {
            get
            {
                return codEmpleado;
            }

            set
            {
                codEmpleado = value;
            }
        }

        internal Clientes CodCliente
        {
            get
            {
                return codCliente;
            }

            set
            {
                codCliente = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        internal TipoPago CodTipoPago
        {
            get
            {
                return codTipoPago;
            }

            set
            {
                codTipoPago = value;
            }
        }

        public string NumeroTarjeta
        {
            get
            {
                return numeroTarjeta;
            }

            set
            {
                numeroTarjeta = value;
            }
        }

        public decimal Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public decimal IVA1
        {
            get
            {
                return IVA;
            }

            set
            {
                IVA = value;
            }
        }

        internal EstadoFactura CodEstado
        {
            get
            {
                return codEstado;
            }

            set
            {
                codEstado = value;
            }
        }
    }
}
