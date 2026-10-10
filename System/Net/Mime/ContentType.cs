using System;
using System.Collections.Specialized;
using System.Net.Mail;
using System.Text;

namespace System.Net.Mime
{
	/// <summary>Представляет заголовок Content-Type протокола MIME.</summary>
	// Token: 0x020007FA RID: 2042
	public class ContentType
	{
		/// <summary>Инициализирует новый экземпляр по умолчанию класса <see cref="T:System.Net.Mime.ContentType" />.</summary>
		// Token: 0x06004128 RID: 16680 RVA: 0x000E075F File Offset: 0x000DE95F
		public ContentType() : this("application/octet-stream")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mime.ContentType" />, используя указанную строку.</summary>
		/// <param name="contentType">Объект <see cref="T:System.String" />, например <c>"text/plain; charset=us-ascii"</c>, который содержит тип мультимедиа MIME, подтип и необязательные параметры.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="contentType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="contentType" /> имеет значение <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="contentType" /> имеет вид формы, которую нельзя проанализировать.</exception>
		// Token: 0x06004129 RID: 16681 RVA: 0x000E076C File Offset: 0x000DE96C
		public ContentType(string contentType)
		{
			if (contentType == null)
			{
				throw new ArgumentNullException("contentType");
			}
			if (contentType == string.Empty)
			{
				throw new ArgumentException(SR.Format("The parameter '{0}' cannot be an empty string.", "contentType"), "contentType");
			}
			this._isChanged = true;
			this._type = contentType;
			this.ParseValue();
		}

		/// <summary>Возвращает или задает значение параметра границы, который содержится в заголовке Content-Type, представляемом данным экземпляром.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит значение, связанное с параметром границы.</returns>
		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x000E07D3 File Offset: 0x000DE9D3
		// (set) Token: 0x0600412B RID: 16683 RVA: 0x000E07E5 File Offset: 0x000DE9E5
		public string Boundary
		{
			get
			{
				return this.Parameters["boundary"];
			}
			set
			{
				if (value == null || value == string.Empty)
				{
					this.Parameters.Remove("boundary");
					return;
				}
				this.Parameters["boundary"] = value;
			}
		}

		/// <summary>Возвращает или задает значение параметра кодировки, который содержится в заголовке Content-Type, представляемом данным экземпляром.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит значение, связанное с параметром кодировки.</returns>
		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x000E0819 File Offset: 0x000DEA19
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x000E082B File Offset: 0x000DEA2B
		public string CharSet
		{
			get
			{
				return this.Parameters["charset"];
			}
			set
			{
				if (value == null || value == string.Empty)
				{
					this.Parameters.Remove("charset");
					return;
				}
				this.Parameters["charset"] = value;
			}
		}

		/// <summary>Возвращает или задает значение типа мультимедиа, которое содержится в заголовке Content-Type, представляемом данным экземпляром.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит значение типа и подтипа мультимедиа. Это значение не содержит точку с запятой (;) — разделитель, следующий за подтипом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для операции задания указано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для операции задания указано значение <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">Нельзя проанализировать формат значения, указанного для операции присвоения.</exception>
		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x000E085F File Offset: 0x000DEA5F
		// (set) Token: 0x0600412F RID: 16687 RVA: 0x000E0878 File Offset: 0x000DEA78
		public string MediaType
		{
			get
			{
				return this._mediaType + "/" + this._subType;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value == string.Empty)
				{
					throw new ArgumentException("This property cannot be set to an empty string.", "value");
				}
				int num = 0;
				this._mediaType = MailBnfHelper.ReadToken(value, ref num, null);
				if (this._mediaType.Length == 0 || num >= value.Length || value[num++] != '/')
				{
					throw new FormatException("The specified media type is invalid.");
				}
				this._subType = MailBnfHelper.ReadToken(value, ref num, null);
				if (this._subType.Length == 0 || num < value.Length)
				{
					throw new FormatException("The specified media type is invalid.");
				}
				this._isChanged = true;
				this._isPersisted = false;
			}
		}

