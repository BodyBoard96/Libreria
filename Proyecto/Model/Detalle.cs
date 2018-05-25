namespace Model
{
    public class Detalle
    {
        private int linea;
        private string codFactura;
        private int codProducto;
        private int codColor;
        private int codPresentacion;
        private string nombreProducto;
        private decimal precioVenta;
        private int cantidadCompra;
        private decimal total;
        private int codIVA;

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

        internal string CodFactura
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

        internal int CodIVA
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
