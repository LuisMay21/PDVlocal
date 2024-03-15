namespace Punto_De_Venta
{
    partial class DashboardCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCont));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            InventarioBtn = new Button();
            VentasBtn = new Button();
            PanelContenedor = new Panel();
            Logout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(InventarioBtn);
            panel1.Controls.Add(VentasBtn);
            panel1.Controls.Add(PanelContenedor);
            panel1.Controls.Add(Logout);
            panel1.Name = "panel1";
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // InventarioBtn
            // 
            resources.ApplyResources(InventarioBtn, "InventarioBtn");
            InventarioBtn.Name = "InventarioBtn";
            InventarioBtn.UseVisualStyleBackColor = true;
            InventarioBtn.Click += InventarioBtn_Click;
            // 
            // VentasBtn
            // 
            resources.ApplyResources(VentasBtn, "VentasBtn");
            VentasBtn.Name = "VentasBtn";
            VentasBtn.UseVisualStyleBackColor = true;
            VentasBtn.Click += VentasBtn_Click;
            // 
            // PanelContenedor
            // 
            resources.ApplyResources(PanelContenedor, "PanelContenedor");
            PanelContenedor.Name = "PanelContenedor";
            // 
            // Logout
            // 
            resources.ApplyResources(Logout, "Logout");
            Logout.Name = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // DashboardCont
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardCont";
            FormClosing += MainForm_FormClosing;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Logout;
        private Panel PanelContenedor;
        private Button Ventas;
        private Button button4;
        private Button button3;
        private Button InventarioBtn;
        private Button VentasBtn;
    }
}