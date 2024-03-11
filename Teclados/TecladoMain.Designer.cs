namespace Punto_De_Venta.Teclados
{
    partial class TecladoMain
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
            panel1 = new Panel();
            OtrosBtn = new Button();
            BrazoBtn = new Button();
            TobisBtn = new Button();
            HorneadoBtn = new Button();
            ColadosBtn = new Button();
            EspelonBtn = new Button();
            ChayaBtn = new Button();
            PolloBtn = new Button();
            MolBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(OtrosBtn);
            panel1.Controls.Add(BrazoBtn);
            panel1.Controls.Add(TobisBtn);
            panel1.Controls.Add(HorneadoBtn);
            panel1.Controls.Add(ColadosBtn);
            panel1.Controls.Add(EspelonBtn);
            panel1.Controls.Add(ChayaBtn);
            panel1.Controls.Add(PolloBtn);
            panel1.Controls.Add(MolBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 855);
            panel1.TabIndex = 0;
            // 
            // OtrosBtn
            // 
            OtrosBtn.Location = new Point(561, 588);
            OtrosBtn.Name = "OtrosBtn";
            OtrosBtn.Size = new Size(255, 267);
            OtrosBtn.TabIndex = 8;
            OtrosBtn.Text = "Test";
            OtrosBtn.UseVisualStyleBackColor = true;
            OtrosBtn.Click += ProdBtn_Click;
            // 
            // BrazoBtn
            // 
            BrazoBtn.Location = new Point(278, 588);
            BrazoBtn.Name = "BrazoBtn";
            BrazoBtn.Size = new Size(255, 267);
            BrazoBtn.TabIndex = 7;
            BrazoBtn.Text = "Brazos";
            BrazoBtn.UseVisualStyleBackColor = true;
            BrazoBtn.Click += ProdBtn_Click;
            // 
            // TobisBtn
            // 
            TobisBtn.Location = new Point(3, 588);
            TobisBtn.Name = "TobisBtn";
            TobisBtn.Size = new Size(255, 267);
            TobisBtn.TabIndex = 6;
            TobisBtn.Text = "Tobiholoch";
            TobisBtn.UseVisualStyleBackColor = true;
            TobisBtn.Click += ProdBtn_Click;
            // 
            // HorneadoBtn
            // 
            HorneadoBtn.Location = new Point(561, 294);
            HorneadoBtn.Name = "HorneadoBtn";
            HorneadoBtn.Size = new Size(255, 267);
            HorneadoBtn.TabIndex = 5;
            HorneadoBtn.Text = "Horneados";
            HorneadoBtn.UseVisualStyleBackColor = true;
            HorneadoBtn.Click += ProdBtn_Click;
            // 
            // ColadosBtn
            // 
            ColadosBtn.Location = new Point(278, 294);
            ColadosBtn.Name = "ColadosBtn";
            ColadosBtn.Size = new Size(255, 267);
            ColadosBtn.TabIndex = 4;
            ColadosBtn.Text = "Colados";
            ColadosBtn.UseVisualStyleBackColor = true;
            ColadosBtn.Click += ProdBtn_Click;
            // 
            // EspelonBtn
            // 
            EspelonBtn.Location = new Point(3, 294);
            EspelonBtn.Name = "EspelonBtn";
            EspelonBtn.Size = new Size(255, 267);
            EspelonBtn.TabIndex = 3;
            EspelonBtn.Text = "Espelon";
            EspelonBtn.UseVisualStyleBackColor = true;
            EspelonBtn.Click += ProdBtn_Click;
            // 
            // ChayaBtn
            // 
            ChayaBtn.Location = new Point(561, 3);
            ChayaBtn.Name = "ChayaBtn";
            ChayaBtn.Size = new Size(255, 267);
            ChayaBtn.TabIndex = 2;
            ChayaBtn.Text = "Chaya";
            ChayaBtn.UseVisualStyleBackColor = true;
            ChayaBtn.Click += ProdBtn_Click;
            // 
            // PolloBtn
            // 
            PolloBtn.Location = new Point(278, 3);
            PolloBtn.Name = "PolloBtn";
            PolloBtn.Size = new Size(255, 267);
            PolloBtn.TabIndex = 1;
            PolloBtn.Text = "Pollo";
            PolloBtn.UseVisualStyleBackColor = true;
            PolloBtn.Click += ProdBtn_Click;
            // 
            // MolBtn
            // 
            MolBtn.Location = new Point(3, 3);
            MolBtn.Name = "MolBtn";
            MolBtn.Size = new Size(255, 267);
            MolBtn.TabIndex = 0;
            MolBtn.Text = "Molida";
            MolBtn.UseVisualStyleBackColor = true;
            MolBtn.Click += ProdBtn_Click;
            // 
            // TecladoMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(819, 855);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TecladoMain";
            Text = "z";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button MolBtn;
        private Button OtrosBtn;
        private Button BrazoBtn;
        private Button TobisBtn;
        private Button HorneadoBtn;
        private Button ColadosBtn;
        private Button EspelonBtn;
        private Button ChayaBtn;
        private Button PolloBtn;
    }
}