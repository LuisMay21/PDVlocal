using Punto_De_Venta.Teclados;
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
    public partial class PDVform : Form
    {
        public PDVform()
        {
            InitializeComponent();
            AbrirTeclado(new TecladoMain(this));

        }



        public void AbrirTeclado(object FormChild)
        {
            if (this.PanelTeclado.Controls.Count > 0)
                this.PanelTeclado.Controls.RemoveAt(0);
            Form FH = FormChild as Form;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;
            this.PanelTeclado.Controls.Add(FH);
            this.PanelTeclado.Tag = FH;
            FH.Show();

        }



    }

}
