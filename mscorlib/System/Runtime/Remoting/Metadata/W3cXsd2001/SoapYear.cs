using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="gYear" />.</summary>
	// Token: 0x020005FE RID: 1534
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapYear : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear" />.</summary>
		// Token: 0x06003A1A RID: 14874 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapYear()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear" /> с указанным объектом <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		// Token: 0x06003A1B RID: 14875 RVA: 0x000CC2EF File Offset: 0x000CA4EF
		public SoapYear(DateTime value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear" /> с заданным объектом <see cref="T:System.DateTime" /> и целое число, указывающее, является ли <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear.Value" /> положительным или отрицательным значением.</summary>
		/// <param name="value">Объект <see cref="T:System.DateTime" />, служащий для инициализации текущего экземпляра.</param>
		/// <param name="sign">Целое число, указывающее, является ли <paramref name="value" /> положительным.</param>
		// Token: 0x06003A1C RID: 14876 RVA: 0x000CC2FE File Offset: 0x000CA4FE
		public SoapYear(DateTime value, int sign)
		{
			this._value = value;
			this._sign = sign;
		}

		/// <summary>Получает или задает, являются ли дата и время текущего экземпляра положительными или отрицательными.</summary>
		/// <returns>Целое число, указывающее, является ли <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear.Value" /> положительным или отрицательным.</returns>
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06003A1D RID: 14877 RVA: 0x000CC314 File Offset: 0x000CA514
		// (set) Token: 0x06003A1E RID: 14878 RVA: 0x000CC31C File Offset: 0x000CA51C
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
		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06003A1F RID: 14879 RVA: 0x000CC325 File Offset: 0x000CA525
		// (set) Token: 0x06003A20 RID: 14880 RVA: 0x000CC32D File Offset: 0x000CA52D
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
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06003A21 RID: 14881 RVA: 0x000CC336 File Offset: 0x000CA536
		public static string XsdType
		{
			get
			{
				return "gYear";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003A22 RID: 14882 RVA: 0x000CC33D File Offset: 0x000CA53D
		public string GetXsdType()
		{
			return SoapYear.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="value" /> не содержит дату и время, соответствующие каким-либо распознаваемым шаблонам формата.</exception>
		// Token: 0x06003A23 RID: 14883 RVA: 0x000CC344 File Offset: 0x000CA544
		public static SoapYear Parse(string value)
		{
			SoapYear soapYear = new SoapYear(DateTime.ParseExact(value, SoapYear._datetimeFormats, null, DateTimeStyles.None));
			if (value.StartsWith("-"))
			{
				soapYear.Sign = -1;
			}
			else
			{
				soapYear.Sign = 0;
			}
			return soapYear;
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, полученный из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear.Value" /> в формате "yyyy" или "-yyyy", если <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear.Sign" /> меньше нуля.</returns>
		// Token: 0x06003A24 RID: 14884 RVA: 0x000CC382 File Offset: 0x000CA582
		public override string ToString()
		{
			if (this._sign >= 0)
			{
				return this._value.ToString("yyyy", CultureInfo.InvariantCulture);
			}
			return this._value.ToString("'-'yyyy", CultureInfo.InvariantCulture);
		}

		// Token: 0x04002644 RID: 9796
		private static readonly string[] _datetimeFormats = new string[]
		{
			"yyyy",
			"'+'yyyy",
			"'-'yyyy",
			"yyyyzzz",
			"'+'yyyyzzz",
			"'-'yyyyzzz"
		};

		// Token: 0x04002645 RID: 9797
		private int _sign;

		// Token: 0x04002646 RID: 9798
		private DateTime _value;
	}
}
