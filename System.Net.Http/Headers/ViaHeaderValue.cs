using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение заголовка Via.</summary>
	// Token: 0x0200006B RID: 107
	public class ViaHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</summary>
		/// <param name="protocolVersion">Версия полученного протокола.</param>
		/// <param name="receivedBy">Узел и порт, которые получили запрос или ответ.</param>
		// Token: 0x060003CF RID: 975 RVA: 0x0000D157 File Offset: 0x0000B357
		public ViaHeaderValue(string protocolVersion, string receivedBy)
		{
			Parser.Token.Check(protocolVersion);
			Parser.Uri.Check(receivedBy);
			this.ProtocolVersion = protocolVersion;
			this.ReceivedBy = receivedBy;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</summary>
		/// <param name="protocolVersion">Версия полученного протокола.</param>
		/// <param name="receivedBy">Узел и порт, которые получили запрос или ответ.</param>
		/// <param name="protocolName">Имя полученного протокола.</param>
		// Token: 0x060003D0 RID: 976 RVA: 0x0000D179 File Offset: 0x0000B379
		public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName) : this(protocolVersion, receivedBy)
		{
			if (!string.IsNullOrEmpty(protocolName))
			{
				Parser.Token.Check(protocolName);
				this.ProtocolName = protocolName;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</summary>
		/// <param name="protocolVersion">Версия полученного протокола.</param>
		/// <param name="receivedBy">Узел и порт, которые получили запрос или ответ.</param>
		/// <param name="protocolName">Имя полученного протокола.</param>
		/// <param name="comment">Поле комментария, используемое для определения программного обеспечения прокси-сервера или шлюза получателя.</param>
		// Token: 0x060003D1 RID: 977 RVA: 0x0000D198 File Offset: 0x0000B398
		public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName, string comment) : this(protocolVersion, receivedBy, protocolName)
		{
			if (!string.IsNullOrEmpty(comment))
			{
				Parser.Token.CheckComment(comment);
				this.Comment = comment;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000022B8 File Offset: 0x000004B8
		private ViaHeaderValue()
		{
		}

		/// <summary>Возвращает поле комментария, используемое для определения программного обеспечения прокси-сервера или шлюза получателя.</summary>
		/// <returns>Поле комментария, используемое для определения программного обеспечения прокси-сервера или шлюза получателя.</returns>
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0000D1BB File Offset: 0x0000B3BB
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x0000D1C3 File Offset: 0x0000B3C3
		public string Comment { get; private set; }

		/// <summary>Возвращает имя протокола полученного протокола.</summary>
		/// <returns>Имя протокола.</returns>
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
		public string ProtocolName { get; private set; }

		/// <summary>Возвращает версию протокола полученного протокола.</summary>
		/// <returns>Версия протокола.</returns>
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000D1DD File Offset: 0x0000B3DD
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0000D1E5 File Offset: 0x0000B3E5
		public string ProtocolVersion { get; private set; }

		/// <summary>Возвращает узел и порт, которые получили запрос или ответ.</summary>
		/// <returns>Узел и порт, которые получили запрос или ответ.</returns>
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000D1EE File Offset: 0x0000B3EE
		// (set) Token: 0x060003DA RID: 986 RVA: 0x0000D1F6 File Offset: 0x0000B3F6
		public string ReceivedBy { get; private set; }

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x060003DB RID: 987 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x060003DC RID: 988 RVA: 0x0000D200 File Offset: 0x0000B400
		public override bool Equals(object obj)
		{
			ViaHeaderValue viaHeaderValue = obj as ViaHeaderValue;
			return viaHeaderValue != null && (string.Equals(viaHeaderValue.Comment, this.Comment, StringComparison.Ordinal) && string.Equals(viaHeaderValue.ProtocolName, this.ProtocolName, StringComparison.OrdinalIgnoreCase) && string.Equals(viaHeaderValue.ProtocolVersion, this.ProtocolVersion, StringComparison.OrdinalIgnoreCase)) && string.Equals(viaHeaderValue.ReceivedBy, this.ReceivedBy, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x060003DD RID: 989 RVA: 0x0000D26C File Offset: 0x0000B46C
		public override int GetHashCode()
		{
			int num = this.ProtocolVersion.ToLowerInvariant().GetHashCode();
			num ^= this.ReceivedBy.ToLowerInvariant().GetHashCode();
			if (!string.IsNullOrEmpty(this.ProtocolName))
			{
				num ^= this.ProtocolName.ToLowerInvariant().GetHashCode();
			}
			if (!string.IsNullOrEmpty(this.Comment))
			{
				num ^= this.Comment.GetHashCode();
			}
			return num;
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не представляет допустимые сведения о значениях заголовка.</exception>
		// Token: 0x060003DE RID: 990 RVA: 0x0000D2DC File Offset: 0x0000B4DC
		public static ViaHeaderValue Parse(string input)
		{
			ViaHeaderValue result;
			if (ViaHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.ViaHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x060003DF RID: 991 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		public static bool TryParse(string input, out ViaHeaderValue parsedValue)
		{
			Token token;
			if (ViaHeaderValue.TryParseElement(new Lexer(input), out parsedValue, out token) && token == Token.Type.End)
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000D328 File Offset: 0x0000B528
		internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result)
		{
			return CollectionParser.TryParse<ViaHeaderValue>(input, minimalCount, new ElementTryParser<ViaHeaderValue>(ViaHeaderValue.TryParseElement), out result);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000D340 File Offset: 0x0000B540
		private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			t = lexer.Scan(false);
			if (t != Token.Type.Token)
			{
				return false;
			}
			Token token = lexer.Scan(false);
			ViaHeaderValue viaHeaderValue = new ViaHeaderValue();
			if (token == Token.Type.SeparatorSlash)
			{
				token = lexer.Scan(false);
				if (token != Token.Type.Token)
				{
					return false;
				}
				viaHeaderValue.ProtocolName = lexer.GetStringValue(t);
				viaHeaderValue.ProtocolVersion = lexer.GetStringValue(token);
				token = lexer.Scan(false);
			}
			else
			{
				viaHeaderValue.ProtocolVersion = lexer.GetStringValue(t);
			}
			if (token != Token.Type.Token)
			{
				return false;
			}
			if (lexer.PeekChar() == 58)
			{
				lexer.EatChar();
				t = lexer.Scan(false);
				if (t != Token.Type.Token)
				{
					return false;
				}
			}
			else
			{
				t = token;
			}
			viaHeaderValue.ReceivedBy = lexer.GetStringValue(token, t);
			string comment;
			if (lexer.ScanCommentOptional(out comment, out t))
			{
				t = lexer.Scan(false);
			}
			viaHeaderValue.Comment = comment;
			parsedValue = viaHeaderValue;
			return true;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.ViaHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x060003E2 RID: 994 RVA: 0x0000D448 File Offset: 0x0000B648
		public override string ToString()
		{
			string text = (this.ProtocolName != null) ? string.Concat(new string[]
			{
				this.ProtocolName,
				"/",
				this.ProtocolVersion,
				" ",
				this.ReceivedBy
			}) : (this.ProtocolVersion + " " + this.ReceivedBy);
			if (this.Comment == null)
			{
				return text;
			}
			return text + " " + this.Comment;
		}
	}
}
