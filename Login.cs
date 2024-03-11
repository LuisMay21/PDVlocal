using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DashboardCont dh = new DashboardCont(this);
            dh.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si el formulario se está cerrando debido a la acción del usuario (haciendo clic en el botón de cierre)
            if (e.CloseReason == CloseReason.UserClosing)
            {

            }
            else 
            {
                e.Cancel = true;
            }
        }
    }
}
