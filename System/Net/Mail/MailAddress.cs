using System;
using System.Globalization;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail
{
	/// <summary>Представляет адрес отправителя или получателя электронной почты.</summary>
	// Token: 0x0200081D RID: 2077
	public class MailAddress
	{
		// Token: 0x06004216 RID: 16918 RVA: 0x000E46C8 File Offset: 0x000E28C8
		internal MailAddress(string displayName, string userName, string domain)
		{
			this._host = domain;
			this._userName = userName;
			this._displayName = displayName;
			this._displayNameEncoding = Encoding.GetEncoding("utf-8");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.MailAddress" />, используя указанный адрес.</summary>
		/// <param name="address">Объект <see cref="T:System.String" />, содержащий адрес электронной почты.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> имеет значение <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="address" /> указан в нераспознаваемом формате.</exception>
		// Token: 0x06004217 RID: 16919 RVA: 0x000E46F5 File Offset: 0x000E28F5
		public MailAddress(string address) : this(address, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.MailAddress" />, используя указанный адрес и отображаемое имя.</summary>
		/// <param name="address">Объект <see cref="T:System.String" />, содержащий адрес электронной почты.</param>
		/// <param name="displayName">
		///   <see cref="T:System.String" />, содержащий отображаемое имя, связанное с <paramref name="address" />. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> имеет значение <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="address" /> указан в нераспознаваемом формате.  
		/// -или- 
		///  <paramref name="address" /> содержит символы, отличные от ASCII.</exception>
		// Token: 0x06004218 RID: 16920 RVA: 0x000E4700 File Offset: 0x000E2900
		public MailAddress(string address, string displayName) : this(address, displayName, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.MailAddress" />, используя заданные адрес, отображаемое имя и кодировку.</summary>
		/// <param name="address">Объект <see cref="T:System.String" />, содержащий адрес электронной почты.</param>
		/// <param name="displayName">
		///   <see cref="T:System.String" />, содержащий отображаемое имя, связанное с <paramref name="address" />.</param>
		/// <param name="displayNameEncoding">
		///   <see cref="T:System.Text.Encoding" />, который определяет набор символов, используемый для параметра <paramref name="displayName" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="displayName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> имеет значение <see cref="F:System.String.Empty" /> ("").  
		/// -или- 
		///  <paramref name="displayName" /> имеет значение <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="address" /> указан в нераспознаваемом формате.  
		/// -или- 
		///  <paramref name="address" /> содержит символы, отличные от ASCII.</exception>
		// Token: 0x06004219 RID: 16921 RVA: 0x000E470C File Offset: 0x000E290C
		public MailAddress(string address, string displayName, Encoding displayNameEncoding)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (address == string.Empty)
			{
				throw new ArgumentException(SR.Format("The parameter '{0}' cannot be an empty string.", "address"), "address");
			}
			this._displayNameEncoding = (displayNameEncoding ?? Encoding.GetEncoding("utf-8"));
			this._displayName = (displayName ?? string.Empty);
			if (!string.IsNullOrEmpty(this._displayName))
			{
				this._displayName = MailAddressParser.NormalizeOrThrow(this._displayName);
				if (this._displayName.Length >= 2 && this._displayName[0] == '"' && this._displayName[this._displayName.Length - 1] == '"')
				{
					this._displayName = this._displayName.Substring(1, this._displayName.Length - 2);
				}
			}
			MailAddress mailAddress = MailAddressParser.ParseAddress(address);
			this._host = mailAddress._host;
			this._userName = mailAddress._userName;
			if (string.IsNullOrEmpty(this._displayName))
			{
				this._displayName = mailAddress._displayName;
			}
		}

		/// <summary>Возвращает отображаемое имя, составленное из отображаемого имени и информации об адресе, заданных при создании этого экземпляра.</summary>
		/// <returns>Значение <see cref="T:System.String" />, которое содержит отображаемое имя; в противном случае — <see cref="F:System.String.Empty" /> (""), если при создании этого экземпляра не была задана информация об отображаемом имени.</returns>
		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x0600421A RID: 16922 RVA: 0x000E4828 File Offset: 0x000E2A28
		public string DisplayName
		{
			get
			{
				return this._displayName;
			}
		}

		/// <summary>Возвращает информацию о пользователе из адреса электронной почты, указанного при создании экземпляра.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее строку имени пользователя из <see cref="P:System.Net.Mail.MailAddress.Address" />.</returns>
		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x0600421B RID: 16923 RVA: 0x000E4830 File Offset: 0x000E2A30
		public string User
		{
			get
			{
				return this._userName;
			}
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x000E4838 File Offset: 0x000E2A38
		private string GetUser(bool allowUnicode)
		{
			if (!allowUnicode && !MimeBasePart.IsAscii(this._userName, true))
			{
				throw new SmtpException(SR.Format("The client or server is only configured for E-mail addresses with ASCII local-parts: {0}.", this.Address));
			}
			return this._userName;
		}

		/// <summary>Возвращает строку узла из адреса электронной почты, заданного при создании экземпляра.</summary>
		/// <returns>Объект <see cref="T:System.String" /> , содержащее имя главного компьютера, который принимает сообщения электронной почты для <see cref="P:System.Net.Mail.MailAddress.User" /> свойство.</returns>
		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x000E4867 File Offset: 0x000E2A67
		public string Host
		{
			get
			{
				return this._host;
			}
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x000E4870 File Offset: 0x000E2A70
		private string GetHost(bool allowUnicode)
		{
			string text = this._host;
			if (!allowUnicode && !MimeBasePart.IsAscii(text, true))
			{
				IdnMapping idnMapping = new IdnMapping();
				try
				{
					text = idnMapping.GetAscii(text);
				}
				catch (ArgumentException innerException)
				{
					throw new SmtpException(SR.Format("The address has an invalid host name: {0}.", this.Address), innerException);
				}
			}
			return text;
		}

		/// <summary>Возвращает адрес электронной почты, указанный при создании этого экземпляра.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее адрес электронной почты.</returns>
		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x000E48CC File Offset: 0x000E2ACC
		public string Address
		{
			get
			{
				return this._userName + "@" + this._host;
			}
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x000E48E4 File Offset: 0x000E2AE4
		private string GetAddress(bool allowUnicode)
		{
			return this.GetUser(allowUnicode) + "@" + this.GetHost(allowUnicode);
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06004221 RID: 16929 RVA: 0x000E48FE File Offset: 0x000E2AFE
		private string SmtpAddress
		{
			get
			{
				return "<" + this.Address + ">";
			}
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x000E4915 File Offset: 0x000E2B15
		internal string GetSmtpAddress(bool allowUnicode)
		{
			return "<" + this.GetAddress(allowUnicode) + ">";
		}

		/// <summary>Возвращает строковое представление данного экземпляра.</summary>
		/// <returns>Значение <see cref="T:System.String" />, которое содержит содержимое данного <see cref="T:System.Net.Mail.MailAddress" />.</returns>
		// Token: 0x06004223 RID: 16931 RVA: 0x000E492D File Offset: 0x000E2B2D
		public override string ToString()
		{
			if (string.IsNullOrEmpty(this.DisplayName))
			{
				return this.Address;
			}
			return "\"" + this.DisplayName + "\" " + this.SmtpAddress;
		}

		/// <summary>Сравнивает два адреса электронной почты.</summary>
		/// <param name="value">Экземпляр <see cref="T:System.Net.Mail.MailAddress" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если два почтовых адреса совпадают; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004224 RID: 16932 RVA: 0x000E495E File Offset: 0x000E2B5E
		public override bool Equals(object value)
		{
			return value != null && this.ToString().Equals(value.ToString(), StringComparison.InvariantCultureIgnoreCase);
		}

		/// <summary>Возвращает значение хэш-функции для почтового адреса.</summary>
		/// <returns>Целочисленное хэш-значение.</returns>
		// Token: 0x06004225 RID: 16933 RVA: 0x000B73A2 File Offset: 0x000B55A2
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x000E4978 File Offset: 0x000E2B78
		internal string Encode(int charsConsumed, bool allowUnicode)
		{
			string text = string.Empty;
			if (!string.IsNullOrEmpty(this._displayName))
			{
				if (MimeBasePart.IsAscii(this._displayName, false) || allowUnicode)
				{
					text = "\"" + this._displayName + "\"";
				}
				else
				{
					IEncodableStream encoderForHeader = MailAddress.s_encoderFactory.GetEncoderForHeader(this._displayNameEncoding, false, charsConsumed);
					byte[] bytes = this._displayNameEncoding.GetBytes(this._displayName);
					encoderForHeader.EncodeBytes(bytes, 0, bytes.Length);
					text = encoderForHeader.GetEncodedString();
				}
				text = text + " " + this.GetSmtpAddress(allowUnicode);
			}
			else
			{
				text = this.GetAddress(allowUnicode);
			}
			return text;
		}

		// Token: 0x04002812 RID: 10258
		private readonly Encoding _displayNameEncoding;

		// Token: 0x04002813 RID: 10259
		private readonly string _displayName;

		// Token: 0x04002814 RID: 10260
		private readonly string _userName;

		// Token: 0x04002815 RID: 10261
		private readonly string _host;

		// Token: 0x04002816 RID: 10262
		private static readonly EncodedStreamFactory s_encoderFactory = new EncodedStreamFactory();
	}
}
