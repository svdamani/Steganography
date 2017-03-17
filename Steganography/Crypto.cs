using System;
using System.Security.Cryptography;
using System.Text;

namespace Steganography {
	internal static class Crypto {
		public static string Encrypt(string text, string password) {
			if (string.IsNullOrEmpty(text))
				return "";
			var data = Encoding.Default.GetBytes(text);
			var newData = Transform(data, password, aes => aes.CreateEncryptor());
			return Convert.ToBase64String(newData);
		}

		public static string Decrypt(string text, string password) {
			if (string.IsNullOrEmpty(text))
				return "";
			try {
				var data = Convert.FromBase64String(text);
				var newData = Transform(data, password, aes => aes.CreateDecryptor());
				return Encoding.Default.GetString(newData);
			}
			catch (Exception e) when (e is CryptographicException || e is FormatException) {
				return "Wrong Password";
			}
		}

		private static byte[] Transform(byte[] data, string password, Func<RijndaelManaged, ICryptoTransform> cryptor) {
			byte[] salt = { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 };
			using (var rfc = new Rfc2898DeriveBytes(password, salt))
			using (var aes = new RijndaelManaged { Key = rfc.GetBytes(32), IV = rfc.GetBytes(16) })
				return cryptor(aes).TransformFinalBlock(data, 0, data.Length);
		}
	}
}