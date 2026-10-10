using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XML <see langword="normalizedString" />.</summary>
	// Token: 0x020005F8 RID: 1528
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapNormalizedString : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString" />.</summary>
		// Token: 0x060039E3 RID: 14819 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapNormalizedString()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString" /> с нормализованной строкой.</summary>
		/// <param name="value">Объект <see cref="T:System.String" />, содержащий нормализованную строку.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> содержит недопустимые символы (0xD, 0xA или 0x9).</exception>
		// Token: 0x060039E4 RID: 14820 RVA: 0x000CBF8C File Offset: 0x000CA18C
		public SoapNormalizedString(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или задает нормализованную строку.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий нормализованную строку.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> содержит недопустимые символы (0xD, 0xA или 0x9).</exception>
		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060039E5 RID: 14821 RVA: 0x000CBFA0 File Offset: 0x000CA1A0
		// (set) Token: 0x060039E6 RID: 14822 RVA: 0x000CBFA8 File Offset: 0x000CA1A8
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
		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060039E7 RID: 14823 RVA: 0x000CBFB1 File Offset: 0x000CA1B1
		public static string XsdType
		{
			get
			{
				return "normalizedString";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039E8 RID: 14824 RVA: 0x000CBFB8 File Offset: 0x000CA1B8
		public string GetXsdType()
		{
			return SoapNormalizedString.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> содержит недопустимые символы (0xD, 0xA или 0x9).</exception>
		// Token: 0x060039E9 RID: 14825 RVA: 0x000CBFBF File Offset: 0x000CA1BF
		public static SoapNormalizedString Parse(string value)
		{
			return new SoapNormalizedString(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, полученный из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString.Value" />, в формате "&lt;![CDATA[" + <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString.Value" /> + "]]&gt;".</returns>
		// Token: 0x060039EA RID: 14826 RVA: 0x000CBFA0 File Offset: 0x000CA1A0
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0400263B RID: 9787
		private string _value;
	}
}
