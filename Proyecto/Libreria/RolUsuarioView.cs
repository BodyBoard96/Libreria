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
    public partial class RolUsuarioView : FormTemplate
    {
       
        RolUsuarioServices clS = null;
        RolUsuario cl = null;
        public RolUsuarioView()
        {
            InitializeComponent();
            allUsuario();
        }
        public void allUsuario()
        {
            clS = new RolUsuarioServices();
            dtgRolUsuario.DataSource = clS.allUsuario();
        }
        /**
         * Método para insertar Rolusuario en la base
         * **/
        private void addRolUsuario(RolUsuario Usuario)
        {
            MessageBox.Show(clS.insert(Usuario));
            allUsuario();
            limpiar();
        }
        /**
         * Método para modificar Rolusuario en la base
         * **/
        private void updateRolUsuario(RolUsuario Usuario)
        {
            MessageBox.Show(clS.update(Usuario));
            allUsuario();
            limpiar();
        }
        /**
         * Método para eliminar proveedores en la base
         * **/
        private void deleteRolUsuario(int Usuario)
        {
            MessageBox.Show(clS.delete(Usuario));
            allUsuario();
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
            cmbRol.SelectedValue = "";
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
           "".Equals(txtClave.Text) 
            {
                return true;
            }
            return false;
        }
        private RolUsuario llenarUsuarioo(Boolean v)
        {
            RolUsuario obj = new RolUsuario();
            if (v)
                obj.CodEmpleado = int.Parse(txtId.Text);
            obj.Nombre = txtName.Text;
            obj.Direccion = txtDireccion.Text;
            obj.Cargo = txtCargo.Text;
            obj.Telefono = txtTelefono.Text;
            obj.Celular = txtCel.Text;
            obj.Usuario = txtUsuario.Text;
            obj.Password = txtClave.Text;
          
            return obj;
        }

        private void dtgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgRolUsuario.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            txtName_Prov.Text = dtgRolUsuario.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(" ", "");
            txtName_ejec.Text = dtgRolUsuario.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(" ", "");
            txtNRC.Text = dtgRolUsuario.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(" ", "");
            txtNIT.Text = dtgRolUsuario.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(" ", "");
            txtDirec_Prov.Text = dtgRolUsuario.Rows[e.RowIndex].Cells[5].Value.ToString().Replace(" ", "");
            txtTelefono.Text = dtgRolUsuario.Rows[e.RowIndex].Cells[6].Value.ToString().Replace(" ", "");
            txtCel.Text = dtgRolUsuario.Rows[e.RowIndex].Cells[7].Value.ToString().Replace(" ", "");
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                addRolUsuario(llenarUsuario(false));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                updateRolUsuario(llenarUsuario(true));
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el Rol de usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    deleteRolUsuario(int.Parse(txtId.Text.Replace(" ", "")));
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
