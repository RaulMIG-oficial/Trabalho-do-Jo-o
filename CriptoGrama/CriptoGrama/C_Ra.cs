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
	internal partial class C_Ra : Form
	{
		private Usuario usuarioLogado;
		public Color cor = Color.Pink;
		public C_Ra(Usuario usuario, Color cor)
		{
			usuarioLogado = usuario;
			this.cor = cor;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random num = new Random();
			int nume = num.Next(1, 10);
			textBox2.Text = CriptoRa(textBox1.Text, nume);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox4.Text = DesCriptoRa(textBox3.Text);
		}
		public string CriptoRa(string senha, int chave)
		{

			StringBuilder resultado = new StringBuilder();

			foreach (char caractere in senha)
			{
				char caractereBase = '!';

				int indiceCaractere = caractere - caractereBase;

				int novoIndice = (indiceCaractere + (chave % 89) + 89) % 89;

				char novoCaractere = (char)(caractereBase + novoIndice);
				resultado.Append(novoCaractere);

			}
			resultado.Append("[" + chave + "]");
			return resultado.ToString();
		}
		public string DesCriptoRa(string senha)
		{

			StringBuilder resultado = new StringBuilder(); // Usado para construir a nova string eficientemente
			Random random = new Random();
			string[] se = senha.ToString().Split('[', ']');
			int chave = Convert.ToInt32(se[1]);
			int chaveDes = (89 - (chave % 89)) % 89;
			senha = se[0];
			string textoDescriptografado = CriptoRa(senha, chaveDes);
			textoDescriptografado = textoDescriptografado.Substring(0, textoDescriptografado.Length - 4);
			return textoDescriptografado.ToString();
		}

		private void C_Ra_Load(object sender, EventArgs e)
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

		private void button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
			{
				label8.Text = "► Para Salvar preencha todos os campos com a bolinha azul";
				return;
			}
			CodBD codBD = new CodBD(usuarioLogado.Email);
			codBD.SalvarRa(textBox1.Text, textBox2.Text);
		}
	}
}
