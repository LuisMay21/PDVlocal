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
    public partial class OtrosTam : Form
    {
        PDVform refer;
        public OtrosTam(PDVform refer)
        {
            InitializeComponent();
            this.refer = refer;
        }

        private void OtrosBtn_Click(object sender, EventArgs e)
        {
            Button BtnClick = sender as Button;
            String opcion = BtnClick.Text;

            if (opcion == "Regresar")
            {
                refer.AbrirTeclado(new TecladoMain(refer));
            }
            else
            {

               

                switch (opcion)
                {

                    case "Chaya Chico":

                        break;


                    case "Molida Chico":

                        break;


                    case "Lata Grande":

                        break;

                    case "Espelon Chico":


                    case "Pollo Chico":

                        break;

                    case "Pollo en salsa Verde":

                        break;

                    case "Rajas con Queso":

                        break;

                    case "Dulce de Fresa":

                        break;


                }


                refer.AbrirTeclado(new TecaldoNum(refer, opcion));

                

            }


            this.Close();
        }
    }
}
