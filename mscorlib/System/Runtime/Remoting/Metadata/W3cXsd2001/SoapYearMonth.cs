using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="gYearMonth" />.</summary>
	// Token: 0x020005FF RID: 1535
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapYearMonth : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" />.</summary>
		// Token: 0x06003A26 RID: 14886 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapYearMonth()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" /> с указанным объектом <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		// Token: 0x06003A27 RID: 14887 RVA: 0x000CC3F5 File Offset: 0x000CA5F5
		public SoapYearMonth(DateTime value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" /> с заданным объектом <see cref="T:System.DateTime" /> и целое число, указывающее, является ли <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.Value" /> положительным или отрицательным значением.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		/// <param name="sign">Целое число, указывающее, является ли <paramref name="value" /> положительным.</param>
		// Token: 0x06003A28 RID: 14888 RVA: 0x000CC404 File Offset: 0x000CA604
		public SoapYearMonth(DateTime value, int sign)
		{
			this._value = value;
			this._sign = sign;
		}

		/// <summary>Получает или задает, являются ли дата и время текущего экземпляра положительными или отрицательными.</summary>
		/// <returns>Целое число, указывающее, является ли <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.Value" /> положительным или отрицательным.</returns>
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x000CC41A File Offset: 0x000CA61A
		// (set) Token: 0x06003A2A RID: 14890 RVA: 0x000CC422 File Offset: 0x000CA622
		public int Sign
		{
			get
			{
				return this._sign;
			}
			set
			{
				this._sign = value;
			}
		}

		/// <summary>Получает или задает дату и время текущего экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" /> содержит дату и время текущего экземпляра.</returns>
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x000CC42B File Offset: 0x000CA62B
		// (set) Token: 0x06003A2C RID: 14892 RVA: 0x000CC433 File Offset: 0x000CA633
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
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x000CC43C File Offset: 0x000CA63C
		public static string XsdType
		{
			get
			{
				return "gYearMonth";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003A2E RID: 14894 RVA: 0x000CC443 File Offset: 0x000CA643
		public string GetXsdType()
		{
			return SoapYearMonth.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" />.</summary>
		/// <param name="value">Преобразуемая строка <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> не содержит дату и время, соответствующие каким-либо распознаваемым шаблонам формата.</exception>
		// Token: 0x06003A2F RID: 14895 RVA: 0x000CC44C File Offset: 0x000CA64C
		public static SoapYearMonth Parse(string value)
		{
			SoapYearMonth soapYearMonth = new SoapYearMonth(DateTime.ParseExact(value, SoapYearMonth._datetimeFormats, null, DateTimeStyles.None));
			if (value.StartsWith("-"))
			{
				soapYearMonth.Sign = -1;
			}
			else
			{
				soapYearMonth.Sign = 0;
			}
			return soapYearMonth;
		}

		/// <summary>Возвращает значение свойства <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.Value" /> в качестве <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, полученный из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.Value" /> в формате "yyyy-MM" или "'-'yyyy-MM", если <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.Sign" /> меньше нуля.</returns>
		// Token: 0x06003A30 RID: 14896 RVA: 0x000CC48A File Offset: 0x000CA68A
		public override string ToString()
		{
			if (this._sign >= 0)
			{
				return this._value.ToString("yyyy-MM", CultureInfo.InvariantCulture);
			}
			return this._value.ToString("'-'yyyy-MM", CultureInfo.InvariantCulture);
		}

		// Token: 0x04002647 RID: 9799
		private static readonly string[] _datetimeFormats = new string[]
		{
			"yyyy-MM",
			"'+'yyyy-MM",
			"'-'yyyy-MM",
			"yyyy-MMzzz",
			"'+'yyyy-MMzzz",
			"'-'yyyy-MMzzz"
		};

		// Token: 0x04002648 RID: 9800
		private int _sign;

		// Token: 0x04002649 RID: 9801
		private DateTime _value;
	}
}
