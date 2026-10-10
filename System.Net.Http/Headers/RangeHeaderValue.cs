using System;
using System.Collections.Generic;
using System.Text;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение заголовка Range.</summary>
	// Token: 0x02000065 RID: 101
	public class RangeHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</summary>
		// Token: 0x06000389 RID: 905 RVA: 0x0000C2B9 File Offset: 0x0000A4B9
		public RangeHeaderValue()
		{
			this.unit = "bytes";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.RangeHeaderValue" /> диапазоном байтов.</summary>
		/// <param name="from">Место начала передачи данных.</param>
		/// <param name="to">Место остановки передачи данных.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="from" /> больше <paramref name="to" />  
		///
		/// или - 
		/// Значение параметра <paramref name="from" /> или <paramref name="to" /> меньше 0.</exception>
		// Token: 0x0600038A RID: 906 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		public RangeHeaderValue(long? from, long? to) : this()
		{
			this.Ranges.Add(new RangeItemHeaderValue(from, to));
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		private RangeHeaderValue(RangeHeaderValue source) : this()
		{
			if (source.ranges != null)
			{
				foreach (RangeItemHeaderValue item in source.ranges)
				{
					this.Ranges.Add(item);
				}
			}
		}

		/// <summary>Возвращает диапазоны, указанные в объекте <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</summary>
		/// <returns>Диапазоны в объекте <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</returns>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000C350 File Offset: 0x0000A550
		public ICollection<RangeItemHeaderValue> Ranges
		{
			get
			{
				List<RangeItemHeaderValue> result;
				if ((result = this.ranges) == null)
				{
					result = (this.ranges = new List<RangeItemHeaderValue>());
				}
				return result;
			}
		}

		/// <summary>Возвращает единицу из объекта <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</summary>
		/// <returns>Единица из объекта <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</returns>
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0000C375 File Offset: 0x0000A575
		// (set) Token: 0x0600038E RID: 910 RVA: 0x0000C37D File Offset: 0x0000A57D
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

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x0600038F RID: 911 RVA: 0x0000C39A File Offset: 0x0000A59A
		object ICloneable.Clone()
		{
			return new RangeHeaderValue(this);
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000390 RID: 912 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		public override bool Equals(object obj)
		{
			RangeHeaderValue rangeHeaderValue = obj as RangeHeaderValue;
			return rangeHeaderValue != null && string.Equals(rangeHeaderValue.Unit, this.Unit, StringComparison.OrdinalIgnoreCase) && rangeHeaderValue.ranges.SequenceEqual(this.ranges);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x06000391 RID: 913 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
		public override int GetHashCode()
		{
			return this.Unit.ToLowerInvariant().GetHashCode() ^ HashCodeCalculator.Calculate<RangeItemHeaderValue>(this.ranges);
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка диапазона.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не представляет допустимые сведения о значениях заголовка диапазона.</exception>
		// Token: 0x06000392 RID: 914 RVA: 0x0000C404 File Offset: 0x0000A604
		public static RangeHeaderValue Parse(string input)
		{
			RangeHeaderValue result;
			if (RangeHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.RangeHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000393 RID: 915 RVA: 0x0000C424 File Offset: 0x0000A624
		public static bool TryParse(string input, out RangeHeaderValue parsedValue)
		{
			parsedValue = null;
			Lexer lexer = new Lexer(input);
			Token token = lexer.Scan(false);
			if (token != Token.Type.Token)
			{
				return false;
			}
			RangeHeaderValue rangeHeaderValue = new RangeHeaderValue();
			rangeHeaderValue.unit = lexer.GetStringValue(token);
			token = lexer.Scan(false);
			if (token != Token.Type.SeparatorEqual)
			{
				return false;
			}
			for (;;)
			{
				long? num = null;
				long? num2 = null;
				bool flag = false;
				token = lexer.Scan(true);
				Token.Type kind = token.Kind;
				if (kind != Token.Type.Token)
				{
					if (kind != Token.Type.SeparatorDash)
					{
						return false;
					}
					token = lexer.Scan(false);
					long value;
					if (!lexer.TryGetNumericValue(token, out value))
					{
						break;
					}
					num2 = new long?(value);
				}
				else
				{
					string stringValue = lexer.GetStringValue(token);
					string[] array = stringValue.Split(new char[]
					{
						'-'
					}, StringSplitOptions.RemoveEmptyEntries);
					long value;
					if (!Parser.Long.TryParse(array[0], out value))
					{
						return false;
					}
					int num3 = array.Length;
					if (num3 != 1)
					{
						if (num3 != 2)
						{
							return false;
						}
						num = new long?(value);
						if (!Parser.Long.TryParse(array[1], out value))
						{
							return false;
						}
						num2 = new long?(value);
						long? num4 = num2;
						long? num5 = num;
						if (num4.GetValueOrDefault() < num5.GetValueOrDefault() & (num4 != null & num5 != null))
						{
							return false;
						}
					}
					else
					{
						token = lexer.Scan(true);
						num = new long?(value);
						Token.Type kind2 = token.Kind;
						if (kind2 != Token.Type.End)
						{
							if (kind2 != Token.Type.SeparatorDash)
							{
								if (kind2 != Token.Type.SeparatorComma)
								{
									return false;
								}
								flag = true;
							}
							else
							{
								token = lexer.Scan(false);
								if (token != Token.Type.Token)
								{
									flag = true;
								}
								else
								{
									if (!lexer.TryGetNumericValue(token, out value))
									{
										return false;
									}
									num2 = new long?(value);
									long? num5 = num2;
									long? num4 = num;
									if (num5.GetValueOrDefault() < num4.GetValueOrDefault() & (num5 != null & num4 != null))
									{
										return false;
									}
								}
							}
						}
						else
						{
							if (stringValue.Length > 0 && stringValue[stringValue.Length - 1] != '-')
							{
								return false;
							}
							flag = true;
						}
					}
				}
				rangeHeaderValue.Ranges.Add(new RangeItemHeaderValue(num, num2));
				if (!flag)
				{
					token = lexer.Scan(false);
				}
				if (token != Token.Type.SeparatorComma)
				{
					goto Block_20;
				}
			}
			return false;
			Block_20:
			if (token != Token.Type.End)
			{
				return false;
			}
			parsedValue = rangeHeaderValue;
			return true;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x06000394 RID: 916 RVA: 0x0000C64C File Offset: 0x0000A84C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(this.unit);
			stringBuilder.Append("=");
			for (int i = 0; i < this.Ranges.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(this.ranges[i]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000146 RID: 326
		private List<RangeItemHeaderValue> ranges;

		// Token: 0x04000147 RID: 327
		private string unit;
	}
}
