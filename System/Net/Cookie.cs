using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>Предоставляет набор свойств и методов, которые используются для управления файлами cookie. Этот класс не наследуется.</summary>
	// Token: 0x02000649 RID: 1609
	[Serializable]
	public sealed class Cookie
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cookie" />.</summary>
		// Token: 0x06003288 RID: 12936 RVA: 0x000AEEBC File Offset: 0x000AD0BC
		public Cookie()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cookie" /> с заданными объектами <see cref="P:System.Net.Cookie.Name" /> и <see cref="P:System.Net.Cookie.Value" />.</summary>
		/// <param name="name">Имя <see cref="T:System.Net.Cookie" />. Внутри <paramref name="name" /> не должны использоваться следующие символы: знак равенства, точка с запятой, запятая, символ перехода на новую строку (\n), символ возврата каретки (\r), символ табуляции (\t) и пробел. Символ доллара ($) не может быть первым знаком.</param>
		/// <param name="value">Значение <see cref="T:System.Net.Cookie" />. Внутри <paramref name="value" /> не должны использоваться следующие знаки: точка с запятой, запятая.</param>
		/// <exception cref="T:System.Net.CookieException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Параметр <paramref name="name" /> содержит недопустимый знак.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> имеет значение <see langword="null" />.  
		///
		///
		/// -или- 
		/// Параметр <paramref name="value" /> содержит строку, не заключенную в кавычки и содержащую недопустимый символ.</exception>
		// Token: 0x06003289 RID: 12937 RVA: 0x000AEF50 File Offset: 0x000AD150
		public Cookie(string name, string value)
		{
			this.Name = name;
			this.m_value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cookie" /> с заданными объектами <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" /> и <see cref="P:System.Net.Cookie.Path" />.</summary>
		/// <param name="name">Имя <see cref="T:System.Net.Cookie" />. Внутри <paramref name="name" /> не должны использоваться следующие символы: знак равенства, точка с запятой, запятая, символ перехода на новую строку (\n), символ возврата каретки (\r), символ табуляции (\t) и пробел. Символ доллара ($) не может быть первым знаком.</param>
		/// <param name="value">Значение <see cref="T:System.Net.Cookie" />. Внутри <paramref name="value" /> не должны использоваться следующие знаки: точка с запятой, запятая.</param>
		/// <param name="path">Подмножество URI на исходном сервере, к которому применяется <see cref="T:System.Net.Cookie" />. Значение по умолчанию — "/".</param>
		/// <exception cref="T:System.Net.CookieException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// -или- 
		/// Параметр <paramref name="name" /> содержит недопустимый знак.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> имеет значение <see langword="null" />.  
		///
		/// -или- 
		/// Параметр <paramref name="value" /> содержит строку, не заключенную в кавычки и содержащую недопустимый символ.</exception>
		// Token: 0x0600328A RID: 12938 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		public Cookie(string name, string value, string path) : this(name, value)
		{
			this.Path = path;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cookie" /> с заданными объектами <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" /> и <see cref="P:System.Net.Cookie.Domain" />.</summary>
		/// <param name="name">Имя <see cref="T:System.Net.Cookie" />. Внутри <paramref name="name" /> не должны использоваться следующие символы: знак равенства, точка с запятой, запятая, символ перехода на новую строку (\n), символ возврата каретки (\r), символ табуляции (\t) и пробел. Символ доллара ($) не может быть первым знаком.</param>
		/// <param name="value">Значение объекта <see cref="T:System.Net.Cookie" />. Внутри <paramref name="value" /> не должны использоваться следующие знаки: точка с запятой, запятая.</param>
		/// <param name="path">Подмножество URI на исходном сервере, к которому применяется <see cref="T:System.Net.Cookie" />. Значение по умолчанию — "/".</param>
		/// <param name="domain">Дополнительный интернет-домен, для которого действует этот <see cref="T:System.Net.Cookie" />. Значением по умолчанию является узел, с которого получен этот объект <see cref="T:System.Net.Cookie" />.</param>
		/// <exception cref="T:System.Net.CookieException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Параметр <paramref name="name" /> содержит недопустимый знак.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> имеет значение <see langword="null" />.  
		///
		///
		/// -или- 
		/// Параметр <paramref name="value" /> содержит строку, не заключенную в кавычки и содержащую недопустимый символ.</exception>
		// Token: 0x0600328B RID: 12939 RVA: 0x000AF001 File Offset: 0x000AD201
		public Cookie(string name, string value, string path, string domain) : this(name, value, path)
		{
			this.Domain = domain;
		}

		/// <summary>Возвращает или задает комментарий, который сервер может добавлять в <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>Дополнительный комментарий к предполагаемому использованию документа для этого класса <see cref="T:System.Net.Cookie" />.</returns>
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x000AF014 File Offset: 0x000AD214
		// (set) Token: 0x0600328D RID: 12941 RVA: 0x000AF01C File Offset: 0x000AD21C
		public string Comment
		{
			get
			{
				return this.m_comment;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				this.m_comment = value;
			}
		}

		/// <summary>Возвращает или задает комментарий URI, который сервер может предоставлять с <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>Дополнительный комментарий, описывающий использование по назначению ссылки URI для этого объекта <see cref="T:System.Net.Cookie" />. Значение должно соответствовать формату URI.</returns>
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x000AF02F File Offset: 0x000AD22F
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x000AF037 File Offset: 0x000AD237
		public Uri CommentUri
		{
			get
			{
				return this.m_commentUri;
			}
			set
			{
				this.m_commentUri = value;
			}
		}

		/// <summary>Определяет, может ли получить доступ к файлу cookie скрипт страницы или другое активное содержимое.</summary>
		/// <returns>Логическое значение, с помощью которого определяется, может ли получить доступ к файлу cookie скрипт страницы или другое активное содержимое.</returns>
		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x000AF040 File Offset: 0x000AD240
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x000AF048 File Offset: 0x000AD248
		public bool HttpOnly
		{
			get
			{
				return this.m_httpOnly;
			}
			set
			{
				this.m_httpOnly = value;
			}
		}

		/// <summary>Возвращает или задает флаг сброса, задаваемый сервером.</summary>
		/// <returns>Значение <see langword="true" />, если клиент должен сбросить <see cref="T:System.Net.Cookie" /> в конце текущего сеанса; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x000AF051 File Offset: 0x000AD251
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x000AF059 File Offset: 0x000AD259
		public bool Discard
		{
			get
			{
				return this.m_discard;
			}
			set
			{
				this.m_discard = value;
			}
		}

		/// <summary>Возвращает или задает URI, для которого <see cref="T:System.Net.Cookie" /> является допустимым.</summary>
		/// <returns>URI, для которого действует <see cref="T:System.Net.Cookie" />.</returns>
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x000AF062 File Offset: 0x000AD262
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x000AF06A File Offset: 0x000AD26A
		public string Domain
		{
			get
			{
				return this.m_domain;
			}
			set
			{
				this.m_domain = ((value == null) ? string.Empty : value);
				this.m_domain_implicit = false;
				this.m_domainKey = string.Empty;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x000AF090 File Offset: 0x000AD290
		private string _Domain
		{
			get
			{
				if (!this.Plain && !this.m_domain_implicit && this.m_domain.Length != 0)
				{
					return "$Domain=" + (this.IsQuotedDomain ? "\"" : string.Empty) + this.m_domain + (this.IsQuotedDomain ? "\"" : string.Empty);
				}
				return string.Empty;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x000AF0F8 File Offset: 0x000AD2F8
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x000AF100 File Offset: 0x000AD300
		internal bool DomainImplicit
		{
			get
			{
				return this.m_domain_implicit;
			}
			set
			{
				this.m_domain_implicit = value;
			}
		}

		/// <summary>Возвращает или задает текущее состояние <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>Значение <see langword="true" />, если класс <see cref="T:System.Net.Cookie" /> прекратил действие, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x000AF109 File Offset: 0x000AD309
		// (set) Token: 0x0600329A RID: 12954 RVA: 0x000AF134 File Offset: 0x000AD334
		public bool Expired
		{
			get
			{
				return this.m_expires != DateTime.MinValue && this.m_expires.ToLocalTime() <= DateTime.Now;
			}
			set
			{
				if (value)
				{
					this.m_expires = DateTime.Now;
				}
			}
		}

		/// <summary>Возвращает или задает для <see cref="T:System.Net.Cookie" /> дату и время окончания действия в виде <see cref="T:System.DateTime" />.</summary>
		/// <returns>Дата и время окончания действия <see cref="T:System.Net.Cookie" /> в виде экземпляра <see cref="T:System.DateTime" />.</returns>
		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x000AF144 File Offset: 0x000AD344
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x000AF14C File Offset: 0x000AD34C
		public DateTime Expires
		{
			get
			{
				return this.m_expires;
			}
			set
			{
				this.m_expires = value;
			}
		}

		/// <summary>Возвращает или задает имя для <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>Имя для <see cref="T:System.Net.Cookie" />.</returns>
		/// <exception cref="T:System.Net.CookieException">Значение, указанное для операции задания, является <see langword="null" /> или пустой строкой. 
		/// -или- 
		/// Значение, указанное для операции задания, содержит недопустимый символ. Внутри свойства <see cref="P:System.Net.Cookie.Name" /> не должны использоваться следующие символы: знак равенства, точка с запятой, запятая, символ перехода на новую строку (\n), символ возврата каретки (\r), символ табуляции (\t) и пробел. Символ доллара ($) не может быть первым знаком.</exception>
		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x000AF155 File Offset: 0x000AD355
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x000AF15D File Offset: 0x000AD35D
		public string Name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				if (ValidationHelper.IsBlankString(value) || !this.InternalSetName(value))
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Name",
						(value == null) ? "<null>" : value
					}));
				}
			}
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000AF19C File Offset: 0x000AD39C
		internal bool InternalSetName(string value)
		{
			if (ValidationHelper.IsBlankString(value) || value[0] == '$' || value.IndexOfAny(Cookie.Reserved2Name) != -1)
			{
				this.m_name = string.Empty;
				return false;
			}
			this.m_name = value;
			return true;
		}

		/// <summary>Возвращает или задает идентификаторы URI, к которым применяется <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>URI, к которым применяется <see cref="T:System.Net.Cookie" />.</returns>
		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x000AF1D4 File Offset: 0x000AD3D4
		// (set) Token: 0x060032A1 RID: 12961 RVA: 0x000AF1DC File Offset: 0x000AD3DC
		public string Path
		{
			get
			{
				return this.m_path;
			}
			set
			{
				this.m_path = ((value == null) ? string.Empty : value);
				this.m_path_implicit = false;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060032A2 RID: 12962 RVA: 0x000AF1F6 File Offset: 0x000AD3F6
		private string _Path
		{
			get
			{
				if (!this.Plain && !this.m_path_implicit && this.m_path.Length != 0)
				{
					return "$Path=" + this.m_path;
				}
				return string.Empty;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060032A3 RID: 12963 RVA: 0x000AF22B File Offset: 0x000AD42B
		internal bool Plain
		{
			get
			{
				return this.Variant == CookieVariant.Plain;
			}
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000AF238 File Offset: 0x000AD438
		internal Cookie Clone()
		{
			Cookie cookie = new Cookie(this.m_name, this.m_value);
			if (!this.m_port_implicit)
			{
				cookie.Port = this.m_port;
			}
			if (!this.m_path_implicit)
			{
				cookie.Path = this.m_path;
			}
			cookie.Domain = this.m_domain;
			cookie.DomainImplicit = this.m_domain_implicit;
			cookie.m_timeStamp = this.m_timeStamp;
			cookie.Comment = this.m_comment;
			cookie.CommentUri = this.m_commentUri;
			cookie.HttpOnly = this.m_httpOnly;
			cookie.Discard = this.m_discard;
			cookie.Expires = this.m_expires;
			cookie.Version = this.m_version;
			cookie.Secure = this.m_secure;
			cookie.m_cookieVariant = this.m_cookieVariant;
			return cookie;
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000AF304 File Offset: 0x000AD504
		private static bool IsDomainEqualToHost(string domain, string host)
		{
			return host.Length + 1 == domain.Length && string.Compare(host, 0, domain, 1, host.Length, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000AF32C File Offset: 0x000AD52C
		internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
		{
			string host = uri.Host;
			int port = uri.Port;
			string absolutePath = uri.AbsolutePath;
			bool flag = true;
			if (set_default)
			{
				if (this.Version == 0)
				{
					variant = CookieVariant.Plain;
				}
				else if (this.Version == 1 && variant == CookieVariant.Unknown)
				{
					variant = CookieVariant.Rfc2109;
				}
				this.m_cookieVariant = variant;
			}
			if (this.m_name == null || this.m_name.Length == 0 || this.m_name[0] == '$' || this.m_name.IndexOfAny(Cookie.Reserved2Name) != -1)
			{
				if (isThrow)
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Name",
						(this.m_name == null) ? "<null>" : this.m_name
					}));
				}
				return false;
			}
			else if (this.m_value == null || ((this.m_value.Length <= 2 || this.m_value[0] != '"' || this.m_value[this.m_value.Length - 1] != '"') && this.m_value.IndexOfAny(Cookie.Reserved2Value) != -1))
			{
				if (isThrow)
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Value",
						(this.m_value == null) ? "<null>" : this.m_value
					}));
				}
				return false;
			}
			else if (this.Comment != null && (this.Comment.Length <= 2 || this.Comment[0] != '"' || this.Comment[this.Comment.Length - 1] != '"') && this.Comment.IndexOfAny(Cookie.Reserved2Value) != -1)
			{
				if (isThrow)
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Comment",
						this.Comment
					}));
				}
				return false;
			}
			else
			{
				if (this.Path == null || (this.Path.Length > 2 && this.Path[0] == '"' && this.Path[this.Path.Length - 1] == '"') || this.Path.IndexOfAny(Cookie.Reserved2Value) == -1)
				{
					if (set_default && this.m_domain_implicit)
					{
						this.m_domain = host;
					}
					else
					{
						if (!this.m_domain_implicit)
						{
							string text = this.m_domain;
							if (!Cookie.DomainCharsTest(text))
							{
								if (isThrow)
								{
									throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
									{
										"Domain",
										(text == null) ? "<null>" : text
									}));
								}
								return false;
							}
							else
							{
								if (text[0] != '.')
								{
									if (variant != CookieVariant.Rfc2965 && variant != CookieVariant.Plain)
									{
										if (isThrow)
										{
											throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
											{
												"Domain",
												this.m_domain
											}));
										}
										return false;
									}
									else
									{
										text = "." + text;
									}
								}
								int num = host.IndexOf('.');
								if (isLocalDomain && string.Compare(localDomain, text, StringComparison.OrdinalIgnoreCase) == 0)
								{
									flag = true;
								}
								else if (text.IndexOf('.', 1, text.Length - 2) == -1)
								{
									if (!Cookie.IsDomainEqualToHost(text, host))
									{
										flag = false;
									}
								}
								else if (variant == CookieVariant.Plain)
								{
									if (!Cookie.IsDomainEqualToHost(text, host) && (host.Length <= text.Length || string.Compare(host, host.Length - text.Length, text, 0, text.Length, StringComparison.OrdinalIgnoreCase) != 0))
									{
										flag = false;
									}
								}
								else if ((num == -1 || text.Length != host.Length - num || string.Compare(host, num, text, 0, text.Length, StringComparison.OrdinalIgnoreCase) != 0) && !Cookie.IsDomainEqualToHost(text, host))
								{
									flag = false;
								}
								if (flag)
								{
									this.m_domainKey = text.ToLower(CultureInfo.InvariantCulture);
								}
							}
						}
						else if (string.Compare(host, this.m_domain, StringComparison.OrdinalIgnoreCase) != 0)
						{
							flag = false;
						}
						if (!flag)
						{
							if (isThrow)
							{
								throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
								{
									"Domain",
									this.m_domain
								}));
							}
							return false;
						}
					}
					if (set_default && this.m_path_implicit)
					{
						switch (this.m_cookieVariant)
						{
						case CookieVariant.Plain:
							this.m_path = absolutePath;
							goto IL_4B8;
						case CookieVariant.Rfc2109:
							this.m_path = absolutePath.Substring(0, absolutePath.LastIndexOf('/'));
							goto IL_4B8;
						}
						this.m_path = absolutePath.Substring(0, absolutePath.LastIndexOf('/') + 1);
					}
					else if (!absolutePath.StartsWith(CookieParser.CheckQuoted(this.m_path)))
					{
						if (isThrow)
						{
							throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
							{
								"Path",
								this.m_path
							}));
						}
						return false;
					}
					IL_4B8:
					if (set_default && !this.m_port_implicit && this.m_port.Length == 0)
					{
						this.m_port_list = new int[]
						{
							port
						};
					}
					if (!this.m_port_implicit)
					{
						flag = false;
						int[] port_list = this.m_port_list;
						for (int i = 0; i < port_list.Length; i++)
						{
							if (port_list[i] == port)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							if (isThrow)
							{
								throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
								{
									"Port",
									this.m_port
								}));
							}
							return false;
						}
					}
					return true;
				}
				if (isThrow)
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Path",
						this.Path
					}));
				}
				return false;
			}
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000AF87C File Offset: 0x000ADA7C
		private static bool DomainCharsTest(string name)
		{
			if (name == null || name.Length == 0)
			{
				return false;
			}
			foreach (char c in name)
			{
				if ((c < '0' || c > '9') && c != '.' && c != '-' && (c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '_')
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает или задает список TCP-портов, к которым применяется <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>Список TCP-портов, к которым применяется класс <see cref="T:System.Net.Cookie" />.</returns>
		/// <exception cref="T:System.Net.CookieException">Значение, указанное для операции задания, может быть проанализировано или заключено в двойные кавычки.</exception>
		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000AF8DF File Offset: 0x000ADADF
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x000AF8E8 File Offset: 0x000ADAE8
		public string Port
		{
			get
			{
				return this.m_port;
			}
			set
			{
				this.m_port_implicit = false;
				if (value == null || value.Length == 0)
				{
					this.m_port = string.Empty;
					return;
				}
				if (value[0] != '"' || value[value.Length - 1] != '"')
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Port",
						value
					}));
				}
				string[] array = value.Split(Cookie.PortSplitDelimiters);
				List<int> list = new List<int>();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != string.Empty)
					{
						int num;
						if (!int.TryParse(array[i], out num))
						{
							throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
							{
								"Port",
								value
							}));
						}
						if (num < 0 || num > 65535)
						{
							throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
							{
								"Port",
								value
							}));
						}
						list.Add(num);
					}
				}
				this.m_port_list = list.ToArray();
				this.m_port = value;
				this.m_version = 1;
				this.m_cookieVariant = CookieVariant.Rfc2965;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x000AFA05 File Offset: 0x000ADC05
		internal int[] PortList
		{
			get
			{
				return this.m_port_list;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x000AFA0D File Offset: 0x000ADC0D
		private string _Port
		{
			get
			{
				if (!this.m_port_implicit)
				{
					return "$Port" + ((this.m_port.Length == 0) ? string.Empty : ("=" + this.m_port));
				}
				return string.Empty;
			}
		}

		/// <summary>Возвращает или задает уровень безопасности <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>Значение <see langword="true" />, если клиент должен только вернуть файл cookie в последующих запросах, при условии что запросы используют HTTPS; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x000AFA4B File Offset: 0x000ADC4B
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x000AFA53 File Offset: 0x000ADC53
		public bool Secure
		{
			get
			{
				return this.m_secure;
			}
			set
			{
				this.m_secure = value;
			}
		}

		/// <summary>Возвращает время выпуска файла cookie в виде <see cref="T:System.DateTime" />.</summary>
		/// <returns>Время выпуска файла cookie в виде <see cref="T:System.DateTime" />.</returns>
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x000AFA5C File Offset: 0x000ADC5C
		public DateTime TimeStamp
		{
			get
			{
				return this.m_timeStamp;
			}
		}

		/// <summary>Возвращает или задает <see cref="P:System.Net.Cookie.Value" /> для объекта <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>Объект <see cref="P:System.Net.Cookie.Value" /> для <see cref="T:System.Net.Cookie" />.</returns>
		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x000AFA64 File Offset: 0x000ADC64
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x000AFA6C File Offset: 0x000ADC6C
		public string Value
		{
			get
			{
				return this.m_value;
			}
			set
			{
				this.m_value = ((value == null) ? string.Empty : value);
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x000AFA7F File Offset: 0x000ADC7F
		// (set) Token: 0x060032B2 RID: 12978 RVA: 0x000AFA87 File Offset: 0x000ADC87
		internal CookieVariant Variant
		{
			get
			{
				return this.m_cookieVariant;
			}
			set
			{
				this.m_cookieVariant = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x060032B3 RID: 12979 RVA: 0x000AFA90 File Offset: 0x000ADC90
		internal string DomainKey
		{
			get
			{
				if (!this.m_domain_implicit)
				{
					return this.m_domainKey;
				}
				return this.Domain;
			}
		}

		/// <summary>Возвращает или задает версию поддержки запоминания состояния HTTP, которой соответствует файл cookie.</summary>
		/// <returns>Версия сопровождения HTTP-состояния, которому соответствует файл cookie.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указано недопустимое значение версии.</exception>
		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000AFAA7 File Offset: 0x000ADCA7
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x000AFAAF File Offset: 0x000ADCAF
		public int Version
		{
			get
			{
				return this.m_version;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.m_version = value;
				if (value > 0 && this.m_cookieVariant < CookieVariant.Rfc2109)
				{
					this.m_cookieVariant = CookieVariant.Rfc2109;
				}
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000AFADC File Offset: 0x000ADCDC
		private string _Version
		{
			get
			{
				if (this.Version != 0)
				{
					return "$Version=" + (this.IsQuotedVersion ? "\"" : string.Empty) + this.m_version.ToString(NumberFormatInfo.InvariantInfo) + (this.IsQuotedVersion ? "\"" : string.Empty);
				}
				return string.Empty;
			}
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x000AFB39 File Offset: 0x000ADD39
		internal static IComparer GetComparer()
		{
			return Cookie.staticComparer;
		}

		/// <summary>Переопределяет метод <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="comparand">Ссылка на <see cref="T:System.Net.Cookie" />.</param>
		/// <returns>Возвращает значение <see langword="true" />, если <see cref="T:System.Net.Cookie" /> равен <paramref name="comparand" />. Два экземпляра <see cref="T:System.Net.Cookie" /> равны, если их свойства <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, <see cref="P:System.Net.Cookie.Domain" /> и <see cref="P:System.Net.Cookie.Version" /> равны. При сравнении строк <see cref="P:System.Net.Cookie.Name" /> и <see cref="P:System.Net.Cookie.Domain" /> не учитывается регистр.</returns>
		// Token: 0x060032B8 RID: 12984 RVA: 0x000AFB40 File Offset: 0x000ADD40
		public override bool Equals(object comparand)
		{
			if (!(comparand is Cookie))
			{
				return false;
			}
			Cookie cookie = (Cookie)comparand;
			return string.Compare(this.Name, cookie.Name, StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(this.Value, cookie.Value, StringComparison.Ordinal) == 0 && string.Compare(this.Path, cookie.Path, StringComparison.Ordinal) == 0 && string.Compare(this.Domain, cookie.Domain, StringComparison.OrdinalIgnoreCase) == 0 && this.Version == cookie.Version;
		}

		/// <summary>Переопределяет метод <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код 32-разрядного целого числа со знаком для этого экземпляра класса.</returns>
		// Token: 0x060032B9 RID: 12985 RVA: 0x000AFBC0 File Offset: 0x000ADDC0
		public override int GetHashCode()
		{
			return string.Concat(new string[]
			{
				this.Name,
				"=",
				this.Value,
				";",
				this.Path,
				"; ",
				this.Domain,
				"; ",
				this.Version.ToString()
			}).GetHashCode();
		}

		/// <summary>Переопределяет метод <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Возвращает строковое представление объекта этого объекта <see cref="T:System.Net.Cookie" />, пригодное для включения в заголовок запроса HTTP Cookie:.</returns>
		// Token: 0x060032BA RID: 12986 RVA: 0x000AFC34 File Offset: 0x000ADE34
		public override string ToString()
		{
			string domain = this._Domain;
			string path = this._Path;
			string port = this._Port;
			string version = this._Version;
			string text = string.Concat(new string[]
			{
				(version.Length == 0) ? string.Empty : (version + "; "),
				this.Name,
				"=",
				this.Value,
				(path.Length == 0) ? string.Empty : ("; " + path),
				(domain.Length == 0) ? string.Empty : ("; " + domain),
				(port.Length == 0) ? string.Empty : ("; " + port)
			});
			if (text == "=")
			{
				return string.Empty;
			}
			return text;
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x000AFD10 File Offset: 0x000ADF10
		internal string ToServerString()
		{
			string text = this.Name + "=" + this.Value;
			if (this.m_comment != null && this.m_comment.Length > 0)
			{
				text = text + "; Comment=" + this.m_comment;
			}
			if (this.m_commentUri != null)
			{
				text = text + "; CommentURL=\"" + this.m_commentUri.ToString() + "\"";
			}
			if (this.m_discard)
			{
				text += "; Discard";
			}
			if (!this.m_domain_implicit && this.m_domain != null && this.m_domain.Length > 0)
			{
				text = text + "; Domain=" + this.m_domain;
			}
			if (this.Expires != DateTime.MinValue)
			{
				int num = (int)(this.Expires.ToLocalTime() - DateTime.Now).TotalSeconds;
				if (num < 0)
				{
					num = 0;
				}
				text = text + "; Max-Age=" + num.ToString(NumberFormatInfo.InvariantInfo);
			}
			if (!this.m_path_implicit && this.m_path != null && this.m_path.Length > 0)
			{
				text = text + "; Path=" + this.m_path;
			}
			if (!this.Plain && !this.m_port_implicit && this.m_port != null && this.m_port.Length > 0)
			{
				text = text + "; Port=" + this.m_port;
			}
			if (this.m_version > 0)
			{
				text = text + "; Version=" + this.m_version.ToString(NumberFormatInfo.InvariantInfo);
			}
			if (!(text == "="))
			{
				return text;
			}
			return null;
		}

		// Token: 0x04001D91 RID: 7569
		internal const int MaxSupportedVersion = 1;

		// Token: 0x04001D92 RID: 7570
		internal const string CommentAttributeName = "Comment";

		// Token: 0x04001D93 RID: 7571
		internal const string CommentUrlAttributeName = "CommentURL";

		// Token: 0x04001D94 RID: 7572
		internal const string DiscardAttributeName = "Discard";

		// Token: 0x04001D95 RID: 7573
		internal const string DomainAttributeName = "Domain";

		// Token: 0x04001D96 RID: 7574
		internal const string ExpiresAttributeName = "Expires";

		// Token: 0x04001D97 RID: 7575
		internal const string MaxAgeAttributeName = "Max-Age";

		// Token: 0x04001D98 RID: 7576
		internal const string PathAttributeName = "Path";

		// Token: 0x04001D99 RID: 7577
		internal const string PortAttributeName = "Port";

		// Token: 0x04001D9A RID: 7578
		internal const string SecureAttributeName = "Secure";

		// Token: 0x04001D9B RID: 7579
		internal const string VersionAttributeName = "Version";

		// Token: 0x04001D9C RID: 7580
		internal const string HttpOnlyAttributeName = "HttpOnly";

		// Token: 0x04001D9D RID: 7581
		internal const string SeparatorLiteral = "; ";

		// Token: 0x04001D9E RID: 7582
		internal const string EqualsLiteral = "=";

		// Token: 0x04001D9F RID: 7583
		internal const string QuotesLiteral = "\"";

		// Token: 0x04001DA0 RID: 7584
		internal const string SpecialAttributeLiteral = "$";

		// Token: 0x04001DA1 RID: 7585
		internal static readonly char[] PortSplitDelimiters = new char[]
		{
			' ',
			',',
			'"'
		};

		// Token: 0x04001DA2 RID: 7586
		internal static readonly char[] Reserved2Name = new char[]
		{
			' ',
			'\t',
			'\r',
			'\n',
			'=',
			';',
			','
		};

		// Token: 0x04001DA3 RID: 7587
		internal static readonly char[] Reserved2Value = new char[]
		{
			';',
			','
		};

		// Token: 0x04001DA4 RID: 7588
		private static Comparer staticComparer = new Comparer();

		// Token: 0x04001DA5 RID: 7589
		private string m_comment = string.Empty;

		// Token: 0x04001DA6 RID: 7590
		private Uri m_commentUri;

		// Token: 0x04001DA7 RID: 7591
		private CookieVariant m_cookieVariant = CookieVariant.Plain;

		// Token: 0x04001DA8 RID: 7592
		private bool m_discard;

		// Token: 0x04001DA9 RID: 7593
		private string m_domain = string.Empty;

		// Token: 0x04001DAA RID: 7594
		private bool m_domain_implicit = true;

		// Token: 0x04001DAB RID: 7595
		private DateTime m_expires = DateTime.MinValue;

		// Token: 0x04001DAC RID: 7596
		private string m_name = string.Empty;

		// Token: 0x04001DAD RID: 7597
		private string m_path = string.Empty;

		// Token: 0x04001DAE RID: 7598
		private bool m_path_implicit = true;

		// Token: 0x04001DAF RID: 7599
		private string m_port = string.Empty;

		// Token: 0x04001DB0 RID: 7600
		private bool m_port_implicit = true;

		// Token: 0x04001DB1 RID: 7601
		private int[] m_port_list;

		// Token: 0x04001DB2 RID: 7602
		private bool m_secure;

		// Token: 0x04001DB3 RID: 7603
		[OptionalField]
		private bool m_httpOnly;

		// Token: 0x04001DB4 RID: 7604
		private DateTime m_timeStamp = DateTime.Now;

		// Token: 0x04001DB5 RID: 7605
		private string m_value = string.Empty;

		// Token: 0x04001DB6 RID: 7606
		private int m_version;

		// Token: 0x04001DB7 RID: 7607
		private string m_domainKey = string.Empty;

		// Token: 0x04001DB8 RID: 7608
		internal bool IsQuotedVersion;

		// Token: 0x04001DB9 RID: 7609
		internal bool IsQuotedDomain;
	}
}
