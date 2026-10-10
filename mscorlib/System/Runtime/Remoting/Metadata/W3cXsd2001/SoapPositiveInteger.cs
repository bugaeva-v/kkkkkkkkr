using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="positiveInteger" />.</summary>
	// Token: 0x020005FA RID: 1530
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapPositiveInteger : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger" />.</summary>
		// Token: 0x060039F3 RID: 14835 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapPositiveInteger()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger" /> значением <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Decimal" />, служащее для инициализации текущего экземпляра.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Значение параметра <paramref name="value" /> меньше 1.</exception>
		// Token: 0x060039F4 RID: 14836 RVA: 0x000CBFFD File Offset: 0x000CA1FD
		public SoapPositiveInteger(decimal value)
		{
			if (value <= 0m)
			{
				throw SoapHelper.GetException(this, "invalid " + value.ToString());
			}
			this._value = value;
		}

		/// <summary>Получает или задает числовое значение текущего экземпляра.</summary>
		/// <returns>
		///   <see cref="T:System.Decimal" />, указывающий числовое значение текущего экземпляра.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Значение параметра <paramref name="value" /> меньше 1.</exception>
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x000CC031 File Offset: 0x000CA231
		// (set) Token: 0x060039F6 RID: 14838 RVA: 0x000CC039 File Offset: 0x000CA239
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
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x000CC042 File Offset: 0x000CA242
		public static string XsdType
		{
			get
			{
				return "positiveInteger";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039F8 RID: 14840 RVA: 0x000CC049 File Offset: 0x000CA249
		public string GetXsdType()
		{
			return SoapPositiveInteger.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039F9 RID: 14841 RVA: 0x000CC050 File Offset: 0x000CA250
		public static SoapPositiveInteger Parse(string value)
		{
			return new SoapPositiveInteger(decimal.Parse(value));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger.Value" />.</returns>
		// Token: 0x060039FA RID: 14842 RVA: 0x000CC05D File Offset: 0x000CA25D
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x0400263D RID: 9789
		private decimal _value;
	}
}
