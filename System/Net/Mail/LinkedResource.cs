using System;
using System.IO;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail
{
	/// <summary>Представляет внедренный внешний ресурс во вложении электронной почты, например изображение в HTML-вложении.</summary>
	// Token: 0x02000829 RID: 2089
	public class LinkedResource : AttachmentBase
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.LinkedResource" />, используя указанное имя файла.</summary>
		/// <param name="fileName">Имя файла с содержимым для данного внедренного ресурса.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="fileName" /> — <see langword="null" />.</exception>
		// Token: 0x06004271 RID: 17009 RVA: 0x000E7843 File Offset: 0x000E5A43
		public LinkedResource(string fileName) : base(fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.LinkedResource" /> с указанным именем файла и типом содержимого.</summary>
		/// <param name="fileName">Имя файла с содержимым для данного внедренного ресурса.</param>
		/// <param name="contentType">Тип содержимого.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="fileName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="contentType" /> не является действительным значением.</exception>
		// Token: 0x06004272 RID: 17010 RVA: 0x000E7855 File Offset: 0x000E5A55
		public LinkedResource(string fileName, ContentType contentType) : base(fileName, contentType)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.LinkedResource" /> с указанным именем файла и типом носителя.</summary>
		/// <param name="fileName">Имя файла с содержимым для данного внедренного ресурса.</param>
		/// <param name="mediaType">Медиатип MIME содержимого.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="fileName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="mediaType" /> не является действительным значением.</exception>
		// Token: 0x06004273 RID: 17011 RVA: 0x000E7868 File Offset: 0x000E5A68
		public LinkedResource(string fileName, string mediaType) : base(fileName, mediaType)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.LinkedResource" />, используя переданный <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="contentStream">Поток с содержимым для данного внедренного ресурса.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="contentStream" /> — <see langword="null" />.</exception>
		// Token: 0x06004274 RID: 17012 RVA: 0x000E787B File Offset: 0x000E5A7B
		public LinkedResource(Stream contentStream) : base(contentStream)
		{
			if (contentStream == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.LinkedResource" /> со значениями, переданными в объектах <see cref="T:System.IO.Stream" /> и <see cref="T:System.Net.Mime.ContentType" />.</summary>
		/// <param name="contentStream">Поток с содержимым для данного внедренного ресурса.</param>
		/// <param name="contentType">Тип содержимого.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="contentStream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="contentType" /> не является действительным значением.</exception>
		// Token: 0x06004275 RID: 17013 RVA: 0x000E788D File Offset: 0x000E5A8D
		public LinkedResource(Stream contentStream, ContentType contentType) : base(contentStream, contentType)
		{
			if (contentStream == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Net.Mail.LinkedResource" /> с указанным <see cref="T:System.IO.Stream" /> и типом носителя.</summary>
		/// <param name="contentStream">Поток с содержимым для данного внедренного ресурса.</param>
		/// <param name="mediaType">Медиатип MIME содержимого.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="contentStream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="mediaType" /> не является действительным значением.</exception>
		// Token: 0x06004276 RID: 17014 RVA: 0x000E78A0 File Offset: 0x000E5AA0
		public LinkedResource(Stream contentStream, string mediaType) : base(contentStream, mediaType)
		{
			if (contentStream == null)
			{
				throw new ArgumentNullException();
			}
		}

		/// <summary>Получает или задает URI, которому должен соответствовать ресурс.</summary>
		/// <returns>Если <see cref="P:System.Net.Mail.LinkedResource.ContentLink" /> представляет собой относительный URI, получатель сообщения должен его разрешить.</returns>
		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x000E78B3 File Offset: 0x000E5AB3
		// (set) Token: 0x06004278 RID: 17016 RVA: 0x000E78BB File Offset: 0x000E5ABB
		public Uri ContentLink
		{
			get
			{
				return this.contentLink;
			}
			set
			{
				this.contentLink = value;
			}
		}

		/// <summary>Создает объект <see cref="T:System.Net.Mail.LinkedResource" /> на основе строки, включаемой во вложение электронной почты в качестве внедренного ресурса. Медиатипом по умолчанию является обычный текст, а типом содержимого по умолчанию — ASCII.</summary>
		/// <param name="content">Строка, содержащая внедренный ресурс для включения во вложение электронной почты.</param>
		/// <returns>Объект <see cref="T:System.Net.Mail.LinkedResource" />, содержащий внедренный ресурс для включения во вложение электронной почты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Указанная строка содержимого равна null.</exception>
		// Token: 0x06004279 RID: 17017 RVA: 0x000E78C4 File Offset: 0x000E5AC4
		public static LinkedResource CreateLinkedResourceFromString(string content)
		{
			if (content == null)
			{
				throw new ArgumentNullException();
			}
			return new LinkedResource(new MemoryStream(Encoding.Default.GetBytes(content)))
			{
				TransferEncoding = TransferEncoding.QuotedPrintable
			};
		}

		/// <summary>Создает объект <see cref="T:System.Net.Mail.LinkedResource" /> на основе строки, включаемой во вложение электронной почты в качестве вложенного ресурса, с указанным типом сообщения и медиатипом "обычный текст".</summary>
		/// <param name="content">Строка, содержащая внедренный ресурс для включения во вложение электронной почты.</param>
		/// <param name="contentType">Тип содержимого.</param>
		/// <returns>Объект <see cref="T:System.Net.Mail.LinkedResource" />, содержащий внедренный ресурс для включения во вложение электронной почты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Указанная строка содержимого равна null.</exception>
		// Token: 0x0600427A RID: 17018 RVA: 0x000E78EB File Offset: 0x000E5AEB
		public static LinkedResource CreateLinkedResourceFromString(string content, ContentType contentType)
		{
			if (content == null)
			{
				throw new ArgumentNullException();
			}
			return new LinkedResource(new MemoryStream(Encoding.Default.GetBytes(content)), contentType)
			{
				TransferEncoding = TransferEncoding.QuotedPrintable
			};
		}

		/// <summary>Создает объект <see cref="T:System.Net.Mail.LinkedResource" /> на основе строки, включаемой во вложение электронной почты в качестве вложенного ресурса, с указанным типом сообщения и медиатипом.</summary>
		/// <param name="content">Строка, содержащая внедренный ресурс для включения во вложение электронной почты.</param>
		/// <param name="contentEncoding">Тип содержимого.</param>
		/// <param name="mediaType">Медиатип MIME содержимого.</param>
		/// <returns>Объект <see cref="T:System.Net.Mail.LinkedResource" />, содержащий внедренный ресурс для включения во вложение электронной почты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Указанная строка содержимого равна null.</exception>
		// Token: 0x0600427B RID: 17019 RVA: 0x000E7913 File Offset: 0x000E5B13
		public static LinkedResource CreateLinkedResourceFromString(string content, Encoding contentEncoding, string mediaType)
		{
			if (content == null)
			{
				throw new ArgumentNullException();
			}
			return new LinkedResource(new MemoryStream(contentEncoding.GetBytes(content)), mediaType)
			{
				TransferEncoding = TransferEncoding.QuotedPrintable
			};
		}

		// Token: 0x04002851 RID: 10321
		private Uri contentLink;
	}
}
