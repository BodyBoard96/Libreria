namespace Model
{
    public class Proveedor
    {
        private int codProveedor;
        private string nombre;
        private string nombreEjecutivo;
        private string nrc;
        private string nit;
        private string direccionProveedor;
        private string telefono;
        private string celularEjecutivo;

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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string NombreEjecutivo
        {
            get
            {
                return nombreEjecutivo;
            }

            set
            {
                nombreEjecutivo = value;
            }
        }

        public string Nrc
        {
            get
            {
                return nrc;
            }

            set
            {
                nrc = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string DireccionProveedor
        {
            get
            {
                return direccionProveedor;
            }

            set
            {
                direccionProveedor = value;
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

        public string CelularEjecutivo
        {
            get
            {
                return celularEjecutivo;
            }

            set
            {
                celularEjecutivo = value;
            }
        }
    }
}
