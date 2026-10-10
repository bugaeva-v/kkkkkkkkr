using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение заголовка Cache-Control.</summary>
	// Token: 0x02000035 RID: 53
	public class CacheControlHeaderValue : ICloneable
	{
		/// <summary>Токены Кэш-расширения, каждый с необязательным присвоенным значения.</summary>
		/// <returns>Коллекция токенов кэш-расширений, каждый с необязательным присвоенным значением.</returns>
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00006C88 File Offset: 0x00004E88
		public ICollection<NameValueHeaderValue> Extensions
		{
			get
			{
				List<NameValueHeaderValue> result;
				if ((result = this.extensions) == null)
				{
					result = (this.extensions = new List<NameValueHeaderValue>());
				}
				return result;
			}
		}

		/// <summary>Максимальная длительность, указанная в секундах, в течение которой клиент HTTP готов принять отклик.</summary>
		/// <returns>Время в секундах.</returns>
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00006CAD File Offset: 0x00004EAD
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00006CB5 File Offset: 0x00004EB5
		public TimeSpan? MaxAge { get; set; }

		/// <summary>Готов ли клиент HTTP принять отклик, срок действия которого истек.</summary>
		/// <returns>Значение <see langword="true" />, если клиент HTTP готов принять отклик, срок действия которого истек; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00006CBE File Offset: 0x00004EBE
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00006CC6 File Offset: 0x00004EC6
		public bool MaxStale { get; set; }

		/// <summary>Максимальное время (в секундах), в течение которого клиент HTTP готов принять отклик, срок действия которого истек.</summary>
		/// <returns>Время в секундах.</returns>
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00006CCF File Offset: 0x00004ECF
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00006CD7 File Offset: 0x00004ED7
		public TimeSpan? MaxStaleLimit { get; set; }

		/// <summary>Длительность существования, указанная в секундах, в течение которой клиент HTTP готов принять отклик.</summary>
		/// <returns>Время в секундах.</returns>
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00006CE0 File Offset: 0x00004EE0
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00006CE8 File Offset: 0x00004EE8
		public TimeSpan? MinFresh { get; set; }

		/// <summary>Требует ли сервер-источник выполнения повторной проверки записи кэша при любом последующем использовании, когда запись кэша устаревает.</summary>
		/// <returns>Значение <see langword="true" />, если сервер-источник требует выполнения повторной проверки записи кэша при любом последующем использовании, когда запись кэша устаревает; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00006CF1 File Offset: 0x00004EF1
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00006CF9 File Offset: 0x00004EF9
		public bool MustRevalidate { get; set; }

		/// <summary>Готов ли клиент HTTP принять кэшированный отклик.</summary>
		/// <returns>Значение <see langword="true" />, если клиент HTTP готов принять кэшированный отклик; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00006D02 File Offset: 0x00004F02
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00006D0A File Offset: 0x00004F0A
		public bool NoCache { get; set; }

		/// <summary>Коллекция имен полей в некэшированной директиве в поле заголовка кэш-элемента управления в HTTP-отклике.</summary>
		/// <returns>Коллекция имен полей.</returns>
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006D14 File Offset: 0x00004F14
		public ICollection<string> NoCacheHeaders
		{
			get
			{
				List<string> result;
				if ((result = this.no_cache_headers) == null)
				{
					result = (this.no_cache_headers = new List<string>());
				}
				return result;
			}
		}

		/// <summary>Не должна ли храниться в кэше какая-либо часть сообщения HTTP-запроса или любого отклика.</summary>
		/// <returns>Значение <see langword="true" />, если в кэше не должна храниться какая-либо часть сообщения HTTP-запроса или любого отклика; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00006D39 File Offset: 0x00004F39
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00006D41 File Offset: 0x00004F41
		public bool NoStore { get; set; }

		/// <summary>Не должен ли кэш или прокси изменять какой-либо аспект тела сущности.</summary>
		/// <returns>Значение <see langword="true" />, если кэш или прокси не должны изменять какой-либо аспект тела сущности; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00006D4A File Offset: 0x00004F4A
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00006D52 File Offset: 0x00004F52
		public bool NoTransform { get; set; }

		/// <summary>Должен ли кэш отвечать, используя согласованную с другими ограничениями HTTP-запроса кэшированную запись или состояние 504 (время ожидания шлюза).</summary>
		/// <returns>Значение <see langword="true" />, если в отклике кэш должен либо использовать кэшированную запись, согласованную с другими ограничениями HTTP-запроса, либо состояние 504 (истекло время ожидания шлюза); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00006D5B File Offset: 0x00004F5B
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00006D63 File Offset: 0x00004F63
		public bool OnlyIfCached { get; set; }

		/// <summary>Предназначено ли все сообщение отклика HTTP или его часть для одного пользователя и не должно ли это сообщение или его часть кэшироваться в общем кэше.</summary>
		/// <returns>Значение <see langword="true" />, если сообщение HTTP-отклика предназначено для одного пользователя и не должно кэшироваться в общем кэше; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00006D6C File Offset: 0x00004F6C
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00006D74 File Offset: 0x00004F74
		public bool Private { get; set; }

		/// <summary>Имена полей коллекции в закрытой директиве в поле заголовка кэш-элемента управления в HTTP-отклике.</summary>
		/// <returns>Коллекция имен полей.</returns>
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00006D80 File Offset: 0x00004F80
		public ICollection<string> PrivateHeaders
		{
			get
			{
				List<string> result;
				if ((result = this.private_headers) == null)
				{
					result = (this.private_headers = new List<string>());
				}
				return result;
			}
		}

		/// <summary>Требует ли сервер-источник выполнения повторной проверки записи кэша при любом последующем использовании, когда запись кэша устаревает для общих кэшей агентов пользователей.</summary>
		/// <returns>Значение <see langword="true" />, если сервер-источник требует выполнения повторной проверки записи кэша при любом последующем использовании, когда запись кэша устаревает для общих кэшей агентов пользователей; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00006DA5 File Offset: 0x00004FA5
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00006DAD File Offset: 0x00004FAD
		public bool ProxyRevalidate { get; set; }

		/// <summary>Может ли отклик HTTP кэшироваться любым кэшем, даже если он обычно не кэшируется или кэшируется только в необщем кэше.</summary>
		/// <returns>Значение <see langword="true" />, если HTTP-отклик может кэшироваться любым кэшем, даже если он обычно не кэшируется или кэшируется только в кэше без общего доступа; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00006DB6 File Offset: 0x00004FB6
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00006DBE File Offset: 0x00004FBE
		public bool Public { get; set; }

		/// <summary>Общая максимальная длительность (в секундах) в отклике HTTP, которая переопределяет директиву "max-age" в заголовке управления кэшем или в заголовке Expires для общего кэша.</summary>
		/// <returns>Время в секундах.</returns>
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00006DC7 File Offset: 0x00004FC7
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00006DCF File Offset: 0x00004FCF
		public TimeSpan? SharedMaxAge { get; set; }

		/// <summary>Создает новый объект, являющийся копией текущего экземпляра <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x060001C6 RID: 454 RVA: 0x00006DD8 File Offset: 0x00004FD8
		object ICloneable.Clone()
		{
			CacheControlHeaderValue cacheControlHeaderValue = (CacheControlHeaderValue)base.MemberwiseClone();
			if (this.extensions != null)
			{
				cacheControlHeaderValue.extensions = new List<NameValueHeaderValue>();
				foreach (NameValueHeaderValue item in this.extensions)
				{
					cacheControlHeaderValue.extensions.Add(item);
				}
			}
			if (this.no_cache_headers != null)
			{
				cacheControlHeaderValue.no_cache_headers = new List<string>();
				foreach (string item2 in this.no_cache_headers)
				{
					cacheControlHeaderValue.no_cache_headers.Add(item2);
				}
			}
			if (this.private_headers != null)
			{
				cacheControlHeaderValue.private_headers = new List<string>();
				foreach (string item3 in this.private_headers)
				{
					cacheControlHeaderValue.private_headers.Add(item3);
				}
			}
			return cacheControlHeaderValue;
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если заданный объект <see cref="T:System.Object" /> равен текущему объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001C7 RID: 455 RVA: 0x00006F08 File Offset: 0x00005108
		public override bool Equals(object obj)
		{
			CacheControlHeaderValue cacheControlHeaderValue = obj as CacheControlHeaderValue;
			return cacheControlHeaderValue != null && (!(this.MaxAge != cacheControlHeaderValue.MaxAge) && this.MaxStale == cacheControlHeaderValue.MaxStale) && !(this.MaxStaleLimit != cacheControlHeaderValue.MaxStaleLimit) && (!(this.MinFresh != cacheControlHeaderValue.MinFresh) && this.MustRevalidate == cacheControlHeaderValue.MustRevalidate && this.NoCache == cacheControlHeaderValue.NoCache && this.NoStore == cacheControlHeaderValue.NoStore && this.NoTransform == cacheControlHeaderValue.NoTransform && this.OnlyIfCached == cacheControlHeaderValue.OnlyIfCached && this.Private == cacheControlHeaderValue.Private && this.ProxyRevalidate == cacheControlHeaderValue.ProxyRevalidate && this.Public == cacheControlHeaderValue.Public) && !(this.SharedMaxAge != cacheControlHeaderValue.SharedMaxAge) && (this.extensions.SequenceEqual(cacheControlHeaderValue.extensions) && this.no_cache_headers.SequenceEqual(cacheControlHeaderValue.no_cache_headers)) && this.private_headers.SequenceEqual(cacheControlHeaderValue.private_headers);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x060001C8 RID: 456 RVA: 0x000070F8 File Offset: 0x000052F8
		public override int GetHashCode()
		{
			return (((((((((((((((29 * 29 + HashCodeCalculator.Calculate<NameValueHeaderValue>(this.extensions)) * 29 + this.MaxAge.GetHashCode()) * 29 + this.MaxStale.GetHashCode()) * 29 + this.MaxStaleLimit.GetHashCode()) * 29 + this.MinFresh.GetHashCode()) * 29 + this.MustRevalidate.GetHashCode()) * 29 + HashCodeCalculator.Calculate<string>(this.no_cache_headers)) * 29 + this.NoCache.GetHashCode()) * 29 + this.NoStore.GetHashCode()) * 29 + this.NoTransform.GetHashCode()) * 29 + this.OnlyIfCached.GetHashCode()) * 29 + this.Private.GetHashCode()) * 29 + HashCodeCalculator.Calculate<string>(this.private_headers)) * 29 + this.ProxyRevalidate.GetHashCode()) * 29 + this.Public.GetHashCode()) * 29 + this.SharedMaxAge.GetHashCode();
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значении заголовка элемента управления кэшем.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> имеет ссылку <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не является допустимыми сведениями о значении заголовка управления кэшем.</exception>
		// Token: 0x060001C9 RID: 457 RVA: 0x00007238 File Offset: 0x00005438
		public static CacheControlHeaderValue Parse(string input)
		{
			CacheControlHeaderValue result;
			if (CacheControlHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимой информацией <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.</summary>
		/// <param name="input">Строка, которую следует проверить.</param>
		/// <param name="parsedValue">Возвращает версию строки <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> является допустимой информацией <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001CA RID: 458 RVA: 0x00007258 File Offset: 0x00005458
		public static bool TryParse(string input, out CacheControlHeaderValue parsedValue)
		{
			parsedValue = null;
			if (input == null)
			{
				return true;
			}
			CacheControlHeaderValue cacheControlHeaderValue = new CacheControlHeaderValue();
			Lexer lexer = new Lexer(input);
			Token token;
			for (;;)
			{
				token = lexer.Scan(false);
				if (token != Token.Type.Token)
				{
					break;
				}
				string stringValue = lexer.GetStringValue(token);
				bool flag = false;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(stringValue);
				if (num <= 1922561311U)
				{
					TimeSpan? timeSpan;
					if (num <= 719568158U)
					{
						if (num != 129047354U)
						{
							if (num != 412259456U)
							{
								if (num != 719568158U)
								{
									goto IL_3B1;
								}
								if (!(stringValue == "no-store"))
								{
									goto IL_3B1;
								}
								cacheControlHeaderValue.NoStore = true;
								goto IL_40A;
							}
							else if (!(stringValue == "s-maxage"))
							{
								goto IL_3B1;
							}
						}
						else if (!(stringValue == "min-fresh"))
						{
							goto IL_3B1;
						}
					}
					else if (num != 962188105U)
					{
						if (num != 1657474316U)
						{
							if (num != 1922561311U)
							{
								goto IL_3B1;
							}
							if (!(stringValue == "max-age"))
							{
								goto IL_3B1;
							}
						}
						else
						{
							if (!(stringValue == "private"))
							{
								goto IL_3B1;
							}
							goto IL_2FE;
						}
					}
					else
					{
						if (!(stringValue == "max-stale"))
						{
							goto IL_3B1;
						}
						cacheControlHeaderValue.MaxStale = true;
						token = lexer.Scan(false);
						if (token != Token.Type.SeparatorEqual)
						{
							flag = true;
							goto IL_40A;
						}
						token = lexer.Scan(false);
						if (token != Token.Type.Token)
						{
							return false;
						}
						timeSpan = lexer.TryGetTimeSpanValue(token);
						if (timeSpan == null)
						{
							return false;
						}
						cacheControlHeaderValue.MaxStaleLimit = timeSpan;
						goto IL_40A;
					}
					token = lexer.Scan(false);
					if (token != Token.Type.SeparatorEqual)
					{
						return false;
					}
					token = lexer.Scan(false);
					if (token != Token.Type.Token)
					{
						return false;
					}
					timeSpan = lexer.TryGetTimeSpanValue(token);
					if (timeSpan == null)
					{
						return false;
					}
					int i = stringValue.Length;
					if (i != 7)
					{
						if (i != 8)
						{
							cacheControlHeaderValue.MinFresh = timeSpan;
						}
						else
						{
							cacheControlHeaderValue.SharedMaxAge = timeSpan;
						}
					}
					else
					{
						cacheControlHeaderValue.MaxAge = timeSpan;
					}
				}
				else if (num <= 2802093227U)
				{
					if (num != 2033558065U)
					{
						if (num != 2154495528U)
						{
							if (num != 2802093227U)
							{
								goto IL_3B1;
							}
							if (!(stringValue == "no-transform"))
							{
								goto IL_3B1;
							}
							cacheControlHeaderValue.NoTransform = true;
						}
						else
						{
							if (!(stringValue == "must-revalidate"))
							{
								goto IL_3B1;
							}
							cacheControlHeaderValue.MustRevalidate = true;
						}
					}
					else
					{
						if (!(stringValue == "proxy-revalidate"))
						{
							goto IL_3B1;
						}
						cacheControlHeaderValue.ProxyRevalidate = true;
					}
				}
				else if (num != 2866772502U)
				{
					if (num != 3432027008U)
					{
						if (num != 3443516981U)
						{
							goto IL_3B1;
						}
						if (!(stringValue == "no-cache"))
						{
							goto IL_3B1;
						}
						goto IL_2FE;
					}
					else
					{
						if (!(stringValue == "public"))
						{
							goto IL_3B1;
						}
						cacheControlHeaderValue.Public = true;
					}
				}
				else
				{
					if (!(stringValue == "only-if-cached"))
					{
						goto IL_3B1;
					}
					cacheControlHeaderValue.OnlyIfCached = true;
				}
				IL_40A:
				if (!flag)
				{
					token = lexer.Scan(false);
				}
				if (token != Token.Type.SeparatorComma)
				{
					goto Block_46;
				}
				continue;
				IL_2FE:
				if (stringValue.Length == 7)
				{
					cacheControlHeaderValue.Private = true;
				}
				else
				{
					cacheControlHeaderValue.NoCache = true;
				}
				token = lexer.Scan(false);
				if (token != Token.Type.SeparatorEqual)
				{
					flag = true;
					goto IL_40A;
				}
				token = lexer.Scan(false);
				if (token != Token.Type.QuotedString)
				{
					return false;
				}
				string[] array = lexer.GetQuotedStringValue(token).Split(',', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					string item = array[i].Trim(new char[]
					{
						'\t',
						' '
					});
					if (stringValue.Length == 7)
					{
						cacheControlHeaderValue.PrivateHeaders.Add(item);
					}
					else
					{
						cacheControlHeaderValue.NoCache = true;
						cacheControlHeaderValue.NoCacheHeaders.Add(item);
					}
				}
				goto IL_40A;
				IL_3B1:
				string stringValue2 = lexer.GetStringValue(token);
				string value = null;
				token = lexer.Scan(false);
				if (token == Token.Type.SeparatorEqual)
				{
					token = lexer.Scan(false);
					Token.Type kind = token.Kind;
					if (kind - Token.Type.Token > 1)
					{
						return false;
					}
					value = lexer.GetStringValue(token);
				}
				else
				{
					flag = true;
				}
				cacheControlHeaderValue.Extensions.Add(NameValueHeaderValue.Create(stringValue2, value));
				goto IL_40A;
			}
			return false;
			Block_46:
			if (token != Token.Type.End)
			{
				return false;
			}
			parsedValue = cacheControlHeaderValue;
			return true;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x060001CB RID: 459 RVA: 0x00007698 File Offset: 0x00005898
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.NoStore)
			{
				stringBuilder.Append("no-store");
				stringBuilder.Append(", ");
			}
			if (this.NoTransform)
			{
				stringBuilder.Append("no-transform");
				stringBuilder.Append(", ");
			}
			if (this.OnlyIfCached)
			{
				stringBuilder.Append("only-if-cached");
				stringBuilder.Append(", ");
			}
			if (this.Public)
			{
				stringBuilder.Append("public");
				stringBuilder.Append(", ");
			}
			if (this.MustRevalidate)
			{
				stringBuilder.Append("must-revalidate");
				stringBuilder.Append(", ");
			}
			if (this.ProxyRevalidate)
			{
				stringBuilder.Append("proxy-revalidate");
				stringBuilder.Append(", ");
			}
			if (this.NoCache)
			{
				stringBuilder.Append("no-cache");
				if (this.no_cache_headers != null)
				{
					stringBuilder.Append("=\"");
					this.no_cache_headers.ToStringBuilder(stringBuilder);
					stringBuilder.Append("\"");
				}
				stringBuilder.Append(", ");
			}
			if (this.MaxAge != null)
			{
				stringBuilder.Append("max-age=");
				stringBuilder.Append(this.MaxAge.Value.TotalSeconds.ToString(CultureInfo.InvariantCulture));
				stringBuilder.Append(", ");
			}
			if (this.SharedMaxAge != null)
			{
				stringBuilder.Append("s-maxage=");
				stringBuilder.Append(this.SharedMaxAge.Value.TotalSeconds.ToString(CultureInfo.InvariantCulture));
				stringBuilder.Append(", ");
			}
			if (this.MaxStale)
			{
				stringBuilder.Append("max-stale");
				if (this.MaxStaleLimit != null)
				{
					stringBuilder.Append("=");
					stringBuilder.Append(this.MaxStaleLimit.Value.TotalSeconds.ToString(CultureInfo.InvariantCulture));
				}
				stringBuilder.Append(", ");
			}
			if (this.MinFresh != null)
			{
				stringBuilder.Append("min-fresh=");
				stringBuilder.Append(this.MinFresh.Value.TotalSeconds.ToString(CultureInfo.InvariantCulture));
				stringBuilder.Append(", ");
			}
			if (this.Private)
			{
				stringBuilder.Append("private");
				if (this.private_headers != null)
				{
					stringBuilder.Append("=\"");
					this.private_headers.ToStringBuilder(stringBuilder);
					stringBuilder.Append("\"");
				}
				stringBuilder.Append(", ");
			}
			this.extensions.ToStringBuilder(stringBuilder);
			if (stringBuilder.Length > 2 && stringBuilder[stringBuilder.Length - 2] == ',' && stringBuilder[stringBuilder.Length - 1] == ' ')
			{
				stringBuilder.Remove(stringBuilder.Length - 2, 2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040000DB RID: 219
		private List<NameValueHeaderValue> extensions;

		// Token: 0x040000DC RID: 220
		private List<string> no_cache_headers;

		// Token: 0x040000DD RID: 221
		private List<string> private_headers;
	}
}
