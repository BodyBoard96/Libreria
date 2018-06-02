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
    public partial class TipoPagoView : FormTemplate
    {
        TipoPagoService clS = null;
        TipoPago cl = null;
        public TipoPagoView()
        {
            InitializeComponent();
            allTipoPago(); //llamando al método para llenar DataGridView
        }
        /**
         * Método para cargar todos los tipo pago de la base
         * **/
        public void allTipoPago()
        {
            clS = new TipoPagoService();
            dtgTipoPago.DataSource = clS.allSucursales();
        }
        /**
         * Método para insertar tipo pago en la base
         * **/
        private void addTipoPago(TipoPago Pago)
        {
            MessageBox.Show(clS.insert(Pago));
            allTipoPago();
            limpiar();
        }

        /**
         * Método para modificar tipo pago en la base
         * **/
        private void updateTipoPAgo(TipoPago Pago)
        {
            MessageBox.Show(clS.update(Pago));
            allTipoPago();
            limpiar();
        }

        /**
     * Método para eliminar tipo pago en la base
     * **/
        private void deleteTipoPago(int Pago)
        {
            MessageBox.Show(clS.delete(Pago));
            allTipoPago();
            limpiar();
        }

        public override void limpiar()
        {
            txtId.Text = "";
            txtTipo_pago.Text = "";
        }

        private Boolean validate()
        {
            if ("".Equals(txtTipo_pago.Text))
            {
                
                return true ; 
            }
            return false ;
        }

        private TipoPago llenartipo_pago(Boolean v)
        {
            TipoPago obj = new TipoPago();
            if (v)
                obj.cod_tipo_pago = int.Parse(txttipo_pago.Text)
                obj.CodigoTipoPago = txtTipo_pago.Text = "";
            return obj;
        }

        private void dtgTipoPago_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgTipoPago.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                addTipoPago(llenartipo_pago(false));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el Pago?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    deleteTipoPago(int.Parse(txtId.Text.Replace(" ", "")));
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
