using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет сведения проверке подлинности в значениях заголовков Authorization, ProxyAuthorization, WWW-Authneticate и Proxy-Authenticate.</summary>
	// Token: 0x02000034 RID: 52
	public class AuthenticationHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.</summary>
		/// <param name="scheme">Схема, используемая при авторизации.</param>
		// Token: 0x0600019A RID: 410 RVA: 0x00006AA6 File Offset: 0x00004CA6
		public AuthenticationHeaderValue(string scheme) : this(scheme, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.</summary>
		/// <param name="scheme">Схема, используемая при авторизации.</param>
		/// <param name="parameter">Учетные данные, содержащие сведения для проверки подлинности агента пользователя для запрашиваемого ресурса.</param>
		// Token: 0x0600019B RID: 411 RVA: 0x00006AB0 File Offset: 0x00004CB0
		public AuthenticationHeaderValue(string scheme, string parameter)
		{
			Parser.Token.Check(scheme);
			this.Scheme = scheme;
			this.Parameter = parameter;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000022B8 File Offset: 0x000004B8
		private AuthenticationHeaderValue()
		{
		}

		/// <summary>Возвращает учетные данные, содержащие сведения о проверке подлинности агента пользователя для запрашиваемого ресурса.</summary>
		/// <returns>Учетные данные, содержащие сведения о проверке подлинности.</returns>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00006ACC File Offset: 0x00004CCC
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00006AD4 File Offset: 0x00004CD4
		public string Parameter { get; private set; }

		/// <summary>Возвращает схему, используемую при авторизации.</summary>
		/// <returns>Схема, используемая при авторизации.</returns>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00006ADD File Offset: 0x00004CDD
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00006AE5 File Offset: 0x00004CE5
		public string Scheme { get; private set; }

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x060001A1 RID: 417 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A2 RID: 418 RVA: 0x00006AF8 File Offset: 0x00004CF8
		public override bool Equals(object obj)
		{
			AuthenticationHeaderValue authenticationHeaderValue = obj as AuthenticationHeaderValue;
			return authenticationHeaderValue != null && string.Equals(authenticationHeaderValue.Scheme, this.Scheme, StringComparison.OrdinalIgnoreCase) && authenticationHeaderValue.Parameter == this.Parameter;
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x060001A3 RID: 419 RVA: 0x00006B38 File Offset: 0x00004D38
		public override int GetHashCode()
		{
			int num = this.Scheme.ToLowerInvariant().GetHashCode();
			if (!string.IsNullOrEmpty(this.Parameter))
			{
				num ^= this.Parameter.ToLowerInvariant().GetHashCode();
			}
			return num;
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значении заголовка проверки подлинности.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не представляет допустимые сведения о значении заголовка проверки подлинности.</exception>
		// Token: 0x060001A4 RID: 420 RVA: 0x00006B78 File Offset: 0x00004D78
		public static AuthenticationHeaderValue Parse(string input)
		{
			AuthenticationHeaderValue result;
			if (AuthenticationHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x060001A5 RID: 421 RVA: 0x00006B98 File Offset: 0x00004D98
		public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue)
		{
			Token token;
			if (AuthenticationHeaderValue.TryParseElement(new Lexer(input), out parsedValue, out token) && token == Token.Type.End)
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006BC4 File Offset: 0x00004DC4
		internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result)
		{
			return CollectionParser.TryParse<AuthenticationHeaderValue>(input, minimalCount, new ElementTryParser<AuthenticationHeaderValue>(AuthenticationHeaderValue.TryParseElement), out result);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006BDC File Offset: 0x00004DDC
		private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t)
		{
			t = lexer.Scan(false);
			if (t != Token.Type.Token)
			{
				parsedValue = null;
				return false;
			}
			parsedValue = new AuthenticationHeaderValue();
			parsedValue.Scheme = lexer.GetStringValue(t);
			t = lexer.Scan(false);
			if (t == Token.Type.Token)
			{
				parsedValue.Parameter = lexer.GetRemainingStringValue(t.StartPosition);
				t = new Token(Token.Type.End, 0, 0);
			}
			return true;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x060001A8 RID: 424 RVA: 0x00006C60 File Offset: 0x00004E60
		public override string ToString()
		{
			if (this.Parameter == null)
			{
				return this.Scheme;
			}
			return this.Scheme + " " + this.Parameter;
		}
	}
}
