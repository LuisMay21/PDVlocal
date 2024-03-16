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
            PanelTeclado = new Panel();
            ContenedorProductos = new TabControl();
            NewPage = new Button();
            EliminarPage = new Button();
            SuspendLayout();
            // 
            // PanelTeclado
            // 
            PanelTeclado.Location = new Point(12, 12);
            PanelTeclado.Name = "PanelTeclado";
            PanelTeclado.Size = new Size(819, 855);
            PanelTeclado.TabIndex = 4;
            // 
            // ContenedorProductos
            // 
            ContenedorProductos.Location = new Point(837, 12);
            ContenedorProductos.Name = "ContenedorProductos";
            ContenedorProductos.SelectedIndex = 0;
            ContenedorProductos.Size = new Size(1067, 716);
            ContenedorProductos.TabIndex = 3;
            ContenedorProductos.TabStop = false;
            // 
            // NewPage
            // 
            NewPage.Location = new Point(837, 734);
            NewPage.Name = "NewPage";
            NewPage.Size = new Size(110, 41);
            NewPage.TabIndex = 5;
            NewPage.Text = "Nueva Nota";
            NewPage.UseVisualStyleBackColor = true;
            NewPage.Click += NewPage_Click;
            // 
            // EliminarPage
            // 
            EliminarPage.Location = new Point(969, 734);
            EliminarPage.Name = "EliminarPage";
            EliminarPage.Size = new Size(110, 41);
            EliminarPage.TabIndex = 6;
            EliminarPage.Text = "Eliminar Nota";
            EliminarPage.UseVisualStyleBackColor = true;
            EliminarPage.Click += EliminarPage_Click;
            // 
            // PDVform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1916, 879);
            Controls.Add(EliminarPage);
            Controls.Add(NewPage);
            Controls.Add(PanelTeclado);
            Controls.Add(ContenedorProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PDVform";
            Text = "PDVform";
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelTeclado;
        private TabControl ContenedorProductos;
        private Button NewPage;
        private Button EliminarPage;
    }
}