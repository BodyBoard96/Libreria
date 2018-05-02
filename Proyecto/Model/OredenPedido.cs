using System;

namespace Model
{
    public class OredenPedido
    {
        private int codOrden;
        private Proveedor codProveedor;
        private DateTime fechaPedido;

        public int CodOrden
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

        public DateTime FechaPedido
        {
            get
            {
                return fechaPedido;
            }

            set
            {
                fechaPedido = value;
            }
        }

        internal Proveedor CodProveedor
        {
            get
            {
                return codProveedor;
            }

            set
            {
                codProveedor = value;
            }
        }
    }
}
