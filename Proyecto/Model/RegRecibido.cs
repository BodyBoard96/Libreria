using System;

namespace Model
{
    public class RegRecibido
    {
        private int codRes;
        private int codOrden;
        private DateTime fechaRecibido;
        private decimal totalPago;
        private decimal totalIVA;

        public int CodRes
        {
            get
            {
                return codRes;
            }

            set
            {
                codRes = value;
            }
        }

        internal int CodOrden
        {
            get
            {
                return codOrden;
            }

            set
            {
                codOrden = value;
            }
        }

        public DateTime FechaRecibido
        {
            get
            {
                return fechaRecibido;
            }

            set
            {
                fechaRecibido = value;
            }
        }

        public decimal TotalPago
        {
            get
            {
                return totalPago;
            }

            set
            {
                totalPago = value;
            }
        }

        public decimal TotalIVA
        {
            get
            {
                return totalIVA;
            }

            set
            {
                totalIVA = value;
            }
        }
    }
}
