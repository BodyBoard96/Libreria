namespace Model
{
    public class Producto
    {
        private int codProducto;
        private int codColor;
        private int codPresentacion;
        private string codigoBarras;
        private string nombreProducto;
        private decimal precioCompra;
        private int codProveedor;
        private decimal precioVenta;
        private int sucursal;

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

        public int CodColor
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

        public int CodPresentacion
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

        public int CodProveedor
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

        public int Sucursal
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
