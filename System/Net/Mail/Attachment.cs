using System;
using System.IO;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail
{
	/// <summary>Представляет вложение в сообщение электронной почты.</summary>
	// Token: 0x02000824 RID: 2084
	public class Attachment : AttachmentBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.Attachment" /> с указанной строкой содержимого.</summary>
		/// <param name="fileName">Значение <see cref="T:System.String" />, содержащее путь к файлу для создания этого вложения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> пуст.</exception>
		// Token: 0x0600424A RID: 16970 RVA: 0x000E520D File Offset: 0x000E340D
		public Attachment(string fileName) : base(fileName)
		{
			this.InitName(fileName);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.Attachment" /> с указанной строкой содержимого и информацией о типе MIME.</summary>
		/// <param name="fileName">Объект <see cref="T:System.String" />, который содержит содержимое данного вложения.</param>
		/// <param name="mediaType">Объект <see cref="T:System.String" />, который содержит информацию MIME Content-Header для данного вложения. Это значение может быть равно <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="mediaType" /> имеет неправильный формат.</exception>
		// Token: 0x0600424B RID: 16971 RVA: 0x000E5228 File Offset: 0x000E3428
		public Attachment(string fileName, string mediaType) : base(fileName, mediaType)
		{
			this.InitName(fileName);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.Attachment" /> с указанной строкой содержимого и <see cref="T:System.Net.Mime.ContentType" />.</summary>
		/// <param name="fileName">Значение <see cref="T:System.String" />, содержащее путь к файлу для создания этого вложения.</param>
		/// <param name="contentType">Объект <see cref="T:System.Net.Mime.ContentType" />, описывающий данные параметра <paramref name="fileName" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mediaType" /> имеет неправильный формат.</exception>
		// Token: 0x0600424C RID: 16972 RVA: 0x000E5244 File Offset: 0x000E3444
		public Attachment(string fileName, ContentType contentType) : base(fileName, contentType)
		{
			this.InitName(fileName);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.Attachment" /> с указанным потоком и типом содержимого.</summary>
		/// <param name="contentStream">Доступный для чтения объект <see cref="T:System.IO.Stream" />, который содержит содержимое данного вложения.</param>
		/// <param name="contentType">Объект <see cref="T:System.Net.Mime.ContentType" />, описывающий данные параметра <paramref name="contentStream" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contentType" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="contentStream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600424D RID: 16973 RVA: 0x000E5260 File Offset: 0x000E3460
		public Attachment(Stream contentStream, ContentType contentType) : base(contentStream, contentType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.Attachment" /> с указанными потоком и именем.</summary>
		/// <param name="contentStream">Доступный для чтения объект <see cref="T:System.IO.Stream" />, который содержит содержимое данного вложения.</param>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий значение свойства <see cref="P:System.Net.Mime.ContentType.Name" /> объекта <see cref="T:System.Net.Mime.ContentType" />, связанного с данным вложением. Это значение может быть равно <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contentStream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600424E RID: 16974 RVA: 0x000E5275 File Offset: 0x000E3475
		public Attachment(Stream contentStream, string name) : base(contentStream)
		{
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.Attachment" /> с указанными потоком, именем и информацией о типе MIME.</summary>
		/// <param name="contentStream">Доступный для чтения объект <see cref="T:System.IO.Stream" />, который содержит содержимое данного вложения.</param>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий значение свойства <see cref="P:System.Net.Mime.ContentType.Name" /> объекта <see cref="T:System.Net.Mime.ContentType" />, связанного с данным вложением. Это значение может быть равно <see langword="null" />.</param>
		/// <param name="mediaType">Объект <see cref="T:System.String" />, который содержит информацию MIME Content-Header для данного вложения. Это значение может быть равно <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="mediaType" /> имеет неправильный формат.</exception>
		// Token: 0x0600424F RID: 16975 RVA: 0x000E5290 File Offset: 0x000E3490
		public Attachment(Stream contentStream, string name, string mediaType) : base(contentStream, mediaType)
		{
			this.Name = name;
		}

		/// <summary>Возвращает расположение содержимого MIME для этого вложения.</summary>
		/// <returns>Объект <see cref="T:System.Net.Mime.ContentDisposition" />, предоставляющий информацию о представлении данного вложения.</returns>
		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x000E52AC File Offset: 0x000E34AC
		public ContentDisposition ContentDisposition
		{
			get
			{
				return this.contentDisposition;
			}
		}

		/// <summary>Возвращает или задает значение имени типа содержимого MIME, связанного с данным вложением.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее значение типа содержимого <paramref name="name" />, представленное свойством <see cref="P:System.Net.Mime.ContentType.Name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для операции задания указано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для операции задания указано значение <see cref="F:System.String.Empty" /> ("").</exception>
		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06004251 RID: 16977 RVA: 0x000E52B4 File Offset: 0x000E34B4
		// (set) Token: 0x06004252 RID: 16978 RVA: 0x000E52C1 File Offset: 0x000E34C1
		public string Name
		{
			get
			{
				return base.ContentType.Name;
			}
			set
			{
				base.ContentType.Name = value;
			}
		}

		/// <summary>Указывает кодировку для <see cref="T:System.Net.Mail.Attachment" /><see cref="P:System.Net.Mail.Attachment.Name" />.</summary>
		/// <returns>Значение <see cref="T:System.Text.Encoding" />, задающее тип кодировки имени. Значение по умолчанию определяется на основе имени вложения.</returns>
		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06004253 RID: 16979 RVA: 0x000E52CF File Offset: 0x000E34CF
		// (set) Token: 0x06004254 RID: 16980 RVA: 0x000E52D7 File Offset: 0x000E34D7
		public Encoding NameEncoding
		{
			get
			{
				return this.nameEncoding;
			}
			set
			{
				this.nameEncoding = value;
			}
		}

		/// <summary>Создает почтовое вложение, используя содержимое указанной строки и заданный <see cref="T:System.Net.Mime.ContentType" />.</summary>
		/// <param name="content">Объект <see cref="T:System.String" />, который содержит содержимое данного вложения.</param>
		/// <param name="contentType">Объект <see cref="T:System.Net.Mime.ContentType" />, представляющий используемый заголовок Content-Type протокола MIME (Multipurpose Internet Mail Exchange).</param>
		/// <returns>Объект типа <see cref="T:System.Net.Mail.Attachment" />.</returns>
		// Token: 0x06004255 RID: 16981 RVA: 0x000E52E0 File Offset: 0x000E34E0
		public static Attachment CreateAttachmentFromString(string content, ContentType contentType)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(memoryStream);
			streamWriter.Write(content);
			streamWriter.Flush();
			memoryStream.Position = 0L;
			return new Attachment(memoryStream, contentType)
			{
				TransferEncoding = TransferEncoding.QuotedPrintable
			};
		}

		/// <summary>Создает почтовое вложение, используя содержимое указанной строки и заданное имя типа содержимого MIME.</summary>
		/// <param name="content">Объект <see cref="T:System.String" />, который содержит содержимое данного вложения.</param>
		/// <param name="name">Значение имени типа содержимого MIME, связанного с данным вложением.</param>
		/// <returns>Объект типа <see cref="T:System.Net.Mail.Attachment" />.</returns>
		// Token: 0x06004256 RID: 16982 RVA: 0x000E531C File Offset: 0x000E351C
		public static Attachment CreateAttachmentFromString(string content, string name)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(memoryStream);
			streamWriter.Write(content);
			streamWriter.Flush();
			memoryStream.Position = 0L;
			return new Attachment(memoryStream, new ContentType("text/plain"))
			{
				TransferEncoding = TransferEncoding.QuotedPrintable,
				Name = name
			};
		}

		/// <summary>Создает почтовое вложение, используя содержимое указанной строки, заданное имя типа содержимого MIME, кодировку символов и информацию заголовка MIME для вложения.</summary>
		/// <param name="content">Объект <see cref="T:System.String" />, который содержит содержимое данного вложения.</param>
		/// <param name="name">Значение имени типа содержимого MIME, связанного с данным вложением.</param>
		/// <param name="contentEncoding">Объект <see cref="T:System.Text.Encoding" />. Это значение может быть равно <see langword="null" />.</param>
		/// <param name="mediaType">Объект <see cref="T:System.String" />, который содержит информацию MIME Content-Header для данного вложения. Это значение может быть равно <see langword="null" />.</param>
		/// <returns>Объект типа <see cref="T:System.Net.Mail.Attachment" />.</returns>
		// Token: 0x06004257 RID: 16983 RVA: 0x000E5374 File Offset: 0x000E3574
		public static Attachment CreateAttachmentFromString(string content, string name, Encoding contentEncoding, string mediaType)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(memoryStream, contentEncoding);
			streamWriter.Write(content);
			streamWriter.Flush();
			memoryStream.Position = 0L;
			return new Attachment(memoryStream, name, mediaType)
			{
				TransferEncoding = MailMessage.GuessTransferEncoding(contentEncoding),
				ContentType = 
				{
					CharSet = streamWriter.Encoding.BodyName
				}
			};
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x000E53DA File Offset: 0x000E35DA
		private void InitName(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			this.Name = Path.GetFileName(fileName);
		}

		// Token: 0x04002844 RID: 10308
		private ContentDisposition contentDisposition = new ContentDisposition();

		// Token: 0x04002845 RID: 10309
		private Encoding nameEncoding;
	}
}
