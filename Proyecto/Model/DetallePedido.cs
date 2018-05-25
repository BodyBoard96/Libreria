namespace Model
{
    public class DetallePedido
    {
        private int codOrden;
        private int linea;
        private int codProducto;
        private int codColor;
        private int codPresentacion;
        private decimal precioCompra;
        private int canPre;
        private decimal total;

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

        public int Linea
        {
            get
            {
                return linea;
            }

            set
            {
                linea = value;
            }
        }

        internal int CodProducto
        {
            get
            {
                return codProducto;
            }

            set
            {
                codProducto = value;
            }
        }

        internal int CodColor
        {
            get
            {
                return codColor;
            }

            set
            {
                codColor = value;
            }
        }

        internal int CodPresentacion
        {
            get
            {
                return codPresentacion;
            }

            set
            {
                codPresentacion = value;
            }
        }

        public decimal PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }

        public int CanPre
        {
            get
            {
                return canPre;
            }

            set
            {
                canPre = value;
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
    }
}
