using System;
using System.Text;

namespace CSharpAssemble
{
	// Token: 0x020000C3 RID: 195
	internal static class UrlEncoder
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00031E0C File Offset: 0x0003000C
		public static string UrlEncode(string str)
		{
			if (str == null)
			{
				return null;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			byte[] array = UrlEncoder.UrlEncode(bytes, 0, bytes.Length, false);
			return Encoding.UTF8.GetString(array, 0, array.Length);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00031E48 File Offset: 0x00030048
		private static byte[] UrlEncode(byte[] bytes, int offset, int count, bool alwaysCreateNewReturnValue)
		{
			byte[] array = UrlEncoder.UrlEncode(bytes, offset, count);
			if (!alwaysCreateNewReturnValue || array == null || array != bytes)
			{
				return array;
			}
			return (byte[])array.Clone();
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00031E78 File Offset: 0x00030078
		private static byte[] UrlEncode(byte[] bytes, int offset, int count)
		{
			if (!UrlEncoder.ValidateUrlEncodingParameters(bytes, offset, count))
			{
				return null;
			}
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < count; i++)
			{
				char c = (char)bytes[offset + i];
				if (c == ' ')
				{
					num++;
				}
				else if (!UrlEncoder.IsUrlSafeChar(c))
				{
					num2++;
				}
			}
			if (num == 0 && num2 == 0)
			{
				return bytes;
			}
			byte[] array = new byte[count + num2 * 2];
			int num3 = 0;
			for (int j = 0; j < count; j++)
			{
				byte b = bytes[offset + j];
				char c2 = (char)b;
				if (UrlEncoder.IsUrlSafeChar(c2))
				{
					array[num3++] = b;
				}
				else if (c2 == ' ')
				{
					array[num3++] = 43;
				}
				else
				{
					array[num3++] = 37;
					array[num3++] = (byte)UrlEncoder.IntToHex(b >> 4 & 15);
					array[num3++] = (byte)UrlEncoder.IntToHex((int)(b & 15));
				}
			}
			return array;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00031F56 File Offset: 0x00030156
		private static char IntToHex(int n)
		{
			if (n <= 9)
			{
				return (char)(n + 48);
			}
			return (char)(n - 10 + 97);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00031F6C File Offset: 0x0003016C
		private static bool IsUrlSafeChar(char ch)
		{
			if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
			{
				return true;
			}
			if (ch != '!')
			{
				switch (ch)
				{
				case '(':
				case ')':
				case '*':
				case '-':
				case '.':
					return true;
				case '+':
				case ',':
					break;
				default:
					if (ch == '_')
					{
						return true;
					}
					break;
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00031FD0 File Offset: 0x000301D0
		private static bool ValidateUrlEncodingParameters(byte[] bytes, int offset, int count)
		{
			if (bytes == null && count == 0)
			{
				return false;
			}
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (offset < 0 || offset > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || offset + count > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			return true;
		}
	}
}
