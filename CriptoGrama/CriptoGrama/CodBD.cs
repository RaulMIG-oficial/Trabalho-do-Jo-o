using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CriptoGrama
{
	internal class CodBD
	{
		public string email_usuario = null;
		public static string amor { get; } = "server=localhost;database=criptocode;uid=root;pwd=;";
		public CodBD(string email)
		{
			email_usuario=email;
		}

		public int SalvarCesar(string text,int num,string text_c)
		{
			int linhasAfetadas = -1;
			using (var connection = new MySqlConnection(amor))
			{
				connection.Open();
				string query = "INSERT INTO c_cesar_saves (normal_text_cesar, chave, cripto_text_cesar,usuario_email) VALUES (@NTC, @Senha, @CTC,@Email)";
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@NTC", text);
					command.Parameters.AddWithValue("@Senha", num);
					command.Parameters.AddWithValue("@CTC", text_c);
					command.Parameters.AddWithValue("@Email",email_usuario);
					linhasAfetadas = command.ExecuteNonQuery();
				}
			}
			return linhasAfetadas;
		}

		public int SalvarHash(string text,string text_c)
		{
			int linhasAfetadas = -1;
			using (var connection = new MySqlConnection(amor))
			{
				connection.Open();
				string query = "INSERT INTO c_hash_saves (normal_text_hash, cripto_text_hash, usuario_email) VALUES (@NTH, @CTH, @Email)";
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@NTH", text);
					command.Parameters.AddWithValue("@CTH", text_c);
					command.Parameters.AddWithValue("@Email", email_usuario);
					linhasAfetadas = command.ExecuteNonQuery();
				}
			}
			return linhasAfetadas;
		}
		public int SalvarRa(string text,string text_c)
		{
			int linhasAfetadas = -1;
			using (var connection = new MySqlConnection(amor))
			{
				connection.Open();
				string query = "INSERT INTO c_ra_saves (normal_text_ra, cripto_text_ra, usuario_email) VALUES (@NTR, @CTR, @Email)";
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@NTR", text);
					command.Parameters.AddWithValue("@CTR", text_c);
					command.Parameters.AddWithValue("@Email", email_usuario);
					linhasAfetadas = command.ExecuteNonQuery();
				}
			}
			return linhasAfetadas;
		}
		
		
		
	}
}
