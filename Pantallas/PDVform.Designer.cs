namespace Punto_De_Venta
{
    partial class PDVform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage1 = new TabPage();
            ContenedorProductos = new TabControl();
            tabPage2 = new TabPage();
            PanelTeclado = new Panel();
            ContenedorProductos.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1059, 827);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ContenedorProductos
            // 
            ContenedorProductos.Controls.Add(tabPage1);
            ContenedorProductos.Controls.Add(tabPage2);
            ContenedorProductos.Location = new Point(837, 12);
            ContenedorProductos.Name = "ContenedorProductos";
            ContenedorProductos.SelectedIndex = 0;
            ContenedorProductos.Size = new Size(1067, 855);
            ContenedorProductos.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1059, 827);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelTeclado
            // 
            PanelTeclado.Location = new Point(12, 12);
            PanelTeclado.Name = "PanelTeclado";
            PanelTeclado.Size = new Size(819, 855);
            PanelTeclado.TabIndex = 4;
            // 
            // PDVform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1916, 879);
            Controls.Add(PanelTeclado);
            Controls.Add(ContenedorProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PDVform";
            Text = "PDVform";
            ContenedorProductos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private TabControl ContenedorProductos;
        private TabPage tabPage2;
        private Panel PanelTeclado;
    }
}