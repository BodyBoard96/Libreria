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
    public partial class ProductoView : FormTemplate
    {
        ProductoService clS = null;
        Producto cl = null;

        public ProductoView()
        {
            InitializeComponent();
            allProducto();//llamando al método para llenar DataGridView
        }
        /**
        * Método para cargar todos los Productos de la base
        * **/
        public void allProducto()
        {
            clS = new ProductoService();
            dtgProductos.DataSource = clS.allProducto();
        }
        /**
         * Método para insertar productos en la base
         * **/
        private void addProducto(Producto producto)
        {
            MessageBox.Show(clS.insert(producto));
            allProducto();
            limpiar();
        }
        /**
         * Método para modificar productos en la base
         * **/
        private void updateProducto(Producto producto)
        {
            MessageBox.Show(clS.update(producto));
            allProducto();
            limpiar();
        }
        /**
         * Método para eliminar productos en la base
         * **/
        private void deleteProducto(int producto)
        {
            MessageBox.Show(clS.delete(producto));
            allProducto();
            limpiar();
        }
        public override void limpiar()
        {
            txtId.Text = "";
            cmbCod_Color.Text = "";
            txtCod_presentacion.Text = "";
            txtNombre_Producto.Text = "";
            txtPre_compra.Text = "";
            cmbCod_Prov.Text = "";
            txtPrecio_venta.Text = "";
            CmbCod_sucursal.Text = "";
        }
        private Boolean validate()
        {
            if ("".Equals(cmbCod_Color.Text) ||
            "".Equals(txtCod_presentacion.Text) ||
            "".Equals(txtNombre_Producto.Text) ||
            "".Equals(txtPre_compra.Text) ||
            "".Equals(cmbCod_Prov.Text) ||
            "".Equals(txtPrecio_venta.Text) ||
            "".Equals(CmbCod_sucursal.Text))
            {
                return true;

            }
            return false;
        }
        private Producto llenarProducto(Boolean v)
        {
            Producto obj = new Producto();
            if (v)
                obj.CodProducto = int.Parse(txtId.Text);
            obj.CodColor = txtCod_color.Text;
            obj.CodPresentacion = txtDireccion.Text;
            obj.CodigoBarras = txtCargo.Text;
            obj.NombreProducto = txtTelefono.Text;
            obj.PrecioCompra = txtCel.Text;
            obj.CodProveedor = txtUsuario.Text;
            obj.PrecioVenta = txtClave.Text;
            obj.Sucursal = int.Parse(txtRol.Text);
            return obj;
        }
    }
}
