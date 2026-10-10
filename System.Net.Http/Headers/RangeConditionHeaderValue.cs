using System;
using System.Globalization;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение заголовка If-Range, которое может быть либо значением даты и времени, либо значением тега сущности.</summary>
	// Token: 0x02000064 RID: 100
	public class RangeConditionHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <param name="date">Значение даты, используемое для инициализации нового экземпляра.</param>
		// Token: 0x0600037C RID: 892 RVA: 0x0000C09B File Offset: 0x0000A29B
		public RangeConditionHeaderValue(DateTimeOffset date)
		{
			this.Date = new DateTimeOffset?(date);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <param name="entityTag">Объект <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />, который используется для инициализации нового экземпляра.</param>
		// Token: 0x0600037D RID: 893 RVA: 0x0000C0AF File Offset: 0x0000A2AF
		public RangeConditionHeaderValue(EntityTagHeaderValue entityTag)
		{
			if (entityTag == null)
			{
				throw new ArgumentNullException("entityTag");
			}
			this.EntityTag = entityTag;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <param name="entityTag">Тег сущности, представленный в виде строки, используемой для инициализации нового экземпляра.</param>
		// Token: 0x0600037E RID: 894 RVA: 0x0000C0CC File Offset: 0x0000A2CC
		public RangeConditionHeaderValue(string entityTag) : this(new EntityTagHeaderValue(entityTag))
		{
		}

		/// <summary>Возвращает данные из объекта <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <returns>Данные из объекта <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</returns>
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000C0DA File Offset: 0x0000A2DA
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0000C0E2 File Offset: 0x0000A2E2
		public DateTimeOffset? Date { get; private set; }

		/// <summary>Получает тег сущности из объекта <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <returns>Тег сущности из объекта <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</returns>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000C0EB File Offset: 0x0000A2EB
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0000C0F3 File Offset: 0x0000A2F3
		public EntityTagHeaderValue EntityTag { get; private set; }

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x06000383 RID: 899 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000384 RID: 900 RVA: 0x0000C0FC File Offset: 0x0000A2FC
		public override bool Equals(object obj)
		{
			RangeConditionHeaderValue rangeConditionHeaderValue = obj as RangeConditionHeaderValue;
			if (rangeConditionHeaderValue == null)
			{
				return false;
			}
			if (this.EntityTag == null)
			{
				return this.Date == rangeConditionHeaderValue.Date;
			}
			return this.EntityTag.Equals(rangeConditionHeaderValue.EntityTag);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x06000385 RID: 901 RVA: 0x0000C170 File Offset: 0x0000A370
		public override int GetHashCode()
		{
			if (this.EntityTag == null)
			{
				return this.Date.GetHashCode();
			}
			return this.EntityTag.GetHashCode();
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка условия диапазона.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не представляет допустимые сведения о значениях заголовка условия диапазона.</exception>
		// Token: 0x06000386 RID: 902 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
		public static RangeConditionHeaderValue Parse(string input)
		{
			RangeConditionHeaderValue result;
			if (RangeConditionHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000387 RID: 903 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue)
		{
			parsedValue = null;
			Lexer lexer = new Lexer(input);
			Token token = lexer.Scan(false);
			bool isWeak;
			if (token == Token.Type.Token)
			{
				if (lexer.GetStringValue(token) != "W")
				{
					DateTimeOffset date;
					if (!Lexer.TryGetDateValue(input, out date))
					{
						return false;
					}
					parsedValue = new RangeConditionHeaderValue(date);
					return true;
				}
				else
				{
					if (lexer.PeekChar() != 47)
					{
						return false;
					}
					isWeak = true;
					lexer.EatChar();
					token = lexer.Scan(false);
				}
			}
			else
			{
				isWeak = false;
			}
			if (token != Token.Type.QuotedString)
			{
				return false;
			}
			if (lexer.Scan(false) != Token.Type.End)
			{
				return false;
			}
			parsedValue = new RangeConditionHeaderValue(new EntityTagHeaderValue
			{
				Tag = lexer.GetStringValue(token),
				IsWeak = isWeak
			});
			return true;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x06000388 RID: 904 RVA: 0x0000C278 File Offset: 0x0000A478
		public override string ToString()
		{
			if (this.EntityTag != null)
			{
				return this.EntityTag.ToString();
			}
			return this.Date.Value.ToString("r", CultureInfo.InvariantCulture);
		}
	}
}
