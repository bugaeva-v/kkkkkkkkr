using System;
using System.IO;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail
{
	/// <summary>Представляет формат для просмотра сообщения электронной почты.</summary>
	// Token: 0x02000822 RID: 2082
	public class AlternateView : AttachmentBase
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.AlternateView" /> с указанным именем файла.</summary>
		/// <param name="fileName">Имя файла с содержимым данного альтернативного представления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например ошибка диска.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный доступ не разрешен операционной системой для указанного дескриптора файла, например, если доступ запрашивается для записи (Write) или для чтения и записи (ReadWrite), а для дескриптора файла установлен доступ только для чтения.</exception>
		// Token: 0x06004237 RID: 16951 RVA: 0x000E500D File Offset: 0x000E320D
		public AlternateView(string fileName) : base(fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.AlternateView" /> с указанным именем файла и типом содержимого.</summary>
		/// <param name="fileName">Имя файла с содержимым данного альтернативного представления.</param>
		/// <param name="contentType">Тип содержимого.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="contentType" /> не является допустимым значением.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например ошибка диска.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный доступ не разрешен операционной системой для указанного дескриптора файла, например, если доступ запрашивается для записи (Write) или для чтения и записи (ReadWrite), а для дескриптора файла установлен доступ только для чтения.</exception>
		// Token: 0x06004238 RID: 16952 RVA: 0x000E502A File Offset: 0x000E322A
		public AlternateView(string fileName, ContentType contentType) : base(fileName, contentType)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.AlternateView" /> с указанным именем файла и типом мультимедиа.</summary>
		/// <param name="fileName">Имя файла с содержимым данного альтернативного представления.</param>
		/// <param name="mediaType">Тип мультимедиа MIME содержимого.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="mediaType" /> не является допустимым значением.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например ошибка диска.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный доступ не разрешен операционной системой для указанного дескриптора файла, например, если доступ запрашивается для записи (Write) или для чтения и записи (ReadWrite), а для дескриптора файла установлен доступ только для чтения.</exception>
		// Token: 0x06004239 RID: 16953 RVA: 0x000E5048 File Offset: 0x000E3248
		public AlternateView(string fileName, string mediaType) : base(fileName, mediaType)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.AlternateView" /> с указанным <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="contentStream">Поток с содержимым для данного представления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contentStream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600423A RID: 16954 RVA: 0x000E5066 File Offset: 0x000E3266
		public AlternateView(Stream contentStream) : base(contentStream)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.AlternateView" /> с указанным <see cref="T:System.IO.Stream" /> и типом мультимедиа.</summary>
		/// <param name="contentStream">Поток с содержимым для данного вложения.</param>
		/// <param name="mediaType">Тип мультимедиа MIME содержимого.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contentStream" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="mediaType" /> не является допустимым значением.</exception>
		// Token: 0x0600423B RID: 16955 RVA: 0x000E507A File Offset: 0x000E327A
		public AlternateView(Stream contentStream, string mediaType) : base(contentStream, mediaType)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.AlternateView" /> с заданными <see cref="T:System.IO.Stream" /> и <see cref="T:System.Net.Mime.ContentType" />.</summary>
		/// <param name="contentStream">Поток с содержимым для данного вложения.</param>
		/// <param name="contentType">Тип содержимого.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contentStream" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="contentType" /> не является допустимым значением.</exception>
		// Token: 0x0600423C RID: 16956 RVA: 0x000E508F File Offset: 0x000E328F
		public AlternateView(Stream contentStream, ContentType contentType) : base(contentStream, contentType)
		{
		}

		/// <summary>Получает или задает базовый универсальный код ресурса (URI), используемый для разрешения относительных универсальных кодов ресурса (URI) в объекте <see cref="T:System.Net.Mail.AlternateView" />.</summary>
		/// <returns>Базовый URI, используемый для разрешения относительных URI в <see cref="T:System.Net.Mail.AlternateView" />.</returns>
		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x000E50A4 File Offset: 0x000E32A4
		// (set) Token: 0x0600423E RID: 16958 RVA: 0x000E50AC File Offset: 0x000E32AC
		public Uri BaseUri
		{
			get
			{
				return this.baseUri;
			}
			set
			{
				this.baseUri = value;
			}
		}

		/// <summary>Возвращает набор внедренных ресурсов, на которое ссылается данное вложение.</summary>
		/// <returns>Объект <see cref="T:System.Net.Mail.LinkedResourceCollection" /> объект, который хранит коллекцию связанных ресурсов для отправки в сообщении электронной почты.</returns>
		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x000E50B5 File Offset: 0x000E32B5
		public LinkedResourceCollection LinkedResources
		{
			get
			{
				return this.linkedResources;
			}
		}

		/// <summary>Создает объект <see cref="T:System.Net.Mail.AlternateView" /> сообщения электронной почты с использованием содержимого, заданного в строке <see cref="T:System.String" />.</summary>
		/// <param name="content">Значение <see cref="T:System.String" /> с содержимым сообщения электронной почты.</param>
		/// <returns>Объект <see cref="T:System.Net.Mail.AlternateView" />, соответствующий альтернативному представлению сообщения электронной почты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="content" /> имеет значение null.</exception>
		// Token: 0x06004240 RID: 16960 RVA: 0x000E50BD File Offset: 0x000E32BD
		public static AlternateView CreateAlternateViewFromString(string content)
		{
			if (content == null)
			{
				throw new ArgumentNullException();
			}
			return new AlternateView(new MemoryStream(Encoding.UTF8.GetBytes(content)))
			{
				TransferEncoding = TransferEncoding.QuotedPrintable
			};
		}

		/// <summary>Создает объект <see cref="T:System.Net.Mail.AlternateView" /> сообщения электронной почты с использованием содержимого, заданного в строке <see cref="T:System.String" />, и указанного типа носителя MIME.</summary>
		/// <param name="content">Объект <see cref="T:System.String" />, который содержит содержимое данного вложения.</param>
		/// <param name="contentType">Объект <see cref="T:System.Net.Mime.ContentType" />, описывающий данные параметра <paramref name="content" />.</param>
		/// <returns>Объект <see cref="T:System.Net.Mail.AlternateView" />, соответствующий альтернативному представлению сообщения электронной почты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="content" /> имеет значение null.</exception>
		// Token: 0x06004241 RID: 16961 RVA: 0x000E50E4 File Offset: 0x000E32E4
		public static AlternateView CreateAlternateViewFromString(string content, ContentType contentType)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			return new AlternateView(new MemoryStream(((contentType.CharSet != null) ? Encoding.GetEncoding(contentType.CharSet) : Encoding.UTF8).GetBytes(content)), contentType)
			{
				TransferEncoding = TransferEncoding.QuotedPrintable
			};
		}

		/// <summary>Создает объект <see cref="T:System.Net.Mail.AlternateView" /> сообщения электронной почты с использованием содержимого, заданного в строке <see cref="T:System.String" />, указанной кодировки текста и указанного типа носителя MIME.</summary>
		/// <param name="content">Объект <see cref="T:System.String" />, который содержит содержимое данного вложения.</param>
		/// <param name="contentEncoding">Объект <see cref="T:System.Text.Encoding" />. Это значение может быть равно <see langword="null." />.</param>
		/// <param name="mediaType">Тип мультимедиа MIME содержимого.</param>
		/// <returns>Объект <see cref="T:System.Net.Mail.AlternateView" />, соответствующий альтернативному представлению сообщения электронной почты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="content" /> имеет значение null.</exception>
		// Token: 0x06004242 RID: 16962 RVA: 0x000E5134 File Offset: 0x000E3334
		public static AlternateView CreateAlternateViewFromString(string content, Encoding contentEncoding, string mediaType)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (contentEncoding == null)
			{
				contentEncoding = Encoding.UTF8;
			}
			return new AlternateView(new MemoryStream(contentEncoding.GetBytes(content)), new ContentType
			{
				MediaType = mediaType,
				CharSet = contentEncoding.HeaderName
			})
			{
				TransferEncoding = TransferEncoding.QuotedPrintable
			};
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Mail.AlternateView" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06004243 RID: 16963 RVA: 0x000E518C File Offset: 0x000E338C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				foreach (LinkedResource linkedResource in this.linkedResources)
				{
					linkedResource.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x04002842 RID: 10306
		private Uri baseUri;

		// Token: 0x04002843 RID: 10307
		private LinkedResourceCollection linkedResources = new LinkedResourceCollection();
	}
}
