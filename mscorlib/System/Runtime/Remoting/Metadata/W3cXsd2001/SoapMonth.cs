using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="gMonth" />.</summary>
	// Token: 0x020005EF RID: 1519
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapMonth : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth" />.</summary>
		// Token: 0x06003999 RID: 14745 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapMonth()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth" /> с указанным объектом <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		// Token: 0x0600399A RID: 14746 RVA: 0x000CBC6D File Offset: 0x000C9E6D
		public SoapMonth(DateTime value)
		{
			this._value = value;
		}

		/// <summary>Получает или задает дату и время текущего экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" /> содержит дату и время текущего экземпляра.</returns>
		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x000CBC7C File Offset: 0x000C9E7C
		// (set) Token: 0x0600399C RID: 14748 RVA: 0x000CBC84 File Offset: 0x000C9E84
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
		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x000CBC8D File Offset: 0x000C9E8D
		public static string XsdType
		{
			get
			{
				return "gMonth";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x0600399E RID: 14750 RVA: 0x000CBC94 File Offset: 0x000C9E94
		public string GetXsdType()
		{
			return SoapMonth.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> не содержит дату и время, соответствующие каким-либо распознаваемым шаблонам формата.</exception>
		// Token: 0x0600399F RID: 14751 RVA: 0x000CBC9B File Offset: 0x000C9E9B
		public static SoapMonth Parse(string value)
		{
			return new SoapMonth(DateTime.ParseExact(value, SoapMonth._datetimeFormats, null, DateTimeStyles.None));
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, полученный из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth.Value" />, в формате "--MM--".</returns>
		// Token: 0x060039A0 RID: 14752 RVA: 0x000CBCAF File Offset: 0x000C9EAF
		public override string ToString()
		{
			return this._value.ToString("--MM--", CultureInfo.InvariantCulture);
		}

		// Token: 0x04002630 RID: 9776
		private static readonly string[] _datetimeFormats = new string[]
		{
			"--MM--",
			"--MM--zzz"
		};

		// Token: 0x04002631 RID: 9777
		private DateTime _value;
	}
}
