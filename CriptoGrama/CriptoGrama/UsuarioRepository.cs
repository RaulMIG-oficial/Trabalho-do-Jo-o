using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CriptoGrama
{
	internal class UsuarioRepository
	{
		private readonly string _connectionString;

		public UsuarioRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public Usuario ObterPorEmailESenha(string email, string senha)
		{
			Usuario usuario = null;
			using (var connection = new MySqlConnection(_connectionString))
			{
				connection.Open();
				string query = "SELECT email, apelido, senha FROM usuario WHERE email = @Email AND senha = @Senha";
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Email", email);
					command.Parameters.AddWithValue("@Senha", senha);

					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							usuario = new Usuario
							{
								Email = reader.GetString("email"),
								Apelido = reader.GetString("apelido"),
								Senha = reader.GetString("senha")
							};
						}
					}
				}
			}
			return usuario;
		}
		/*public string ObterEmail(string email)
	   {
		   using (var connection = new MySqlConnection(_connectionString))
		   {
			   connection.Open();
			   string query = "SELECT email FROM usuario WHERE email = @Email";
			   using (var command = new MySqlCommand(query, connection))
			   {
				   command.Parameters.AddWithValue("@Email", email);


				   using (var reader = command.ExecuteReader())
				   {
					   if (reader.Read())
					   {
						   usuario = new Usuario
						   {
							   Email = reader.GetString("email"),
							   Apelido = reader.GetString("apelido"),
							   Senha = reader.GetString("senha")
						   };
					   }
				   }
			   }
		   }
	   }*/
		/*
		public string ObterPorEmail(string email)
		{
			Usuario usuario = null;
			using (var connection = new MySqlConnection(_connectionString))
			{
				connection.Open();
				string query = "SELECT email, apelido, senha FROM usuario WHERE email = @Email";
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Email", email);

					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							usuario = new Usuario
							{
								Email = reader.GetString("email"),
								Apelido = reader.GetString("apelido"),
								Senha = reader.GetString("senha")
							};
						}
						if (usuario.Email == null)
						{
							usuario.Email = "a";
						}
					}
				}
			}
			return usuario.Email;
		}*/
		public int InserirUsuario(Usuario usuario)
		{
			int linhasAfetadas = -1;
			using (var connection = new MySqlConnection(_connectionString))
			{
				connection.Open();
				string query = "INSERT INTO usuario (email, apelido, senha) VALUES (@Email, @Apelido, @Senha)";
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Email", usuario.Email);
					command.Parameters.AddWithValue("@Apelido", usuario.Apelido);
					command.Parameters.AddWithValue("@Senha", usuario.Senha);
					linhasAfetadas = command.ExecuteNonQuery();
				}
			}
			return linhasAfetadas;
		}
	}
}
