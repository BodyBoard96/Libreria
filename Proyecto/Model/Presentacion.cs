namespace Model
{
    public class Presentacion
    {
        private int codPresentacion;
        private string descripcion;
        private decimal cantidadUnidad;

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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public decimal CantidadUnidad
        {
            get
            {
                return cantidadUnidad;
            }

            set
            {
                cantidadUnidad = value;
            }
        }
    }
}
