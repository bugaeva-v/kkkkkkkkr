using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Net.Mail;
using System.Text;

namespace System.Net.Mime
{
	/// <summary>Представляет заголовок Content-Disposition протокола MIME.</summary>
	// Token: 0x020007F8 RID: 2040
	public class ContentDisposition
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mime.ContentDisposition" /> со значением <see cref="P:System.Net.Mime.ContentDisposition.DispositionType" /> объекта <see cref="F:System.Net.Mime.DispositionTypeNames.Attachment" />.</summary>
		// Token: 0x06004108 RID: 16648 RVA: 0x000E0074 File Offset: 0x000DE274
		public ContentDisposition()
		{
			this._isChanged = true;
			this._disposition = (this._dispositionType = "attachment");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mime.ContentDisposition" /> с заданными сведениями о расположении.</summary>
		/// <param name="disposition">Значение <see cref="T:System.Net.Mime.DispositionTypeNames" />, содержащее расположение.</param>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="disposition" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" /> ("").</exception>
		// Token: 0x06004109 RID: 16649 RVA: 0x000E00A2 File Offset: 0x000DE2A2
		public ContentDisposition(string disposition)
		{
			if (disposition == null)
			{
				throw new ArgumentNullException("disposition");
			}
			this._isChanged = true;
			this._disposition = disposition;
			this.ParseValue();
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x000E00CC File Offset: 0x000DE2CC
		internal DateTime GetDateParameter(string parameterName)
		{
			SmtpDateTime smtpDateTime = ((TrackingValidationObjectDictionary)this.Parameters).InternalGet(parameterName) as SmtpDateTime;
			if (smtpDateTime != null)
			{
				return smtpDateTime.Date;
			}
			return DateTime.MinValue;
		}

		/// <summary>Возвращает или задает тип расположения для вложения электронной почты.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая тип расположения. Значение не ограничено, но обычно является одним из значений <see cref="P:System.Net.Mime.ContentDisposition.DispositionType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для операции задания указано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для операции присвоения указано значение <see cref="F:System.String.Empty" /> ("").</exception>
		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x0600410B RID: 16651 RVA: 0x000E00FF File Offset: 0x000DE2FF
		// (set) Token: 0x0600410C RID: 16652 RVA: 0x000E0107 File Offset: 0x000DE307
		public string DispositionType
		{
			get
			{
				return this._dispositionType;
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
				this._isChanged = true;
				this._dispositionType = value;
			}
		}

		/// <summary>Возвращает параметры, которые содержатся в заголовке Content-Disposition, представляемом этим экземпляром.</summary>
		/// <returns>Доступный для записи объект <see cref="T:System.Collections.Specialized.StringDictionary" />, содержащий пары имя/значение параметра.</returns>
		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x0600410D RID: 16653 RVA: 0x000E0144 File Offset: 0x000DE344
		public StringDictionary Parameters
		{
			get
			{
				TrackingValidationObjectDictionary result;
				if ((result = this._parameters) == null)
				{
					result = (this._parameters = new TrackingValidationObjectDictionary(ContentDisposition.s_validators));
				}
				return result;
			}
		}

		/// <summary>Возвращает или задает предлагаемое имя файла для вложения электронной почты.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит имя файла.</returns>
		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x000E016E File Offset: 0x000DE36E
		// (set) Token: 0x0600410F RID: 16655 RVA: 0x000E0180 File Offset: 0x000DE380
		public string FileName
		{
			get
			{
				return this.Parameters["filename"];
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.Parameters.Remove("filename");
					return;
				}
				this.Parameters["filename"] = value;
			}
		}

		/// <summary>Возвращает или задает дату создания файла вложения.</summary>
		/// <returns>Значение <see cref="T:System.DateTime" />, обозначающее дату создания файла, в противном случае — <see cref="F:System.DateTime.MinValue" />, если дата не указана.</returns>
		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x000E01AC File Offset: 0x000DE3AC
		// (set) Token: 0x06004111 RID: 16657 RVA: 0x000E01BC File Offset: 0x000DE3BC
		public DateTime CreationDate
		{
			get
			{
				return this.GetDateParameter("creation-date");
			}
			set
			{
				SmtpDateTime value2 = new SmtpDateTime(value);
				((TrackingValidationObjectDictionary)this.Parameters).InternalSet("creation-date", value2);
			}
		}

		/// <summary>Возвращает или задает дату изменения файла вложения.</summary>
		/// <returns>Значение <see cref="T:System.DateTime" />, обозначающее дату изменения файла, в противном случае — <see cref="F:System.DateTime.MinValue" />, если дата не указана.</returns>
		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x000E01E6 File Offset: 0x000DE3E6
		// (set) Token: 0x06004113 RID: 16659 RVA: 0x000E01F4 File Offset: 0x000DE3F4
		public DateTime ModificationDate
		{
			get
			{
				return this.GetDateParameter("modification-date");
			}
			set
			{
				SmtpDateTime value2 = new SmtpDateTime(value);
				((TrackingValidationObjectDictionary)this.Parameters).InternalSet("modification-date", value2);
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, определяющее тип расположения (Inline или Attachment) вложения электронной почты.</summary>
		/// <returns>
		///   <see langword="true" /> Если содержимое вложения отображается в тексте сообщения электронной почты; в противном случае <see langword="false" />.</returns>
		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06004114 RID: 16660 RVA: 0x000E021E File Offset: 0x000DE41E
		// (set) Token: 0x06004115 RID: 16661 RVA: 0x000E0230 File Offset: 0x000DE430
		public bool Inline
		{
			get
			{
				return this._dispositionType == "inline";
			}
			set
			{
				this._isChanged = true;
				this._dispositionType = (value ? "inline" : "attachment");
			}
		}

		/// <summary>Возвращает или задает дату чтения файла вложения.</summary>
		/// <returns>Значение <see cref="T:System.DateTime" />, обозначающее дату чтения файла, в противном случае — <see cref="F:System.DateTime.MinValue" />, если дата не указана.</returns>
		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x000E024E File Offset: 0x000DE44E
		// (set) Token: 0x06004117 RID: 16663 RVA: 0x000E025C File Offset: 0x000DE45C
		public DateTime ReadDate
		{
			get
			{
				return this.GetDateParameter("read-date");
			}
			set
			{
				SmtpDateTime value2 = new SmtpDateTime(value);
				((TrackingValidationObjectDictionary)this.Parameters).InternalSet("read-date", value2);
			}
		}

		/// <summary>Возвращает или задает размер вложенного файла.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, указывающее количество байтов во вложенном файле. По умолчанию принимается значение –1, указывающее на то, что размер файла неизвестен.</returns>
		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x000E0288 File Offset: 0x000DE488
		// (set) Token: 0x06004119 RID: 16665 RVA: 0x000E02B7 File Offset: 0x000DE4B7
		public long Size
		{
			get
			{
				object obj = ((TrackingValidationObjectDictionary)this.Parameters).InternalGet("size");
				if (obj != null)
				{
					return (long)obj;
				}
				return -1L;
			}
			set
			{
				((TrackingValidationObjectDictionary)this.Parameters).InternalSet("size", value);
			}
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x000E02D4 File Offset: 0x000DE4D4
		internal void Set(string contentDisposition, HeaderCollection headers)
		{
			this._disposition = contentDisposition;
			this.ParseValue();
			headers.InternalSet(MailHeaderInfo.GetString(MailHeaderID.ContentDisposition), this.ToString());
			this._isPersisted = true;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x000E02FC File Offset: 0x000DE4FC
		internal void PersistIfNeeded(HeaderCollection headers, bool forcePersist)
		{
			if (this.IsChanged || !this._isPersisted || forcePersist)
			{
				headers.InternalSet(MailHeaderInfo.GetString(MailHeaderID.ContentDisposition), this.ToString());
				this._isPersisted = true;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x000E032F File Offset: 0x000DE52F
		internal bool IsChanged
		{
			get
			{
				return this._isChanged || (this._parameters != null && this._parameters.IsChanged);
			}
		}

		/// <summary>Возвращает представление типа <see cref="T:System.String" /> данного экземпляра.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит значения свойств для данного экземпляра.</returns>
		// Token: 0x0600411D RID: 16669 RVA: 0x000E0350 File Offset: 0x000DE550
		public override string ToString()
		{
			if (this._disposition == null || this._isChanged || (this._parameters != null && this._parameters.IsChanged))
			{
				this._disposition = this.Encode(false);
				this._isChanged = false;
				this._parameters.IsChanged = false;
				this._isPersisted = false;
			}
			return this._disposition;
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x000E03B0 File Offset: 0x000DE5B0
		internal string Encode(bool allowUnicode)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this._dispositionType);
			foreach (object obj in this.Parameters.Keys)
			{
				string text = (string)obj;
				stringBuilder.Append("; ");
				ContentDisposition.EncodeToBuffer(text, stringBuilder, allowUnicode);
				stringBuilder.Append('=');
				ContentDisposition.EncodeToBuffer(this._parameters[text], stringBuilder, allowUnicode);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x000E0450 File Offset: 0x000DE650
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

		/// <summary>Определяет, равен ли заголовок Content-Disposition указанного объекта <see cref="T:System.Net.Mime.ContentDisposition" /> заголовку Content-Disposition данного объекта.</summary>
		/// <param name="rparam">Объект <see cref="T:System.Net.Mime.ContentDisposition" />, который требуется сравнить с данным объектом.</param>
		/// <returns>Значение <see langword="true" />, если заголовки Content-Disposition одинаковы, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004120 RID: 16672 RVA: 0x000E04C8 File Offset: 0x000DE6C8
		public override bool Equals(object rparam)
		{
			return rparam != null && string.Equals(this.ToString(), rparam.ToString(), StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>Определяет хэш-код указанного объекта <see cref="T:System.Net.Mime.ContentDisposition" />.</summary>
		/// <returns>Целочисленное хэш-значение.</returns>
		// Token: 0x06004121 RID: 16673 RVA: 0x000E04E1 File Offset: 0x000DE6E1
		public override int GetHashCode()
		{
			return this.ToString().ToLowerInvariant().GetHashCode();
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x000E04F4 File Offset: 0x000DE6F4
		private void ParseValue()
		{
			int num = 0;
			try
			{
				this._dispositionType = MailBnfHelper.ReadToken(this._disposition, ref num, null);
				if (string.IsNullOrEmpty(this._dispositionType))
				{
					throw new FormatException("The mail header is malformed.");
				}
				if (this._parameters == null)
				{
					this._parameters = new TrackingValidationObjectDictionary(ContentDisposition.s_validators);
				}
				else
				{
					this._parameters.Clear();
				}
				while (MailBnfHelper.SkipCFWS(this._disposition, ref num))
				{
					if (this._disposition[num++] != ';')
					{
						throw new FormatException(SR.Format("An invalid character was found in the mail header: '{0}'.", this._disposition[num - 1]));
					}
					if (!MailBnfHelper.SkipCFWS(this._disposition, ref num))
					{
						break;
					}
					string text = MailBnfHelper.ReadParameterAttribute(this._disposition, ref num, null);
					if (this._disposition[num++] != '=')
					{
						throw new FormatException("The mail header is malformed.");
					}
					if (!MailBnfHelper.SkipCFWS(this._disposition, ref num))
					{
						throw new FormatException("The specified content disposition is invalid.");
					}
					string value = (this._disposition[num] == '"') ? MailBnfHelper.ReadQuotedString(this._disposition, ref num, null) : MailBnfHelper.ReadToken(this._disposition, ref num, null);
					if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(value))
					{
						throw new FormatException("The specified content disposition is invalid.");
					}
					this.Parameters.Add(text, value);
				}
			}
			catch (FormatException innerException)
			{
				throw new FormatException("The specified content disposition is invalid.", innerException);
			}
			this._parameters.IsChanged = false;
		}

		// Token: 0x04002781 RID: 10113
		private const string CreationDateKey = "creation-date";

		// Token: 0x04002782 RID: 10114
		private const string ModificationDateKey = "modification-date";

		// Token: 0x04002783 RID: 10115
		private const string ReadDateKey = "read-date";

		// Token: 0x04002784 RID: 10116
		private const string FileNameKey = "filename";

		// Token: 0x04002785 RID: 10117
		private const string SizeKey = "size";

		// Token: 0x04002786 RID: 10118
		private TrackingValidationObjectDictionary _parameters;

		// Token: 0x04002787 RID: 10119
		private string _disposition;

		// Token: 0x04002788 RID: 10120
		private string _dispositionType;

		// Token: 0x04002789 RID: 10121
		private bool _isChanged;

		// Token: 0x0400278A RID: 10122
		private bool _isPersisted;

		// Token: 0x0400278B RID: 10123
		private static readonly TrackingValidationObjectDictionary.ValidateAndParseValue s_dateParser = (object v) => new SmtpDateTime(v.ToString());

		// Token: 0x0400278C RID: 10124
		private static readonly TrackingValidationObjectDictionary.ValidateAndParseValue s_longParser = delegate(object value)
		{
			long num;
			if (!long.TryParse(value.ToString(), NumberStyles.None, CultureInfo.InvariantCulture, out num))
			{
				throw new FormatException("The specified content disposition is invalid.");
			}
			return num;
		};

		// Token: 0x0400278D RID: 10125
		private static readonly Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> s_validators = new Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue>
		{
			{
				"creation-date",
				ContentDisposition.s_dateParser
			},
			{
				"modification-date",
				ContentDisposition.s_dateParser
			},
			{
				"read-date",
				ContentDisposition.s_dateParser
			},
			{
				"size",
				ContentDisposition.s_longParser
			}
		};
	}
}
