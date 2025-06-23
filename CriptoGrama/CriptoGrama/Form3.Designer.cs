namespace CriptoGrama
{
	partial class Form3
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
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			textBox2 = new TextBox();
			button1 = new Button();
			label4 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Black;
			label1.ForeColor = Color.LimeGreen;
			label1.Location = new Point(31, 28);
			label1.Name = "label1";
			label1.Size = new Size(37, 15);
			label1.TabIndex = 0;
			label1.Text = "Login";
			label1.Click += label1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(100, 61);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(165, 23);
			textBox1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Black;
			label2.ForeColor = Color.LimeGreen;
			label2.Location = new Point(31, 64);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 2;
			label2.Text = "Email:";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Black;
			label3.ForeColor = Color.LimeGreen;
			label3.Location = new Point(31, 93);
			label3.Name = "label3";
			label3.Size = new Size(42, 15);
			label3.TabIndex = 4;
			label3.Text = "Senha:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(100, 90);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(165, 23);
			textBox2.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(190, 145);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 5;
			button1.Text = "Entra";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.Red;
			label4.Location = new Point(12, 167);
			label4.Name = "label4";
			label4.Size = new Size(0, 15);
			label4.TabIndex = 6;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(334, 211);
			Controls.Add(label4);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			MaximumSize = new Size(350, 250);
			Name = "Form3";
			Text = "Form3";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private TextBox textBox2;
		private Button button1;
		private Label label4;
	}
}