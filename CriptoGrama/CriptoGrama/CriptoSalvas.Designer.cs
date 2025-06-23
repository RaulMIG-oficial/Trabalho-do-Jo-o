namespace CriptoGrama
{
	partial class CriptoSalvas
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
			dataGridView1 = new DataGridView();
			label6 = new Label();
			label7 = new Label();
			numericUpDown1 = new NumericUpDown();
			label8 = new Label();
			textBox2 = new TextBox();
			numericUpDown2 = new NumericUpDown();
			textBox1 = new TextBox();
			label9 = new Label();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(10, 426);
			label1.Name = "label1";
			label1.Size = new Size(77, 15);
			label1.TabIndex = 0;
			label1.Text = "Ver seves em:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(120, 426);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 1;
			label2.Text = "Cesar";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(180, 426);
			label3.Name = "label3";
			label3.Size = new Size(34, 15);
			label3.TabIndex = 2;
			label3.Text = "Hash";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(240, 426);
			label4.Name = "label4";
			label4.Size = new Size(20, 15);
			label4.TabIndex = 3;
			label4.Text = "Ra";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 9);
			label5.Name = "label5";
			label5.Size = new Size(91, 15);
			label5.TabIndex = 4;
			label5.Text = "Saves em: Cesar";
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.Black;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.GridColor = Color.IndianRed;
			dataGridView1.Location = new Point(421, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(353, 194);
			dataGridView1.TabIndex = 5;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(35, 62);
			label6.Name = "label6";
			label6.Size = new Size(218, 15);
			label6.TabIndex = 6;
			label6.Text = "Aqui estão seu saves feitos por [apelido]";
			label6.Click += label6_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(35, 106);
			label7.Name = "label7";
			label7.Size = new Size(84, 15);
			label7.TabIndex = 7;
			label7.Text = "escolha um id:";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(35, 133);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(120, 23);
			numericUpDown1.TabIndex = 8;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(35, 191);
			label8.Name = "label8";
			label8.Size = new Size(202, 15);
			label8.TabIndex = 10;
			label8.Text = "Aqui está os valores correspondentes";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(180, 283);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(126, 99);
			textBox2.TabIndex = 14;
			// 
			// numericUpDown2
			// 
			numericUpDown2.Location = new Point(180, 231);
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new Size(126, 23);
			numericUpDown2.TabIndex = 13;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(29, 283);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(126, 99);
			textBox1.TabIndex = 12;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(120, 233);
			label9.Name = "label9";
			label9.Size = new Size(40, 15);
			label9.TabIndex = 15;
			label9.Text = "Chave";
			// 
			// button1
			// 
			button1.Location = new Point(185, 133);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 16;
			button1.Text = "Escolher";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// CriptoSalvas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(label9);
			Controls.Add(textBox2);
			Controls.Add(numericUpDown2);
			Controls.Add(textBox1);
			Controls.Add(label8);
			Controls.Add(numericUpDown1);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(dataGridView1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CriptoSalvas";
			Text = "CriptoSalvas";
			Load += CriptoSalvas_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private DataGridView dataGridView1;
		private Label label6;
		private Label label7;
		private NumericUpDown numericUpDown1;
		private Label label8;
		private TextBox textBox2;
		private NumericUpDown numericUpDown2;
		private TextBox textBox1;
		private Label label9;
		private Button button1;
	}
}