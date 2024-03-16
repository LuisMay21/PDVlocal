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


            if (opcion=="Otros")
            {



            }
            else
            {

                refer.AbrirTeclado(new TecaldoNum(refer));

                switch (opcion)
                {

                    case "Molida":

                        break;


                    case "Pollo":

                        break;


                    case "Chaya":

                        break;

                    case "Espelon":


                    case "Colados":

                        break;

                    case "Horneados":

                        break;

                    case "Tobiholoch":

                        break;

                    case "Brazos":

                        break;
                }


            }







        }
    }
}