		/// <summary>Возвращает или задает параметр имени, который содержится в заголовке Content-Type, представляемом данным экземпляром.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит значение, связанное с параметром имени.</returns>
		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x000E0930 File Offset: 0x000DEB30
		// (set) Token: 0x06004131 RID: 16689 RVA: 0x000E095E File Offset: 0x000DEB5E
		public string Name
		{
			get
			{
				string text = this.Parameters["name"];
				if (MimeBasePart.DecodeEncoding(text) != null)
				{
					text = MimeBasePart.DecodeHeaderValue(text);
				}
				return text;
			}
			set
			{
				if (value == null || value == string.Empty)
				{
					this.Parameters.Remove("name");
					return;
				}
				this.Parameters["name"] = value;
			}
		}

		/// <summary>Возвращает словарь, который содержит параметры заголовка Content-Type, представляемого данным экземпляром.</summary>
		/// <returns>Доступный для записи объект <see cref="T:System.Collections.Specialized.StringDictionary" />, содержащий пары имя/значение.</returns>
		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x000E0992 File Offset: 0x000DEB92
		public StringDictionary Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x000E099A File Offset: 0x000DEB9A
		internal void Set(string contentType, HeaderCollection headers)
		{
			this._type = contentType;
			this.ParseValue();
			headers.InternalSet(MailHeaderInfo.GetString(MailHeaderID.ContentType), this.ToString());
			this._isPersisted = true;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x000E09C2 File Offset: 0x000DEBC2
		internal void PersistIfNeeded(HeaderCollection headers, bool forcePersist)
		{
			if (this.IsChanged || !this._isPersisted || forcePersist)
			{
				headers.InternalSet(MailHeaderInfo.GetString(MailHeaderID.ContentType), this.ToString());
				this._isPersisted = true;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x000E09F5 File Offset: 0x000DEBF5
		internal bool IsChanged
		{
			get
			{
				return this._isChanged || (this._parameters != null && this._parameters.IsChanged);
			}
		}

		/// <summary>Возвращает строковое представление этого объекта <see cref="T:System.Net.Mime.ContentType" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит текущие параметры данного <see cref="T:System.Net.Mime.ContentType" />.</returns>
		// Token: 0x06004136 RID: 16694 RVA: 0x000E0A16 File Offset: 0x000DEC16
		public override string ToString()
		{
			if (this._type == null || this.IsChanged)
			{
				this._type = this.Encode(false);
				this._isChanged = false;
				this._parameters.IsChanged = false;
				this._isPersisted = false;
			}
			return this._type;
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x000E0A58 File Offset: 0x000DEC58
		internal string Encode(bool allowUnicode)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this._mediaType);
			stringBuilder.Append('/');
			stringBuilder.Append(this._subType);
			foreach (object obj in this.Parameters.Keys)
			{
				string text = (string)obj;
				stringBuilder.Append("; ");
				ContentType.EncodeToBuffer(text, stringBuilder, allowUnicode);
				stringBuilder.Append('=');
				ContentType.EncodeToBuffer(this._parameters[text], stringBuilder, allowUnicode);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x000E0B10 File Offset: 0x000DED10
		private static void EncodeToBuffer(string value, StringBuilder builder, bool allowUnicode)
		{
			Encoding encoding = MimeBasePart.DecodeEncoding(value);
			if (encoding != null)
			{
				builder.Append('"').Append(value).Append('"');
				return;
			}
			if ((allowUnicode && !MailBnfHelper.HasCROrLF(value)) || MimeBasePart.IsAscii(value, false))
			{
				MailBnfHelper.GetTokenOrQuotedString(value, builder, allowUnicode);
				return;
			}
			encoding = Encoding.GetEncoding("utf-8");
			builder.Append('"').Append(MimeBasePart.EncodeHeaderValue(value, encoding, MimeBasePart.ShouldUseBase64Encoding(encoding))).Append('"');
		}

		/// <summary>Определяет, равен ли заголовок Content-Type указанного объекта <see cref="T:System.Net.Mime.ContentType" /> заголовку Content-Type данного объекта.</summary>
		/// <param name="rparam">Объект <see cref="T:System.Net.Mime.ContentType" />, который требуется сравнить с данным объектом.</param>
		/// <returns>Значение <see langword="true" />, если заголовки Content-Type одинаковы; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004139 RID: 16697 RVA: 0x000E04C8 File Offset: 0x000DE6C8
		public override bool Equals(object rparam)
		{
			return rparam != null && string.Equals(this.ToString(), rparam.ToString(), StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>Определяет хэш-код указанного объекта <see cref="T:System.Net.Mime.ContentType" />.</summary>
		/// <returns>Целочисленное хэш-значение.</returns>
		// Token: 0x0600413A RID: 16698 RVA: 0x000E04E1 File Offset: 0x000DE6E1
		public override int GetHashCode()
		{
			return this.ToString().ToLowerInvariant().GetHashCode();
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x000E0B88 File Offset: 0x000DED88
		private void ParseValue()
		{
			int num = 0;
			Exception ex = null;
			try
			{
				this._mediaType = MailBnfHelper.ReadToken(this._type, ref num, null);
				if (this._mediaType == null || this._mediaType.Length == 0 || num >= this._type.Length || this._type[num++] != '/')
				{
					ex = new FormatException("The specified content type is invalid.");
				}
				if (ex == null)
				{
					this._subType = MailBnfHelper.ReadToken(this._type, ref num, null);
					if (this._subType == null || this._subType.Length == 0)
					{
						ex = new FormatException("The specified content type is invalid.");
					}
				}
				if (ex == null)
				{
					while (MailBnfHelper.SkipCFWS(this._type, ref num))
					{
						if (this._type[num++] != ';')
						{
							ex = new FormatException("The specified content type is invalid.");
							break;
						}
						if (!MailBnfHelper.SkipCFWS(this._type, ref num))
						{
							break;
						}
						string text = MailBnfHelper.ReadParameterAttribute(this._type, ref num, null);
						if (text == null || text.Length == 0)
						{
							ex = new FormatException("The specified content type is invalid.");
							break;
						}
						if (num >= this._type.Length || this._type[num++] != '=')
						{
							ex = new FormatException("The specified content type is invalid.");
							break;
						}
						if (!MailBnfHelper.SkipCFWS(this._type, ref num))
						{
							ex = new FormatException("The specified content type is invalid.");
							break;
						}
						string text2 = (this._type[num] == '"') ? MailBnfHelper.ReadQuotedString(this._type, ref num, null) : MailBnfHelper.ReadToken(this._type, ref num, null);
						if (text2 == null)
						{
							ex = new FormatException("The specified content type is invalid.");
							break;
						}
						this._parameters.Add(text, text2);
					}
				}
				this._parameters.IsChanged = false;
			}
			catch (FormatException)
			{
				throw new FormatException("The specified content type is invalid.");
			}
			if (ex != null)
			{
				throw new FormatException("The specified content type is invalid.");
			}
		}

		// Token: 0x0400278F RID: 10127
		private readonly TrackingStringDictionary _parameters = new TrackingStringDictionary();

		// Token: 0x04002790 RID: 10128
		private string _mediaType;

		// Token: 0x04002791 RID: 10129
		private string _subType;

		// Token: 0x04002792 RID: 10130
		private bool _isChanged;

		// Token: 0x04002793 RID: 10131
		private string _type;

		// Token: 0x04002794 RID: 10132
		private bool _isPersisted;

		// Token: 0x04002795 RID: 10133
		internal const string Default = "application/octet-stream";
	}
}
