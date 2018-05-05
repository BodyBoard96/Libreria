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
using Controller;

namespace Libreria
{
    public partial class ColorView : FormTemplate
    {
        private ColoresService colorService = new ColoresService();
        public ColorView()
        {
            InitializeComponent();
            llenar();
        }
        private void llenar() {
            dtgColores.DataSource = new ColoresService().allColores();
        }
        private void insertar(Colores cl) {
            MessageBox.Show(colorService.insert(cl));
            llenar();
            limpiar();
        }
        public override void limpiar() {
            txtColor.Text = "";
            txtCodColor.Text = "";
        }
        
        private void modificar(Colores cl)
        {
            MessageBox.Show(colorService.update(cl));
            llenar();
            limpiar();
        }

        private void eliminar(int cl)
        {
            MessageBox.Show(colorService.delete(cl));
            llenar();
            limpiar();
        }

        private Boolean validate()
        {
            if ("".Equals(txtColor.Text))
            {
                return true;
            }
            return false;
        }

        private Colores llenarColores(Boolean v)
        {
            Colores obj = new Colores();
            if (v)
                obj.CodColor= int.Parse(txtCodColor.Text);
            obj.Color = txtColor.Text;
            return obj;
        }
        private void ColorView_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                insertar(llenarColores(false));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                modificar(llenarColores(true));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    eliminar(int.Parse(txtCodColor.Text.Replace(" ", "")));
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

        private void dtgColores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodColor.Text = dtgColores.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            txtColor.Text = dtgColores.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(" ", "");
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }
    }
}
