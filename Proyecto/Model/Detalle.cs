namespace Model
{
    public class Detalle
    {
        private int linea;
        private Factura codFactura;
        private Producto codProducto;
        private Colores codColor;
        private Presentacion codPresentacion;
        private string nombreProducto;
        private decimal precioVenta;
        private int cantidadCompra;
        private decimal total;
        private TpIVA codIVA;

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

        internal Factura CodFactura
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

        public string NombreProducto
        {
            get
            {
                return nombreProducto;
            }

            set
            {
                nombreProducto = value;
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set
            {
                precioVenta = value;
            }
        }

        public int CantidadCompra
        {
            get
            {
                return cantidadCompra;
            }

            set
            {
                cantidadCompra = value;
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

        internal TpIVA CodIVA
        {
            get
            {
                return codIVA;
            }

            set
            {
                codIVA = value;
            }
        }
    }
}
