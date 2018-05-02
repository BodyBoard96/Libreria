namespace Model
{
    public class Tmp
    {
        private Producto codProducto;
        private Colores codColor;
        private Presentacion codPresentacion;
        private decimal val;
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

        public decimal Val
        {
            get
            {
                return val;
            }

            set
            {
                val = value;
            }
        }
    }
}
