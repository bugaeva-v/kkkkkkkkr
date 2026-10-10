using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="gMonthDay" />.</summary>
	// Token: 0x020005F0 RID: 1520
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapMonthDay : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay" />.</summary>
		// Token: 0x060039A2 RID: 14754 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapMonthDay()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay" /> с указанным объектом <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		// Token: 0x060039A3 RID: 14755 RVA: 0x000CBCE3 File Offset: 0x000C9EE3
		public SoapMonthDay(DateTime value)
		{
			this._value = value;
		}

		/// <summary>Получает или задает дату и время текущего экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" /> содержит дату и время текущего экземпляра.</returns>
		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060039A4 RID: 14756 RVA: 0x000CBCF2 File Offset: 0x000C9EF2
		// (set) Token: 0x060039A5 RID: 14757 RVA: 0x000CBCFA File Offset: 0x000C9EFA
		public DateTime Value
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
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060039A6 RID: 14758 RVA: 0x000CBD03 File Offset: 0x000C9F03
		public static string XsdType
		{
			get
			{
				return "gMonthDay";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039A7 RID: 14759 RVA: 0x000CBD0A File Offset: 0x000C9F0A
		public string GetXsdType()
		{
			return SoapMonthDay.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> не содержит дату и время, соответствующие каким-либо распознаваемым шаблонам формата.</exception>
		// Token: 0x060039A8 RID: 14760 RVA: 0x000CBD11 File Offset: 0x000C9F11
		public static SoapMonthDay Parse(string value)
		{
			return new SoapMonthDay(DateTime.ParseExact(value, SoapMonthDay._datetimeFormats, null, DateTimeStyles.None));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, полученный из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay.Value" />, в формате "'--'MM'-'dd".</returns>
		// Token: 0x060039A9 RID: 14761 RVA: 0x000CBD25 File Offset: 0x000C9F25
		public override string ToString()
		{
			return this._value.ToString("--MM-dd", CultureInfo.InvariantCulture);
		}

		// Token: 0x04002632 RID: 9778
		private static readonly string[] _datetimeFormats = new string[]
		{
			"--MM-dd",
			"--MM-ddzzz"
		};

		// Token: 0x04002633 RID: 9779
		private DateTime _value;
	}
}
