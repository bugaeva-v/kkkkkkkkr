using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип атрибута XML <see langword="NOTATION" />.</summary>
	// Token: 0x020005F9 RID: 1529
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapNotation : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation" />.</summary>
		// Token: 0x060039EB RID: 14827 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapNotation()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation" /> с атрибутом XML <see langword="NOTATION" />.</summary>
		/// <param name="value">Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="NOTATION" />.</param>
		// Token: 0x060039EC RID: 14828 RVA: 0x000CBFC7 File Offset: 0x000CA1C7
		public SoapNotation(string value)
		{
			this._value = value;
		}

		/// <summary>Получает или устанавливает атрибут XML <see langword="NOTATION" />.</summary>
		/// <returns>Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="NOTATION" />.</returns>
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060039ED RID: 14829 RVA: 0x000CBFD6 File Offset: 0x000CA1D6
		// (set) Token: 0x060039EE RID: 14830 RVA: 0x000CBFDE File Offset: 0x000CA1DE
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
		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060039EF RID: 14831 RVA: 0x000CBFE7 File Offset: 0x000CA1E7
		public static string XsdType
		{
			get
			{
				return "NOTATION";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039F0 RID: 14832 RVA: 0x000CBFEE File Offset: 0x000CA1EE
		public string GetXsdType()
		{
			return SoapNotation.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039F1 RID: 14833 RVA: 0x000CBFF5 File Offset: 0x000CA1F5
		public static SoapNotation Parse(string value)
		{
			return new SoapNotation(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation.Value" />.</returns>
		// Token: 0x060039F2 RID: 14834 RVA: 0x000CBFD6 File Offset: 0x000CA1D6
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0400263C RID: 9788
		private string _value;
	}
}
