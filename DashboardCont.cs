using Punto_De_Venta.Pantallas;
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
    public partial class DashboardCont : Form
    {
        Login L1;
        int BtnOutChk = 0;


        public DashboardCont(Login L1)
        {
            InitializeComponent();
            AbrirForm(new PDVform());
            this.L1 = L1;

        }





        private void Logout_Click(object sender, EventArgs e)
        {
            BtnOutChk = 1;
            this.Close();

            L1.Show();
        }




        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Verifica si el formulario se está cerrando debido a la acción del usuario (haciendo clic en el botón de cierre)
            if ((e.CloseReason == CloseReason.UserClosing) && (BtnOutChk == 0))
            {


                // Pregunta al usuario si está seguro de que quiere cerrar el programa
                DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar el programa?", "Cerrar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                // Si el usuario elige "No", cancela el cierre del formulario
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    MessageBox.Show("Estado  :" + result);
                }
                else
                {
                    L1.Close();
                }

            }
        }

        private void AbrirForm(object FormChild)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FH = FormChild as Form;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FH);
            this.PanelContenedor.Tag = FH;
            FH.Show();

        }

        private void VentasBtn_Click(object sender, EventArgs e)
        {

            AbrirForm(new PDVform());
        }

        private void InventarioBtn_Click(object sender, EventArgs e)
        {
            AbrirForm(new InventarioForm());
        }
    }
}
