using System;

namespace Model
{
    public class Empleado
    {
        private int codEmpleado;
        private String nombre;
        private String direccion;
        private String cargo;
        private String telefono;
        private String celular;
        private String usuario;
        private String password;
        private RolUsuario idRol;
        private decimal comision;

        public int CodEmpleado
        {
            get { return codEmpleado; }
            set { codEmpleado = value; }
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

        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
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

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public RolUsuario IdRol
        {
            get
            {
                return idRol;
            }

            set
            {
                idRol = value;
            }
        }

        public decimal Comision
        {
            get
            {
                return comision;
            }

            set
            {
                comision = value;
            }
        }
    }
}
