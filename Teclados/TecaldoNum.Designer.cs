namespace Punto_De_Venta.Teclados
{
    partial class TecaldoNum
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
            textBox1 = new TextBox();
            RegresarBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 60F);
            textBox1.Location = new Point(12, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(779, 114);
            textBox1.TabIndex = 0;
            // 
            // RegresarBtn
            // 
            RegresarBtn.Location = new Point(664, 672);
            RegresarBtn.Name = "RegresarBtn";
            RegresarBtn.Size = new Size(127, 132);
            RegresarBtn.TabIndex = 1;
            RegresarBtn.Text = "Atras";
            RegresarBtn.UseVisualStyleBackColor = true;
            RegresarBtn.Click += NumerBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(293, 290);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // TecaldoNum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 816);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(RegresarBtn);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TecaldoNum";
            Text = "TecaldoNum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button RegresarBtn;
        private Button button1;
    }
}