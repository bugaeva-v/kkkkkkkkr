using System;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail
{
	/// <summary>Представляет сообщение электронной почты, которое может быть отправлено с помощью класса <see cref="T:System.Net.Mail.SmtpClient" />.</summary>
	// Token: 0x0200082B RID: 2091
	public class MailMessage : IDisposable
	{
		/// <summary>Инициализирует пустой экземпляр класса <see cref="T:System.Net.Mail.MailMessage" />.</summary>
		// Token: 0x06004283 RID: 17027 RVA: 0x000E7974 File Offset: 0x000E5B74
		public MailMessage()
		{
			this.to = new MailAddressCollection();
			this.alternateViews = new AlternateViewCollection();
			this.attachments = new AttachmentCollection();
			this.bcc = new MailAddressCollection();
			this.cc = new MailAddressCollection();
			this.replyTo = new MailAddressCollection();
			this.headers = new NameValueCollection();
			this.headers.Add("MIME-Version", "1.0");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.MailMessage" />, используя указанные объекты класса <see cref="T:System.Net.Mail.MailAddress" />.</summary>
		/// <param name="from">Объект <see cref="T:System.Net.Mail.MailAddress" />, содержащий адрес отправителя сообщения электронной почты.</param>
		/// <param name="to">Объект <see cref="T:System.Net.Mail.MailAddress" />, содержащий адрес получателя сообщения электронной почты.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="from" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="to" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="from" /> или <paramref name="to" /> имеет неправильный формат.</exception>
		// Token: 0x06004284 RID: 17028 RVA: 0x000E79F4 File Offset: 0x000E5BF4
		public MailMessage(MailAddress from, MailAddress to) : this()
		{
			if (from == null || to == null)
			{
				throw new ArgumentNullException();
			}
			this.From = from;
			this.to.Add(to);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.MailMessage" />, используя указанные объекты класса <see cref="T:System.String" />.</summary>
		/// <param name="from">Объект <see cref="T:System.String" />, содержащий адрес отправителя сообщения электронной почты.</param>
		/// <param name="to">Значение <see cref="T:System.String" />, содержащее адреса получателей сообщения электронной почты. Несколько адресов электронной почты необходимо разделять запятыми (",").</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="from" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="to" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="from" /> имеет значение <see cref="F:System.String.Empty" /> ("").  
		///
		/// или - 
		/// <paramref name="to" /> имеет значение <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="from" /> или <paramref name="to" /> имеет неправильный формат.</exception>
		// Token: 0x06004285 RID: 17029 RVA: 0x000E7A1C File Offset: 0x000E5C1C
		public MailMessage(string from, string to) : this()
		{
			if (from == null || from == string.Empty)
			{
				throw new ArgumentNullException("from");
			}
			if (to == null || to == string.Empty)
			{
				throw new ArgumentNullException("to");
			}
			this.from = new MailAddress(from);
			foreach (string text in to.Split(new char[]
			{
				','
			}))
			{
				this.to.Add(new MailAddress(text.Trim()));
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.MailMessage" />.</summary>
		/// <param name="from">Объект <see cref="T:System.String" />, содержащий адрес отправителя сообщения электронной почты.</param>
		/// <param name="to">Значение <see cref="T:System.String" />, содержащее адреса получателей сообщения электронной почты. Несколько адресов электронной почты необходимо разделять запятыми (",").</param>
		/// <param name="subject">Значение <see cref="T:System.String" />, содержащее текст темы.</param>
		/// <param name="body">Значение <see cref="T:System.String" />, содержащее основную часть сообщения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="from" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="to" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="from" /> имеет значение <see cref="F:System.String.Empty" /> ("").  
		/// -или- 
		///  <paramref name="to" /> имеет значение <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="from" /> или <paramref name="to" /> имеет неправильный формат.</exception>
		// Token: 0x06004286 RID: 17030 RVA: 0x000E7AAC File Offset: 0x000E5CAC
		public MailMessage(string from, string to, string subject, string body) : this()
		{
			if (from == null || from == string.Empty)
			{
				throw new ArgumentNullException("from");
			}
			if (to == null || to == string.Empty)
			{
				throw new ArgumentNullException("to");
			}
			this.from = new MailAddress(from);
			foreach (string text in to.Split(new char[]
			{
				','
			}))
			{
				this.to.Add(new MailAddress(text.Trim()));
			}
			this.Body = body;
			this.Subject = subject;
		}

		/// <summary>Возвращает коллекцию вложений, используемую для хранения альтернативных форм текста сообщения.</summary>
		/// <returns>Доступный для записи объект <see cref="T:System.Net.Mail.AlternateViewCollection" />.</returns>
		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x000E7B4A File Offset: 0x000E5D4A
		public AlternateViewCollection AlternateViews
		{
			get
			{
				return this.alternateViews;
			}
		}

		/// <summary>Возвращает коллекцию вложений, используемую для хранения данных, вложенных в это сообщение электронной почты.</summary>
		/// <returns>Доступный для записи объект <see cref="T:System.Net.Mail.AttachmentCollection" />.</returns>
		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x000E7B52 File Offset: 0x000E5D52
		public AttachmentCollection Attachments
		{
			get
			{
				return this.attachments;
			}
		}

		/// <summary>Возвращает коллекцию адресов, содержащую получателей скрытой копии (BCC) данного сообщения электронной почты.</summary>
		/// <returns>Доступный для записи объект <see cref="T:System.Net.Mail.MailAddressCollection" />.</returns>
		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x000E7B5A File Offset: 0x000E5D5A
		public MailAddressCollection Bcc
		{
			get
			{
				return this.bcc;
			}
		}

		/// <summary>Возвращает или задает текст сообщения.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее основной текст.</returns>
		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x000E7B62 File Offset: 0x000E5D62
		// (set) Token: 0x0600428B RID: 17035 RVA: 0x000E7B6A File Offset: 0x000E5D6A
		public string Body
		{
			get
			{
				return this.body;
			}
			set
			{
				if (value != null && this.bodyEncoding == null)
				{
					this.bodyEncoding = (this.GuessEncoding(value) ?? Encoding.ASCII);
				}
				this.body = value;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x000E7B94 File Offset: 0x000E5D94
		internal ContentType BodyContentType
		{
			get
			{
				return new ContentType(this.isHtml ? "text/html" : "text/plain")
				{
					CharSet = (this.BodyEncoding ?? Encoding.ASCII).HeaderName
				};
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x000E7BC9 File Offset: 0x000E5DC9
		internal TransferEncoding ContentTransferEncoding
		{
			get
			{
				return MailMessage.GuessTransferEncoding(this.BodyEncoding);
			}
		}

		/// <summary>Возвращает или задает кодировку, используемую для кодирования текста сообщения.</summary>
		/// <returns>Кодировка <see cref="T:System.Text.Encoding" />, применяемая к содержимому <see cref="P:System.Net.Mail.MailMessage.Body" />.</returns>
		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x000E7BD6 File Offset: 0x000E5DD6
		// (set) Token: 0x0600428F RID: 17039 RVA: 0x000E7BDE File Offset: 0x000E5DDE
		public Encoding BodyEncoding
		{
			get
			{
				return this.bodyEncoding;
			}
			set
			{
				this.bodyEncoding = value;
			}
		}

		/// <summary>Возвращает или задает кодировку передачи, используемую для кодирования текста сообщения.</summary>
		/// <returns>Объект <see cref="T:System.Net.Mime.TransferEncoding" />, применяемый к содержимому свойства <see cref="P:System.Net.Mail.MailMessage.Body" />.</returns>
		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x000E7BC9 File Offset: 0x000E5DC9
		// (set) Token: 0x06004291 RID: 17041 RVA: 0x0000829A File Offset: 0x0000649A
		public TransferEncoding BodyTransferEncoding
		{
			get
			{
				return MailMessage.GuessTransferEncoding(this.BodyEncoding);
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает коллекцию адресов, содержащую получателей копии (CC) данного сообщения электронной почты.</summary>
		/// <returns>Доступный для записи объект <see cref="T:System.Net.Mail.MailAddressCollection" />.</returns>
		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x000E7BE7 File Offset: 0x000E5DE7
		public MailAddressCollection CC
		{
			get
			{
				return this.cc;
			}
		}

		/// <summary>Возвращает или задает уведомления о доставке данного сообщения электронной почты.</summary>
		/// <returns>Значение <see cref="T:System.Net.Mail.DeliveryNotificationOptions" />, которое содержит уведомления о доставке данного сообщения.</returns>
		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x000E7BEF File Offset: 0x000E5DEF
		// (set) Token: 0x06004294 RID: 17044 RVA: 0x000E7BF7 File Offset: 0x000E5DF7
		public DeliveryNotificationOptions DeliveryNotificationOptions
		{
			get
			{
				return this.deliveryNotificationOptions;
			}
			set
			{
				this.deliveryNotificationOptions = value;
			}
		}

		/// <summary>Возвращает или задает адрес отправителя данного сообщения электронной почты.</summary>
		/// <returns>Объект <see cref="T:System.Net.Mail.MailAddress" />, содержащий информацию об адресе отправителя.</returns>
		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x000E7C00 File Offset: 0x000E5E00
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x000E7C08 File Offset: 0x000E5E08
		public MailAddress From
		{
			get
			{
				return this.from;
			}
			set
			{
				this.from = value;
			}
		}

		/// <summary>Возвращает заголовки электронной почты, передаваемые с данным сообщением.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Specialized.NameValueCollection" /> , содержащий заголовки электронной почты.</returns>
		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x000E7C11 File Offset: 0x000E5E11
		public NameValueCollection Headers
		{
			get
			{
				return this.headers;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, имеет ли текст почтового сообщения формат HTML.</summary>
		/// <returns>
		///   <see langword="true" /> Если текст сообщения имеет формат HTML; Else <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x000E7C19 File Offset: 0x000E5E19
		// (set) Token: 0x06004299 RID: 17049 RVA: 0x000E7C21 File Offset: 0x000E5E21
		public bool IsBodyHtml
		{
			get
			{
				return this.isHtml;
			}
			set
			{
				this.isHtml = value;
			}
		}

		/// <summary>Возвращает или задает приоритет данного сообщения электронной почты.</summary>
		/// <returns>Объект <see cref="T:System.Net.Mail.MailPriority" />, содержащий приоритет данного сообщения.</returns>
		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x0600429A RID: 17050 RVA: 0x000E7C2A File Offset: 0x000E5E2A
		// (set) Token: 0x0600429B RID: 17051 RVA: 0x000E7C32 File Offset: 0x000E5E32
		public MailPriority Priority
		{
			get
			{
				return this.priority;
			}
			set
			{
				this.priority = value;
			}
		}

		/// <summary>Возвращает или задает кодировку, используемую для пользовательских заголовков данного сообщения электронной почты.</summary>
		/// <returns>Кодировка, используемая для пользователя пользовательских заголовков данного сообщения электронной почты.</returns>
		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x000E7C3B File Offset: 0x000E5E3B
		// (set) Token: 0x0600429D RID: 17053 RVA: 0x000E7C43 File Offset: 0x000E5E43
		public Encoding HeadersEncoding
		{
			get
			{
				return this.headersEncoding;
			}
			set
			{
				this.headersEncoding = value;
			}
		}

		/// <summary>Возвращает список адресов для ответа для данного почтового сообщения.</summary>
		/// <returns>Список адресов для ответа для данного сообщения электронной почты.</returns>
		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x000E7C4C File Offset: 0x000E5E4C
		public MailAddressCollection ReplyToList
		{
			get
			{
				return this.replyTo;
			}
		}

		/// <summary>Возвращает или задает адрес ReplyTo для данного почтового сообщения.</summary>
		/// <returns>MailAddress, указывающий значение поля <see cref="P:System.Net.Mail.MailMessage.ReplyTo" />.</returns>
		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x000E7C54 File Offset: 0x000E5E54
		// (set) Token: 0x060042A0 RID: 17056 RVA: 0x000E7C71 File Offset: 0x000E5E71
		[Obsolete("Use ReplyToList instead")]
		public MailAddress ReplyTo
		{
			get
			{
				if (this.replyTo.Count == 0)
				{
					return null;
				}
				return this.replyTo[0];
			}
			set
			{
				this.replyTo.Clear();
				this.replyTo.Add(value);
			}
		}

		/// <summary>Возвращает или задает адрес отправителя данного сообщения электронной почты.</summary>
		/// <returns>Объект <see cref="T:System.Net.Mail.MailAddress" />, содержащий информацию об адресе отправителя.</returns>
		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x000E7C8A File Offset: 0x000E5E8A
		// (set) Token: 0x060042A2 RID: 17058 RVA: 0x000E7C92 File Offset: 0x000E5E92
		public MailAddress Sender
		{
			get
			{
				return this.sender;
			}
			set
			{
				this.sender = value;
			}
		}

		/// <summary>Возвращает или задает строку темы для данного сообщения электронной почты.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее тему.</returns>
		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x000E7C9B File Offset: 0x000E5E9B
		// (set) Token: 0x060042A4 RID: 17060 RVA: 0x000E7CA3 File Offset: 0x000E5EA3
		public string Subject
		{
			get
			{
				return this.subject;
			}
			set
			{
				if (value != null && this.subjectEncoding == null)
				{
					this.subjectEncoding = this.GuessEncoding(value);
				}
				this.subject = value;
			}
		}

		/// <summary>Возвращает или задает кодировку, используемую для темы данного сообщения электронной почты.</summary>
		/// <returns>Кодировка <see cref="T:System.Text.Encoding" />, использованная для кодирования свойства <see cref="P:System.Net.Mail.MailMessage.Subject" />.</returns>
		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x000E7CC4 File Offset: 0x000E5EC4
		// (set) Token: 0x060042A6 RID: 17062 RVA: 0x000E7CCC File Offset: 0x000E5ECC
		public Encoding SubjectEncoding
		{
			get
			{
				return this.subjectEncoding;
			}
			set
			{
				this.subjectEncoding = value;
			}
		}

		/// <summary>Возвращает коллекцию адресов, содержащую получателей данного сообщения электронной почты.</summary>
		/// <returns>Доступный для записи объект <see cref="T:System.Net.Mail.MailAddressCollection" />.</returns>
		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x000E7CD5 File Offset: 0x000E5ED5
		public MailAddressCollection To
		{
			get
			{
				return this.to;
			}
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Net.Mail.MailMessage" />.</summary>
		// Token: 0x060042A8 RID: 17064 RVA: 0x000E7CDD File Offset: 0x000E5EDD
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Mail.MailMessage" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060042A9 RID: 17065 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x000E7CEC File Offset: 0x000E5EEC
		private Encoding GuessEncoding(string s)
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] >= '\u0080')
				{
					return MailMessage.UTF8Unmarked;
				}
			}
			return null;
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x000E7D20 File Offset: 0x000E5F20
		internal static TransferEncoding GuessTransferEncoding(Encoding enc)
		{
			if (Encoding.ASCII.Equals(enc))
			{
				return TransferEncoding.SevenBit;
			}
			if (Encoding.UTF8.CodePage == enc.CodePage || Encoding.Unicode.CodePage == enc.CodePage || Encoding.UTF32.CodePage == enc.CodePage)
			{
				return TransferEncoding.Base64;
			}
			return TransferEncoding.QuotedPrintable;
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x000E7D78 File Offset: 0x000E5F78
		internal static string To2047(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				if (b < 33 || b > 126 || b == 63 || b == 61 || b == 95)
				{
					stringBuilder.Append('=');
					stringBuilder.Append(MailMessage.hex[b >> 4 & 15]);
					stringBuilder.Append(MailMessage.hex[(int)(b & 15)]);
				}
				else
				{
					stringBuilder.Append((char)b);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000E7DF8 File Offset: 0x000E5FF8
		internal static string EncodeSubjectRFC2047(string s, Encoding enc)
		{
			if (s == null || Encoding.ASCII.Equals(enc))
			{
				return s;
			}
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] >= '\u0080')
				{
					string text = MailMessage.To2047(enc.GetBytes(s));
					return string.Concat(new string[]
					{
						"=?",
						enc.HeaderName,
						"?Q?",
						text,
						"?="
					});
				}
			}
			return s;
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x000E7E75 File Offset: 0x000E6075
		private static Encoding UTF8Unmarked
		{
			get
			{
				if (MailMessage.utf8unmarked == null)
				{
					MailMessage.utf8unmarked = new UTF8Encoding(false);
				}
				return MailMessage.utf8unmarked;
			}
		}

		// Token: 0x04002852 RID: 10322
		private AlternateViewCollection alternateViews;

		// Token: 0x04002853 RID: 10323
		private AttachmentCollection attachments;

		// Token: 0x04002854 RID: 10324
		private MailAddressCollection bcc;

		// Token: 0x04002855 RID: 10325
		private MailAddressCollection replyTo;

		// Token: 0x04002856 RID: 10326
		private string body;

		// Token: 0x04002857 RID: 10327
		private MailPriority priority;

		// Token: 0x04002858 RID: 10328
		private MailAddress sender;

		// Token: 0x04002859 RID: 10329
		private DeliveryNotificationOptions deliveryNotificationOptions;

		// Token: 0x0400285A RID: 10330
		private MailAddressCollection cc;

		// Token: 0x0400285B RID: 10331
		private MailAddress from;

		// Token: 0x0400285C RID: 10332
		private NameValueCollection headers;

		// Token: 0x0400285D RID: 10333
		private MailAddressCollection to;

		// Token: 0x0400285E RID: 10334
		private string subject;

		// Token: 0x0400285F RID: 10335
		private Encoding subjectEncoding;

		// Token: 0x04002860 RID: 10336
		private Encoding bodyEncoding;

		// Token: 0x04002861 RID: 10337
		private Encoding headersEncoding = Encoding.UTF8;

		// Token: 0x04002862 RID: 10338
		private bool isHtml;

		// Token: 0x04002863 RID: 10339
		private static char[] hex = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F'
		};

		// Token: 0x04002864 RID: 10340
		private static Encoding utf8unmarked;
	}
}
