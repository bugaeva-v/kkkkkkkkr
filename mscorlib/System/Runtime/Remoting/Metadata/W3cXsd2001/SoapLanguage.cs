using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XML <see langword="language" />.</summary>
	// Token: 0x020005EE RID: 1518
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapLanguage : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage" />.</summary>
		// Token: 0x06003991 RID: 14737 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapLanguage()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage" /> со значением идентификатора языка атрибута <see langword="language" />.</summary>
		/// <param name="value">Объект <see cref="T:System.String" />, содержащий значение идентификатора языка атрибута <see langword="language" />.</param>
		// Token: 0x06003992 RID: 14738 RVA: 0x000CBC32 File Offset: 0x000C9E32
		public SoapLanguage(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или задает идентификатор языка атрибута <see langword="language" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий значение идентификатора языка атрибута <see langword="language" />.</returns>
		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x000CBC46 File Offset: 0x000C9E46
		// (set) Token: 0x06003994 RID: 14740 RVA: 0x000CBC4E File Offset: 0x000C9E4E
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
		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x000CBC57 File Offset: 0x000C9E57
		public static string XsdType
		{
			get
			{
				return "language";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003996 RID: 14742 RVA: 0x000CBC5E File Offset: 0x000C9E5E
		public string GetXsdType()
		{
			return SoapLanguage.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x06003997 RID: 14743 RVA: 0x000CBC65 File Offset: 0x000C9E65
		public static SoapLanguage Parse(string value)
		{
			return new SoapLanguage(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage" />, полученный из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage.Value" />.</returns>
		// Token: 0x06003998 RID: 14744 RVA: 0x000CBC46 File Offset: 0x000C9E46
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0400262F RID: 9775
		private string _value;
	}
}
