using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class EmpleadoView : FormTemplate
    {
        EmpleadoService clS = null;
        Empleado cl = null;
        public EmpleadoView()
        {
            InitializeComponent();
            allEmpleado();//llamando al método para llenar DataGridView
        }
        /**
        * Método para cargar todos los Empleados de la base
        * **/
        public void allEmpleado()
        {
            clS = new EmpleadoService();
            dtgEmpleados.DataSource = clS.allEmpleado();
        }
        /**
         * Método para insertar empleados en la base
         * **/
        private void addEmpleado(Empleado empleado)
        {
            MessageBox.Show(clS.insert(empleado));
            allEmpleado();
            limpiar();
        }
        /**
         * Método para modificar empleados en la base
         * **/
        private void updateEmpleado(Empleado empleado)
        {
            MessageBox.Show(clS.update(empleado));
            allEmpleado();
            limpiar();
        }
        /**
         * Método para eliminar empleados en la base
         * **/
        private void deleteEmpleado(int empleado)
        {
            MessageBox.Show(clS.delete(empleado));
            allEmpleado();
            limpiar();
        }

        public override void limpiar()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDireccion.Text = "";
            txtCargo.Text = "";
            txtTelefono.Text = "";
            txtCel.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtRol.Text = "";
            txtComision.Text = "";
        }

        private Boolean validate()
        {
            if ("".Equals(txtName.Text) ||
            "".Equals(txtDireccion.Text) ||
            "".Equals(txtCargo.Text) ||
            "".Equals(txtTelefono.Text) ||
            "".Equals(txtCel.Text) ||
            "".Equals(txtUsuario.Text) ||
            "".Equals(txtClave.Text) ||
            "".Equals(txtRol.Text) ||
            "".Equals(txtComision.Text))
            {
                return true;
            }
            return false;
        }

        private Empleado llenarEmpleado(Boolean v)
        {
           

            Empleado obj = new Empleado();
            if (v)
                obj.CodEmpleado = int.Parse(txtId.Text);
            obj.Nombre = txtName.Text;
            obj.Direccion = txtDireccion.Text;
            obj.Cargo = txtCargo.Text;
            obj.Telefono = txtTelefono.Text;
            obj.Celular = txtCel.Text;
            obj.Usuario = txtUsuario.Text;
            obj.Password = txtClave.Text;

            obj.IdRol = RolUsuario.ReferenceEquals(txtRol.Text);
            obj.Comision = decimal.Parse(txtComision.Text);
            return obj;
        }
    }
}
