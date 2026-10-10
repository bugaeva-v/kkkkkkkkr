using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="nonPositiveInteger" />.</summary>
	// Token: 0x020005F7 RID: 1527
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapNonPositiveInteger : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger" />.</summary>
		// Token: 0x060039DB RID: 14811 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapNonPositiveInteger()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger" /> значением <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Decimal" />, служащее для инициализации текущего экземпляра.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Значение параметра <paramref name="value" /> больше нуля.</exception>
		// Token: 0x060039DC RID: 14812 RVA: 0x000CBF1F File Offset: 0x000CA11F
		public SoapNonPositiveInteger(decimal value)
		{
			if (value > 0m)
			{
				throw SoapHelper.GetException(this, "invalid " + value.ToString());
			}
			this._value = value;
		}

		/// <summary>Получает или задает числовое значение текущего экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.Decimal" />, указывающий числовое значение текущего экземпляра.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Значение параметра <paramref name="value" /> больше нуля.</exception>
		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060039DD RID: 14813 RVA: 0x000CBF53 File Offset: 0x000CA153
		// (set) Token: 0x060039DE RID: 14814 RVA: 0x000CBF5B File Offset: 0x000CA15B
		public decimal Value
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
		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x000CBF64 File Offset: 0x000CA164
		public static string XsdType
		{
			get
			{
				return "nonPositiveInteger";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039E0 RID: 14816 RVA: 0x000CBF6B File Offset: 0x000CA16B
		public string GetXsdType()
		{
			return SoapNonPositiveInteger.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039E1 RID: 14817 RVA: 0x000CBF72 File Offset: 0x000CA172
		public static SoapNonPositiveInteger Parse(string value)
		{
			return new SoapNonPositiveInteger(decimal.Parse(value));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see langword="Value" />.</returns>
		// Token: 0x060039E2 RID: 14818 RVA: 0x000CBF7F File Offset: 0x000CA17F
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x0400263A RID: 9786
		private decimal _value;
	}
}
