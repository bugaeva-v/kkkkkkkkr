using System;
using System.Globalization;
using System.Resources;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml.Utils;

namespace System.Xml.Xsl
{
	/// <summary>
	///         Исключение, возникающее при возникновении ошибки во время обработки XSLT-преобразования.
	///       </summary>
	// Token: 0x0200034C RID: 844
	[Serializable]
	public class XsltException : SystemException
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see langword="XsltException" /> класса, используя сведения в <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" /> объектов.
		///       </summary>
		/// <param name="info">
		///           <see langword="SerializationInfo" /> Объект, содержащий все свойства <see langword="XsltException" />.
		///         </param>
		/// <param name="context">
		///           Объект <see langword="StreamingContext" />.
		///         </param>
		// Token: 0x060022DA RID: 8922 RVA: 0x000DA750 File Offset: 0x000D8950
		protected XsltException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.res = (string)info.GetValue("res", typeof(string));
			this.args = (string[])info.GetValue("args", typeof(string[]));
			this.sourceUri = (string)info.GetValue("sourceUri", typeof(string));
			this.lineNumber = (int)info.GetValue("lineNumber", typeof(int));
			this.linePosition = (int)info.GetValue("linePosition", typeof(int));
			string text = null;
			foreach (SerializationEntry serializationEntry in info)
			{
				if (serializationEntry.Name == "version")
				{
					text = (string)serializationEntry.Value;
				}
			}
			if (text == null)
			{
				this.message = XsltException.CreateMessage(this.res, this.args, this.sourceUri, this.lineNumber, this.linePosition);
				return;
			}
			this.message = null;
		}

		/// <summary>
		///         Объединяет все <see langword="XsltException" /> Свойства в <see cref="T:System.Runtime.Serialization.SerializationInfo" /> класса для данного <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///       </summary>
		/// <param name="info">
		///           Объект <see langword="SerializationInfo" />.
		///         </param>
		/// <param name="context">
		///           Объект <see langword="StreamingContext" />.
		///         </param>
		// Token: 0x060022DB RID: 8923 RVA: 0x000DA874 File Offset: 0x000D8A74
		[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("res", this.res);
			info.AddValue("args", this.args);
			info.AddValue("sourceUri", this.sourceUri);
			info.AddValue("lineNumber", this.lineNumber);
			info.AddValue("linePosition", this.linePosition);
			info.AddValue("version", "2.0");
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Xsl.XsltException" />.
		///       </summary>
		// Token: 0x060022DC RID: 8924 RVA: 0x000DA8EE File Offset: 0x000D8AEE
		public XsltException() : this(string.Empty, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Xsl.XsltException" /> с указанным сообщением об ошибке.
		///       </summary>
		/// <param name="message">
		///           Сообщение, описывающее ошибку.
		///         </param>
		// Token: 0x060022DD RID: 8925 RVA: 0x000DA8FC File Offset: 0x000D8AFC
		public XsltException(string message) : this(message, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XsltException" />.
		///       </summary>
		/// <param name="message">
		///           Описание условия ошибки.
		///         </param>
		/// <param name="innerException">
		///           <see cref="T:System.Exception" /> Сгенерировавшее данное исключение <see langword="XsltException" />, если таковые имеются.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		// Token: 0x060022DE RID: 8926 RVA: 0x000DA906 File Offset: 0x000D8B06
		public XsltException(string message, Exception innerException) : this("{0}", new string[]
		{
			message
		}, null, 0, 0, innerException)
		{
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x000DA921 File Offset: 0x000D8B21
		internal static XsltException Create(string res, params string[] args)
		{
			return new XsltException(res, args, null, 0, 0, null);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000DA92E File Offset: 0x000D8B2E
		internal static XsltException Create(string res, string[] args, Exception inner)
		{
			return new XsltException(res, args, null, 0, 0, inner);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000DA93B File Offset: 0x000D8B3B
		internal XsltException(string res, string[] args, string sourceUri, int lineNumber, int linePosition, Exception inner) : base(XsltException.CreateMessage(res, args, sourceUri, lineNumber, linePosition), inner)
		{
			base.HResult = -2146231998;
			this.res = res;
			this.sourceUri = sourceUri;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
		}

		/// <summary>
		///         Возвращает путь к таблице стилей.
		///       </summary>
		/// <returns>
		///         Путь к таблице стилей.
		///       </returns>
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000DA97A File Offset: 0x000D8B7A
		public virtual string SourceUri
		{
			get
			{
				return this.sourceUri;
			}
		}

		/// <summary>
		///         Возвращает номер строки, указывающий место возникновения ошибки в таблице стилей.
		///       </summary>
		/// <returns>
		///         Номер строки, указывающий место возникновения ошибки в таблице стилей.
		///       </returns>
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x000DA982 File Offset: 0x000D8B82
		public virtual int LineNumber
		{
			get
			{
				return this.lineNumber;
			}
		}

		/// <summary>
		///         Возвращает номер строки, указывающий место возникновения ошибки в таблице стилей.
		///       </summary>
		/// <returns>
		///         Позиция в строке, указывающую место возникновения ошибки в таблице стилей.
		///       </returns>
		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000DA98A File Offset: 0x000D8B8A
		public virtual int LinePosition
		{
			get
			{
				return this.linePosition;
			}
		}

		/// <summary>
		///         Возвращает отформатированное сообщение, описывающее текущее исключение.
		///       </summary>
		/// <returns>
		///         Отформатированное сообщение об описывающее текущее исключение.
		///       </returns>
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000DA992 File Offset: 0x000D8B92
		public override string Message
		{
			get
			{
				if (this.message != null)
				{
					return this.message;
				}
				return base.Message;
			}
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000DA9AC File Offset: 0x000D8BAC
		private static string CreateMessage(string res, string[] args, string sourceUri, int lineNumber, int linePosition)
		{
			string result;
			try
			{
				string text = XsltException.FormatMessage(res, args);
				if (res != "XSLT compile error at {0}({1},{2}). See InnerException for details." && lineNumber != 0)
				{
					text = text + " " + XsltException.FormatMessage("An error occurred at {0}({1},{2}).", new string[]
					{
						sourceUri,
						lineNumber.ToString(CultureInfo.InvariantCulture),
						linePosition.ToString(CultureInfo.InvariantCulture)
					});
				}
				result = text;
			}
			catch (MissingManifestResourceException)
			{
				result = "UNKNOWN(" + res + ")";
			}
			return result;
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x000DAA38 File Offset: 0x000D8C38
		private static string FormatMessage(string key, params string[] args)
		{
			string text = Res.GetString(key);
			if (text != null && args != null)
			{
				text = string.Format(CultureInfo.InvariantCulture, text, args);
			}
			return text;
		}

		// Token: 0x04001C52 RID: 7250
		private string res;

		// Token: 0x04001C53 RID: 7251
		private string[] args;

		// Token: 0x04001C54 RID: 7252
		private string sourceUri;

		// Token: 0x04001C55 RID: 7253
		private int lineNumber;

		// Token: 0x04001C56 RID: 7254
		private int linePosition;

		// Token: 0x04001C57 RID: 7255
		private string message;
	}
}
