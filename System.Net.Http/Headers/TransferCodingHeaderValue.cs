using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение заголовка Accept-Encoding.</summary>
	// Token: 0x02000069 RID: 105
	public class TransferCodingHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />.</summary>
		/// <param name="value">Строка, используемая для инициализации нового экземпляра.</param>
		// Token: 0x060003B9 RID: 953 RVA: 0x0000CDF0 File Offset: 0x0000AFF0
		public TransferCodingHeaderValue(string value)
		{
			Parser.Token.Check(value);
			this.value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />.</summary>
		/// <param name="source">Объект <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />, который используется для инициализации нового экземпляра.</param>
		// Token: 0x060003BA RID: 954 RVA: 0x0000CE08 File Offset: 0x0000B008
		protected TransferCodingHeaderValue(TransferCodingHeaderValue source)
		{
			this.value = source.value;
			if (source.parameters != null)
			{
				foreach (NameValueHeaderValue source2 in source.parameters)
				{
					this.Parameters.Add(new NameValueHeaderValue(source2));
				}
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000022B8 File Offset: 0x000004B8
		internal TransferCodingHeaderValue()
		{
		}

		/// <summary>Возвращает параметры переходного кодирования.</summary>
		/// <returns>Параметры переходного кодирования.</returns>
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000CE80 File Offset: 0x0000B080
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

		/// <summary>Возвращает значение переходного кодирования.</summary>
		/// <returns>Значение переходного кодирования.</returns>
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000CEA5 File Offset: 0x0000B0A5
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x060003BE RID: 958 RVA: 0x0000CEAD File Offset: 0x0000B0AD
		object ICloneable.Clone()
		{
			return new TransferCodingHeaderValue(this);
		}

		/// <summary>Определяет, равен ли заданный объект текущему объекту <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x060003BF RID: 959 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		public override bool Equals(object obj)
		{
			TransferCodingHeaderValue transferCodingHeaderValue = obj as TransferCodingHeaderValue;
			return transferCodingHeaderValue != null && string.Equals(this.value, transferCodingHeaderValue.value, StringComparison.OrdinalIgnoreCase) && this.parameters.SequenceEqual(transferCodingHeaderValue.parameters);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x060003C0 RID: 960 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		public override int GetHashCode()
		{
			int num = this.value.ToLowerInvariant().GetHashCode();
			if (this.parameters != null)
			{
				num ^= HashCodeCalculator.Calculate<NameValueHeaderValue>(this.parameters);
			}
			return num;
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка переходного кодирования.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не представляет допустимые сведения о значениях заголовка переходного кодирования.</exception>
		// Token: 0x060003C1 RID: 961 RVA: 0x0000CF30 File Offset: 0x0000B130
		public static TransferCodingHeaderValue Parse(string input)
		{
			TransferCodingHeaderValue result;
			if (TransferCodingHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x060003C2 RID: 962 RVA: 0x0000CF4F File Offset: 0x0000B14F
		public override string ToString()
		{
			return this.value + this.parameters.ToString<NameValueHeaderValue>();
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.TransferCodingHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x060003C3 RID: 963 RVA: 0x0000CF68 File Offset: 0x0000B168
		public static bool TryParse(string input, out TransferCodingHeaderValue parsedValue)
		{
			Token token;
			if (TransferCodingHeaderValue.TryParseElement(new Lexer(input), out parsedValue, out token) && token == Token.Type.End)
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000CF94 File Offset: 0x0000B194
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result)
		{
			return CollectionParser.TryParse<TransferCodingHeaderValue>(input, minimalCount, new ElementTryParser<TransferCodingHeaderValue>(TransferCodingHeaderValue.TryParseElement), out result);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			t = lexer.Scan(false);
			if (t != Token.Type.Token)
			{
				return false;
			}
			TransferCodingHeaderValue transferCodingHeaderValue = new TransferCodingHeaderValue();
			transferCodingHeaderValue.value = lexer.GetStringValue(t);
			t = lexer.Scan(false);
			if (t == Token.Type.SeparatorSemicolon && (!NameValueHeaderValue.TryParseParameters(lexer, out transferCodingHeaderValue.parameters, out t) || t != Token.Type.End))
			{
				return false;
			}
			parsedValue = transferCodingHeaderValue;
			return true;
		}

		// Token: 0x0400014E RID: 334
		internal string value;

		// Token: 0x0400014F RID: 335
		internal List<NameValueHeaderValue> parameters;
	}
}
