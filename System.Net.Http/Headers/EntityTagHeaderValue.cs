using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение заголовка Entity-Tag.</summary>
	// Token: 0x0200003B RID: 59
	public class EntityTagHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</summary>
		/// <param name="tag">Строка, содержащая <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</param>
		// Token: 0x0600020F RID: 527 RVA: 0x00008912 File Offset: 0x00006B12
		public EntityTagHeaderValue(string tag)
		{
			Parser.Token.CheckQuotedString(tag);
			this.Tag = tag;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</summary>
		/// <param name="tag">Строка, содержащая <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</param>
		/// <param name="isWeak">Значение, указывающее, является ли данный заголовок тега сущности слабым проверяющим элементом. Если заголовок тега сущности — слабый проверяющий элемент, <paramref name="isWeak" /> должно быть установлено в значение <see langword="true" />. Если заголовок тега сущности — сильный проверяющий элемент, <paramref name="isWeak" /> должно быть установлено в значение <see langword="false" />.</param>
		// Token: 0x06000210 RID: 528 RVA: 0x00008927 File Offset: 0x00006B27
		public EntityTagHeaderValue(string tag, bool isWeak) : this(tag)
		{
			this.IsWeak = isWeak;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000022B8 File Offset: 0x000004B8
		internal EntityTagHeaderValue()
		{
		}

		/// <summary>Получает значение заголовка тега сущности.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</returns>
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00008937 File Offset: 0x00006B37
		public static EntityTagHeaderValue Any
		{
			get
			{
				return EntityTagHeaderValue.any;
			}
		}

		/// <summary>Получает значение, указывающее, предваряет ли тег сущности индикатор ослабления безопасности.</summary>
		/// <returns>
		///   <see langword="true" />, если тег сущности предваряет индикатор ослабления безопасности. В противном случае — <see langword="false" />.</returns>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000893E File Offset: 0x00006B3E
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00008946 File Offset: 0x00006B46
		public bool IsWeak { get; internal set; }

		/// <summary>Возвращает непрозрачную строку в кавычках.</summary>
		/// <returns>Непрозрачная строка в кавычках.</returns>
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000894F File Offset: 0x00006B4F
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00008957 File Offset: 0x00006B57
		public string Tag { get; internal set; }

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x06000217 RID: 535 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000218 RID: 536 RVA: 0x00008960 File Offset: 0x00006B60
		public override bool Equals(object obj)
		{
			EntityTagHeaderValue entityTagHeaderValue = obj as EntityTagHeaderValue;
			return entityTagHeaderValue != null && entityTagHeaderValue.Tag == this.Tag && string.Equals(entityTagHeaderValue.Tag, this.Tag, StringComparison.Ordinal);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x06000219 RID: 537 RVA: 0x000089A0 File Offset: 0x00006BA0
		public override int GetHashCode()
		{
			return this.IsWeak.GetHashCode() ^ this.Tag.GetHashCode();
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка тега сущности.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не представляет допустимые сведения о значениях заголовка тега сущности.</exception>
		// Token: 0x0600021A RID: 538 RVA: 0x000089C8 File Offset: 0x00006BC8
		public static EntityTagHeaderValue Parse(string input)
		{
			EntityTagHeaderValue result;
			if (EntityTagHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x0600021B RID: 539 RVA: 0x000089E8 File Offset: 0x00006BE8
		public static bool TryParse(string input, out EntityTagHeaderValue parsedValue)
		{
			Token token;
			if (EntityTagHeaderValue.TryParseElement(new Lexer(input), out parsedValue, out token) && token == Token.Type.End)
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008A14 File Offset: 0x00006C14
		private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			t = lexer.Scan(false);
			bool isWeak = false;
			if (t == Token.Type.Token)
			{
				string stringValue = lexer.GetStringValue(t);
				if (stringValue == "*")
				{
					parsedValue = EntityTagHeaderValue.any;
					t = lexer.Scan(false);
					return true;
				}
				if (stringValue != "W" || lexer.PeekChar() != 47)
				{
					return false;
				}
				isWeak = true;
				lexer.EatChar();
				t = lexer.Scan(false);
			}
			if (t != Token.Type.QuotedString)
			{
				return false;
			}
			parsedValue = new EntityTagHeaderValue();
			parsedValue.Tag = lexer.GetStringValue(t);
			parsedValue.IsWeak = isWeak;
			t = lexer.Scan(false);
			return true;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00008ADF File Offset: 0x00006CDF
		internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result)
		{
			return CollectionParser.TryParse<EntityTagHeaderValue>(input, minimalCount, new ElementTryParser<EntityTagHeaderValue>(EntityTagHeaderValue.TryParseElement), out result);
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x0600021E RID: 542 RVA: 0x00008AF5 File Offset: 0x00006CF5
		public override string ToString()
		{
			if (!this.IsWeak)
			{
				return this.Tag;
			}
			return "W/" + this.Tag;
		}

		// Token: 0x040000F1 RID: 241
		private static readonly EntityTagHeaderValue any = new EntityTagHeaderValue
		{
			Tag = "*"
		};
	}
}
