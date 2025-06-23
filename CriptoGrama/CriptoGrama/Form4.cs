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
	internal partial class Form4 : Form
	{
		private Usuario usuarioLogado;
		public Color cor = Color.LimeGreen;
		public Form4(Usuario usuario, Color cor)
		{
			this.cor = cor;
			usuarioLogado = usuario;
			InitializeComponent();
		}


		private void label3_Click(object sender, EventArgs e)
		{
			C_Cesar cesar = new C_Cesar(usuarioLogado, cor);
			cesar.Show();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			C_Hash hash = new C_Hash(usuarioLogado, cor);
			hash.Show();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			{
				label1.ForeColor = cor;
				label2.ForeColor = cor;
				label3.ForeColor = Color.Aqua;
				label4.ForeColor = Color.Aqua;
				label5.ForeColor = Color.Aqua;
				label6.ForeColor = Color.Aqua;
				BackColor = Color.Black;

			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			C_Ra ra = new C_Ra(usuarioLogado, cor);
			ra.Show();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			CriptoSalvas cripSave = new CriptoSalvas(usuarioLogado, cor);
			cripSave.Show();
		}
	}
}
