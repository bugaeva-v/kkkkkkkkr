using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку атрибут XML <see langword="ID" />.</summary>
	// Token: 0x020005EA RID: 1514
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapId : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId" />.</summary>
		// Token: 0x06003971 RID: 14705 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapId()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId" /> с атрибутом XML <see langword="ID" />.</summary>
		/// <param name="value">Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="ID" />.</param>
		// Token: 0x06003972 RID: 14706 RVA: 0x000CBB39 File Offset: 0x000C9D39
		public SoapId(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает атрибут XML <see langword="ID" />.</summary>
		/// <returns>Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="ID" />.</returns>
		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x000CBB4D File Offset: 0x000C9D4D
		// (set) Token: 0x06003974 RID: 14708 RVA: 0x000CBB55 File Offset: 0x000C9D55
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
		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x000CBB5E File Offset: 0x000C9D5E
		public static string XsdType
		{
			get
			{
				return "ID";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003976 RID: 14710 RVA: 0x000CBB65 File Offset: 0x000C9D65
		public string GetXsdType()
		{
			return SoapId.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x06003977 RID: 14711 RVA: 0x000CBB6C File Offset: 0x000C9D6C
		public static SoapId Parse(string value)
		{
			return new SoapId(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId.Value" />.</returns>
		// Token: 0x06003978 RID: 14712 RVA: 0x000CBB4D File Offset: 0x000C9D4D
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0400262B RID: 9771
		private string _value;
	}
}
