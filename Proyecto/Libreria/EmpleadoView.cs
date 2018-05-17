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
            RolUsuario ru = new RolUsuario();
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
            ru.IdRolUsuario = int.Parse(txtRol.Text);
            obj.IdRol = ru;
            obj.Comision = decimal.Parse(txtComision.Text);
            return obj;
        }

        private void dtgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            txtName.Text = dtgEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(" ", "");
            txtDireccion.Text = dtgEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(" ", "");
            txtCargo.Text = dtgEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(" ", "");
            txtTelefono.Text = dtgEmpleados.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(" ", "");
            txtCel.Text = dtgEmpleados.Rows[e.RowIndex].Cells[5].Value.ToString().Replace(" ", "");
            txtUsuario.Text = dtgEmpleados.Rows[e.RowIndex].Cells[6].Value.ToString().Replace(" ", "");
            txtClave.Text = dtgEmpleados.Rows[e.RowIndex].Cells[7].Value.ToString().Replace(" ", "");
            txtRol.Text = dtgEmpleados.Rows[e.RowIndex].Cells[8].Value.ToString().Replace(" ", "");
            txtComision.Text = dtgEmpleados.Rows[e.RowIndex].Cells[9].Value.ToString().Replace(" ", "");
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                addEmpleado(llenarEmpleado(false));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                updateEmpleado(llenarEmpleado(true));
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    deleteEmpleado(int.Parse(txtId.Text.Replace(" ", "")));
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Ocurrio un problema, favor intentar mas tarde");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
