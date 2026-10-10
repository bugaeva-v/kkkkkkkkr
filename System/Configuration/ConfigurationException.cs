using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Вызванное исключение при возникновении ошибки в системе конфигурации.</summary>
	// Token: 0x020001A5 RID: 421
	[Serializable]
	public class ConfigurationException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationException" />.</summary>
		// Token: 0x06000B02 RID: 2818 RVA: 0x0002F145 File Offset: 0x0002D345
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException() : this(null)
		{
			this.filename = null;
			this.line = 0;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationException" />.</summary>
		/// <param name="message">Сообщение, описывающее причину создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		// Token: 0x06000B03 RID: 2819 RVA: 0x0002F15C File Offset: 0x0002D35C
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationException" />.</summary>
		/// <param name="info">Объект, содержащий сведения о выполнении десериализации.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000B04 RID: 2820 RVA: 0x0002F165 File Offset: 0x0002D365
		protected ConfigurationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.filename = info.GetString("filename");
			this.line = info.GetInt32("line");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationException" />.</summary>
		/// <param name="message">Сообщение, описывающее причину создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <param name="inner">Внутреннее исключение, которое вызвало данное исключение <see cref="T:System.Configuration.ConfigurationException" />, если таковое есть.</param>
		// Token: 0x06000B05 RID: 2821 RVA: 0x0002F191 File Offset: 0x0002D391
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner) : base(message, inner)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationException" />.</summary>
		/// <param name="message">Сообщение, описывающее причину создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <param name="node">Объект <see cref="T:System.Xml.XmlNode" />, который вызвал исключение <see cref="T:System.Configuration.ConfigurationException" />.</param>
		// Token: 0x06000B06 RID: 2822 RVA: 0x0002F19B File Offset: 0x0002D39B
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, XmlNode node) : base(message)
		{
			this.filename = ConfigurationException.GetXmlNodeFilename(node);
			this.line = ConfigurationException.GetXmlNodeLineNumber(node);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationException" />.</summary>
		/// <param name="message">Сообщение, описывающее причину создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <param name="inner">Внутреннее исключение, которое вызвало данное исключение <see cref="T:System.Configuration.ConfigurationException" />, если таковое есть.</param>
		/// <param name="node">Объект <see cref="T:System.Xml.XmlNode" />, который вызвал исключение <see cref="T:System.Configuration.ConfigurationException" />.</param>
		// Token: 0x06000B07 RID: 2823 RVA: 0x0002F1BC File Offset: 0x0002D3BC
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner, XmlNode node) : base(message, inner)
		{
			this.filename = ConfigurationException.GetXmlNodeFilename(node);
			this.line = ConfigurationException.GetXmlNodeLineNumber(node);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationException" />.</summary>
		/// <param name="message">Сообщение, описывающее причину создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <param name="filename">Путь к файлу конфигурации, который привел к вызову данного исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <param name="line">Номер строки в файле конфигурации, в которой возникло данное исключение <see cref="T:System.Configuration.ConfigurationException" />.</param>
		// Token: 0x06000B08 RID: 2824 RVA: 0x0002F1DE File Offset: 0x0002D3DE
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, string filename, int line) : base(message)
		{
			this.filename = filename;
			this.line = line;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationException" />.</summary>
		/// <param name="message">Сообщение, описывающее причину создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <param name="inner">Внутреннее исключение, которое вызвало данное исключение <see cref="T:System.Configuration.ConfigurationException" />, если таковое есть.</param>
		/// <param name="filename">Путь к файлу конфигурации, который привел к вызову данного исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <param name="line">Номер строки в файле конфигурации, в которой возникло данное исключение <see cref="T:System.Configuration.ConfigurationException" />.</param>
		// Token: 0x06000B09 RID: 2825 RVA: 0x0002F1F5 File Offset: 0x0002D3F5
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner, string filename, int line) : base(message, inner)
		{
			this.filename = filename;
			this.line = line;
		}

		/// <summary>Получает описание причины возникновения данного исключения конфигурации.</summary>
		/// <returns>Описание причины создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</returns>
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0002F20E File Offset: 0x0002D40E
		public virtual string BareMessage
		{
			get
			{
				return base.Message;
			}
		}

		/// <summary>Получает путь к файлу конфигурации, который привел к возникновению данного исключения конфигурации.</summary>
		/// <returns>Путь к файлу конфигурации, который привел к возникновению данного исключения <see cref="T:System.Configuration.ConfigurationException" />.</returns>
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0002F216 File Offset: 0x0002D416
		public virtual string Filename
		{
			get
			{
				return this.filename;
			}
		}

		/// <summary>Получает номер строки в файле конфигурации, в которой возникло данное исключение.</summary>
		/// <returns>Номер строки в файле конфигурации, в которой возникло данное исключение <see cref="T:System.Configuration.ConfigurationException" />.</returns>
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0002F21E File Offset: 0x0002D41E
		public virtual int Line
		{
			get
			{
				return this.line;
			}
		}

		/// <summary>Получает расширенное описание причины возникновения данного исключения конфигурации.</summary>
		/// <returns>Расширенное описание причины вызова данного исключения <see cref="T:System.Configuration.ConfigurationException" />.</returns>
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0002F228 File Offset: 0x0002D428
		public override string Message
		{
			get
			{
				string result;
				if (this.filename != null && this.filename.Length != 0)
				{
					if (this.line != 0)
					{
						result = string.Concat(new string[]
						{
							this.BareMessage,
							" (",
							this.filename,
							" line ",
							this.line.ToString(),
							")"
						});
					}
					else
					{
						result = this.BareMessage + " (" + this.filename + ")";
					}
				}
				else if (this.line != 0)
				{
					result = this.BareMessage + " (line " + this.line.ToString() + ")";
				}
				else
				{
					result = this.BareMessage;
				}
				return result;
			}
		}

		/// <summary>Получает путь к файлу конфигурации, из которого загружался внутренний объект <see cref="T:System.Xml.XmlNode" />, когда возникло данное исключение конфигурации.</summary>
		/// <param name="node">Объект <see cref="T:System.Xml.XmlNode" />, который стал причиной создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <returns>Объект <see langword="string" />, представляющий имя файла узла.</returns>
		// Token: 0x06000B0E RID: 2830 RVA: 0x0002F2E9 File Offset: 0x0002D4E9
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public static string GetXmlNodeFilename(XmlNode node)
		{
			if (!(node is IConfigXmlNode))
			{
				return string.Empty;
			}
			return ((IConfigXmlNode)node).Filename;
		}

		/// <summary>Получает номер строки в файле конфигурации, которую представлял внутренний объект <see cref="T:System.Xml.XmlNode" />, когда возникло данное исключение конфигурации.</summary>
		/// <param name="node">Объект <see cref="T:System.Xml.XmlNode" />, который стал причиной создания исключения <see cref="T:System.Configuration.ConfigurationException" />.</param>
		/// <returns>Значение <see langword="int" />, представляющее номер строки узла.</returns>
		// Token: 0x06000B0F RID: 2831 RVA: 0x0002F304 File Offset: 0x0002D504
		[Obsolete("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
		public static int GetXmlNodeLineNumber(XmlNode node)
		{
			if (!(node is IConfigXmlNode))
			{
				return 0;
			}
			return ((IConfigXmlNode)node).LineNumber;
		}

		/// <summary>Задает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с именем файла и номером строки, в которых возникло данное исключение конфигурации.</summary>
		/// <param name="info">Объект, содержащий сведения о выполнении сериализации.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000B10 RID: 2832 RVA: 0x0002F31B File Offset: 0x0002D51B
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("filename", this.filename);
			info.AddValue("line", this.line);
		}

		// Token: 0x04000740 RID: 1856
		private readonly string filename;

		// Token: 0x04000741 RID: 1857
		private readonly int line;
	}
}
