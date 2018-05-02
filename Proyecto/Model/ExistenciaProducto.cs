namespace Model
{
    public class ExistenciaProducto
    {
        private Producto codProducto;
        private Colores codColor;
        private Presentacion codPresentacion;
        private string codBarras;
        private int existencia;
        private decimal precioVenta;
        private Sucursal codSucursal;

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

        public string CodBarras
        {
            get
            {
                return codBarras;
            }

            set
            {
                codBarras = value;
            }
        }

        public int Existencia
        {
            get
            {
                return existencia;
            }

            set
            {
                existencia = value;
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
    }
}
