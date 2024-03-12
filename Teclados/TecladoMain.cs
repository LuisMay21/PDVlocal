using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta.Teclados
{
    public partial class TecladoMain : Form
    {
        PDVform refer;
       
        public TecladoMain(PDVform refer)
        {
            InitializeComponent();
            this.refer = refer;
        }

        private void ProdBtn_Click(object sender, EventArgs e)
        {
            Button BtnClick = sender as Button;

            String opcion = BtnClick.Text;

            this.Close();


            switch (opcion)
            {

                case "Molida":
                    this.refer.AbrirTeclado(new TecaldoNum(this.refer));
                    break;


                case "Pollo":
                        this.refer.AbrirTeclado(new TecaldoNum(this.refer));
                    break;


                case "Chaya":
                    this.refer.AbrirTeclado(new TecaldoNum(this.refer));
                    break;

                case "Espelon":
                    this.refer.AbrirTeclado(new TecaldoNum(this.refer));
                    break;

                case "Colados":
                    this.refer.AbrirTeclado(new TecaldoNum(this.refer));
                    break;

                case "Horneados":
                    this.refer.AbrirTeclado(new TecaldoNum(this.refer));
                    break;

                case "Tobiholoch":
                    this.refer.AbrirTeclado(new TecaldoNum(this.refer));
                    break;

                case "Brazos":
                    this.refer.AbrirTeclado(new TecaldoNum(this.refer));
                    break;
            }










        }
    }
}
