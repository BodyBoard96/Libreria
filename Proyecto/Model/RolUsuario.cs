 using System;
namespace Model
{
    public class RolUsuario
    {
        private int idRolUsuario; 
        private string nombreRol;
        public int IdRolUsuario
        {
            get
            {
                return idRolUsuario;
            }

            set
            {
                idRolUsuario = value;
            }
        }

        public string NombreRol
        {
            get
            {
                return nombreRol;
            }

            set
            {
                nombreRol = value;
            }
        }
    }
}
