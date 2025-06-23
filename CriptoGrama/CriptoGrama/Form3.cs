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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string email = textBox1.Text;
			string senha = textBox2.Text;
			string senhaHash = Cripto_Hash.GerarHashSha256(senha);
			UsuarioRepository repo = new UsuarioRepository(CodBD.amor);

			Usuario usuario = repo.ObterPorEmailESenha(email, senhaHash);

			if (usuario != null)
			{
				Form4 main = new Form4(usuario,Color.Purple);
				this.Hide();
				main.ShowDialog();
				this.Show();
			}
			else
			{
				label4.Text = "Ou lhe falta inteligência \nOu vc é um otário";
			}
		}
	}
}
