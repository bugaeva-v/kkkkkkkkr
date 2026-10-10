using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace System.Runtime.Serialization.Json
{
	/// <summary>Создает экземпляры <see cref="T:System.Xml.XmlDictionaryReader" />, которые могут осуществлять чтение данных, кодированных с использованием нотации объектов JavaScript (JSON), из потока или буфера и сопоставлять их набору сведений XML, а также экземпляры <see cref="T:System.Xml.XmlDictionaryWriter" />, которые могут сопоставлять набор сведений XML данным JSON и записывать данные с кодированием JSON в поток.</summary>
	// Token: 0x02000188 RID: 392
	[TypeForwardedFrom("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
	public static class JsonReaderWriterFactory
	{
		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может сопоставлять потоки, кодированные с использованием нотации объектов JavaScript (JSON), набору сведений XML.</summary>
		/// <param name="stream">Входной поток <see cref="T:System.IO.Stream" />, из которого выполняется чтение.</param>
		/// <param name="quotas">Объект <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />, используемый для предотвращения атак типа «отказ в обслуживании» при чтении ненадежных данных.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может осуществлять чтение данных нотации объектов JavaScript (JSON).</returns>
		// Token: 0x060013AB RID: 5035 RVA: 0x0004C0A0 File Offset: 0x0004A2A0
		public static XmlDictionaryReader CreateJsonReader(Stream stream, XmlDictionaryReaderQuotas quotas)
		{
			return JsonReaderWriterFactory.CreateJsonReader(stream, null, quotas, null);
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может сопоставлять буферы, кодированные с использованием нотации объектов JavaScript (JSON), набору сведений XML.</summary>
		/// <param name="buffer">Массив буфера входных байтов <see cref="T:System.Byte" />, из которого выполняется чтение.</param>
		/// <param name="quotas">Объект <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />, используемый для предотвращения атак типа «отказ в обслуживании» при чтении ненадежных данных.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может обрабатывать данные нотации объектов JavaScript (JSON).</returns>
		// Token: 0x060013AC RID: 5036 RVA: 0x0004C0AB File Offset: 0x0004A2AB
		public static XmlDictionaryReader CreateJsonReader(byte[] buffer, XmlDictionaryReaderQuotas quotas)
		{
			if (buffer == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("buffer");
			}
			return JsonReaderWriterFactory.CreateJsonReader(buffer, 0, buffer.Length, null, quotas, null);
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может сопоставлять потоки заданных размера и смещения, кодированные с использованием нотации объектов JavaScript (JSON), набору сведений XML.</summary>
		/// <param name="stream">Входной поток <see cref="T:System.IO.Stream" />, из которого выполняется чтение.</param>
		/// <param name="encoding">Параметр <see cref="T:System.Text.Encoding" />, указывающий кодировку, используемую средством чтения. Если в качестве значения задана <see langword="null" />, средство чтения пытается обнаружить кодировку автоматически.</param>
		/// <param name="quotas">Объект <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />, используемый для предотвращения атак типа «отказ в обслуживании» при чтении ненадежных данных.</param>
		/// <param name="onClose">Делегат <see cref="T:System.Xml.OnXmlDictionaryReaderClose" />, вызываемый при закрытии средства чтения.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может осуществлять чтение данных нотации объектов JavaScript (JSON).</returns>
		// Token: 0x060013AD RID: 5037 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
		public static XmlDictionaryReader CreateJsonReader(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose)
		{
			XmlJsonReader xmlJsonReader = new XmlJsonReader();
			xmlJsonReader.SetInput(stream, encoding, quotas, onClose);
			return xmlJsonReader;
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может сопоставлять буферы заданных размера и смещения, кодированные с использованием нотации объектов JavaScript (JSON), набору сведений XML.</summary>
		/// <param name="buffer">Массив буфера входных байтов <see cref="T:System.Byte" />, из которого выполняется чтение.</param>
		/// <param name="offset">Начальное положение для чтения из параметра <paramref name="buffer" />.</param>
		/// <param name="count">Количество байтов, которое может быть считано из параметра <paramref name="buffer" />.</param>
		/// <param name="quotas">Объект <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />, используемый для предотвращения атак типа «отказ в обслуживании» при чтении ненадежных данных.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может осуществлять чтение данных нотации объектов JavaScript (JSON).</returns>
		// Token: 0x060013AE RID: 5038 RVA: 0x0004C0D9 File Offset: 0x0004A2D9
		public static XmlDictionaryReader CreateJsonReader(byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas)
		{
			return JsonReaderWriterFactory.CreateJsonReader(buffer, offset, count, null, quotas, null);
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может сопоставлять буферы с заданными размером, смещением и кодировкой, кодированные с использованием нотации объектов JavaScript (JSON), набору сведений XML.</summary>
		/// <param name="buffer">Массив буфера входных байтов <see cref="T:System.Byte" />, из которого выполняется чтение.</param>
		/// <param name="offset">Начальное положение для чтения из параметра <paramref name="buffer" />.</param>
		/// <param name="count">Количество байтов, которое может быть считано из параметра <paramref name="buffer" />.</param>
		/// <param name="encoding">Параметр <see cref="T:System.Text.Encoding" />, указывающий кодировку, используемую средством чтения. Если в качестве значения задана <see langword="null" />, средство чтения пытается обнаружить кодировку автоматически.</param>
		/// <param name="quotas">Объект <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />, используемый для предотвращения атак типа «отказ в обслуживании» при чтении ненадежных данных.</param>
		/// <param name="onClose">Делегат <see cref="T:System.Xml.OnXmlDictionaryReaderClose" />, вызываемый при закрытии средства чтения. Значение по умолчанию — <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryReader" />, который может осуществлять чтение данных нотации объектов JavaScript (JSON).</returns>
		// Token: 0x060013AF RID: 5039 RVA: 0x0004C0E6 File Offset: 0x0004A2E6
		public static XmlDictionaryReader CreateJsonReader(byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose)
		{
			XmlJsonReader xmlJsonReader = new XmlJsonReader();
			xmlJsonReader.SetInput(buffer, offset, count, encoding, quotas, onClose);
			return xmlJsonReader;
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток.</summary>
		/// <param name="stream">Выходной поток <see cref="T:System.IO.Stream" /> для модуля записи JSON.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток на основе набора сведений XML.</returns>
		// Token: 0x060013B0 RID: 5040 RVA: 0x0004C0FB File Offset: 0x0004A2FB
		public static XmlDictionaryWriter CreateJsonWriter(Stream stream)
		{
			return JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true);
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток с заданной кодировкой.</summary>
		/// <param name="stream">Выходной поток <see cref="T:System.IO.Stream" /> для модуля записи JSON.</param>
		/// <param name="encoding">Параметр <see cref="T:System.Text.Encoding" />, указывающий кодировку, используемую средством записи. Кодировка по умолчанию — UTF-8.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток на основе набора сведений XML.</returns>
		// Token: 0x060013B1 RID: 5041 RVA: 0x0004C109 File Offset: 0x0004A309
		public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding)
		{
			return JsonReaderWriterFactory.CreateJsonWriter(stream, encoding, true);
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток с заданной кодировкой.</summary>
		/// <param name="stream">Выходной поток <see cref="T:System.IO.Stream" /> для модуля записи JSON.</param>
		/// <param name="encoding">Параметр <see cref="T:System.Text.Encoding" />, указывающий кодировку, используемую средством записи. Кодировка по умолчанию — UTF-8.</param>
		/// <param name="ownsStream">Значение <see langword="true" />, если выходной поток закрывается средством записи после завершения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток на основе набора сведений XML.</returns>
		// Token: 0x060013B2 RID: 5042 RVA: 0x0004C113 File Offset: 0x0004A313
		public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding, bool ownsStream)
		{
			return JsonReaderWriterFactory.CreateJsonWriter(stream, encoding, ownsStream, false);
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток с заданным символом.</summary>
		/// <param name="stream">Выходной поток <see cref="T:System.IO.Stream" /> для модуля записи JSON.</param>
		/// <param name="encoding">Параметр <see cref="T:System.Text.Encoding" />, указывающий кодировку, используемую средством записи. Кодировка по умолчанию — UTF-8.</param>
		/// <param name="ownsStream">Значение <see langword="true" />, если выходной поток закрывается средством записи после завершения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</param>
		/// <param name="indent">Если значение равно <see langword="true" />, в выходных данных используется многострочный формат с надлежащим отступом для каждого уровня; в противном случае значение равно <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток на основе набора сведений XML.</returns>
		// Token: 0x060013B3 RID: 5043 RVA: 0x0004C11E File Offset: 0x0004A31E
		public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding, bool ownsStream, bool indent)
		{
			return JsonReaderWriterFactory.CreateJsonWriter(stream, encoding, ownsStream, indent, "  ");
		}

		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток с заданным символом.</summary>
		/// <param name="stream">Выходной поток <see cref="T:System.IO.Stream" /> для модуля записи JSON.</param>
		/// <param name="encoding">Параметр <see cref="T:System.Text.Encoding" />, указывающий кодировку, используемую средством записи. Кодировка по умолчанию — UTF-8.</param>
		/// <param name="ownsStream">Значение <see langword="true" />, если выходной поток закрывается средством записи после завершения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</param>
		/// <param name="indent">Если значение равно <see langword="true" />, в выходных данных используется многострочный формат с надлежащим отступом для каждого уровня; в противном случае значение равно <see langword="false" />.</param>
		/// <param name="indentChars">Строка, используемая для задания отступа каждого уровня.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, осуществляющий запись данных с кодированием JSON в поток на основе набора сведений XML.</returns>
		// Token: 0x060013B4 RID: 5044 RVA: 0x0004C12E File Offset: 0x0004A32E
		public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding, bool ownsStream, bool indent, string indentChars)
		{
			XmlJsonWriter xmlJsonWriter = new XmlJsonWriter(indent, indentChars);
			xmlJsonWriter.SetOutput(stream, encoding, ownsStream);
			return xmlJsonWriter;
		}

		// Token: 0x040009FB RID: 2555
		private const string DefaultIndentChars = "  ";
	}
}
