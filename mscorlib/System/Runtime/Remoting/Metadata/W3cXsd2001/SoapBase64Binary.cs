using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="base64Binary" />.</summary>
	// Token: 0x020005E1 RID: 1505
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapBase64Binary : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary" />.</summary>
		// Token: 0x0600392D RID: 14637 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapBase64Binary()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary" /> с двоичным представлением 64-разрядного числа.</summary>
		/// <param name="value">Массив <see cref="T:System.Byte" />, содержащий 64-разрядное число.</param>
		// Token: 0x0600392E RID: 14638 RVA: 0x000CB2AD File Offset: 0x000C94AD
		public SoapBase64Binary(byte[] value)
		{
			this._value = value;
		}

		/// <summary>Получает или задает двоичное представление 64-разрядного числа.</summary>
		/// <returns>Массив <see cref="T:System.Byte" />, содержащий двоичное представление 64-разрядного числа.</returns>
		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x000CB2BC File Offset: 0x000C94BC
		// (set) Token: 0x06003930 RID: 14640 RVA: 0x000CB2C4 File Offset: 0x000C94C4
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
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x000CB2CD File Offset: 0x000C94CD
		public static string XsdType
		{
			get
			{
				return "base64Binary";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003932 RID: 14642 RVA: 0x000CB2D4 File Offset: 0x000C94D4
		public string GetXsdType()
		{
			return SoapBase64Binary.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Один из следующих вариантов: 
		///
		/// <paramref name="value" /> имеет значение <see langword="null" />.  
		///
		/// – длина <paramref name="value" /> меньше 4;  
		/// – длина <paramref name="value" /> не кратна 4.</exception>
		// Token: 0x06003933 RID: 14643 RVA: 0x000CB2DB File Offset: 0x000C94DB
		public static SoapBase64Binary Parse(string value)
		{
			return new SoapBase64Binary(Convert.FromBase64String(value));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary.Value" />.</returns>
		// Token: 0x06003934 RID: 14644 RVA: 0x000CB2E8 File Offset: 0x000C94E8
		public override string ToString()
		{
			return Convert.ToBase64String(this._value);
		}

		// Token: 0x04002620 RID: 9760
		private byte[] _value;
	}
}
