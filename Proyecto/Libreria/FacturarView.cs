using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace Libreria
{
    public partial class FacturarView : Form
    {
        public FacturarView()
        {
            InitializeComponent();
            cmbClientes.DataSource = new ClienteService().allCliente();
            cmbClientes.DisplayMember = "PNombre";
            cmbClientes.ValueMember = "PNombre";
        }
    }
}
