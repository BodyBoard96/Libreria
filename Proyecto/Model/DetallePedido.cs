namespace Model
{
    public class DetallePedido
    {
        private OredenPedido codOrden;
        private int linea;
        private Producto codProducto;
        private Colores codColor;
        private Presentacion codPresentacion;
        private decimal precioCompra;
        private int canPre;
        private decimal total;

        internal OredenPedido CodOrden
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

        internal Producto CodProducto
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

        internal Colores CodColor
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

        internal Presentacion CodPresentacion
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
