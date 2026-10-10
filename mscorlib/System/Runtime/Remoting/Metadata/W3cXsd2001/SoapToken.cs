using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XML <see langword="token" />.</summary>
	// Token: 0x020005FD RID: 1533
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapToken : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken" />.</summary>
		// Token: 0x06003A12 RID: 14866 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapToken()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken" /> с XML-<see langword="token" />.</summary>
		/// <param name="value">Объект <see cref="T:System.String" /> содержащий <see langword="token" /> XML.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Один из следующих вариантов: 
		///
		/// <paramref name="value" /> содержит недопустимые символы (0xD или 0x9);  
		///
		/// <paramref name="value" /> [0] или <paramref name="value" /> [ <paramref name="value" />.Length — 1] содержат пробел;  
		///
		/// <paramref name="value" /> содержит пробелы.</exception>
		// Token: 0x06003A13 RID: 14867 RVA: 0x000CC2B4 File Offset: 0x000CA4B4
		public SoapToken(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или задает <see langword="token" /> XML.</summary>
		/// <returns>Объект <see cref="T:System.String" /> содержащий <see langword="token" /> XML.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">– Один из следующих вариантов: <paramref name="value" /> содержит недопустимые символы (0xD или 0x9);  
		///
		/// <paramref name="value" /> [0] или <paramref name="value" /> [ <paramref name="value" />.Length — 1] содержат пробел;  
		///
		/// <paramref name="value" /> содержит пробелы.</exception>
		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x000CC2C8 File Offset: 0x000CA4C8
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x000CC2D0 File Offset: 0x000CA4D0
		public string Value
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
		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x000CC2D9 File Offset: 0x000CA4D9
		public static string XsdType
		{
			get
			{
				return "token";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003A17 RID: 14871 RVA: 0x000CC2E0 File Offset: 0x000CA4E0
		public string GetXsdType()
		{
			return SoapToken.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x06003A18 RID: 14872 RVA: 0x000CC2E7 File Offset: 0x000CA4E7
		public static SoapToken Parse(string value)
		{
			return new SoapToken(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken.Value" />.</returns>
		// Token: 0x06003A19 RID: 14873 RVA: 0x000CC2C8 File Offset: 0x000CA4C8
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x04002643 RID: 9795
		private string _value;
	}
}
