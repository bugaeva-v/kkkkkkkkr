using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="integer" />.</summary>
	// Token: 0x020005ED RID: 1517
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapInteger : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger" />.</summary>
		// Token: 0x06003989 RID: 14729 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapInteger()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger" /> значением <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Decimal" />, служащее для инициализации текущего экземпляра.</param>
		// Token: 0x0600398A RID: 14730 RVA: 0x000CBBEA File Offset: 0x000C9DEA
		public SoapInteger(decimal value)
		{
			this._value = value;
		}

		/// <summary>Получает или задает числовое значение текущего экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.Decimal" />, указывающий числовое значение текущего экземпляра.</returns>
		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x000CBBF9 File Offset: 0x000C9DF9
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x000CBC01 File Offset: 0x000C9E01
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
		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x000CBC0A File Offset: 0x000C9E0A
		public static string XsdType
		{
			get
			{
				return "integer";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x0600398E RID: 14734 RVA: 0x000CBC11 File Offset: 0x000C9E11
		public string GetXsdType()
		{
			return SoapInteger.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x0600398F RID: 14735 RVA: 0x000CBC18 File Offset: 0x000C9E18
		public static SoapInteger Parse(string value)
		{
			return new SoapInteger(decimal.Parse(value));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger.Value" />.</returns>
		// Token: 0x06003990 RID: 14736 RVA: 0x000CBC25 File Offset: 0x000C9E25
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x0400262E RID: 9774
		private decimal _value;
	}
}
