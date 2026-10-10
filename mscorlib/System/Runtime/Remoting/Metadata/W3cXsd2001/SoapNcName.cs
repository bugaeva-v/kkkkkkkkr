using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XML <see langword="NcName" />.</summary>
	// Token: 0x020005F2 RID: 1522
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapNcName : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName" />.</summary>
		// Token: 0x060039B3 RID: 14771 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapNcName()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName" /> с типом XML <see langword="NcName" />.</summary>
		/// <param name="value">Строка <see cref="T:System.String" />, содержащая тип XML <see langword="NcName" />.</param>
		// Token: 0x060039B4 RID: 14772 RVA: 0x000CBD94 File Offset: 0x000C9F94
		public SoapNcName(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает тип XML <see langword="NcName" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая тип XML <see langword="NcName" />.</returns>
		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060039B5 RID: 14773 RVA: 0x000CBDA8 File Offset: 0x000C9FA8
		// (set) Token: 0x060039B6 RID: 14774 RVA: 0x000CBDB0 File Offset: 0x000C9FB0
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
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060039B7 RID: 14775 RVA: 0x000CBDB9 File Offset: 0x000C9FB9
		public static string XsdType
		{
			get
			{
				return "NCName";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039B8 RID: 14776 RVA: 0x000CBDC0 File Offset: 0x000C9FC0
		public string GetXsdType()
		{
			return SoapNcName.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039B9 RID: 14777 RVA: 0x000CBDC7 File Offset: 0x000C9FC7
		public static SoapNcName Parse(string value)
		{
			return new SoapNcName(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName.Value" />.</returns>
		// Token: 0x060039BA RID: 14778 RVA: 0x000CBDA8 File Offset: 0x000C9FA8
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x04002635 RID: 9781
		private string _value;
	}
}
