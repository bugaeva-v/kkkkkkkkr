using System;
using System.Text;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет МАС-адрес сетевого интерфейса (адаптера).</summary>
	// Token: 0x020006FB RID: 1787
	public class PhysicalAddress
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.PhysicalAddress" />.</summary>
		/// <param name="address">Массив <see cref="T:System.Byte" />, содержащий адрес.</param>
		// Token: 0x0600396A RID: 14698 RVA: 0x000C87BF File Offset: 0x000C69BF
		public PhysicalAddress(byte[] address)
		{
			this.address = address;
		}

		/// <summary>Возвращает значение хэша физического адреса.</summary>
		/// <returns>Целочисленное хэш-значение.</returns>
		// Token: 0x0600396B RID: 14699 RVA: 0x000C87D8 File Offset: 0x000C69D8
		public override int GetHashCode()
		{
			if (this.changed)
			{
				this.changed = false;
				this.hash = 0;
				int num = this.address.Length & -4;
				int i;
				for (i = 0; i < num; i += 4)
				{
					this.hash ^= ((int)this.address[i] | (int)this.address[i + 1] << 8 | (int)this.address[i + 2] << 16 | (int)this.address[i + 3] << 24);
				}
				if ((this.address.Length & 3) != 0)
				{
					int num2 = 0;
					int num3 = 0;
					while (i < this.address.Length)
					{
						num2 |= (int)this.address[i] << num3;
						num3 += 8;
						i++;
					}
					this.hash ^= num2;
				}
			}
			return this.hash;
		}

		/// <summary>Сравниваются два экземпляра <see cref="T:System.Net.NetworkInformation.PhysicalAddress" />.</summary>
		/// <param name="comparand">
		///   <see cref="T:System.Net.NetworkInformation.PhysicalAddress" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если данный и указанный экземпляры содержат один и тот же адрес; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600396C RID: 14700 RVA: 0x000C88A0 File Offset: 0x000C6AA0
		public override bool Equals(object comparand)
		{
			PhysicalAddress physicalAddress = comparand as PhysicalAddress;
			if (physicalAddress == null)
			{
				return false;
			}
			if (this.address.Length != physicalAddress.address.Length)
			{
				return false;
			}
			for (int i = 0; i < physicalAddress.address.Length; i++)
			{
				if (this.address[i] != physicalAddress.address[i])
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает представление адреса экземпляра в виде строки <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" /> с адресом, содержащимся в этом экземпляре.</returns>
		// Token: 0x0600396D RID: 14701 RVA: 0x000C88F8 File Offset: 0x000C6AF8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in this.address)
			{
				int num = b >> 4 & 15;
				for (int j = 0; j < 2; j++)
				{
					if (num < 10)
					{
						stringBuilder.Append((char)(num + 48));
					}
					else
					{
						stringBuilder.Append((char)(num + 55));
					}
					num = (int)(b & 15);
				}
			}
			return stringBuilder.ToString();
		}

		/// <summary>Возвращает адрес текущего экземпляра.</summary>
		/// <returns>Массив <see cref="T:System.Byte" />, содержащий адрес.</returns>
		// Token: 0x0600396E RID: 14702 RVA: 0x000C896C File Offset: 0x000C6B6C
		public byte[] GetAddressBytes()
		{
			byte[] array = new byte[this.address.Length];
			Buffer.BlockCopy(this.address, 0, array, 0, this.address.Length);
			return array;
		}

		/// <summary>Анализирует заданную строку <see cref="T:System.String" /> и сохраняет ее содержимое в виде байтов адреса экземпляра <see cref="T:System.Net.NetworkInformation.PhysicalAddress" />, возвращаемого этим методом.</summary>
		/// <param name="address">Строка <see cref="T:System.String" />, содержащая адрес, будет использоваться для инициализации экземпляра <see cref="T:System.Net.NetworkInformation.PhysicalAddress" />, возвращаемого этим методом.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.NetworkInformation.PhysicalAddress" /> с заданным адресом.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="address" /> содержит недопустимый аппаратный адрес или строку в неверном формате.</exception>
		// Token: 0x0600396F RID: 14703 RVA: 0x000C89A0 File Offset: 0x000C6BA0
		public static PhysicalAddress Parse(string address)
		{
			int num = 0;
			bool flag = false;
			if (address == null)
			{
				return PhysicalAddress.None;
			}
			byte[] array;
			if (address.IndexOf('-') >= 0)
			{
				flag = true;
				array = new byte[(address.Length + 1) / 3];
			}
			else
			{
				if (address.Length % 2 > 0)
				{
					throw new FormatException(SR.GetString("An invalid physical address was specified."));
				}
				array = new byte[address.Length / 2];
			}
			int num2 = 0;
			int i = 0;
			while (i < address.Length)
			{
				int num3 = (int)address[i];
				if (num3 >= 48 && num3 <= 57)
				{
					num3 -= 48;
					goto IL_C3;
				}
				if (num3 >= 65 && num3 <= 70)
				{
					num3 -= 55;
					goto IL_C3;
				}
				if (num3 != 45)
				{
					throw new FormatException(SR.GetString("An invalid physical address was specified."));
				}
				if (num != 2)
				{
					throw new FormatException(SR.GetString("An invalid physical address was specified."));
				}
				num = 0;
				IL_100:
				i++;
				continue;
				IL_C3:
				if (flag && num >= 2)
				{
					throw new FormatException(SR.GetString("An invalid physical address was specified."));
				}
				if (num % 2 == 0)
				{
					array[num2] = (byte)(num3 << 4);
				}
				else
				{
					byte[] array2 = array;
					int num4 = num2++;
					array2[num4] |= (byte)num3;
				}
				num++;
				goto IL_100;
			}
			if (num < 2)
			{
				throw new FormatException(SR.GetString("An invalid physical address was specified."));
			}
			return new PhysicalAddress(array);
		}

		// Token: 0x040021A4 RID: 8612
		private byte[] address;

		// Token: 0x040021A5 RID: 8613
		private bool changed = true;

		// Token: 0x040021A6 RID: 8614
		private int hash;

		/// <summary>Возвращает новый экземпляр <see cref="T:System.Net.NetworkInformation.PhysicalAddress" /> с адресом нулевой длины. Это поле доступно только для чтения.</summary>
		// Token: 0x040021A7 RID: 8615
		public static readonly PhysicalAddress None = new PhysicalAddress(new byte[0]);
	}
}
