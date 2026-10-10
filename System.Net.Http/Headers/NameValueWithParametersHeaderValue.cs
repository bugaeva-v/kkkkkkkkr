using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет пару " имя-значение " с параметрами, которые используется в различных заголовках согласно определению в стандарте RFC 2616.</summary>
	// Token: 0x02000053 RID: 83
	public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <param name="name">Имя заголовка.</param>
		// Token: 0x06000335 RID: 821 RVA: 0x0000B633 File Offset: 0x00009833
		public NameValueWithParametersHeaderValue(string name) : base(name)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <param name="name">Имя заголовка.</param>
		/// <param name="value">Значение заголовка.</param>
		// Token: 0x06000336 RID: 822 RVA: 0x0000B63C File Offset: 0x0000983C
		public NameValueWithParametersHeaderValue(string name, string value) : base(name, value)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <param name="source">Объект <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />, который используется для инициализации нового экземпляра.</param>
		// Token: 0x06000337 RID: 823 RVA: 0x0000B648 File Offset: 0x00009848
		protected NameValueWithParametersHeaderValue(NameValueWithParametersHeaderValue source) : base(source)
		{
			if (source.parameters != null)
			{
				foreach (NameValueHeaderValue item in source.parameters)
				{
					this.Parameters.Add(item);
				}
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000B6B0 File Offset: 0x000098B0
		private NameValueWithParametersHeaderValue()
		{
		}

		/// <summary>Получает параметры из объекта <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <returns>Коллекция, содержащая параметры.</returns>
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000B6B8 File Offset: 0x000098B8
		public ICollection<NameValueHeaderValue> Parameters
		{
			get
			{
				List<NameValueHeaderValue> result;
				if ((result = this.parameters) == null)
				{
					result = (this.parameters = new List<NameValueHeaderValue>());
				}
				return result;
			}
		}

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x0600033A RID: 826 RVA: 0x0000B6DD File Offset: 0x000098DD
		object ICloneable.Clone()
		{
			return new NameValueWithParametersHeaderValue(this);
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x0600033B RID: 827 RVA: 0x0000B6E8 File Offset: 0x000098E8
		public override bool Equals(object obj)
		{
			NameValueWithParametersHeaderValue nameValueWithParametersHeaderValue = obj as NameValueWithParametersHeaderValue;
			return nameValueWithParametersHeaderValue != null && base.Equals(obj) && nameValueWithParametersHeaderValue.parameters.SequenceEqual(this.parameters);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x0600033C RID: 828 RVA: 0x0000B71D File Offset: 0x0000991D
		public override int GetHashCode()
		{
			return base.GetHashCode() ^ HashCodeCalculator.Calculate<NameValueHeaderValue>(this.parameters);
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая значение имени со сведениями о значении заголовка параметра.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> — недопустимое значение имени со сведениями о значении заголовка параметра.</exception>
		// Token: 0x0600033D RID: 829 RVA: 0x0000B734 File Offset: 0x00009934
		public new static NameValueWithParametersHeaderValue Parse(string input)
		{
			NameValueWithParametersHeaderValue result;
			if (NameValueWithParametersHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x0600033E RID: 830 RVA: 0x0000B753 File Offset: 0x00009953
		public override string ToString()
		{
			if (this.parameters == null || this.parameters.Count == 0)
			{
				return base.ToString();
			}
			return base.ToString() + this.parameters.ToString<NameValueHeaderValue>();
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.NameValueWithParametersHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x0600033F RID: 831 RVA: 0x0000B788 File Offset: 0x00009988
		public static bool TryParse(string input, out NameValueWithParametersHeaderValue parsedValue)
		{
			Token token;
			if (NameValueWithParametersHeaderValue.TryParseElement(new Lexer(input), out parsedValue, out token) && token == Token.Type.End)
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000B7B4 File Offset: 0x000099B4
		internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result)
		{
			return CollectionParser.TryParse<NameValueWithParametersHeaderValue>(input, minimalCount, new ElementTryParser<NameValueWithParametersHeaderValue>(NameValueWithParametersHeaderValue.TryParseElement), out result);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000B7CC File Offset: 0x000099CC
		private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			t = lexer.Scan(false);
			if (t != Token.Type.Token)
			{
				return false;
			}
			parsedValue = new NameValueWithParametersHeaderValue
			{
				Name = lexer.GetStringValue(t)
			};
			t = lexer.Scan(false);
			if (t == Token.Type.SeparatorEqual)
			{
				t = lexer.Scan(false);
				if (t != Token.Type.Token && t != Token.Type.QuotedString)
				{
					return false;
				}
				parsedValue.value = lexer.GetStringValue(t);
				t = lexer.Scan(false);
			}
			if (t == Token.Type.SeparatorSemicolon)
			{
				List<NameValueHeaderValue> list;
				if (!NameValueHeaderValue.TryParseParameters(lexer, out list, out t))
				{
					return false;
				}
				parsedValue.parameters = list;
			}
			return true;
		}

		// Token: 0x04000139 RID: 313
		private List<NameValueHeaderValue> parameters;
	}
}
