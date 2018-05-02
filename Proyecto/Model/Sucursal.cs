namespace Model
{
    public class Sucursal
    {
        private int codSucursal;
        private string direccion;
        private string telefono;
        private string email;

        public int CodSucursal
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

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
