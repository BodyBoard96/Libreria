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
    public partial class Index : Form
    {
        private int childFormNumber = 0;
        private Empleado emp= null;

        public Empleado Emp
        {
            get
            {
                return emp;
            }

            set
            {
                emp = value;
            }
        }

        public Index(Empleado ep)
        {
            InitializeComponent();
            this.Emp = ep;
            lblEmpleado.Text = "Empleado: "+emp.Nombre+"  Cargo: "+emp.Cargo;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClienteView frmCl = new ClienteView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorView frmCl = new ColorView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoView frmCl = new EmpleadoView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void presentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentacionView frmCl = new PresentacionView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoView frmCl = new ProductoView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorView frmCl = new ProveedorView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void rolUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolUsuarioView frmCl = new RolUsuarioView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SucursalView frmCl = new SucursalView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void tipoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoPagoView frmCl = new TipoPagoView();
            frmCl.MdiParent = this;
            frmCl.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturarView frm = new FacturarView();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
