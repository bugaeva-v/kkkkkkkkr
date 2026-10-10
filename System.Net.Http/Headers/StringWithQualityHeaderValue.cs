using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение заголовка строки с дополнительным качеством.</summary>
	// Token: 0x02000068 RID: 104
	public class StringWithQualityHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <param name="value">Строка, используемая для инициализации нового экземпляра.</param>
		// Token: 0x060003AA RID: 938 RVA: 0x0000CB26 File Offset: 0x0000AD26
		public StringWithQualityHeaderValue(string value)
		{
			Parser.Token.Check(value);
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <param name="value">Строка, используемая для инициализации нового экземпляра.</param>
		/// <param name="quality">Коэффициент качества, используемый для инициализации нового экземпляра.</param>
		// Token: 0x060003AB RID: 939 RVA: 0x0000CB3B File Offset: 0x0000AD3B
		public StringWithQualityHeaderValue(string value, double quality) : this(value)
		{
			if (quality < 0.0 || quality > 1.0)
			{
				throw new ArgumentOutOfRangeException("quality");
			}
			this.Quality = new double?(quality);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000022B8 File Offset: 0x000004B8
		private StringWithQualityHeaderValue()
		{
		}

		/// <summary>Возвращает коэффициент качества из объекта <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <returns>Коэффициент качества из объекта <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</returns>
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000CB73 File Offset: 0x0000AD73
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000CB7B File Offset: 0x0000AD7B
		public double? Quality { get; private set; }

		/// <summary>Возвращает строковое значение объекта <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <returns>Строковое значение объекта <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</returns>
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000CB84 File Offset: 0x0000AD84
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		public string Value { get; private set; }

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x060003B1 RID: 945 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект текущему объекту <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x060003B2 RID: 946 RVA: 0x0000CB98 File Offset: 0x0000AD98
		public override bool Equals(object obj)
		{
			StringWithQualityHeaderValue stringWithQualityHeaderValue = obj as StringWithQualityHeaderValue;
			if (stringWithQualityHeaderValue != null && string.Equals(stringWithQualityHeaderValue.Value, this.Value, StringComparison.OrdinalIgnoreCase))
			{
				double? quality = stringWithQualityHeaderValue.Quality;
				double? quality2 = this.Quality;
				return quality.GetValueOrDefault() == quality2.GetValueOrDefault() & quality != null == (quality2 != null);
			}
			return false;
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x060003B3 RID: 947 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		public override int GetHashCode()
		{
			return this.Value.ToLowerInvariant().GetHashCode() ^ this.Quality.GetHashCode();
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка качества.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> является недопустимой строкой со сведениями о значении заголовка качества.</exception>
		// Token: 0x060003B4 RID: 948 RVA: 0x0000CC28 File Offset: 0x0000AE28
		public static StringWithQualityHeaderValue Parse(string input)
		{
			StringWithQualityHeaderValue result;
			if (StringWithQualityHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x060003B5 RID: 949 RVA: 0x0000CC48 File Offset: 0x0000AE48
		public static bool TryParse(string input, out StringWithQualityHeaderValue parsedValue)
		{
			Token token;
			if (StringWithQualityHeaderValue.TryParseElement(new Lexer(input), out parsedValue, out token) && token == Token.Type.End)
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000CC74 File Offset: 0x0000AE74
		internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result)
		{
			return CollectionParser.TryParse<StringWithQualityHeaderValue>(input, minimalCount, new ElementTryParser<StringWithQualityHeaderValue>(StringWithQualityHeaderValue.TryParseElement), out result);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			t = lexer.Scan(false);
			if (t != Token.Type.Token)
			{
				return false;
			}
			StringWithQualityHeaderValue stringWithQualityHeaderValue = new StringWithQualityHeaderValue();
			stringWithQualityHeaderValue.Value = lexer.GetStringValue(t);
			t = lexer.Scan(false);
			if (t == Token.Type.SeparatorSemicolon)
			{
				t = lexer.Scan(false);
				if (t != Token.Type.Token)
				{
					return false;
				}
				string stringValue = lexer.GetStringValue(t);
				if (stringValue != "q" && stringValue != "Q")
				{
					return false;
				}
				t = lexer.Scan(false);
				if (t != Token.Type.SeparatorEqual)
				{
					return false;
				}
				t = lexer.Scan(false);
				double num;
				if (!lexer.TryGetDoubleValue(t, out num))
				{
					return false;
				}
				if (num > 1.0)
				{
					return false;
				}
				stringWithQualityHeaderValue.Quality = new double?(num);
				t = lexer.Scan(false);
			}
			parsedValue = stringWithQualityHeaderValue;
			return true;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.StringWithQualityHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x060003B8 RID: 952 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public override string ToString()
		{
			if (this.Quality != null)
			{
				return this.Value + "; q=" + this.Quality.Value.ToString("0.0##", CultureInfo.InvariantCulture);
			}
			return this.Value;
		}
	}
}
