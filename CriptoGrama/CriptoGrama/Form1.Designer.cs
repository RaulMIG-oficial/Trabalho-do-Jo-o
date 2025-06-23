namespace CriptoGrama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			button1 = new Button();
			button2 = new Button();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label9 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.LimeGreen;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(155, 28);
			label1.TabIndex = 0;
			label1.Text = "CriptoGrama";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 35);
			label2.Name = "label2";
			label2.Size = new Size(0, 15);
			label2.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.LimeGreen;
			label3.Location = new Point(12, 46);
			label3.Name = "label3";
			label3.Size = new Size(224, 75);
			label3.TabIndex = 11;
			label3.Text = "seja bem vindo ao Criptosenha,\r\naqui você podera ver formas \r\ndiferentes de cripotografia, \r\npondedo salva las e utilizalas \r\nquando quiser.\r\n";
			label3.Click += label3_Click_1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
			label4.ForeColor = Color.LimeGreen;
			label4.Location = new Point(376, 155);
			label4.Name = "label4";
			label4.Size = new Size(32, 26);
			label4.TabIndex = 12;
			label4.Text = "J";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
			label5.ForeColor = Color.Yellow;
			label5.Location = new Point(414, 155);
			label5.Name = "label5";
			label5.Size = new Size(32, 26);
			label5.TabIndex = 13;
			label5.Text = "K";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
			label6.ForeColor = Color.Red;
			label6.Location = new Point(452, 155);
			label6.Name = "label6";
			label6.Size = new Size(32, 26);
			label6.TabIndex = 14;
			label6.Text = "L";
			label6.Click += label6_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = Color.LimeGreen;
			label7.Location = new Point(258, 73);
			label7.Name = "label7";
			label7.Size = new Size(42, 15);
			label7.TabIndex = 18;
			label7.Text = "Senha:";
			label7.Click += label7_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.ForeColor = Color.LimeGreen;
			label8.Location = new Point(258, 35);
			label8.Name = "label8";
			label8.Size = new Size(39, 15);
			label8.TabIndex = 16;
			label8.Text = "Email:";
			// 
			// button1
			// 
			button1.BackColor = Color.Black;
			button1.ForeColor = Color.LimeGreen;
			button1.Location = new Point(9, 176);
			button1.Margin = new Padding(0);
			button1.Name = "button1";
			button1.Size = new Size(138, 32);
			button1.TabIndex = 8;
			button1.Text = "Cadastrar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.Black;
			button2.ForeColor = Color.LimeGreen;
			button2.Location = new Point(277, 116);
			button2.Name = "button2";
			button2.Size = new Size(176, 23);
			button2.TabIndex = 10;
			button2.Text = "Entrar";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(315, 70);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(165, 23);
			textBox2.TabIndex = 17;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(315, 32);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(165, 23);
			textBox1.TabIndex = 15;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.ForeColor = Color.Red;
			label9.Location = new Point(173, 155);
			label9.Name = "label9";
			label9.Size = new Size(0, 15);
			label9.TabIndex = 19;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = SystemColors.ActiveCaptionText;
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(496, 217);
			Controls.Add(label9);
			Controls.Add(label7);
			Controls.Add(textBox2);
			Controls.Add(label8);
			Controls.Add(textBox1);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			DoubleBuffered = true;
			MaximumSize = new Size(512, 256);
			MinimumSize = new Size(512, 256);
			Name = "Form1";
			Text = "Criptograma";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox textBox2;
		private Label label8;
		private TextBox textBox1;
		private Label label9;
	}
}
