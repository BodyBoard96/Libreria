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
    public partial class PresentacionView : FormTemplate
    {
        PresentacionService clS = null;
        Presentacion cl = null;
        public PresentacionView()
        {
            InitializeComponent();
            allPresentacion();//llamando al método para llenar DataGridView
        }

         /**
         * Método para cargar todos los presentacion de la base
         * **/
        public void allPresentacion()
        {
            clS = new PresentacionService();
            dtgPresentacion.DataSource = clS.allSucursales();

        }


        /**
         * Método para insertar presentacion en la base
         * **/
        private void addPresentacion(Presentacion pre)
        {
            MessageBox.Show(clS.insert(pre));
            allPresentacion();
            limpiar();
        }

        /**
        * Método para modificar presentacion en la base
        * **/
        private void updatePresentacion(Presentacion pre)
        {
            MessageBox.Show(clS.update(pre));
            allPresentacion();
            limpiar();
        }

        /**
         * Método para eliminar presentacion en la base
         * **/
        private void deletePresentacion(int pre)
        {
            MessageBox.Show(clS.delete(pre));
            allPresentacion();
            limpiar();
        }

        public override void limpiar()
        {
            txtcod_pre.Text = "";
            txtdescripcion_pre.Text = "";
            txtcan_uni_pre.Text = "";

        }
        private Boolean validate()
        {
            if ("".Equals(txtcod_pre.Text) ||
            "".Equals(txtdescripcion_pre.Text) ||
            "".Equals(txtcan_uni_pre.Text))
            {
                return true;
            }
            return false;
        }

        private Clientes llenarPresentacion(Boolean v)
        {
            Presentacion obj = new Presentacion();
            if (v)
                obj.cod_pre = int.Parse(txCod_pre.Text);
            obj.Descripcion = txtdescripcion_pre.Text;
            obj.Can_uni_pro = txtcan_uni_pre.Text = "";


            return obj;
        }

        private void dtgPresentacion_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtcod_pre.Text = dtgPresentacion.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            txtdescripcion_pre.Text.Text = dtgPresentacion.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(" ", "");
            txtcan_uni_pre.Text = dtgPresentacion.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(" ", "");
           
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                addPresentacion(llenarPresentacion(false));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (!validate())
            {
                updatePresentacion(llenarPresentacion(true));
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el pago?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    deletePresentacion(int.Parse(txtId.Text.Replace(" ", "")));
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
