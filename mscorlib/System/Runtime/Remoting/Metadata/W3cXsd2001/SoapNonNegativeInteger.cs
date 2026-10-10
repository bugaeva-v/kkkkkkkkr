using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="nonNegativeInteger" />.</summary>
	// Token: 0x020005F6 RID: 1526
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapNonNegativeInteger : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger" />.</summary>
		// Token: 0x060039D3 RID: 14803 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapNonNegativeInteger()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger" /> значением <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Decimal" />, служащее для инициализации текущего экземпляра.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Значение параметра <paramref name="value" /> меньше 0.</exception>
		// Token: 0x060039D4 RID: 14804 RVA: 0x000CBEB2 File Offset: 0x000CA0B2
		public SoapNonNegativeInteger(decimal value)
		{
			if (value < 0m)
			{
				throw SoapHelper.GetException(this, "invalid " + value.ToString());
			}
			this._value = value;
		}

		/// <summary>Получает или задает числовое значение текущего экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.Decimal" />, указывающий числовое значение текущего экземпляра.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Значение параметра <paramref name="value" /> меньше 0.</exception>
		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x000CBEE6 File Offset: 0x000CA0E6
		// (set) Token: 0x060039D6 RID: 14806 RVA: 0x000CBEEE File Offset: 0x000CA0EE
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
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060039D7 RID: 14807 RVA: 0x000CBEF7 File Offset: 0x000CA0F7
		public static string XsdType
		{
			get
			{
				return "nonNegativeInteger";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039D8 RID: 14808 RVA: 0x000CBEFE File Offset: 0x000CA0FE
		public string GetXsdType()
		{
			return SoapNonNegativeInteger.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039D9 RID: 14809 RVA: 0x000CBF05 File Offset: 0x000CA105
		public static SoapNonNegativeInteger Parse(string value)
		{
			return new SoapNonNegativeInteger(decimal.Parse(value));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger.Value" />.</returns>
		// Token: 0x060039DA RID: 14810 RVA: 0x000CBF12 File Offset: 0x000CA112
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x04002639 RID: 9785
		private decimal _value;
	}
}
