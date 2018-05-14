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
    public partial class EmpleadoView : FormTemplate
    {
        EmpleadoService clS = null;
        Empleado cl = null;
        public EmpleadoView()
        {
            InitializeComponent();
            allEmpleado();//llamando al método para llenar DataGridView
        }
        /**
        * Método para cargar todos los Empleados de la base
        * **/
        public void allEmpleado()
        {
            clS = new EmpleadoService();
            dtgEmpleados.DataSource = clS.allEmpleado();
        }
        /**
         * Método para insertar empleados en la base
         * **/
        private void addEmpleado(Empleado empleado)
        {
            MessageBox.Show(clS.insert(empleado));
            allEmpleado();
            limpiar();
        }
        /**
         * Método para modificar empleados en la base
         * **/
        private void updateEmpleado(Empleado empleado)
        {
            MessageBox.Show(clS.update(empleado));
            allEmpleado();
            limpiar();
        }
    }
}
