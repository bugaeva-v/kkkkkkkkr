using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="date" />.</summary>
	// Token: 0x020005E2 RID: 1506
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapDate : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate" />.</summary>
		// Token: 0x06003935 RID: 14645 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapDate()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate" /> с указанным объектом <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		// Token: 0x06003936 RID: 14646 RVA: 0x000CB2F5 File Offset: 0x000C94F5
		public SoapDate(DateTime value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate" /> с заданным объектом <see cref="T:System.DateTime" /> и целое число, указывающее, является ли <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate.Value" /> положительным или отрицательным значением.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		/// <param name="sign">Целое число, указывающее, является ли <paramref name="value" /> положительным.</param>
		// Token: 0x06003937 RID: 14647 RVA: 0x000CB304 File Offset: 0x000C9504
		public SoapDate(DateTime value, int sign)
		{
			this._value = value;
			this._sign = sign;
		}

		/// <summary>Получает или задает, являются ли дата и время текущего экземпляра положительными или отрицательными.</summary>
		/// <returns>Целое число, указывающее, является ли <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate.Value" /> положительным или отрицательным.</returns>
		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x000CB31A File Offset: 0x000C951A
		// (set) Token: 0x06003939 RID: 14649 RVA: 0x000CB322 File Offset: 0x000C9522
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
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x000CB32B File Offset: 0x000C952B
		// (set) Token: 0x0600393B RID: 14651 RVA: 0x000CB333 File Offset: 0x000C9533
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
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600393C RID: 14652 RVA: 0x000CB33C File Offset: 0x000C953C
		public static string XsdType
		{
			get
			{
				return "date";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x0600393D RID: 14653 RVA: 0x000CB343 File Offset: 0x000C9543
		public string GetXsdType()
		{
			return SoapDate.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> не содержит дату и время, соответствующие каким-либо распознаваемым шаблонам формата.</exception>
		// Token: 0x0600393E RID: 14654 RVA: 0x000CB34C File Offset: 0x000C954C
		public static SoapDate Parse(string value)
		{
			SoapDate soapDate = new SoapDate(DateTime.ParseExact(value, SoapDate._datetimeFormats, null, DateTimeStyles.None));
			if (value.StartsWith("-"))
			{
				soapDate.Sign = -1;
			}
			else
			{
				soapDate.Sign = 0;
			}
			return soapDate;
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, полученный из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate.Value" /> в формате "yyyy-MM-dd" или "'-'yyyy-MM-dd", если <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate.Sign" /> меньше нуля.</returns>
		// Token: 0x0600393F RID: 14655 RVA: 0x000CB38A File Offset: 0x000C958A
		public override string ToString()
		{
			if (this._sign >= 0)
			{
				return this._value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
			}
			return this._value.ToString("'-'yyyy-MM-dd", CultureInfo.InvariantCulture);
		}

		// Token: 0x04002621 RID: 9761
		private static readonly string[] _datetimeFormats = new string[]
		{
			"yyyy-MM-dd",
			"'+'yyyy-MM-dd",
			"'-'yyyy-MM-dd",
			"yyyy-MM-ddzzz",
			"'+'yyyy-MM-ddzzz",
			"'-'yyyy-MM-ddzzz"
		};

		// Token: 0x04002622 RID: 9762
		private int _sign;

		// Token: 0x04002623 RID: 9763
		private DateTime _value;
	}
}
