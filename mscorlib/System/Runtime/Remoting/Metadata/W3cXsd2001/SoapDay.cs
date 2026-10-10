using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="gDay" />.</summary>
	// Token: 0x020005E4 RID: 1508
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapDay : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay" />.</summary>
		// Token: 0x06003946 RID: 14662 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapDay()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay" /> с указанным объектом <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		// Token: 0x06003947 RID: 14663 RVA: 0x000CB510 File Offset: 0x000C9710
		public SoapDay(DateTime value)
		{
			this._value = value;
		}

		/// <summary>Получает или задает дату и время текущего экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" /> содержит дату и время текущего экземпляра.</returns>
		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x000CB51F File Offset: 0x000C971F
		// (set) Token: 0x06003949 RID: 14665 RVA: 0x000CB527 File Offset: 0x000C9727
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
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x000CB530 File Offset: 0x000C9730
		public static string XsdType
		{
			get
			{
				return "gDay";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x0600394B RID: 14667 RVA: 0x000CB537 File Offset: 0x000C9737
		public string GetXsdType()
		{
			return SoapDay.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> не содержит дату и время, соответствующие каким-либо распознаваемым шаблонам формата.</exception>
		// Token: 0x0600394C RID: 14668 RVA: 0x000CB53E File Offset: 0x000C973E
		public static SoapDay Parse(string value)
		{
			return new SoapDay(DateTime.ParseExact(value, SoapDay._datetimeFormats, null, DateTimeStyles.None));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, полученный из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay.Value" /> в формате "---dd".</returns>
		// Token: 0x0600394D RID: 14669 RVA: 0x000CB552 File Offset: 0x000C9752
		public override string ToString()
		{
			return this._value.ToString("---dd", CultureInfo.InvariantCulture);
		}

		// Token: 0x04002625 RID: 9765
		private static readonly string[] _datetimeFormats = new string[]
		{
			"---dd",
			"---ddzzz"
		};

		// Token: 0x04002626 RID: 9766
		private DateTime _value;
	}
}
