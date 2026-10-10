using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="negativeInteger" />.</summary>
	// Token: 0x020005F3 RID: 1523
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapNegativeInteger : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger" />.</summary>
		// Token: 0x060039BB RID: 14779 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapNegativeInteger()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger" /> значением <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Decimal" />, служащее для инициализации текущего экземпляра.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> больше –1.</exception>
		// Token: 0x060039BC RID: 14780 RVA: 0x000CBDCF File Offset: 0x000C9FCF
		public SoapNegativeInteger(decimal value)
		{
			if (value >= 0m)
			{
				throw SoapHelper.GetException(this, "invalid " + value.ToString());
			}
			this._value = value;
		}

		/// <summary>Получает или задает числовое значение текущего экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.Decimal" />, указывающий числовое значение текущего экземпляра.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> больше –1.</exception>
		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060039BD RID: 14781 RVA: 0x000CBE03 File Offset: 0x000CA003
		// (set) Token: 0x060039BE RID: 14782 RVA: 0x000CBE0B File Offset: 0x000CA00B
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
		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060039BF RID: 14783 RVA: 0x000CBE14 File Offset: 0x000CA014
		public static string XsdType
		{
			get
			{
				return "negativeInteger";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039C0 RID: 14784 RVA: 0x000CBE1B File Offset: 0x000CA01B
		public string GetXsdType()
		{
			return SoapNegativeInteger.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039C1 RID: 14785 RVA: 0x000CBE22 File Offset: 0x000CA022
		public static SoapNegativeInteger Parse(string value)
		{
			return new SoapNegativeInteger(decimal.Parse(value));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see langword="Value" />.</returns>
		// Token: 0x060039C2 RID: 14786 RVA: 0x000CBE2F File Offset: 0x000CA02F
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x04002636 RID: 9782
		private decimal _value;
	}
}
