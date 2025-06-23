using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoGrama
{
	internal partial class C_Hash : Form
	{
		private Usuario usuarioLogado;
		public Color cor = Color.Pink;
		public C_Hash(Usuario usuario, Color cor)
		{
			usuarioLogado = usuario;
			this.cor = cor;
			InitializeComponent();
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string text = textBox1.Text;
			string textHash = Cripto_Hash.GerarHashSha256(text);
			textBox2.Text = textHash;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string textHash = textBox3.Text;
			string text = Cripto_Hash.GerarHashSha256(textHash);
			textBox4.Text = text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
			{
				label8.Text = "► Para Salvar preencha todos os campos com a bolinha azul";
				return;
			}
			CodBD codBD = new CodBD(usuarioLogado.Email);
			codBD.SalvarHash(textBox1.Text, textBox2.Text);
		}

		private void C_Hash_Load(object sender, EventArgs e)
		{
			{
				//
				// Form
				//
				BackColor = Color.Black;
				//
				// label
				//
				label1.ForeColor = cor;
				//
				label2.ForeColor = Color.Purple;
				//
				label3.ForeColor = cor;
				//
				label4.ForeColor = cor;
				//
				label5.ForeColor = cor;
				//
				label6.ForeColor = cor;
				//
				label7.ForeColor = cor;
				//
				label8.ForeColor = Color.Red;
				//
				label9.ForeColor = cor;

				//
				// Button
				//
				button1.ForeColor = cor;
				button1.BackColor = Color.Black;
				//
				button2.ForeColor = cor;
				button2.BackColor = Color.Black;
				//
				button3.ForeColor = cor;
				button3.BackColor = Color.Black;


			}
		}
	}
}
