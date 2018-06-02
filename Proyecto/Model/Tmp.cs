namespace Model
{
    public class Tmp
    {
        private int codProducto;
        private int codColor;
        private int codPresentacion;
        private decimal val;
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
