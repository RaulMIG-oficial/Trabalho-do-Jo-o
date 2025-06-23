using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CriptoGrama
{
	internal partial class C_Cesar : Form
	{
		private Usuario usuarioLogado;
		public Color cor = Color.Red;
		public C_Cesar(Usuario usuario, Color cor)
		{
			this.cor = cor;
			usuarioLogado = usuario;
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}
		// 100% chatGPT
		private void button1_Click(object sender, EventArgs e)
		{
			// 1. Pega o texto do textBox1
			string textoOriginal = textBox1.Text.ToUpper(); // Converte para maiúsculas para simplificar

			// 2. Pega a chave do numericUpDown1
			// O valor do NumericUpDown já é numérico (decimal), então precisamos converter para int
			int chave = (int)numericUpDown1.Value;

			// 3. Faz a criptografia usando a função CriptografarCesar
			string textoCriptografado = CriptografarCesar(textoOriginal, chave);

			// 4. Escreve o resultado na textBox2
			textBox2.Text = textoCriptografado;
		}
		public static string CriptografarCesar(string texto, int chave)
		{
			StringBuilder resultado = new StringBuilder(); // Usado para construir a nova string eficientemente

			foreach (char caractere in texto)
			{
				if (char.IsLetter(caractere)) // Verifica se o caractere é uma letra
				{
					char baseAlfabeto = 'A'; // A base para letras maiúsculas

					// Normaliza o caractere para sua posição de 0 a 25 no alfabeto (A=0, B=1, ...)
					int indiceCaractere = caractere - baseAlfabeto;

					// Aplica o deslocamento e usa o operador módulo (%) para "voltar" ao início do alfabeto se passar de 'Z'
					// O (indiceCaractere + chave % 26 + 26) % 26 é uma forma robusta de lidar com chaves negativas ou grandes
					int novoIndice = (indiceCaractere + (chave % 26) + 26) % 26;

					//◙◙◙◙◙ COMO QUE FUNCIONA ESSA BOMBA DO %          ^^^^Tabela ASCII Completa^^^^

					// Converte o novo índice de volta para a letra correspondente
					char novoCaractere = (char)(baseAlfabeto + novoIndice);

					resultado.Append(novoCaractere);
				}
				else
				{
					// Se não for uma letra (espaços, números, pontuações), mantém o caractere original
					resultado.Append(caractere);
				}
			}
			return resultado.ToString(); // Converte o StringBuilder para string e retorna
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// 1. Pega o texto criptografado do textBox3
			string textoCriptografado = textBox3.Text.ToUpper(); // Converte para maiúsculas

			// 2. Pega a chave de descriptografia do numericUpDown2
			int chave = (int)numericUpDown2.Value;

			// Para descriptografar, a chave que precisamos usar na função CriptografarCesar
			// é o "inverso" da chave original.
			// Ex: se criptografou com 3, para descriptografar (usando a mesma função) precisa de -3, que é 23 no ciclo de 26.
			int chaveDescriptografia = (26 - (chave % 26)) % 26;

			// 3. Faz a descriptografia usando a função CriptografarCesar com a chave reversa
			string textoDescriptografado = CriptografarCesar(textoCriptografado, chaveDescriptografia);

			// 4. Escreve o resultado na textBox4
			textBox4.Text = textoDescriptografado;
		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void C_Cesar_Load(object sender, EventArgs e)
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
				label8.ForeColor = cor;
				//
				label9.ForeColor = cor;
				//
				label13.ForeColor = Color.Red;

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
				//
				// numericUpDown
				//
				numericUpDown1.ForeColor = cor;
				numericUpDown1.BackColor = Color.Black;
				//
				numericUpDown2.ForeColor = cor;
				numericUpDown2.BackColor = Color.Black;
				//

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(Convert.ToString(numericUpDown1.Value)) ||
			   string.IsNullOrWhiteSpace(textBox2.Text))
			{
				label13.Text = "► Para Salvar preencha todos os campos com a bolinha azul";
				return;
			}
			CodBD codBD = new CodBD(usuarioLogado.Email);
			int linha = codBD.SalvarCesar(textBox1.Text,(int)numericUpDown1.Value,textBox2.Text);
			if (linha != -1)
			{
				label13.Text = "► Criptografia salva";
			}
		}
	}
}
