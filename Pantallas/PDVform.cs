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
        int ContadorDeNotas = 0;
        public PDVform()
        {
            InitializeComponent();

            AbrirTeclado(new TecladoMain(this));
            ContenedorProductos.TabPages.Add(CrearTab());

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











        public TabPage CrearTab() //
        {
            ContadorDeNotas++;
            string nombreNota = "Nota " + ContadorDeNotas;
            TabPage tabPage = new TabPage();
            tabPage.Text = nombreNota;
            tabPage.BackColor = System.Drawing.Color.LightGray;
            tabPage.TabIndex = ContadorDeNotas;
            tabPage.Controls.Add(CrearGrid());
            ContenedorProductos.SelectedTab = tabPage;
            return tabPage;
        }


        public DataGridView CrearGrid()
        {
            DataGridView grid = new DataGridView();
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(3, 3);
            grid.Name = "dataGridView1";
            grid.ReadOnly = true;
            grid.Size = new Size(1053, 821);
            grid.TabIndex = 0;
            return grid;

        }







        private void NewPage_Click(object sender, EventArgs e)
        {
            ContenedorProductos.TabPages.Add(CrearTab());
        }

       
        private void EliminarPage_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quiere Borrar la "+ContenedorProductos.SelectedTab.Text+"?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {

                if (ContenedorProductos.SelectedTab != null)
                {

                    TabPage paginaActiva = ContenedorProductos.SelectedTab;

                    foreach (Control control in paginaActiva.Controls)
                    { control.Dispose(); }

                    ContenedorProductos.TabPages.Remove(paginaActiva);
                    paginaActiva.Dispose();
                }
            }

        }
    }

}
