using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Permissions
{
	/// <summary>Предоставляет информацию открытого ключа (называемую "блоб") для строгого имени. Этот класс не наследуется.</summary>
	// Token: 0x0200045F RID: 1119
	[ComVisible(true)]
	[Serializable]
	public sealed class StrongNamePublicKeyBlob
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> с необработанными байтами объекта "блоб" открытого ключа.</summary>
		/// <param name="publicKey">Массив данных в байтах, представляющий необработанные данные открытого ключа.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="publicKey" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002D7B RID: 11643 RVA: 0x000A3078 File Offset: 0x000A1278
		public StrongNamePublicKeyBlob(byte[] publicKey)
		{
			if (publicKey == null)
			{
				throw new ArgumentNullException("publicKey");
			}
			this.pubkey = publicKey;
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000A3098 File Offset: 0x000A1298
		internal static StrongNamePublicKeyBlob FromString(string s)
		{
			if (s == null || s.Length == 0)
			{
				return null;
			}
			byte[] array = new byte[s.Length / 2];
			int i = 0;
			int num = 0;
			while (i < s.Length)
			{
				byte b = StrongNamePublicKeyBlob.CharToByte(s[i]);
				byte b2 = StrongNamePublicKeyBlob.CharToByte(s[i + 1]);
				array[num] = Convert.ToByte((int)(b * 16 + b2));
				i += 2;
				num++;
			}
			return new StrongNamePublicKeyBlob(array);
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000A310C File Offset: 0x000A130C
		private static byte CharToByte(char c)
		{
			char c2 = char.ToLowerInvariant(c);
			if (char.IsDigit(c2))
			{
				return (byte)(c2 - '0');
			}
			return (byte)(c2 - 'a' + '\n');
		}

		/// <summary>Получает или задает значение, показывающее, равен ли объект "блоб" текущего открытого ключа объекту "блоб" указанного открытого ключа.</summary>
		/// <param name="obj">Объект, содержащий "блоб" открытого ключа.</param>
		/// <returns>Значение <see langword="true" />, если объект "блоб" открытого ключа текущего объекта равен объекту "блоб" открытого ключа параметра <paramref name="o" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002D7E RID: 11646 RVA: 0x000A3138 File Offset: 0x000A1338
		public override bool Equals(object obj)
		{
			StrongNamePublicKeyBlob strongNamePublicKeyBlob = obj as StrongNamePublicKeyBlob;
			if (strongNamePublicKeyBlob == null)
			{
				return false;
			}
			bool flag = this.pubkey.Length == strongNamePublicKeyBlob.pubkey.Length;
			if (flag)
			{
				for (int i = 0; i < this.pubkey.Length; i++)
				{
					if (this.pubkey[i] != strongNamePublicKeyBlob.pubkey[i])
					{
						return false;
					}
				}
			}
			return flag;
		}

		/// <summary>Возвращает хеш-код, основанный на открытом ключе.</summary>
		/// <returns>Хеш-код, основанный на открытом ключе.</returns>
		// Token: 0x06002D7F RID: 11647 RVA: 0x000A3190 File Offset: 0x000A1390
		public override int GetHashCode()
		{
			int num = 0;
			int i = 0;
			int num2 = Math.Min(this.pubkey.Length, 4);
			while (i < num2)
			{
				num = (num << 8) + (int)this.pubkey[i++];
			}
			return num;
		}

		/// <summary>Создает и возвращает строковое представление объекта "блоб" открытого ключа.</summary>
		/// <returns>Шестнадцатеричная версия объекта "блоб" открытого ключа.</returns>
		// Token: 0x06002D80 RID: 11648 RVA: 0x000A31C8 File Offset: 0x000A13C8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this.pubkey.Length; i++)
			{
				stringBuilder.Append(this.pubkey[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040020B7 RID: 8375
		internal byte[] pubkey;
	}
}
