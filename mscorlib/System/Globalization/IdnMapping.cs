using System;
using System.Text;

namespace System.Globalization
{
	/// <summary>Поддерживает использование символов, не относящихся к ASCII, для имен доменов Интернета. Этот класс не наследуется.</summary>
	// Token: 0x020009AA RID: 2474
	public sealed class IdnMapping
	{
		/// <summary>Получает или задает значение, указывающее, следует ли использовать кодовые точки Юникод в операциях, выполняемых членами текущего объекта <see cref="T:System.Globalization.IdnMapping" />.</summary>
		/// <returns>Значение равно <see langword="true" />, если в процедурах используются точки кода без знака; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06005959 RID: 22873 RVA: 0x0013215F File Offset: 0x0013035F
		// (set) Token: 0x0600595A RID: 22874 RVA: 0x00132167 File Offset: 0x00130367
		public bool AllowUnassigned
		{
			get
			{
				return this.allow_unassigned;
			}
			set
			{
				this.allow_unassigned = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, следует ли использовать стандартные или ослабленные правила именования в операциях, выполняемых членами текущего объекта <see cref="T:System.Globalization.IdnMapping" />.</summary>
		/// <returns>Значение <see langword="true" />, если в процедурах используются стандартные правила именования; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x00132170 File Offset: 0x00130370
		// (set) Token: 0x0600595C RID: 22876 RVA: 0x00132178 File Offset: 0x00130378
		public bool UseStd3AsciiRules
		{
			get
			{
				return this.use_std3;
			}
			set
			{
				this.use_std3 = value;
			}
		}

		/// <summary>Указывает, равны ли указанный объект и текущий объект <see cref="T:System.Globalization.IdnMapping" />.</summary>
		/// <param name="obj">Объект для сравнения с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если объект, указанный параметром <paramref name="obj" />, унаследован от <see cref="T:System.Globalization.IdnMapping" /> и его свойства <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> и <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600595D RID: 22877 RVA: 0x00132184 File Offset: 0x00130384
		public override bool Equals(object obj)
		{
			IdnMapping idnMapping = obj as IdnMapping;
			return idnMapping != null && this.allow_unassigned == idnMapping.allow_unassigned && this.use_std3 == idnMapping.use_std3;
		}

		/// <summary>Возвращает хэш-код объекта <see cref="T:System.Globalization.IdnMapping" />.</summary>
		/// <returns>Одна из четырех 32-битных констант со знаком, унаследованных от свойств объекта <see cref="T:System.Globalization.IdnMapping" />.  Возвращаемое значение не имеет особого значения и не пригодно к использованию в алгоритме хэш-кода.</returns>
		// Token: 0x0600595E RID: 22878 RVA: 0x001321B9 File Offset: 0x001303B9
		public override int GetHashCode()
		{
			return (this.allow_unassigned ? 2 : 0) + (this.use_std3 ? 1 : 0);
		}

		/// <summary>Кодирует строку меток доменных имен, в которой содержатся символы Юникода, в строку отображаемых символов Юникода в диапазоне символов US-ASCII. Строка форматируется в соответствии со стандартом IDNA.</summary>
		/// <param name="unicode">Строка для преобразования, которая состоит из одной или нескольких меток доменного имени, разделенных особыми символами.</param>
		/// <returns>Эквивалент строки, указанной параметром <paramref name="unicode" />, состоящей из отображаемых символов Юникода в диапазоне символов US-ASCII (с U+0020 до U+007E) и отформатированной в соответствии со стандартом IDNA.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="unicode" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="unicode" /> не является допустимым на основе свойств <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> и <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" />, а также стандарта IDNA,</exception>
		// Token: 0x0600595F RID: 22879 RVA: 0x001321D4 File Offset: 0x001303D4
		public string GetAscii(string unicode)
		{
			if (unicode == null)
			{
				throw new ArgumentNullException("unicode");
			}
			return this.GetAscii(unicode, 0, unicode.Length);
		}

		/// <summary>Кодирует подстроку меток имени домена, включающих знаки юникода, выходящие за диапазон символов US-ASCII. Подстрока преобразуется в строку отображаемых символов Юникода в диапазоне символов US-ASCII и форматируется в соответствии со стандартом IDNA.</summary>
		/// <param name="unicode">Строка для преобразования, которая состоит из одной или нескольких меток доменного имени, разделенных особыми символами.</param>
		/// <param name="index">Нулевое смещение в <paramref name="unicode" />, которое указывает на начало подстроки для преобразования. Процедура преобразования продолжается до окончания строки <paramref name="unicode" />.</param>
		/// <returns>Эквивалент подстроки, указанной параметрами <paramref name="unicode" /> и <paramref name="index" />, состоящей из отображаемых символов Юникода в диапазоне символов US-ASCII (с U+0020 до U+007E) и отформатированной в соответствии со стандартом IDNA.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="unicode" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> превышает длину <paramref name="unicode" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="unicode" /> не является допустимым на основе свойств <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> и <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" />, а также стандарта IDNA,</exception>
		// Token: 0x06005960 RID: 22880 RVA: 0x001321F2 File Offset: 0x001303F2
		public string GetAscii(string unicode, int index)
		{
			if (unicode == null)
			{
				throw new ArgumentNullException("unicode");
			}
			return this.GetAscii(unicode, index, unicode.Length - index);
		}

		/// <summary>Кодирует указанное количество символов в подстроке меток имени домена, включающих знаки Юникода, выходящие за диапазон символов US-ASCII. Подстрока преобразуется в строку отображаемых символов Юникода в диапазоне символов US-ASCII и форматируется в соответствии со стандартом IDNA.</summary>
		/// <param name="unicode">Строка для преобразования, которая состоит из одной или нескольких меток доменного имени, разделенных особыми символами.</param>
		/// <param name="index">Нулевое смещение в <paramref name="unicode" />, которое указывает на начало подстроки.</param>
		/// <param name="count">Количество символов для преобразования в подстроку, которая начинается с места, указанного параметром <paramref name="index" /> в строке <paramref name="unicode" />.</param>
		/// <returns>Эквивалент подстроки, указанной параметрами <paramref name="unicode" />, <paramref name="index" /> и <paramref name="count" />, состоящей из отображаемых символов Юникода в диапазоне символов US-ASCII (с U+0020 до U+007E) и отформатированной в соответствии со стандартом IDNA.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="unicode" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> превышает длину <paramref name="unicode" />.  
		///
		/// или - 
		/// длина значения <paramref name="index" /> больше, чем длина <paramref name="unicode" /> минус <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="unicode" /> не является допустимым на основе свойств <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> и <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" />, а также стандарта IDNA,</exception>
		// Token: 0x06005961 RID: 22881 RVA: 0x00132214 File Offset: 0x00130414
		public string GetAscii(string unicode, int index, int count)
		{
			if (unicode == null)
			{
				throw new ArgumentNullException("unicode");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index must be non-negative value");
			}
			if (count < 0 || index + count > unicode.Length)
			{
				throw new ArgumentOutOfRangeException("index + count must point inside the argument unicode string");
			}
			return this.Convert(unicode, index, count, true);
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x00132264 File Offset: 0x00130464
		private string Convert(string input, int index, int count, bool toAscii)
		{
			string text = input.Substring(index, count);
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] >= '\u0080')
				{
					text = text.ToLower(CultureInfo.InvariantCulture);
					break;
				}
			}
			string[] array = text.Split(new char[]
			{
				'.',
				'。',
				'．',
				'｡'
			});
			int num = 0;
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j].Length != 0 || j + 1 != array.Length)
				{
					if (toAscii)
					{
						array[j] = this.ToAscii(array[j], num);
					}
					else
					{
						array[j] = this.ToUnicode(array[j], num);
					}
				}
				num += array[j].Length;
			}
			return string.Join(".", array);
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x00132324 File Offset: 0x00130524
		private string ToAscii(string s, int offset)
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] < ' ' || s[i] == '\u007f')
				{
					throw new ArgumentException(string.Format("Not allowed character was found, at {0}", offset + i));
				}
				if (s[i] >= '\u0080')
				{
					s = this.NamePrep(s, offset);
					break;
				}
			}
			if (this.use_std3)
			{
				this.VerifyStd3AsciiRules(s, offset);
			}
			int j = 0;
			while (j < s.Length)
			{
				if (s[j] >= '\u0080')
				{
					if (s.StartsWith("xn--", StringComparison.OrdinalIgnoreCase))
					{
						throw new ArgumentException(string.Format("The input string must not start with ACE (xn--), at {0}", offset + j));
					}
					s = this.puny.Encode(s, offset);
					s = "xn--" + s;
					break;
				}
				else
				{
					j++;
				}
			}
			this.VerifyLength(s, offset);
			return s;
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00132406 File Offset: 0x00130606
		private void VerifyLength(string s, int offset)
		{
			if (s.Length == 0)
			{
				throw new ArgumentException(string.Format("A label in the input string resulted in an invalid zero-length string, at {0}", offset));
			}
			if (s.Length > 63)
			{
				throw new ArgumentException(string.Format("A label in the input string exceeded the length in ASCII representation, at {0}", offset));
			}
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x00132448 File Offset: 0x00130648
		private string NamePrep(string s, int offset)
		{
			s = s.Normalize(NormalizationForm.FormKC);
			this.VerifyProhibitedCharacters(s, offset);
			if (!this.allow_unassigned)
			{
				for (int i = 0; i < s.Length; i++)
				{
					if (char.GetUnicodeCategory(s, i) == UnicodeCategory.OtherNotAssigned)
					{
						throw new ArgumentException(string.Format("Use of unassigned Unicode characer is prohibited in this IdnMapping, at {0}", offset + i));
					}
				}
			}
			return s;
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x001324A4 File Offset: 0x001306A4
		private void VerifyProhibitedCharacters(string s, int offset)
		{
			int i = 0;
			while (i < s.Length)
			{
				switch (char.GetUnicodeCategory(s, i))
				{
				case UnicodeCategory.SpaceSeparator:
					if (s[i] >= '\u0080')
					{
						goto IL_111;
					}
					break;
				case UnicodeCategory.LineSeparator:
				case UnicodeCategory.ParagraphSeparator:
				case UnicodeCategory.Format:
					goto IL_6E;
				case UnicodeCategory.Control:
					if (s[i] == '\0' || s[i] >= '\u0080')
					{
						goto IL_111;
					}
					break;
				case UnicodeCategory.Surrogate:
				case UnicodeCategory.PrivateUse:
					goto IL_111;
				default:
					goto IL_6E;
				}
				IL_129:
				i++;
				continue;
				IL_111:
				throw new ArgumentException(string.Format("Not allowed character was in the input string, at {0}", offset + i));
				IL_6E:
				char c = s[i];
				if (('﷟' <= c && c <= '﷯') || (c & '￿') == '￾' || ('￹' <= c && c <= '�') || ('⿰' <= c && c <= '⿻') || ('‪' <= c && c <= '‮') || ('⁪' <= c && c <= '⁯'))
				{
					goto IL_111;
				}
				if (c <= '‎')
				{
					if (c != '̀' && c != '́' && c != '‎')
					{
						goto IL_129;
					}
					goto IL_111;
				}
				else
				{
					if (c == '‏' || c == '\u2028' || c == '\u2029')
					{
						goto IL_111;
					}
					goto IL_129;
				}
			}
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x001325EC File Offset: 0x001307EC
		private void VerifyStd3AsciiRules(string s, int offset)
		{
			if (s.Length > 0 && s[0] == '-')
			{
				throw new ArgumentException(string.Format("'-' is not allowed at head of a sequence in STD3 mode, found at {0}", offset));
			}
			if (s.Length > 0 && s[s.Length - 1] == '-')
			{
				throw new ArgumentException(string.Format("'-' is not allowed at tail of a sequence in STD3 mode, found at {0}", offset + s.Length - 1));
			}
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				if (c != '-' && (c <= '/' || (':' <= c && c <= '@') || ('[' <= c && c <= '`') || ('{' <= c && c <= '\u007f')))
				{
					throw new ArgumentException(string.Format("Not allowed character in STD3 mode, found at {0}", offset + i));
				}
			}
		}

		/// <summary>Декодирует строку, состоящую из одной или нескольких меток доменного имени, в соответствии со стандартом IDNA в строку символов Юникода.</summary>
		/// <param name="ascii">Строка для декодирования, состоящая из одной или нескольких меток в диапазоне символов US-ASCII (с U+0020 до U+007E), закодированных в соответствии со стандартом IDNA.</param>
		/// <returns>Эквивалент подстроки IDNA, указанной в параметре <paramref name="ascii" />, в символах Юникода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="ascii" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ascii" /> не является допустимым на основе свойств <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> и <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" />, а также стандарта IDNA,</exception>
		// Token: 0x06005968 RID: 22888 RVA: 0x001326B6 File Offset: 0x001308B6
		public string GetUnicode(string ascii)
		{
			if (ascii == null)
			{
				throw new ArgumentNullException("ascii");
			}
			return this.GetUnicode(ascii, 0, ascii.Length);
		}

		/// <summary>Декодирует подстроку, состоящую из одной или нескольких меток доменного имени, в соответствии со стандартом IDNA в строку символов Юникода.</summary>
		/// <param name="ascii">Строка для декодирования, состоящая из одной или нескольких меток в диапазоне символов US-ASCII (с U+0020 до U+007E), закодированных в соответствии со стандартом IDNA.</param>
		/// <param name="index">Нулевое смещение в <paramref name="ascii" />, которое указывает на начало подстроки для декодирования. Процедура декодирования продолжается до окончания строки <paramref name="ascii" />.</param>
		/// <returns>Эквивалент подстроки IDNA, указанной в параметрах <paramref name="ascii" /> и <paramref name="index" />, в символах Юникода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="ascii" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> превышает длину <paramref name="ascii" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ascii" /> не является допустимым на основе свойств <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> и <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" />, а также стандарта IDNA,</exception>
		// Token: 0x06005969 RID: 22889 RVA: 0x001326D4 File Offset: 0x001308D4
		public string GetUnicode(string ascii, int index)
		{
			if (ascii == null)
			{
				throw new ArgumentNullException("ascii");
			}
			return this.GetUnicode(ascii, index, ascii.Length - index);
		}

		/// <summary>Декодирует подстроку заданной длины, состоящую из одной или нескольких меток доменного имени, в соответствии со стандартом IDNA в строку символов Юникода.</summary>
		/// <param name="ascii">Строка для декодирования, состоящая из одной или нескольких меток в диапазоне символов US-ASCII (с U+0020 до U+007E), закодированных в соответствии со стандартом IDNA.</param>
		/// <param name="index">Нулевое смещение в <paramref name="ascii" />, которое указывает на начало подстроки.</param>
		/// <param name="count">Количество символов для преобразования в подстроку, которая начинается с места, указанного параметром <paramref name="index" /> в строке <paramref name="ascii" />.</param>
		/// <returns>Эквивалент подстроки IDNA, указанной в параметрах <paramref name="ascii" />, <paramref name="index" /> и <paramref name="count" />, в символах Юникода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="ascii" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> превышает длину <paramref name="ascii" />.  
		///
		/// или - 
		/// длина значения <paramref name="index" /> больше, чем длина <paramref name="ascii" /> минус <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ascii" /> не является допустимым на основе свойств <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> и <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" />, а также стандарта IDNA,</exception>
		// Token: 0x0600596A RID: 22890 RVA: 0x001326F4 File Offset: 0x001308F4
		public string GetUnicode(string ascii, int index, int count)
		{
			if (ascii == null)
			{
				throw new ArgumentNullException("ascii");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index must be non-negative value");
			}
			if (count < 0 || index + count > ascii.Length)
			{
				throw new ArgumentOutOfRangeException("index + count must point inside the argument ascii string");
			}
			return this.Convert(ascii, index, count, false);
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x00132744 File Offset: 0x00130944
		private string ToUnicode(string s, int offset)
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] >= '\u0080')
				{
					s = this.NamePrep(s, offset);
					break;
				}
			}
			if (!s.StartsWith("xn--", StringComparison.OrdinalIgnoreCase))
			{
				return s;
			}
			s = s.ToLower(CultureInfo.InvariantCulture);
			string strA = s;
			s = s.Substring(4);
			s = this.puny.Decode(s, offset);
			string result = s;
			s = this.ToAscii(s, offset);
			if (string.Compare(strA, s, StringComparison.OrdinalIgnoreCase) != 0)
			{
				throw new ArgumentException(string.Format("ToUnicode() failed at verifying the result, at label part from {0}", offset));
			}
			return result;
		}

		// Token: 0x04003756 RID: 14166
		private bool allow_unassigned;

		// Token: 0x04003757 RID: 14167
		private bool use_std3;

		// Token: 0x04003758 RID: 14168
		private Punycode puny = new Punycode();
	}
}
