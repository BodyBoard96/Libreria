namespace Model
{
    public class TpIVA
    {
        private int codIVA;
        private decimal tpiva;
        private decimal cantidad;
        public int CodIVA
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

        public decimal Tpiva
        {
            get
            {
                return tpiva;
            }

            set
            {
                tpiva = value;
            }
        }

        public decimal Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
    }
}
