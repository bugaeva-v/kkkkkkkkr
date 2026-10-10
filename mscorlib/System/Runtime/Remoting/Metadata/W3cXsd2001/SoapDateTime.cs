using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Предоставляет статические методы сериализации и десериализации <see cref="T:System.DateTime" /> в строку, отформатированную как XSD <see langword="dateTime" />.</summary>
	// Token: 0x020005E3 RID: 1507
	[ComVisible(true)]
	public sealed class SoapDateTime
	{
		/// <summary>Получает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06003942 RID: 14658 RVA: 0x000CB3FD File Offset: 0x000C95FD
		public static string XsdType
		{
			get
			{
				return "dateTime";
			}
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный из <paramref name="value" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Один из следующих вариантов: 
		///
		/// параметр <paramref name="value" /> равен пустой строке;  
		///
		/// <paramref name="value" /> является ссылкой <see langword="null" />;  
		///
		/// <paramref name="value" /> не содержит дату и время, соответствующие каким-либо распознаваемым шаблонам формата.</exception>
		// Token: 0x06003943 RID: 14659 RVA: 0x000CB404 File Offset: 0x000C9604
		public static DateTime Parse(string value)
		{
			return DateTime.ParseExact(value, SoapDateTime._datetimeFormats, null, DateTimeStyles.None);
		}

		/// <summary>Возвращает указанный объект <see cref="T:System.DateTime" /> в виде объекта <see cref="T:System.String" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.DateTime" />.</param>
		/// <returns>Представление <see cref="T:System.String" /><paramref name="value" /> в формате "yyyy-MM-dd'T'HH:mm:ss.fffffffzzz".</returns>
		// Token: 0x06003944 RID: 14660 RVA: 0x000CB413 File Offset: 0x000C9613
		public static string ToString(DateTime value)
		{
			return value.ToString("yyyy-MM-ddTHH:mm:ss.fffffffzzz", CultureInfo.InvariantCulture);
		}

		// Token: 0x04002624 RID: 9764
		private static readonly string[] _datetimeFormats = new string[]
		{
			"yyyy-MM-ddTHH:mm:ss",
			"yyyy-MM-ddTHH:mm:ss.f",
			"yyyy-MM-ddTHH:mm:ss.ff",
			"yyyy-MM-ddTHH:mm:ss.fff",
			"yyyy-MM-ddTHH:mm:ss.ffff",
			"yyyy-MM-ddTHH:mm:ss.fffff",
			"yyyy-MM-ddTHH:mm:ss.ffffff",
			"yyyy-MM-ddTHH:mm:ss.fffffff",
			"yyyy-MM-ddTHH:mm:sszzz",
			"yyyy-MM-ddTHH:mm:ss.fzzz",
			"yyyy-MM-ddTHH:mm:ss.ffzzz",
			"yyyy-MM-ddTHH:mm:ss.fffzzz",
			"yyyy-MM-ddTHH:mm:ss.ffffzzz",
			"yyyy-MM-ddTHH:mm:ss.fffffzzz",
			"yyyy-MM-ddTHH:mm:ss.ffffffzzz",
			"yyyy-MM-ddTHH:mm:ss.fffffffzzz",
			"yyyy-MM-ddTHH:mm:ssZ",
			"yyyy-MM-ddTHH:mm:ss.fZ",
			"yyyy-MM-ddTHH:mm:ss.ffZ",
			"yyyy-MM-ddTHH:mm:ss.fffZ",
			"yyyy-MM-ddTHH:mm:ss.ffffZ",
			"yyyy-MM-ddTHH:mm:ss.fffffZ",
			"yyyy-MM-ddTHH:mm:ss.ffffffZ",
			"yyyy-MM-ddTHH:mm:ss.fffffffZ"
		};
	}
}
