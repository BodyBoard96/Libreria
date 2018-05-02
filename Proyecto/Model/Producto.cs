namespace Model
{
    public class Producto
    {
        private int codProducto;
        private Colores codColor;
        private Presentacion codPresentacion;
        private string codigoBarras;
        private string nombreProducto;
        private decimal precioCompra;
        private Proveedor codProveedor;
        private decimal precioVenta;
        private Sucursal sucursal;

        public int CodProducto
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

        public Colores CodColor
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

        public Presentacion CodPresentacion
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

        public string CodigoBarras
        {
            get
            {
                return codigoBarras;
            }

            set
            {
                codigoBarras = value;
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

        public Proveedor CodProveedor
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

        public Sucursal Sucursal
        {
            get
            {
                return sucursal;
            }

            set
            {
                sucursal = value;
            }
        }
    }
}
