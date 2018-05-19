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
    public partial class SucursalView : FormTemplate
    {
        SucursalService clS = null;
        Sucursal cl = null;
        public SucursalView()
        {
            InitializeComponent();
            allSucursal();//llamando al método para llenar DataGridView
        }
        /**
        * Método para cargar todas las sucursales de la base
        * **/
        public void allSucursal()
        {
            clS = new SucursalService();
            dtgSucursal.DataSource = clS.allSucursales();
        }
        /**
         * Método para insertar sucursales en la base
         * **/
        private void addSucursal(Sucursal sucursal)
        {
            MessageBox.Show(clS.insert(sucursal));
            allSucursal();
            limpiar();
        }
        /**
         * Método para modificar sucursales en la base
         * **/
        private void updateSucursal(Sucursal sucursal)
        {
            MessageBox.Show(clS.update(sucursal));
            allSucursal();
            limpiar();
        }
        /**
         * Método para eliminar sucursales en la base
         * **/
        private void deleteSucursal(int sucursal)
        {
            MessageBox.Show(clS.delete(sucursal));
            allSucursal();
            limpiar();
        }
        public override void limpiar()
        {
            txtId.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }
        private Boolean validate()
        {
            if ("".Equals(txtDireccion.Text) ||
            "".Equals(txtTelefono.Text) ||
            "".Equals(txtCorreo.Text))
            {
                return true;
            }
            return false;
        }
        private Sucursal llenarSucursal(Boolean v)
        {
            Sucursal obj = new Sucursal();
            if (v)
                obj.CodSucursal = int.Parse(txtId.Text);
            obj.Direccion = txtDireccion.Text;
            obj.Telefono = txtTelefono.Text;
            obj.Email = txtCorreo.Text;
            return obj;
        }
        private void dtgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgSucursal.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            txtDireccion.Text = dtgSucursal.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(" ", "");
            txtTelefono.Text = dtgSucursal.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(" ", "");
            txtCorreo.Text = dtgSucursal.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(" ", "");
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                addSucursal(llenarSucursal(false));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                updateSucursal(llenarSucursal(true));
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
                    deleteSucursal(int.Parse(txtId.Text.Replace(" ", "")));
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
