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
    public partial class ProveedorView : FormTemplate
    {
     
        ProveedorService clS = null;
        Proveedor cl = null;
        public ProveedorView()
        {
            InitializeComponent();
            allProveedor();//llamando al método para llenar DataGridView
        }
        /**
        * Método para cargar todos los proveedore de la base
        * **/
        public void allProveedor()
        {
            clS = new ProveedorService();
            dtgProveedor.DataSource = clS.allProveedor();
        }
        /**
         * Método para insertar proveedores en la base
         * **/
        private void addProveedor(Proveedor proveedor)
        {
            MessageBox.Show(clS.insert(proveedor));
            allProveedor();
            limpiar();
        }
        /**
         * Método para modificar proveedores en la base
         * **/
        private void updateProveedor(Proveedor proveedor)
        {
            MessageBox.Show(clS.update(proveedor));
            allProveedor();
            limpiar();
        }
        /**
         * Método para eliminar proveedores en la base
         * **/
        private void deleteProveedor(int proveedor)
        {
            MessageBox.Show(clS.delete(proveedor));
            allProveedor();
            limpiar();
        }
        public override void limpiar()
        {
            txtId.Text = "";
            txtName_Prov.Text = "";
            txtName_ejec.Text = "";
            txtNRC.Text = "";
            txtNIT.Text = "";
            txtDirec_Prov.Text = "";
            txtTelefono.Text = "";
            txtCel.Text = "";
        }
        private Boolean validate()
        {
            if ("".Equals(txtName_Prov.Text) ||
            "".Equals(txtName_ejec.Text) ||
            "".Equals(txtNRC.Text) ||
            "".Equals(txtNIT.Text) ||
            "".Equals(txtDirec_Prov.Text) ||
            "".Equals(txtTelefono.Text) ||
            "".Equals(txtCel.Text))
            {
                return true;
            }
            return false;
        }
        private Proveedor llenarProveedor(Boolean v)
        {
            Proveedor obj = new Proveedor();
            if (v)
                obj.CodProveedor = int.Parse(txtId.Text);
            obj.Nombre = txtName_Prov.Text;
            obj.NombreEjecutivo = txtName_ejec.Text;
            obj.Nrc = txtNRC.Text;
            obj.Nit = txtNIT.Text;
            obj.DireccionProveedor = txtDirec_Prov.Text;
            obj.Telefono = txtTelefono.Text;
            obj.CelularEjecutivo = txtCel.Text;
           return obj;
        }

        private void dtgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgProveedor.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            txtName_Prov.Text = dtgProveedor.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(" ", "");
            txtName_ejec.Text = dtgProveedor.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(" ", "");
            txtNRC.Text = dtgProveedor.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(" ", "");
            txtNIT.Text = dtgProveedor.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(" ", "");
            txtDirec_Prov.Text = dtgProveedor.Rows[e.RowIndex].Cells[5].Value.ToString().Replace(" ", "");
            txtTelefono.Text = dtgProveedor.Rows[e.RowIndex].Cells[6].Value.ToString().Replace(" ", "");
            txtCel.Text = dtgProveedor.Rows[e.RowIndex].Cells[7].Value.ToString().Replace(" ", "");
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                addProveedor(llenarProveedor(false));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                updateProveedor(llenarProveedor(true));
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
                    deleteProveedor(int.Parse(txtId.Text.Replace(" ", "")));
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
