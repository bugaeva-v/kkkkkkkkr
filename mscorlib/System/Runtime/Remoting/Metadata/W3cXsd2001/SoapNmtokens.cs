using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку атрибут XML <see langword="NMTOKENS" />.</summary>
	// Token: 0x020005F5 RID: 1525
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapNmtokens : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens" />.</summary>
		// Token: 0x060039CB RID: 14795 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapNmtokens()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens" /> с атрибутом XML <see langword="NMTOKENS" />.</summary>
		/// <param name="value">Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="NMTOKENS" />.</param>
		// Token: 0x060039CC RID: 14796 RVA: 0x000CBE77 File Offset: 0x000CA077
		public SoapNmtokens(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает атрибут XML <see langword="NMTOKENS" />.</summary>
		/// <returns>Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="NMTOKENS" />.</returns>
		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060039CD RID: 14797 RVA: 0x000CBE8B File Offset: 0x000CA08B
		// (set) Token: 0x060039CE RID: 14798 RVA: 0x000CBE93 File Offset: 0x000CA093
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
		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060039CF RID: 14799 RVA: 0x000CBE9C File Offset: 0x000CA09C
		public static string XsdType
		{
			get
			{
				return "NMTOKENS";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039D0 RID: 14800 RVA: 0x000CBEA3 File Offset: 0x000CA0A3
		public string GetXsdType()
		{
			return SoapNmtokens.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039D1 RID: 14801 RVA: 0x000CBEAA File Offset: 0x000CA0AA
		public static SoapNmtokens Parse(string value)
		{
			return new SoapNmtokens(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens.Value" />.</returns>
		// Token: 0x060039D2 RID: 14802 RVA: 0x000CBE8B File Offset: 0x000CA08B
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x04002638 RID: 9784
		private string _value;
	}
}
