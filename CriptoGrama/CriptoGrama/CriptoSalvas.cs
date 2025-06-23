using CriptoGrama;
using MySql.Data.MySqlClient;
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
	internal partial class CriptoSalvas : Form
	{
		Usuario usuarioCadastrado;
		Color cor;
		string cetor = "cesar";
		public CriptoSalvas(Usuario usuario, Color cor)
		{
			usuarioCadastrado = usuario;
			this.cor = cor;
			InitializeComponent();
		}

		private void CriptoSalvas_Load(object sender, EventArgs e)
		{
			CarregarDadosCesar();
			label6.Text = $"Aqui estão seu saves feitos por {usuarioCadastrado.Apelido}";
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
				label2.ForeColor = Color.Aqua;
				//
				label3.ForeColor = Color.Aqua;
				//
				label4.ForeColor = Color.Aqua;
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
				// Button
				//
				button1.ForeColor = cor;
				button1.BackColor = Color.Black;
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void CarregarDadosCesar()
		{
			string conexao = "server=localhost;database=criptocode;uid=root;pwd=;";
			string query = $"SELECT id_cesar, normal_text_cesar, cripto_text_cesar FROM c_cesar_saves c where c.usuario_email = '{usuarioCadastrado.Email}';";
			//
			using (MySqlConnection conn = new MySqlConnection(conexao))
			{
				try
				{
					conn.Open();
					MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridView1.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao carregar dados: " + ex.Message);
				}
			}
		}
		private void CarregarDadosHash()
		{
			string conexao = "server=localhost;database=criptocode;uid=root;pwd=;";
			string query = $"SELECT id_hash, normal_text_hash, cripto_text_hash FROM c_hash_saves c where c.usuario_email = '{usuarioCadastrado.Email}';";
			//
			using (MySqlConnection conn = new MySqlConnection(conexao))
			{
				try
				{
					conn.Open();
					MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridView1.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao carregar dados: " + ex.Message);
				}
			}
		}
		private void CarregarDadosRa()
		{
			string conexao = "server=localhost;database=criptocode;uid=root;pwd=;";
			string query = $"SELECT id_ra, normal_text_ra, cripto_text_ra FROM c_ra_saves c where c.usuario_email = '{usuarioCadastrado.Email}';";
			//
			using (MySqlConnection conn = new MySqlConnection(conexao))
			{
				try
				{
					conn.Open();
					MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridView1.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao carregar dados: " + ex.Message);
				}
			}
		}
		private void label2_Click(object sender, EventArgs e)
		{
			CarregarDadosCesar();
			cetor = "cesar";
			label9.Visible = true;
			numericUpDown2.Visible = true;
			label5.Text = "Saves em: Cesar";

		}

		private void label3_Click(object sender, EventArgs e)
		{
			CarregarDadosHash();
			cetor = "hash";
			label9.Visible = false;
			numericUpDown2.Visible = false;
			label5.Text = "Saves em: Hash";

		}

		private void label4_Click(object sender, EventArgs e)
		{
			CarregarDadosRa();
			cetor = "ra";
			label9.Visible = false;
			numericUpDown2.Visible = false;
			label5.Text = "Saves em: Ra";
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			int id = (int)numericUpDown1.Value;
			using (var connection = new MySqlConnection(CodBD.amor))
			{ 
			if (cetor == "cesar")
				{
					connection.Open();
					string query = $"SELECT normal_text_cesar, cripto_text_cesar, chave FROM c_cesar_saves c where c.usuario_email = '{usuarioCadastrado.Email}' AND id_cesar = {id};";
					using (var command = new MySqlCommand(query, connection))
					{
						using (var reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								textBox1.Text = reader.GetString("normal_text_cesar");
								textBox2.Text = reader.GetString("cripto_text_cesar");
								numericUpDown2.Value = reader.GetUInt32("chave"); 
							}
						}
					}
				
					//
				}
				else if (cetor == "hash")
				{
					connection.Open();
					string query = $"SELECT normal_text_hash, cripto_text_hash FROM c_hash_saves c where c.usuario_email = '{usuarioCadastrado.Email}' AND id_hash = {id};";
					using (var command = new MySqlCommand(query, connection))
					{
						using (var reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								textBox1.Text = reader.GetString("normal_text_hash");
								textBox2.Text = reader.GetString("cripto_text_hash");
							}
						}
					}
				}
				else if (cetor == "ra")
				{
					connection.Open();
					string query = $"SELECT normal_text_ra, cripto_text_ra FROM c_ra_saves c where c.usuario_email = '{usuarioCadastrado.Email}' AND id_ra = {id};";
					using (var command = new MySqlCommand(query, connection))
					{
						using (var reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								textBox1.Text = reader.GetString("normal_text_ra");
								textBox2.Text = reader.GetString("cripto_text_ra");
							}
						}
					}
				}

			}
			}

	}
}
