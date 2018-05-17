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
    public partial class ClienteView : FormTemplate
    {
        ClienteService clS = null;
        Clientes cl = null;
        public ClienteView()
        {
            InitializeComponent();
            allClient();//llamando al método para llenar DataGridView
        }
        /**
         * Método para cargar todos los clientes de la base
         * **/
        public void allClient() {
            clS = new ClienteService();
           dtgClientes.DataSource = clS.allCliente();
        }

        /**
         * Método para insertar clientes en la base
         * **/
        private void addCliente(Clientes cliente) {
          MessageBox.Show(clS.insert(cliente));
            allClient();
            limpiar();
        }

        /**
         * Método para modificar clientes en la base
         * **/
        private void updateCliente(Clientes cliente)
        {
            MessageBox.Show(clS.update(cliente));
            allClient();
            limpiar();
        }

        /**
         * Método para eliminar clientes en la base
         * **/
        private void deleteCliente(int cliente)
        {
            MessageBox.Show(clS.delete(cliente));
            allClient();
            limpiar();
        }

        public override void limpiar()
        {
            txtId.Text = "";
            txtPName.Text = "";
            txtSName.Text = "";
            txtPAplellido.Text = "";
            txtSApellido.Text = "";
            txtDireccion.Text = "";
            txtNIT.Text = "";
            txtNRC.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
        }
        private Boolean validate() {
            if ("".Equals(txtPName.Text)||
            "".Equals(txtSName.Text)||
            "".Equals(txtPAplellido.Text)||
            "".Equals(txtSApellido.Text)||
            "".Equals(txtDireccion.Text)||
            "".Equals(txtNIT.Text)||
            "".Equals(txtNRC.Text)||
            "".Equals(txtTelefono.Text)||
            "".Equals(txtCelular.Text)) {
                return true;
            }
            return false;
        }

        private Clientes llenarCliente(Boolean v)
        {
            Clientes obj = new Clientes();
            if (v)
                obj.CodCliente = int.Parse(txtId.Text);
            obj.PNombre = txtPName.Text;
            obj.SNombre = txtSName.Text;
            obj.PApellido = txtPAplellido.Text;
            obj.SApellido = txtSApellido.Text;
            obj.Direccion = txtDireccion.Text;
            obj.Nit = txtNIT.Text;
            obj.Nrc = txtNRC.Text;
            obj.Telefono = txtTelefono.Text;
            obj.Celular = txtCelular.Text;
            return obj;
        }

        private void dtgClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgClientes.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ","");
            txtPName.Text = dtgClientes.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(" ", "");
            txtSName.Text = dtgClientes.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(" ", "");
            txtPAplellido.Text = dtgClientes.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(" ", "");
            txtSApellido.Text = dtgClientes.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(" ", "");
            txtDireccion.Text = dtgClientes.Rows[e.RowIndex].Cells[5].Value.ToString().Replace(" ", "");
            txtNIT.Text = dtgClientes.Rows[e.RowIndex].Cells[6].Value.ToString().Replace(" ", "");
            txtNRC.Text = dtgClientes.Rows[e.RowIndex].Cells[7].Value.ToString().Replace(" ", "");
            txtTelefono.Text = dtgClientes.Rows[e.RowIndex].Cells[8].Value.ToString().Replace(" ", "");
            txtCelular.Text = dtgClientes.Rows[e.RowIndex].Cells[9].Value.ToString().Replace(" ", "");
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                addCliente(llenarCliente(false));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (!validate())
            {
                updateCliente(llenarCliente(true));
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                	deleteCliente(int.Parse(txtId.Text.Replace(" ", "")));
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
