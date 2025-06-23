namespace CriptoGrama
{
	public partial class Form1 : Form
	{
		public Color cor = Color.LimeGreen;
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			Form2 form2 = new Form2(cor);
			this.Hide();
			form2.ShowDialog();
			this.Show();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			string email = textBox1.Text;
			string senha = textBox2.Text;
			string senhaHash = Cripto_Hash.GerarHashSha256(senha);
			UsuarioRepository repo = new UsuarioRepository(CodBD.amor);

			Usuario usuario = repo.ObterPorEmailESenha(email, senhaHash);

			if (usuario != null)
			{
				Form4 main = new Form4(usuario, cor);
				this.Hide();
				main.ShowDialog();
				this.Show();
			}
			else
			{
				label9.Text = "Ou lhe falta inteligência \nOu vc é um otário";
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			//BackgroundImage = Properties.Resources.download;

		}
		private void label3_Click_1(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			cor = Color.LimeGreen;
			label1.ForeColor = cor;
			label2.ForeColor = cor;
			label3.ForeColor = cor;
			label7.ForeColor = cor;
			label8.ForeColor = cor;
			button1.ForeColor = cor;
			button2.ForeColor = cor;
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{
			cor = Color.Yellow;
			label1.ForeColor = cor;
			label2.ForeColor = cor;
			label3.ForeColor = cor;
			label7.ForeColor = cor;
			label8.ForeColor = cor;
			button1.ForeColor = cor;
			button2.ForeColor = cor;
		}

		private void label6_Click(object sender, EventArgs e)
		{
			cor = Color.Red;
			label1.ForeColor = cor;
			label2.ForeColor = cor;
			label3.ForeColor = cor;
			label7.ForeColor = cor;
			label8.ForeColor = cor;
			button1.ForeColor = cor;
			button2.ForeColor = cor;
		}
	}
}
