using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="hexBinary" />.</summary>
	// Token: 0x020005E9 RID: 1513
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapHexBinary : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary" />.</summary>
		// Token: 0x06003966 RID: 14694 RVA: 0x000CB9AC File Offset: 0x000C9BAC
		public SoapHexBinary()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary" />.</summary>
		/// <param name="value">Массив <see cref="T:System.Byte" />, содержащий шестнадцатеричное число.</param>
		// Token: 0x06003967 RID: 14695 RVA: 0x000CB9BF File Offset: 0x000C9BBF
		public SoapHexBinary(byte[] value)
		{
			this._value = value;
		}

		/// <summary>Получает или устанавливает шестнадцатеричное представление числа.</summary>
		/// <returns>Массив <see cref="T:System.Byte" />, содержащий шестнадцатеричное представление числа.</returns>
		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06003968 RID: 14696 RVA: 0x000CB9D9 File Offset: 0x000C9BD9
		// (set) Token: 0x06003969 RID: 14697 RVA: 0x000CB9E1 File Offset: 0x000C9BE1
		public byte[] Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		/// <summary>Получает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Строка <see cref="T:System.String" />, указывающая XSD текущего типа SOAP.</returns>
		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x000CB9EA File Offset: 0x000C9BEA
		public static string XsdType
		{
			get
			{
				return "hexBinary";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x0600396B RID: 14699 RVA: 0x000CB9F1 File Offset: 0x000C9BF1
		public string GetXsdType()
		{
			return SoapHexBinary.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x0600396C RID: 14700 RVA: 0x000CB9F8 File Offset: 0x000C9BF8
		public static SoapHexBinary Parse(string value)
		{
			return new SoapHexBinary(SoapHexBinary.FromBinHexString(value));
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x000CBA08 File Offset: 0x000C9C08
		internal static byte[] FromBinHexString(string value)
		{
			char[] array = value.ToCharArray();
			byte[] array2 = new byte[array.Length / 2 + array.Length % 2];
			int num = array.Length;
			if (num % 2 != 0)
			{
				throw SoapHexBinary.CreateInvalidValueException(value);
			}
			int num2 = 0;
			for (int i = 0; i < num - 1; i += 2)
			{
				array2[num2] = SoapHexBinary.FromHex(array[i], value);
				byte[] array3 = array2;
				int num3 = num2;
				array3[num3] = (byte)(array3[num3] << 4);
				byte[] array4 = array2;
				int num4 = num2;
				array4[num4] += SoapHexBinary.FromHex(array[i + 1], value);
				num2++;
			}
			return array2;
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x000CBA88 File Offset: 0x000C9C88
		private static byte FromHex(char hexDigit, string value)
		{
			byte result;
			try
			{
				result = byte.Parse(hexDigit.ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
				throw SoapHexBinary.CreateInvalidValueException(value);
			}
			return result;
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x000CBAC8 File Offset: 0x000C9CC8
		private static Exception CreateInvalidValueException(string value)
		{
			return new RemotingException(string.Format(CultureInfo.InvariantCulture, "Invalid value '{0}' for xsd:{1}.", value, SoapHexBinary.XsdType));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary.Value" />.</returns>
		// Token: 0x06003970 RID: 14704 RVA: 0x000CBAE4 File Offset: 0x000C9CE4
		public override string ToString()
		{
			this.sb.Length = 0;
			foreach (byte b in this._value)
			{
				this.sb.Append(b.ToString("X2"));
			}
			return this.sb.ToString();
		}

		// Token: 0x04002629 RID: 9769
		private byte[] _value;

		// Token: 0x0400262A RID: 9770
		private StringBuilder sb = new StringBuilder();
	}
}
