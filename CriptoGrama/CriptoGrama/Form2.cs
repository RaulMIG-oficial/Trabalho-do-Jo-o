using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace CriptoGrama
{
	public partial class Form2 : Form
	{
		public Color cor = Color.LimeGreen;
		public Form2(Color Cor)
		{
			cor = Cor;
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			string email = textBox1.Text;
			string senha = textBox2.Text;
			string senha2 = textBox3.Text;
			string apelido = textBox4.Text;
			string senhaHash = Cripto_Hash.GerarHashSha256(senha);
			UsuarioRepository repo = new UsuarioRepository(CodBD.amor);
			
			
			if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) ||
			   string.IsNullOrWhiteSpace(senha2) || string.IsNullOrWhiteSpace(apelido))
			{
				label8.Text = "► Você é burro ou se faz.\n Preencha todos os campos";
				return;
			}
			if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
			{
				label8.Text = "► Email inválido.";
				return;
			}

			if (senha.Length < 6)
			{
				label8.Text = "► A senha deve ter pelo menos 6 caracteres.";
				return;
			}

			if (apelido.Length < 3)
			{
				label8.Text = "► Que apelido se graça\nCOLOQUE ALGO MAIS ♥♦♣♠ C R I A T I V O ♠♣♦♥";
				return;
			}

			if (senha != senha2)
			{
				label8.Text = "► Não ta vendo que as senhas não são igual...\n...a... é verdade";
				return;
			}


			Usuario novoUsuario = new Usuario
			{
				Email = email,
				Apelido = apelido,
				Senha = senhaHash
			};
			try
			{
				int linhas = repo.InserirUsuario(novoUsuario);
				if (linhas > 0)
				{
					label8.ForeColor = Color.Green;
					label8.Text = "Boa moleke. Cadastrado com sucesso!";
					LimparCampos();
				}
				else
				{
					label8.Text = "Sua maquina,PODRE, deu erro ao cadastrar.";
				}
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				if (ex.Number == 1062)
					label8.Text = "Já existe um cria com este e-mail.";
			}
			catch (Exception ex)
			{
				label8.Text = "Erro inesperado: " + ex.Message;
			}
		}

		private void LimparCampos()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
			{
				label2.ForeColor = cor;
				label3.ForeColor = cor;
				label4.ForeColor = cor;
				label5.ForeColor = cor;
				label6.ForeColor = cor;
				label7.ForeColor = cor;
				button1.ForeColor = cor;
				button2.ForeColor = cor;
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
