using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Punto_De_Venta.Teclados
{
    public partial class TecaldoNum : Form
    {

        PDVform refer;
        public TecaldoNum(PDVform refer, String a)
        {
            String b = a;
            InitializeComponent();
            this.refer = refer;
            TamTipolb.Text = b;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
            refer.AbrirTeclado(new TecladoMain(this.refer));
        }
        private void AddBtn_Click(Object sender, EventArgs e)
        {
            System.Windows.Forms.Button BtnClick = sender as System.Windows.Forms.Button;

            CantTamtxt.Text += BtnClick.Text;
        }


        private void DelBtn_Click(Object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CantTamtxt.Text))
            {
                // Eliminar el último carácter del TextBox
                CantTamtxt.Text = CantTamtxt.Text.Remove(CantTamtxt.Text.Length - 1);
            }
        }
    }
}
