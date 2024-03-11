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
    public partial class TecaldoNum : Form
    {

        PDVform refer;
        public TecaldoNum(PDVform refer)
        {
            InitializeComponent();
            this.refer = refer;
        }

        private void NumerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
            refer.AbrirTeclado(new TecladoMain(this.refer));
        }
    }
}
