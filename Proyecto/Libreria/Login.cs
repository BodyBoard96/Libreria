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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!"".Equals(txtUser.Text) && !"".Equals(txtPassword.Text))
            {
                LoginService lg = new LoginService();
                Empleado emp = lg.validate(txtUser.Text, txtPassword.Text);
                if (emp != null)
                {
                    Index main = new Index(emp);
                    main.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Contraseña o Usuario incorrecto");
                }
            }
            else {
                MessageBox.Show("Contraseña y Usuario requeridos");
            }
        }
    }
}
