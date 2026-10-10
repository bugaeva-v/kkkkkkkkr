using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку атрибут XML <see langword="IDREFS" />.</summary>
	// Token: 0x020005EC RID: 1516
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapIdrefs : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs" />.</summary>
		// Token: 0x06003981 RID: 14721 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapIdrefs()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs" /> с атрибутом XML <see langword="IDREFS" />.</summary>
		/// <param name="value">Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="IDREFS" />.</param>
		// Token: 0x06003982 RID: 14722 RVA: 0x000CBBAF File Offset: 0x000C9DAF
		public SoapIdrefs(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает атрибут XML <see langword="IDREFS" />.</summary>
		/// <returns>Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="IDREFS" />.</returns>
		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x000CBBC3 File Offset: 0x000C9DC3
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x000CBBCB File Offset: 0x000C9DCB
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
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x000CBBD4 File Offset: 0x000C9DD4
		public static string XsdType
		{
			get
			{
				return "IDREFS";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003986 RID: 14726 RVA: 0x000CBBDB File Offset: 0x000C9DDB
		public string GetXsdType()
		{
			return SoapIdrefs.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <paramref name="value" />.</returns>
		// Token: 0x06003987 RID: 14727 RVA: 0x000CBBE2 File Offset: 0x000C9DE2
		public static SoapIdrefs Parse(string value)
		{
			return new SoapIdrefs(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs.Value" />.</returns>
		// Token: 0x06003988 RID: 14728 RVA: 0x000CBBC3 File Offset: 0x000C9DC3
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0400262D RID: 9773
		private string _value;
	}
}
