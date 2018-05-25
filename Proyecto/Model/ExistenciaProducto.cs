namespace Model
{
    public class ExistenciaProducto
    {
        private int codProducto;
        private int codColor;
        private int codPresentacion;
        private string codBarras;
        private int existencia;
        private decimal precioVenta;
        private int codSucursal;

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

        internal int CodSucursal
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
