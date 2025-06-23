using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CriptoGrama
{
	internal class Cripto_Hash
	{
		public static string GerarHashSha256(string texto)
		{
			using (SHA256 sha = SHA256.Create())
			{
				byte[] bytes = Encoding.UTF8.GetBytes(texto);
				byte[] hash = sha.ComputeHash(bytes);
				return Convert.ToBase64String(hash);
			}
		}
	}
}
