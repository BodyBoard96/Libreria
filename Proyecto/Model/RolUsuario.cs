 using System;
namespace Model
{
    public class RolUsuario
    {
        private int idRolUsuario; 
        private string nombreRol;
        private string codigo;
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

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
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
