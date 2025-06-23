namespace CriptoGrama
{
	partial class Form4
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
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 21);
			label1.Name = "label1";
			label1.Size = new Size(68, 15);
			label1.TabIndex = 8;
			label1.Text = "CriptoCode";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 78);
			label2.Name = "label2";
			label2.Size = new Size(126, 15);
			label2.TabIndex = 9;
			label2.Text = "• Tipos de criptografia:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 110);
			label3.Name = "label3";
			label3.Size = new Size(93, 15);
			label3.TabIndex = 10;
			label3.Text = "→ Cifra de Cesar";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 125);
			label4.Name = "label4";
			label4.Size = new Size(47, 15);
			label4.TabIndex = 11;
			label4.Text = "→ Hash";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 140);
			label5.MaximumSize = new Size(63, 15);
			label5.MinimumSize = new Size(63, 15);
			label5.Name = "label5";
			label5.Size = new Size(63, 15);
			label5.TabIndex = 12;
			label5.Text = "→ M.Crifra";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 180);
			label6.Name = "label6";
			label6.Size = new Size(172, 15);
			label6.TabIndex = 13;
			label6.Text = "→ Veja suas Criptografias salvas";
			label6.UseWaitCursor = true;
			label6.Click += label6_Click;
			// 
			// Form4
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(240, 217);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			MaximumSize = new Size(256, 256);
			MinimumSize = new Size(256, 256);
			Name = "Form4";
			Text = "Form4";
			Load += Form4_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
	}
}