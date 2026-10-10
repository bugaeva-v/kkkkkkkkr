using System;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение заголовка Content-Range.</summary>
	// Token: 0x0200003A RID: 58
	public class ContentRangeHeaderValue : ICloneable
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00008437 File Offset: 0x00006637
		private ContentRangeHeaderValue()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</summary>
		/// <param name="length">Начальная или конечная точка диапазона, в байтах.</param>
		// Token: 0x060001FC RID: 508 RVA: 0x0000844A File Offset: 0x0000664A
		public ContentRangeHeaderValue(long length)
		{
			if (length < 0L)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			this.Length = new long?(length);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</summary>
		/// <param name="from">Позиция (в байтах) начала передачи данных.</param>
		/// <param name="to">Позиция окончания передачи данных в байтах.</param>
		// Token: 0x060001FD RID: 509 RVA: 0x00008479 File Offset: 0x00006679
		public ContentRangeHeaderValue(long from, long to)
		{
			if (from < 0L || from > to)
			{
				throw new ArgumentOutOfRangeException("from");
			}
			this.From = new long?(from);
			this.To = new long?(to);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</summary>
		/// <param name="from">Позиция (в байтах) начала передачи данных.</param>
		/// <param name="to">Позиция окончания передачи данных в байтах.</param>
		/// <param name="length">Начальная или конечная точка диапазона, в байтах.</param>
		// Token: 0x060001FE RID: 510 RVA: 0x000084B8 File Offset: 0x000066B8
		public ContentRangeHeaderValue(long from, long to, long length) : this(from, to)
		{
			if (length < 0L)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			if (to > length)
			{
				throw new ArgumentOutOfRangeException("to");
			}
			this.Length = new long?(length);
		}

		/// <summary>Возвращает позицию начала передачи данных.</summary>
		/// <returns>Позиция (в байтах) начала передачи данных.</returns>
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001FF RID: 511 RVA: 0x000084ED File Offset: 0x000066ED
		// (set) Token: 0x06000200 RID: 512 RVA: 0x000084F5 File Offset: 0x000066F5
		public long? From { get; private set; }

		/// <summary>Получает значение, которое указывает, имеет ли заголовок Content-Range заданную длину.</summary>
		/// <returns>
		///   <see langword="true" />, если длина Content-Range соответствует заданному значению. В противном случае — <see langword="false" />.</returns>
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00008500 File Offset: 0x00006700
		public bool HasLength
		{
			get
			{
				return this.Length != null;
			}
		}

		/// <summary>Получает значение, которое указывает, имеет ли Content-Range заданный диапазон.</summary>
		/// <returns>
		///   <see langword="true" />, если диапазон Content-Range соответствует заданному значению. В противном случае — <see langword="false" />.</returns>
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000851C File Offset: 0x0000671C
		public bool HasRange
		{
			get
			{
				return this.From != null;
			}
		}

		/// <summary>Возвращает длину полного тела сущности.</summary>
		/// <returns>Длина полного тела сущности.</returns>
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00008537 File Offset: 0x00006737
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000853F File Offset: 0x0000673F
		public long? Length { get; private set; }

		/// <summary>Возвращает место остановки передачи данных.</summary>
		/// <returns>Место остановки передачи данных.</returns>
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00008548 File Offset: 0x00006748
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00008550 File Offset: 0x00006750
		public long? To { get; private set; }

		/// <summary>Используемые единицы диапазона.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий единицы диапазона.</returns>
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00008559 File Offset: 0x00006759
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00008561 File Offset: 0x00006761
		public string Unit
		{
			get
			{
				return this.unit;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Unit");
				}
				Parser.Token.Check(value);
				this.unit = value;
			}
		}

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x06000209 RID: 521 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект текущему объекту <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x0600020A RID: 522 RVA: 0x00008580 File Offset: 0x00006780
		public override bool Equals(object obj)
		{
			ContentRangeHeaderValue contentRangeHeaderValue = obj as ContentRangeHeaderValue;
			if (contentRangeHeaderValue == null)
			{
				return false;
			}
			long? num = contentRangeHeaderValue.Length;
			long? num2 = this.Length;
			if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
			{
				num2 = contentRangeHeaderValue.From;
				num = this.From;
				if (num2.GetValueOrDefault() == num.GetValueOrDefault() & num2 != null == (num != null))
				{
					num = contentRangeHeaderValue.To;
					num2 = this.To;
					if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
					{
						return string.Equals(contentRangeHeaderValue.unit, this.unit, StringComparison.OrdinalIgnoreCase);
					}
				}
			}
			return false;
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x0600020B RID: 523 RVA: 0x00008640 File Offset: 0x00006840
		public override int GetHashCode()
		{
			return this.Unit.GetHashCode() ^ this.Length.GetHashCode() ^ this.From.GetHashCode() ^ this.To.GetHashCode() ^ this.unit.ToLowerInvariant().GetHashCode();
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка диапазона содержимого.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не представляет допустимые сведения о значениях заголовка диапазона содержимого.</exception>
		// Token: 0x0600020C RID: 524 RVA: 0x000086A8 File Offset: 0x000068A8
		public static ContentRangeHeaderValue Parse(string input)
		{
			ContentRangeHeaderValue result;
			if (ContentRangeHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x0600020D RID: 525 RVA: 0x000086C8 File Offset: 0x000068C8
		public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue)
		{
			parsedValue = null;
			Lexer lexer = new Lexer(input);
			Token token = lexer.Scan(false);
			if (token != Token.Type.Token)
			{
				return false;
			}
			ContentRangeHeaderValue contentRangeHeaderValue = new ContentRangeHeaderValue();
			contentRangeHeaderValue.unit = lexer.GetStringValue(token);
			token = lexer.Scan(false);
			if (token != Token.Type.Token)
			{
				return false;
			}
			if (!lexer.IsStarStringValue(token))
			{
				long value;
				if (!lexer.TryGetNumericValue(token, out value))
				{
					string stringValue = lexer.GetStringValue(token);
					if (stringValue.Length < 3)
					{
						return false;
					}
					string[] array = stringValue.Split('-', StringSplitOptions.None);
					if (array.Length != 2)
					{
						return false;
					}
					if (!long.TryParse(array[0], NumberStyles.None, CultureInfo.InvariantCulture, out value))
					{
						return false;
					}
					contentRangeHeaderValue.From = new long?(value);
					if (!long.TryParse(array[1], NumberStyles.None, CultureInfo.InvariantCulture, out value))
					{
						return false;
					}
					contentRangeHeaderValue.To = new long?(value);
				}
				else
				{
					contentRangeHeaderValue.From = new long?(value);
					token = lexer.Scan(true);
					if (token != Token.Type.SeparatorDash)
					{
						return false;
					}
					token = lexer.Scan(false);
					if (!lexer.TryGetNumericValue(token, out value))
					{
						return false;
					}
					contentRangeHeaderValue.To = new long?(value);
				}
			}
			token = lexer.Scan(false);
			if (token != Token.Type.SeparatorSlash)
			{
				return false;
			}
			token = lexer.Scan(false);
			if (!lexer.IsStarStringValue(token))
			{
				long value2;
				if (!lexer.TryGetNumericValue(token, out value2))
				{
					return false;
				}
				contentRangeHeaderValue.Length = new long?(value2);
			}
			token = lexer.Scan(false);
			if (token != Token.Type.End)
			{
				return false;
			}
			parsedValue = contentRangeHeaderValue;
			return true;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x0600020E RID: 526 RVA: 0x00008834 File Offset: 0x00006A34
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(this.unit);
			stringBuilder.Append(" ");
			if (this.From == null)
			{
				stringBuilder.Append("*");
			}
			else
			{
				stringBuilder.Append(this.From.Value.ToString(CultureInfo.InvariantCulture));
				stringBuilder.Append("-");
				stringBuilder.Append(this.To.Value.ToString(CultureInfo.InvariantCulture));
			}
			stringBuilder.Append("/");
			stringBuilder.Append((this.Length == null) ? "*" : this.Length.Value.ToString(CultureInfo.InvariantCulture));
			return stringBuilder.ToString();
		}

		// Token: 0x040000ED RID: 237
		private string unit = "bytes";
	}
}
