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
            CantTamtxt = new TextBox();
            RegresarBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            TamTipolb = new Label();
            DelBtn = new Button();
            SuspendLayout();
            // 
            // CantTamtxt
            // 
            CantTamtxt.Font = new Font("Segoe UI", 60F);
            CantTamtxt.Location = new Point(12, 71);
            CantTamtxt.Name = "CantTamtxt";
            CantTamtxt.Size = new Size(779, 114);
            CantTamtxt.TabIndex = 0;
            // 
            // RegresarBtn
            // 
            RegresarBtn.Location = new Point(664, 672);
            RegresarBtn.Name = "RegresarBtn";
            RegresarBtn.Size = new Size(127, 132);
            RegresarBtn.TabIndex = 1;
            RegresarBtn.Text = "Atras";
            RegresarBtn.UseVisualStyleBackColor = true;
            RegresarBtn.Click += BackBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(73, 191);
            button1.Name = "button1";
            button1.Size = new Size(146, 130);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 191);
            button2.Name = "button2";
            button2.Size = new Size(146, 130);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(417, 191);
            button3.Name = "button3";
            button3.Size = new Size(146, 130);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddBtn_Click;
            // 
            // button4
            // 
            button4.Location = new Point(73, 359);
            button4.Name = "button4";
            button4.Size = new Size(146, 130);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AddBtn_Click;
            // 
            // button5
            // 
            button5.Location = new Point(244, 359);
            button5.Name = "button5";
            button5.Size = new Size(146, 130);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += AddBtn_Click;
            // 
            // button6
            // 
            button6.Location = new Point(417, 359);
            button6.Name = "button6";
            button6.Size = new Size(146, 130);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AddBtn_Click;
            // 
            // button7
            // 
            button7.Location = new Point(417, 524);
            button7.Name = "button7";
            button7.Size = new Size(146, 130);
            button7.TabIndex = 10;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += AddBtn_Click;
            // 
            // button8
            // 
            button8.Location = new Point(244, 524);
            button8.Name = "button8";
            button8.Size = new Size(146, 130);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += AddBtn_Click;
            // 
            // button9
            // 
            button9.Location = new Point(73, 524);
            button9.Name = "button9";
            button9.Size = new Size(146, 130);
            button9.TabIndex = 8;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += AddBtn_Click;
            // 
            // button10
            // 
            button10.Location = new Point(244, 674);
            button10.Name = "button10";
            button10.Size = new Size(146, 130);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += AddBtn_Click;
            // 
            // TamTipolb
            // 
            TamTipolb.AutoSize = true;
            TamTipolb.Font = new Font("Segoe UI", 30F);
            TamTipolb.Location = new Point(14, 13);
            TamTipolb.Name = "TamTipolb";
            TamTipolb.Size = new Size(597, 54);
            TamTipolb.TabIndex = 12;
            TamTipolb.Text = "Si ves esto reportar al supervisor";
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(599, 202);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(180, 109);
            DelBtn.TabIndex = 13;
            DelBtn.Text = "Borrar";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // TecaldoNum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 816);
            ControlBox = false;
            Controls.Add(DelBtn);
            Controls.Add(TamTipolb);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RegresarBtn);
            Controls.Add(CantTamtxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TecaldoNum";
            Text = "TecaldoNum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CantTamtxt;
        private Button RegresarBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label TamTipolb;
        private Button DelBtn;
    }
}