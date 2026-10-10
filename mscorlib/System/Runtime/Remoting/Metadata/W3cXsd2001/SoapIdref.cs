using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку атрибут XML <see langword="IDREFS" />.</summary>
	// Token: 0x020005EB RID: 1515
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapIdref : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref" />.</summary>
		// Token: 0x06003979 RID: 14713 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapIdref()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref" /> с атрибутом XML <see langword="IDREF" />.</summary>
		/// <param name="value">Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="IDREF" />.</param>
		// Token: 0x0600397A RID: 14714 RVA: 0x000CBB74 File Offset: 0x000C9D74
		public SoapIdref(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает атрибут XML <see langword="IDREF" />.</summary>
		/// <returns>Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="IDREF" />.</returns>
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x000CBB88 File Offset: 0x000C9D88
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x000CBB90 File Offset: 0x000C9D90
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
		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x000CBB99 File Offset: 0x000C9D99
		public static string XsdType
		{
			get
			{
				return "IDREF";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x0600397E RID: 14718 RVA: 0x000CBBA0 File Offset: 0x000C9DA0
		public string GetXsdType()
		{
			return SoapIdref.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.String" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x0600397F RID: 14719 RVA: 0x000CBBA7 File Offset: 0x000C9DA7
		public static SoapIdref Parse(string value)
		{
			return new SoapIdref(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref.Value" />.</returns>
		// Token: 0x06003980 RID: 14720 RVA: 0x000CBB88 File Offset: 0x000C9D88
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0400262C RID: 9772
		private string _value;
	}
}
