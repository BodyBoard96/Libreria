namespace Model
{
    public class EstadoFactura
    {
        private int codEstado;
        private string estado;
        public int CodEstado
        {
            get
            {
                return codEstado;
            }

            set
            {
                codEstado = value;
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
