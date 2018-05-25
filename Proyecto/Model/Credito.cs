namespace Model
{
    public class Credito
    {
        //Prueba desde github
        private int codigoCredito;
        private string codFactura;
        private int codCliente;
        private decimal total;
        private decimal abono;
        private decimal saldo;
        private string estado;
        public int CodigoCredito
        {
            get
            {
                return codigoCredito;
            }

            set
            {
                codigoCredito = value;
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

        internal int CodCliente
        {
            get
            {
                return codCliente;
            }

            set
            {
                codCliente = value;
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

        public decimal Abono
        {
            get
            {
                return abono;
            }

            set
            {
                abono = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
