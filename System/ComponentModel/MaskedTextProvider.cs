using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Text;

namespace System.ComponentModel
{
	/// <summary>Представляет службу разбора маски, которая может использоваться любым количеством элементов управления, поддерживающих маски, например элементом управления <see cref="T:System.Windows.Forms.MaskedTextBox" />.</summary>
	// Token: 0x020003D5 RID: 981
	public class MaskedTextProvider : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MaskedTextProvider" />, используя заданную маску.</summary>
		/// <param name="mask">Строка <see cref="T:System.String" />, представляющая маску ввода.</param>
		// Token: 0x06001FAF RID: 8111 RVA: 0x0006D94F File Offset: 0x0006BB4F
		public MaskedTextProvider(string mask) : this(mask, null, true, '_', '\0', false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MaskedTextProvider" />, используя заданную маску и значение ограничения ASCII.</summary>
		/// <param name="mask">Строка <see cref="T:System.String" />, представляющая маску ввода.</param>
		/// <param name="restrictToAscii">Значение <see langword="true" />, чтобы ограничить ввод ASCII-совместимыми знаками; в противном случае — значение <see langword="false" />, чтобы разрешить использовать полный набор Юникод.</param>
		// Token: 0x06001FB0 RID: 8112 RVA: 0x0006D95E File Offset: 0x0006BB5E
		public MaskedTextProvider(string mask, bool restrictToAscii) : this(mask, null, true, '_', '\0', restrictToAscii)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MaskedTextProvider" />, используя указанные маску и значения языка и региональных параметров.</summary>
		/// <param name="mask">Строка <see cref="T:System.String" />, представляющая маску ввода.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для задания зависимых от региона символов разделения.</param>
		// Token: 0x06001FB1 RID: 8113 RVA: 0x0006D96D File Offset: 0x0006BB6D
		public MaskedTextProvider(string mask, CultureInfo culture) : this(mask, culture, true, '_', '\0', false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MaskedTextProvider" />, используя заданную маску, язык и региональные параметры, а также значение ограничения ASCII.</summary>
		/// <param name="mask">Строка <see cref="T:System.String" />, представляющая маску ввода.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для задания зависимых от региона символов разделения.</param>
		/// <param name="restrictToAscii">Значение <see langword="true" />, чтобы ограничить ввод ASCII-совместимыми знаками; в противном случае — значение <see langword="false" />, чтобы разрешить использовать полный набор Юникод.</param>
		// Token: 0x06001FB2 RID: 8114 RVA: 0x0006D97C File Offset: 0x0006BB7C
		public MaskedTextProvider(string mask, CultureInfo culture, bool restrictToAscii) : this(mask, culture, true, '_', '\0', restrictToAscii)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MaskedTextProvider" />, используя заданную маску, знак пароля и значение использования приглашения.</summary>
		/// <param name="mask">Строка <see cref="T:System.String" />, представляющая маску ввода.</param>
		/// <param name="passwordChar">Знак <see cref="T:System.Char" />, отображаемый при вводе знаков в строке пароля.</param>
		/// <param name="allowPromptAsInput">Значение <see langword="true" />, разрешающее использовать знак приглашения в качестве ввода, в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001FB3 RID: 8115 RVA: 0x0006D98B File Offset: 0x0006BB8B
		public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput) : this(mask, null, allowPromptAsInput, '_', passwordChar, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MaskedTextProvider" />, используя заданную маску, язык и региональные параметры, знак пароля и значение использования приглашения.</summary>
		/// <param name="mask">Строка <see cref="T:System.String" />, представляющая маску ввода.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для задания зависимых от региона символов разделения.</param>
		/// <param name="passwordChar">Знак <see cref="T:System.Char" />, отображаемый при вводе знаков в строке пароля.</param>
		/// <param name="allowPromptAsInput">Значение <see langword="true" />, разрешающее использовать знак приглашения в качестве ввода, в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001FB4 RID: 8116 RVA: 0x0006D99A File Offset: 0x0006BB9A
		public MaskedTextProvider(string mask, CultureInfo culture, char passwordChar, bool allowPromptAsInput) : this(mask, culture, allowPromptAsInput, '_', passwordChar, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MaskedTextProvider" />, используя заданную маску, язык и региональные параметры, значение использования приглашения, символ приглашения, знак пароля и значение ограничения ASCII.</summary>
		/// <param name="mask">Строка <see cref="T:System.String" />, представляющая маску ввода.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для задания зависимых от региона символов разделения.</param>
		/// <param name="allowPromptAsInput">Значение <see cref="T:System.Boolean" />, определяющее, следует ли разрешать использование символа приглашения в качестве символа ввода значения.</param>
		/// <param name="promptChar">Знак <see cref="T:System.Char" />, который будет отображаться в качестве местозаполнителя для пользовательского ввода.</param>
		/// <param name="passwordChar">Знак <see cref="T:System.Char" />, отображаемый при вводе знаков в строке пароля.</param>
		/// <param name="restrictToAscii">Значение <see langword="true" />, чтобы ограничить ввод ASCII-совместимыми знаками; в противном случае — значение <see langword="false" />, чтобы разрешить использовать полный набор Юникод.</param>
		/// <exception cref="T:System.ArgumentException">Параметр маски имеет значение <see langword="null" /> или равен <see cref="F:System.String.Empty" />.  
		///
		/// или - 
		/// Маска содержит один или несколько непечатаемых символов.</exception>
		// Token: 0x06001FB5 RID: 8117 RVA: 0x0006D9AC File Offset: 0x0006BBAC
		public MaskedTextProvider(string mask, CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii)
		{
			if (string.IsNullOrEmpty(mask))
			{
				throw new ArgumentException(SR.Format("The Mask value cannot be null or empty.", Array.Empty<object>()), "mask");
			}
			for (int i = 0; i < mask.Length; i++)
			{
				if (!MaskedTextProvider.IsPrintableChar(mask[i]))
				{
					throw new ArgumentException("The specified mask contains invalid characters.");
				}
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			this._flagState = default(BitVector32);
			this.Mask = mask;
			this._promptChar = promptChar;
			this._passwordChar = passwordChar;
			if (culture.IsNeutralCulture)
			{
				foreach (CultureInfo cultureInfo in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
				{
					if (culture.Equals(cultureInfo.Parent))
					{
						this.Culture = cultureInfo;
						break;
					}
				}
				if (this.Culture == null)
				{
					this.Culture = CultureInfo.InvariantCulture;
				}
			}
			else
			{
				this.Culture = culture;
			}
			if (!this.Culture.IsReadOnly)
			{
				this.Culture = CultureInfo.ReadOnly(this.Culture);
			}
			this._flagState[MaskedTextProvider.s_ALLOW_PROMPT_AS_INPUT] = allowPromptAsInput;
			this._flagState[MaskedTextProvider.s_ASCII_ONLY] = restrictToAscii;
			this._flagState[MaskedTextProvider.s_INCLUDE_PROMPT] = false;
			this._flagState[MaskedTextProvider.s_INCLUDE_LITERALS] = true;
			this._flagState[MaskedTextProvider.s_RESET_ON_PROMPT] = true;
			this._flagState[MaskedTextProvider.s_SKIP_SPACE] = true;
			this._flagState[MaskedTextProvider.s_RESET_ON_LITERALS] = true;
			this.Initialize();
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		private void Initialize()
		{
			this._testString = new StringBuilder();
			this._stringDescriptor = new List<MaskedTextProvider.CharDescriptor>();
			MaskedTextProvider.CaseConversion caseConversion = MaskedTextProvider.CaseConversion.None;
			bool flag = false;
			int num = 0;
			MaskedTextProvider.CharType charType = MaskedTextProvider.CharType.Literal;
			string text = string.Empty;
			int i = 0;
			while (i < this.Mask.Length)
			{
				char c = this.Mask[i];
				if (!flag)
				{
					if (c <= 'C')
					{
						switch (c)
						{
						case '#':
							goto IL_19E;
						case '$':
							text = this.Culture.NumberFormat.CurrencySymbol;
							charType = MaskedTextProvider.CharType.Separator;
							goto IL_1BE;
						case '%':
							goto IL_1B8;
						case '&':
							break;
						default:
							switch (c)
							{
							case ',':
								text = this.Culture.NumberFormat.NumberGroupSeparator;
								charType = MaskedTextProvider.CharType.Separator;
								goto IL_1BE;
							case '-':
								goto IL_1B8;
							case '.':
								text = this.Culture.NumberFormat.NumberDecimalSeparator;
								charType = MaskedTextProvider.CharType.Separator;
								goto IL_1BE;
							case '/':
								text = this.Culture.DateTimeFormat.DateSeparator;
								charType = MaskedTextProvider.CharType.Separator;
								goto IL_1BE;
							case '0':
								break;
							default:
								switch (c)
								{
								case '9':
								case '?':
								case 'C':
									goto IL_19E;
								case ':':
									text = this.Culture.DateTimeFormat.TimeSeparator;
									charType = MaskedTextProvider.CharType.Separator;
									goto IL_1BE;
								case ';':
								case '=':
								case '@':
								case 'B':
									goto IL_1B8;
								case '<':
									caseConversion = MaskedTextProvider.CaseConversion.ToLower;
									goto IL_22A;
								case '>':
									caseConversion = MaskedTextProvider.CaseConversion.ToUpper;
									goto IL_22A;
								case 'A':
									break;
								default:
									goto IL_1B8;
								}
								break;
							}
							break;
						}
					}
					else if (c <= '\\')
					{
						if (c != 'L')
						{
							if (c != '\\')
							{
								goto IL_1B8;
							}
							flag = true;
							charType = MaskedTextProvider.CharType.Literal;
							goto IL_22A;
						}
					}
					else
					{
						if (c == 'a')
						{
							goto IL_19E;
						}
						if (c != '|')
						{
							goto IL_1B8;
						}
						caseConversion = MaskedTextProvider.CaseConversion.None;
						goto IL_22A;
					}
					this._requiredEditChars++;
					c = this._promptChar;
					charType = MaskedTextProvider.CharType.EditRequired;
					goto IL_1BE;
					IL_19E:
					this._optionalEditChars++;
					c = this._promptChar;
					charType = MaskedTextProvider.CharType.EditOptional;
					goto IL_1BE;
					IL_1B8:
					charType = MaskedTextProvider.CharType.Literal;
					goto IL_1BE;
				}
				flag = false;
				goto IL_1BE;
				IL_22A:
				i++;
				continue;
				IL_1BE:
				MaskedTextProvider.CharDescriptor charDescriptor = new MaskedTextProvider.CharDescriptor(i, charType);
				if (MaskedTextProvider.IsEditPosition(charDescriptor))
				{
					charDescriptor.CaseConversion = caseConversion;
				}
				if (charType != MaskedTextProvider.CharType.Separator)
				{
					text = c.ToString();
				}
				foreach (char value in text)
				{
					this._testString.Append(value);
					this._stringDescriptor.Add(charDescriptor);
					num++;
				}
				goto IL_22A;
			}
			this._testString.Capacity = this._testString.Length;
		}

		/// <summary>Возвращает значение, показывающее, следует ли рассматривать символ приглашения как допустимый знак ввода или нет.</summary>
		/// <returns>Значение <see langword="true" />, если пользователь может ввести любой символ <see cref="P:System.ComponentModel.MaskedTextProvider.PromptChar" /> в элемент управления; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0006DD91 File Offset: 0x0006BF91
		public bool AllowPromptAsInput
		{
			get
			{
				return this._flagState[MaskedTextProvider.s_ALLOW_PROMPT_AS_INPUT];
			}
		}

		/// <summary>Возвращает количество позиций редактируемых знаков, которым было успешно назначено введенное значение.</summary>
		/// <returns>Значение <see cref="T:System.Int32" /> содержит количество редактируемых позиций знаков в маске ввода, которым значение в форматированной строке уже назначено.</returns>
		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0006DDA3 File Offset: 0x0006BFA3
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x0006DDAB File Offset: 0x0006BFAB
		public int AssignedEditPositionCount { get; private set; }

		/// <summary>Возвращает количество редактируемых позиций знаков в маске ввода, которым еще не назначено вводимое значение.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, содержащее количество позиций редактируемых знаков, которым еще не было назначено символьное значение.</returns>
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x0006DDB4 File Offset: 0x0006BFB4
		public int AvailableEditPositionCount
		{
			get
			{
				return this.EditPositionCount - this.AssignedEditPositionCount;
			}
		}

		/// <summary>Создает копию текущего поставщика <see cref="T:System.ComponentModel.MaskedTextProvider" />.</summary>
		/// <returns>Поставщик <see cref="T:System.ComponentModel.MaskedTextProvider" />, созданный данным методом, приводится к форме объекта.</returns>
		// Token: 0x06001FBB RID: 8123 RVA: 0x0006DDC4 File Offset: 0x0006BFC4
		public object Clone()
		{
			Type type = base.GetType();
			MaskedTextProvider maskedTextProvider;
			if (type == MaskedTextProvider.s_maskTextProviderType)
			{
				maskedTextProvider = new MaskedTextProvider(this.Mask, this.Culture, this.AllowPromptAsInput, this.PromptChar, this.PasswordChar, this.AsciiOnly);
			}
			else
			{
				object[] args = new object[]
				{
					this.Mask,
					this.Culture,
					this.AllowPromptAsInput,
					this.PromptChar,
					this.PasswordChar,
					this.AsciiOnly
				};
				maskedTextProvider = (SecurityUtils.SecureCreateInstance(type, args) as MaskedTextProvider);
			}
			maskedTextProvider.ResetOnPrompt = false;
			maskedTextProvider.ResetOnSpace = false;
			maskedTextProvider.SkipLiterals = false;
			for (int i = 0; i < this._testString.Length; i++)
			{
				MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[i];
				if (MaskedTextProvider.IsEditPosition(charDescriptor) && charDescriptor.IsAssigned)
				{
					maskedTextProvider.Replace(this._testString[i], i);
				}
			}
			maskedTextProvider.ResetOnPrompt = this.ResetOnPrompt;
			maskedTextProvider.ResetOnSpace = this.ResetOnSpace;
			maskedTextProvider.SkipLiterals = this.SkipLiterals;
			maskedTextProvider.IncludeLiterals = this.IncludeLiterals;
			maskedTextProvider.IncludePrompt = this.IncludePrompt;
			return maskedTextProvider;
		}

		/// <summary>Возвращает язык и региональные параметры, определяющие значения локализуемых разделителей в маске ввода.</summary>
		/// <returns>Объект <see cref="T:System.Globalization.CultureInfo" />, содержащий сведения о языке и региональных параметрах, связанных с маской ввода.</returns>
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0006DF0B File Offset: 0x0006C10B
		public CultureInfo Culture { get; }

		/// <summary>Возвращает знак пароля по умолчанию, используемый, чтобы сделать невидимым ввод пользователя.</summary>
		/// <returns>Знак <see cref="T:System.Char" />, представляющий знак пароля по умолчанию.</returns>
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x0006DF13 File Offset: 0x0006C113
		public static char DefaultPasswordChar
		{
			get
			{
				return '*';
			}
		}

		/// <summary>Возвращает количество редактируемых позиций в форматируемой строке.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, содержащее количество редактируемых позиций в форматируемой строке.</returns>
		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0006DF17 File Offset: 0x0006C117
		public int EditPositionCount
		{
			get
			{
				return this._optionalEditChars + this._requiredEditChars;
			}
		}

		/// <summary>Возвращает вновь созданный перечислитель для редактируемых позиций в форматируемой строке.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IEnumerator" />, поддерживающий перечисление редактируемых позиций в форматируемой строке.</returns>
		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0006DF28 File Offset: 0x0006C128
		public IEnumerator EditPositions
		{
			get
			{
				List<int> list = new List<int>();
				int num = 0;
				using (List<MaskedTextProvider.CharDescriptor>.Enumerator enumerator = this._stringDescriptor.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (MaskedTextProvider.IsEditPosition(enumerator.Current))
						{
							list.Add(num);
						}
						num++;
					}
				}
				return ((IEnumerable)list).GetEnumerator();
			}
		}

		/// <summary>Получает или задает значение, показывающее, должны ли в форматируемую строку включаться литералы.</summary>
		/// <returns>Значение <see langword="true" />, если включаются литералы; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x0006DF94 File Offset: 0x0006C194
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0006DFA6 File Offset: 0x0006C1A6
		public bool IncludeLiterals
		{
			get
			{
				return this._flagState[MaskedTextProvider.s_INCLUDE_LITERALS];
			}
			set
			{
				this._flagState[MaskedTextProvider.s_INCLUDE_LITERALS] = value;
			}
		}

		/// <summary>Получает или задает значение, показывающее, используется ли знак <see cref="P:System.Windows.Forms.MaskedTextBox.PromptChar" /> для представления отсутствия пользовательского ввода при отображении форматируемой строки.</summary>
		/// <returns>Значение <see langword="true" />, если знак приглашения используется для представления позиций, в которых отсутствует пользовательский ввод; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x0006DFB9 File Offset: 0x0006C1B9
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x0006DFCB File Offset: 0x0006C1CB
		public bool IncludePrompt
		{
			get
			{
				return this._flagState[MaskedTextProvider.s_INCLUDE_PROMPT];
			}
			set
			{
				this._flagState[MaskedTextProvider.s_INCLUDE_PROMPT] = value;
			}
		}

		/// <summary>Возвращает значение, показывающее, принимает ли маска знаки, не входящие в набор знаков ASCII.</summary>
		/// <returns>Значение <see langword="true" />, если допустимы только знаки ASCII; значение <see langword="false" />, если поставщик <see cref="T:System.ComponentModel.MaskedTextProvider" /> может принимать любой знак Юникода. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x0006DFDE File Offset: 0x0006C1DE
		public bool AsciiOnly
		{
			get
			{
				return this._flagState[MaskedTextProvider.s_ASCII_ONLY];
			}
		}

		/// <summary>Получает или задает значение, определяющее, должна ли к форматируемой строке применяться защита паролем.</summary>
		/// <returns>Значение <see langword="true" />, если входная строка должна рассматриваться как строка пароля, в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0006DFF0 File Offset: 0x0006C1F0
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x0006DFFB File Offset: 0x0006C1FB
		public bool IsPassword
		{
			get
			{
				return this._passwordChar > '\0';
			}
			set
			{
				if (this.IsPassword != value)
				{
					this._passwordChar = (value ? MaskedTextProvider.DefaultPasswordChar : '\0');
				}
			}
		}

		/// <summary>Возвращает верхнюю границу диапазона неправильных индексов.</summary>
		/// <returns>Значение, представляющее максимальный неправильный индекс, определяемый реализацией поставщика. Например, если минимальный допустимый индекс равен 0, это свойство возвращает -1.</returns>
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000521EC File Offset: 0x000503EC
		public static int InvalidIndex
		{
			get
			{
				return -1;
			}
		}

		/// <summary>Возвращает индекс в маске для крайнего правого введенного знака, назначенного маске.</summary>
		/// <returns>Если хотя бы одни введенный знак назначен маске — значение <see cref="T:System.Int32" />, содержащее индекс в маске для крайней правой назначенной позиции знака; в противном случае, если позиция не назначена — свойство <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0006E017 File Offset: 0x0006C217
		public int LastAssignedPosition
		{
			get
			{
				return this.FindAssignedEditPositionFrom(this._testString.Length - 1, false);
			}
		}

		/// <summary>Возвращает длину маски, кроме знаков-модификаторов маски.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, содержащее количество позиций в маске за исключением знаков, изменяющих ввод для маски.</returns>
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0006E02D File Offset: 0x0006C22D
		public int Length
		{
			get
			{
				return this._testString.Length;
			}
		}

		/// <summary>Возвращаем маску ввода.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая полную маску.</returns>
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0006E03A File Offset: 0x0006C23A
		public string Mask { get; }

		/// <summary>Возвращает значение, показывающее, были ли введены в форматируемую строку все необходимые знаки.</summary>
		/// <returns>Значение <see langword="true" />, если в маске ведены все необходимые знаки; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x0006E042 File Offset: 0x0006C242
		public bool MaskCompleted
		{
			get
			{
				return this._requiredCharCount == this._requiredEditChars;
			}
		}

		/// <summary>Возвращает значение, показывающее, были ли введены в форматируемую строку все обязательные и необязательные знаки.</summary>
		/// <returns>Значение <see langword="true" />, если были введены все обязательные необходимые и необязательные знаки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0006E052 File Offset: 0x0006C252
		public bool MaskFull
		{
			get
			{
				return this.AssignedEditPositionCount == this.EditPositionCount;
			}
		}

		/// <summary>Получает или задает знак, используемый для подстановки фактически введенных знаков.</summary>
		/// <returns>Значение <see cref="T:System.Char" />, используемое в качестве знака пароля.</returns>
		/// <exception cref="T:System.InvalidOperationException">Знак пароля, заданный при определении этого свойства, совпадает с текущим знаком приглашения, <see cref="P:System.ComponentModel.MaskedTextProvider.PromptChar" />. Эти два знака должны отличаться.</exception>
		/// <exception cref="T:System.ArgumentException">Знак, заданный при определении этого свойства, не является допустимым знаком пароля, определенным методом <see cref="M:System.ComponentModel.MaskedTextProvider.IsValidPasswordChar(System.Char)" />.</exception>
		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0006E062 File Offset: 0x0006C262
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0006E06A File Offset: 0x0006C26A
		public char PasswordChar
		{
			get
			{
				return this._passwordChar;
			}
			set
			{
				if (value == this._promptChar)
				{
					throw new InvalidOperationException("The PasswordChar and PromptChar values cannot be the same.");
				}
				if (!MaskedTextProvider.IsValidPasswordChar(value) && value != '\0')
				{
					throw new ArgumentException("The specified character value is not allowed for this property.");
				}
				if (value != this._passwordChar)
				{
					this._passwordChar = value;
				}
			}
		}

		/// <summary>Получает или задает знак, используемый для представления отсутствия пользовательского ввода для всех доступных позиций редактирования.</summary>
		/// <returns>Знак, предлагающий пользователю ввести данные. По умолчанию это знак подчеркивания (_).</returns>
		/// <exception cref="T:System.InvalidOperationException">Знак приглашения, заданный при определении этого свойства, совпадает с текущим знаком пароля, <see cref="P:System.ComponentModel.MaskedTextProvider.PasswordChar" />. Эти два знака должны отличаться.</exception>
		/// <exception cref="T:System.ArgumentException">Знак, заданный при определении этого свойства, не является допустимым знаком пароля, определенным методом <see cref="M:System.ComponentModel.MaskedTextProvider.IsValidPasswordChar(System.Char)" />.</exception>
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0006E0A6 File Offset: 0x0006C2A6
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0006E0B0 File Offset: 0x0006C2B0
		public char PromptChar
		{
			get
			{
				return this._promptChar;
			}
			set
			{
				if (value == this._passwordChar)
				{
					throw new InvalidOperationException("The PasswordChar and PromptChar values cannot be the same.");
				}
				if (!MaskedTextProvider.IsPrintableChar(value))
				{
					throw new ArgumentException("The specified character value is not allowed for this property.");
				}
				if (value != this._promptChar)
				{
					this._promptChar = value;
					for (int i = 0; i < this._testString.Length; i++)
					{
						MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[i];
						if (this.IsEditPosition(i) && !charDescriptor.IsAssigned)
						{
							this._testString[i] = this._promptChar;
						}
					}
				}
			}
		}

		/// <summary>Возвращает или задает значение, определяющее способ обработки введенного символа, совпадающего с символом приглашения.</summary>
		/// <returns>Значение <see langword="true" />, если ввод знака приглашения вызывает сброс текущей редактируемой позиции в маске; в противном случае — значение <see langword="false" />, чтобы показать, что знак приглашения должен обрабатываться как обычный введенный знак. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0006E13A File Offset: 0x0006C33A
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0006E14C File Offset: 0x0006C34C
		public bool ResetOnPrompt
		{
			get
			{
				return this._flagState[MaskedTextProvider.s_RESET_ON_PROMPT];
			}
			set
			{
				this._flagState[MaskedTextProvider.s_RESET_ON_PROMPT] = value;
			}
		}

		/// <summary>Возвращает или задает значение, определяющее способ обработки введенного знака пробела.</summary>
		/// <returns>Значение <see langword="true" />, если введенный знак пробела вызывает сброс текущей редактируемой позиции в маске, в противном случае — значение <see langword="false" />, показывающее, что этот знак должен обрабатываться как обычный введенный знак. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0006E15F File Offset: 0x0006C35F
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0006E171 File Offset: 0x0006C371
		public bool ResetOnSpace
		{
			get
			{
				return this._flagState[MaskedTextProvider.s_SKIP_SPACE];
			}
			set
			{
				this._flagState[MaskedTextProvider.s_SKIP_SPACE] = value;
			}
		}

		/// <summary>Получает или задает значение, показывающее можно ли использовать для переопределения позиций литералов те же самые буквенные значения.</summary>
		/// <returns>Значение <see langword="true" />, чтобы позволить добавлять литералы; в противном случае — значение <see langword="false" />, не позволяющее пользователю переопределять литералы. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0006E184 File Offset: 0x0006C384
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0006E196 File Offset: 0x0006C396
		public bool SkipLiterals
		{
			get
			{
				return this._flagState[MaskedTextProvider.s_RESET_ON_LITERALS];
			}
			set
			{
				this._flagState[MaskedTextProvider.s_RESET_ON_LITERALS] = value;
			}
		}

		/// <summary>Возвращает элемент в заданной позиции форматируемой строки.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс извлекаемого элемента.</param>
		/// <returns>Знак <see cref="T:System.Char" /> в заданной позиции форматируемой строки.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> меньше нуля либо больше или равен значению свойства <see cref="P:System.ComponentModel.MaskedTextProvider.Length" /> маски.</exception>
		// Token: 0x17000690 RID: 1680
		public char this[int index]
		{
			get
			{
				if (index < 0 || index >= this._testString.Length)
				{
					throw new IndexOutOfRangeException(index.ToString(CultureInfo.CurrentCulture));
				}
				return this._testString[index];
			}
		}

		/// <summary>Добавляет указанный введенный знак в конец форматируемой строки.</summary>
		/// <param name="input">Значение <see cref="T:System.Char" />, добавляемое в форматируемую строку.</param>
		/// <returns>Значение <see langword="true" />, если введенный знак был успешно добавлен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FD8 RID: 8152 RVA: 0x0006E1DC File Offset: 0x0006C3DC
		public bool Add(char input)
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.Add(input, out num, out maskedTextResultHint);
		}

		/// <summary>Добавляет заданный введенный знак в конец форматируемой строки, а затем выводит позицию и описательные сведения.</summary>
		/// <param name="input">Значение <see cref="T:System.Char" />, добавляемое в форматируемую строку.</param>
		/// <param name="testPosition">Отсчитываемая от нуля позиция форматируемой строки, в которую была предпринята попытка добавить знак. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если введенный знак был успешно добавлен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FD9 RID: 8153 RVA: 0x0006E1F4 File Offset: 0x0006C3F4
		public bool Add(char input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			int lastAssignedPosition = this.LastAssignedPosition;
			if (lastAssignedPosition == this._testString.Length - 1)
			{
				testPosition = this._testString.Length;
				resultHint = MaskedTextResultHint.UnavailableEditPosition;
				return false;
			}
			testPosition = lastAssignedPosition + 1;
			testPosition = this.FindEditPositionFrom(testPosition, true);
			if (testPosition == -1)
			{
				resultHint = MaskedTextResultHint.UnavailableEditPosition;
				testPosition = this._testString.Length;
				return false;
			}
			return this.TestSetChar(input, testPosition, out resultHint);
		}

		/// <summary>Добавляет в конец форматируемой строки знаки заданной входной строки.</summary>
		/// <param name="input">Строка <see cref="T:System.String" />, содержащая значения знаков, добавляемых в форматируемую строку.</param>
		/// <returns>Значение <see langword="true" />, если все знаки входной строки были успешно добавлены; в противном случае — значение <see langword="false" />, показывающее, что никакие знаки не были добавлены.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001FDA RID: 8154 RVA: 0x0006E264 File Offset: 0x0006C464
		public bool Add(string input)
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.Add(input, out num, out maskedTextResultHint);
		}

		/// <summary>Добавляет знаки заданной входной строки в конец форматируемой строки, а затем выводит позицию и описательные сведения.</summary>
		/// <param name="input">Строка <see cref="T:System.String" />, содержащая значения знаков, добавляемых в форматируемую строку.</param>
		/// <param name="testPosition">Отсчитываемая от нуля позиция форматируемой строки, в которую была предпринята попытка добавить знак. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если все знаки входной строки были успешно добавлены; в противном случае — значение <see langword="false" />, показывающее, что никакие знаки не были добавлены.</returns>
		// Token: 0x06001FDB RID: 8155 RVA: 0x0006E27C File Offset: 0x0006C47C
		public bool Add(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			testPosition = this.LastAssignedPosition + 1;
			if (input.Length == 0)
			{
				resultHint = MaskedTextResultHint.NoEffect;
				return true;
			}
			return this.TestSetString(input, testPosition, out testPosition, out resultHint);
		}

		/// <summary>Удаляет все введенные редактируемые знаки из форматируемой строки, заменяя их знаками приглашения.</summary>
		// Token: 0x06001FDC RID: 8156 RVA: 0x0006E2B0 File Offset: 0x0006C4B0
		public void Clear()
		{
			MaskedTextResultHint maskedTextResultHint;
			this.Clear(out maskedTextResultHint);
		}

		/// <summary>Удаляет все введенные редактируемые знаки из форматируемой строки, заменяя их знаками приглашения, а затем выводя описательные сведения.</summary>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции. Выходной параметр.</param>
		// Token: 0x06001FDD RID: 8157 RVA: 0x0006E2C8 File Offset: 0x0006C4C8
		public void Clear(out MaskedTextResultHint resultHint)
		{
			if (this.AssignedEditPositionCount == 0)
			{
				resultHint = MaskedTextResultHint.NoEffect;
				return;
			}
			resultHint = MaskedTextResultHint.Success;
			for (int i = 0; i < this._testString.Length; i++)
			{
				this.ResetChar(i);
			}
		}

		/// <summary>Возвращает позицию первой назначенной редактируемой позиции после заданной позиции, используя заданное направление поиска.</summary>
		/// <param name="position">Отсчитываемая от нуля позиция в форматируемой строке для начала поиска.</param>
		/// <param name="direction">Значение типа <see cref="T:System.Boolean" />, показывающее направление поиска: <see langword="true" /> для поиска в направлении вперед или <see langword="false" /> для поиска в направлении назад.</param>
		/// <returns>При успешном выполнении — значение <see cref="T:System.Int32" />, представляющее отсчитываемую от нуля позицию первой встреченной назначенной редактируемой позиции, в противном случае — значение <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x06001FDE RID: 8158 RVA: 0x0006E304 File Offset: 0x0006C504
		public int FindAssignedEditPositionFrom(int position, bool direction)
		{
			if (this.AssignedEditPositionCount == 0)
			{
				return -1;
			}
			int startPosition;
			int endPosition;
			if (direction)
			{
				startPosition = position;
				endPosition = this._testString.Length - 1;
			}
			else
			{
				startPosition = 0;
				endPosition = position;
			}
			return this.FindAssignedEditPositionInRange(startPosition, endPosition, direction);
		}

		/// <summary>Возвращает позицию первой назначенной редактируемой позиции между заданными позициями, используя заданное направление поиска.</summary>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается поиск.</param>
		/// <param name="endPosition">Отсчитываемая от нуля позиция в форматируемой строке, в которой будет заканчиваться поиск.</param>
		/// <param name="direction">Значение типа <see cref="T:System.Boolean" />, показывающее направление поиска: <see langword="true" /> для поиска в направлении вперед или <see langword="false" /> для поиска в направлении назад.</param>
		/// <returns>При успешном выполнении — значение <see cref="T:System.Int32" />, представляющее отсчитываемую от нуля позицию первой встреченной назначенной редактируемой позиции, в противном случае — значение <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x06001FDF RID: 8159 RVA: 0x0006E33D File Offset: 0x0006C53D
		public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			if (this.AssignedEditPositionCount == 0)
			{
				return -1;
			}
			return this.FindEditPositionInRange(startPosition, endPosition, direction, 2);
		}

		/// <summary>Возвращает позицию первой редактируемой позиции после заданной позиции, используя заданное направление поиска.</summary>
		/// <param name="position">Отсчитываемая от нуля позиция в форматируемой строке для начала поиска.</param>
		/// <param name="direction">Значение типа <see cref="T:System.Boolean" />, показывающее направление поиска: <see langword="true" /> для поиска в направлении вперед или <see langword="false" /> для поиска в направлении назад.</param>
		/// <returns>При успешном выполнении — значение <see cref="T:System.Int32" />, представляющее отсчитываемую от нуля позицию первой встреченной редактируемой позиции, в противном случае — значение <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x06001FE0 RID: 8160 RVA: 0x0006E354 File Offset: 0x0006C554
		public int FindEditPositionFrom(int position, bool direction)
		{
			int startPosition;
			int endPosition;
			if (direction)
			{
				startPosition = position;
				endPosition = this._testString.Length - 1;
			}
			else
			{
				startPosition = 0;
				endPosition = position;
			}
			return this.FindEditPositionInRange(startPosition, endPosition, direction);
		}

		/// <summary>Возвращает позицию первой редактируемой позиции между заданными позициями, используя заданное направление поиска.</summary>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается поиск.</param>
		/// <param name="endPosition">Отсчитываемая от нуля позиция в форматируемой строке, в которой будет заканчиваться поиск.</param>
		/// <param name="direction">Значение типа <see cref="T:System.Boolean" />, показывающее направление поиска: <see langword="true" /> для поиска в направлении вперед или <see langword="false" /> для поиска в направлении назад.</param>
		/// <returns>При успешном выполнении — значение <see cref="T:System.Int32" />, представляющее отсчитываемую от нуля позицию первой встреченной редактируемой позиции, в противном случае — значение <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x06001FE1 RID: 8161 RVA: 0x0006E384 File Offset: 0x0006C584
		public int FindEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			MaskedTextProvider.CharType charTypeFlags = MaskedTextProvider.CharType.EditOptional | MaskedTextProvider.CharType.EditRequired;
			return this.FindPositionInRange(startPosition, endPosition, direction, charTypeFlags);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0006E3A0 File Offset: 0x0006C5A0
		private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, byte assignedStatus)
		{
			int num;
			for (;;)
			{
				num = this.FindEditPositionInRange(startPosition, endPosition, direction);
				if (num == -1)
				{
					return -1;
				}
				MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[num];
				if (assignedStatus != 1)
				{
					if (assignedStatus != 2)
					{
						break;
					}
					if (charDescriptor.IsAssigned)
					{
						return num;
					}
				}
				else if (!charDescriptor.IsAssigned)
				{
					return num;
				}
				if (direction)
				{
					startPosition++;
				}
				else
				{
					endPosition--;
				}
				if (startPosition > endPosition)
				{
					return -1;
				}
			}
			return num;
		}

		/// <summary>Возвращает позицию первой нередактируемой позиции после заданной позиции, используя заданное направление поиска.</summary>
		/// <param name="position">Отсчитываемая от нуля позиция в форматируемой строке для начала поиска.</param>
		/// <param name="direction">Значение типа <see cref="T:System.Boolean" />, показывающее направление поиска: <see langword="true" /> для поиска в направлении вперед или <see langword="false" /> для поиска в направлении назад.</param>
		/// <returns>При успешном выполнении — значение <see cref="T:System.Int32" />, представляющее отсчитываемую от нуля позицию первого встреченного литерала, в противном случае — значение <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x06001FE3 RID: 8163 RVA: 0x0006E400 File Offset: 0x0006C600
		public int FindNonEditPositionFrom(int position, bool direction)
		{
			int startPosition;
			int endPosition;
			if (direction)
			{
				startPosition = position;
				endPosition = this._testString.Length - 1;
			}
			else
			{
				startPosition = 0;
				endPosition = position;
			}
			return this.FindNonEditPositionInRange(startPosition, endPosition, direction);
		}

		/// <summary>Возвращает позицию первой нередактируемой позиции между заданными позициями, используя заданное направление поиска.</summary>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается поиск.</param>
		/// <param name="endPosition">Отсчитываемая от нуля позиция в форматируемой строке, в которой будет заканчиваться поиск.</param>
		/// <param name="direction">Значение типа <see cref="T:System.Boolean" />, показывающее направление поиска: <see langword="true" /> для поиска в направлении вперед или <see langword="false" /> для поиска в направлении назад.</param>
		/// <returns>При успешном выполнении — значение <see cref="T:System.Int32" />, представляющее отсчитываемую от нуля позицию первого встреченного литерала, в противном случае — значение <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x06001FE4 RID: 8164 RVA: 0x0006E430 File Offset: 0x0006C630
		public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			MaskedTextProvider.CharType charTypeFlags = MaskedTextProvider.CharType.Separator | MaskedTextProvider.CharType.Literal;
			return this.FindPositionInRange(startPosition, endPosition, direction, charTypeFlags);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0006E44C File Offset: 0x0006C64C
		private int FindPositionInRange(int startPosition, int endPosition, bool direction, MaskedTextProvider.CharType charTypeFlags)
		{
			if (startPosition < 0)
			{
				startPosition = 0;
			}
			if (endPosition >= this._testString.Length)
			{
				endPosition = this._testString.Length - 1;
			}
			if (startPosition > endPosition)
			{
				return -1;
			}
			while (startPosition <= endPosition)
			{
				int num;
				if (!direction)
				{
					endPosition = (num = endPosition) - 1;
				}
				else
				{
					startPosition = (num = startPosition) + 1;
				}
				int num2 = num;
				MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[num2];
				if ((charDescriptor.CharType & charTypeFlags) == charDescriptor.CharType)
				{
					return num2;
				}
			}
			return -1;
		}

		/// <summary>Возвращает позицию первой неназначенной редактируемой позиции после заданной позиции, используя заданное направление поиска.</summary>
		/// <param name="position">Отсчитываемая от нуля позиция в форматируемой строке для начала поиска.</param>
		/// <param name="direction">Значение типа <see cref="T:System.Boolean" />, показывающее направление поиска: <see langword="true" /> для поиска в направлении вперед или <see langword="false" /> для поиска в направлении назад.</param>
		/// <returns>При успешном выполнении — значение <see cref="T:System.Int32" />, представляющее отсчитываемую от нуля позицию первой встреченной неназначенной редактируемой позиции, в противном случае — значение <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x06001FE6 RID: 8166 RVA: 0x0006E4BC File Offset: 0x0006C6BC
		public int FindUnassignedEditPositionFrom(int position, bool direction)
		{
			int startPosition;
			int endPosition;
			if (direction)
			{
				startPosition = position;
				endPosition = this._testString.Length - 1;
			}
			else
			{
				startPosition = 0;
				endPosition = position;
			}
			return this.FindEditPositionInRange(startPosition, endPosition, direction, 1);
		}

		/// <summary>Возвращает позицию первой неназначенной редактируемой позиции между заданными позициями, используя заданное направление поиска.</summary>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается поиск.</param>
		/// <param name="endPosition">Отсчитываемая от нуля позиция в форматируемой строке, в которой будет заканчиваться поиск.</param>
		/// <param name="direction">Значение типа <see cref="T:System.Boolean" />, показывающее направление поиска: <see langword="true" /> для поиска в направлении вперед или <see langword="false" /> для поиска в направлении назад.</param>
		/// <returns>При успешном выполнении — значение <see cref="T:System.Int32" />, представляющее отсчитываемую от нуля позицию первой встреченной неназначенной редактируемой позиции, в противном случае — значение <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		// Token: 0x06001FE7 RID: 8167 RVA: 0x0006E4EC File Offset: 0x0006C6EC
		public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			for (;;)
			{
				int num = this.FindEditPositionInRange(startPosition, endPosition, direction, 0);
				if (num == -1)
				{
					break;
				}
				if (!this._stringDescriptor[num].IsAssigned)
				{
					return num;
				}
				if (direction)
				{
					startPosition++;
				}
				else
				{
					endPosition--;
				}
			}
			return -1;
		}

		/// <summary>Определяет, указывает ли объект <see cref="T:System.ComponentModel.MaskedTextResultHint" /> на удачное или неудачное выполнение.</summary>
		/// <param name="hint">Значение <see cref="T:System.ComponentModel.MaskedTextResultHint" />, обычно получаемое как выходной параметр предыдущей операции.</param>
		/// <returns>Значение <see langword="true" />, если заданное значение <see cref="T:System.ComponentModel.MaskedTextResultHint" /> представляет успешное завершение; в противном случае — значение <see langword="false" />, если значение объекта сообщает о неудачном выполнении.</returns>
		// Token: 0x06001FE8 RID: 8168 RVA: 0x0006E52F File Offset: 0x0006C72F
		public static bool GetOperationResultFromHint(MaskedTextResultHint hint)
		{
			return hint > MaskedTextResultHint.Unknown;
		}

		/// <summary>Вставляет заданный знак в заданную позицию форматируемой строки.</summary>
		/// <param name="input">Вставляемый объект <see cref="T:System.Char" />.</param>
		/// <param name="position">Отсчитываемая от нуля позиция для вставки знака в форматируемую строку.</param>
		/// <returns>Значение <see langword="true" />, если вставка прошла успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FE9 RID: 8169 RVA: 0x0006E535 File Offset: 0x0006C735
		public bool InsertAt(char input, int position)
		{
			return position >= 0 && position < this._testString.Length && this.InsertAt(input.ToString(), position);
		}

		/// <summary>Вставляет заданный знак в заданную позицию форматируемой строки, возвращая последнюю позицию вставки и статус операции.</summary>
		/// <param name="input">Вставляемый объект <see cref="T:System.Char" />.</param>
		/// <param name="position">Отсчитываемая от нуля позиция для вставки знака в форматируемую строку.</param>
		/// <param name="testPosition">При успешном выполнении метода — последняя позиция, в которой был вставлен знак; в противном случае — первая позиция, вставка в которую закончилась неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции вставки. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если вставка прошла успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FEA RID: 8170 RVA: 0x0006E559 File Offset: 0x0006C759
		public bool InsertAt(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			return this.InsertAt(input.ToString(), position, out testPosition, out resultHint);
		}

		/// <summary>Вставляет заданную строку в заданную позицию форматируемой строки.</summary>
		/// <param name="input">Вставляемый объект <see cref="T:System.String" />.</param>
		/// <param name="position">Отсчитываемая от нуля позиция для вставки входной строки в форматируемую строку.</param>
		/// <returns>Значение <see langword="true" />, если вставка прошла успешно; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001FEB RID: 8171 RVA: 0x0006E56C File Offset: 0x0006C76C
		public bool InsertAt(string input, int position)
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.InsertAt(input, position, out num, out maskedTextResultHint);
		}

		/// <summary>Вставляет заданную строку в заданную позицию форматируемой строки, возвращая последнюю позицию вставки и статус операции.</summary>
		/// <param name="input">Вставляемый объект <see cref="T:System.String" />.</param>
		/// <param name="position">Отсчитываемая от нуля позиция для вставки входной строки в форматируемую строку.</param>
		/// <param name="testPosition">При успешном выполнении метода — последняя позиция, в которой был вставлен знак; в противном случае — первая позиция, вставка в которую закончилась неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции вставки. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если вставка прошла успешно; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001FEC RID: 8172 RVA: 0x0006E585 File Offset: 0x0006C785
		public bool InsertAt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (position < 0 || position >= this._testString.Length)
			{
				testPosition = position;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			return this.InsertAtInt(input, position, out testPosition, out resultHint, false);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0006E5C0 File Offset: 0x0006C7C0
		private bool InsertAtInt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			if (input.Length == 0)
			{
				testPosition = position;
				resultHint = MaskedTextResultHint.NoEffect;
				return true;
			}
			if (!this.TestString(input, position, out testPosition, out resultHint))
			{
				return false;
			}
			int i = this.FindEditPositionFrom(position, true);
			bool flag = this.FindAssignedEditPositionInRange(i, testPosition, true) != -1;
			int lastAssignedPosition = this.LastAssignedPosition;
			if (flag && testPosition == this._testString.Length - 1)
			{
				resultHint = MaskedTextResultHint.UnavailableEditPosition;
				testPosition = this._testString.Length;
				return false;
			}
			int num = this.FindEditPositionFrom(testPosition + 1, true);
			if (flag)
			{
				MaskedTextResultHint maskedTextResultHint = MaskedTextResultHint.Unknown;
				while (num != -1)
				{
					if (this._stringDescriptor[i].IsAssigned && !this.TestChar(this._testString[i], num, out maskedTextResultHint))
					{
						resultHint = maskedTextResultHint;
						testPosition = num;
						return false;
					}
					if (i != lastAssignedPosition)
					{
						i = this.FindEditPositionFrom(i + 1, true);
						num = this.FindEditPositionFrom(num + 1, true);
					}
					else
					{
						if (maskedTextResultHint > resultHint)
						{
							resultHint = maskedTextResultHint;
							goto IL_EF;
						}
						goto IL_EF;
					}
				}
				resultHint = MaskedTextResultHint.UnavailableEditPosition;
				testPosition = this._testString.Length;
				return false;
			}
			IL_EF:
			if (testOnly)
			{
				return true;
			}
			if (flag)
			{
				while (i >= position)
				{
					if (this._stringDescriptor[i].IsAssigned)
					{
						this.SetChar(this._testString[i], num);
					}
					else
					{
						this.ResetChar(num);
					}
					num = this.FindEditPositionFrom(num - 1, false);
					i = this.FindEditPositionFrom(i - 1, false);
				}
			}
			this.SetString(input, position);
			return true;
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0006E719 File Offset: 0x0006C919
		private static bool IsAscii(char c)
		{
			return c >= '!' && c <= '~';
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0006E72A File Offset: 0x0006C92A
		private static bool IsAciiAlphanumeric(char c)
		{
			return (c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0006E751 File Offset: 0x0006C951
		private static bool IsAlphanumeric(char c)
		{
			return char.IsLetter(c) || char.IsDigit(c);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0006E763 File Offset: 0x0006C963
		private static bool IsAsciiLetter(char c)
		{
			return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
		}

		/// <summary>Определяет, доступна ли заданная позиция для назначения.</summary>
		/// <param name="position">Отсчитываемая от нуля проверяемая позиция в маске.</param>
		/// <returns>Значение <see langword="true" />, если заданная позиция форматируемой строки является редактируемой и ей еще не было назначено значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FF2 RID: 8178 RVA: 0x0006E780 File Offset: 0x0006C980
		public bool IsAvailablePosition(int position)
		{
			if (position < 0 || position >= this._testString.Length)
			{
				return false;
			}
			MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[position];
			return MaskedTextProvider.IsEditPosition(charDescriptor) && !charDescriptor.IsAssigned;
		}

		/// <summary>Определяет, является заданная позиция редактируемой.</summary>
		/// <param name="position">Отсчитываемая от нуля проверяемая позиция в маске.</param>
		/// <returns>Значение <see langword="true" />, если заданная позиция форматируемой строки является редактируемой; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FF3 RID: 8179 RVA: 0x0006E7C1 File Offset: 0x0006C9C1
		public bool IsEditPosition(int position)
		{
			return position >= 0 && position < this._testString.Length && MaskedTextProvider.IsEditPosition(this._stringDescriptor[position]);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0006E7E8 File Offset: 0x0006C9E8
		private static bool IsEditPosition(MaskedTextProvider.CharDescriptor charDescriptor)
		{
			return charDescriptor.CharType == MaskedTextProvider.CharType.EditRequired || charDescriptor.CharType == MaskedTextProvider.CharType.EditOptional;
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0006E7FE File Offset: 0x0006C9FE
		private static bool IsLiteralPosition(MaskedTextProvider.CharDescriptor charDescriptor)
		{
			return charDescriptor.CharType == MaskedTextProvider.CharType.Literal || charDescriptor.CharType == MaskedTextProvider.CharType.Separator;
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0006E814 File Offset: 0x0006CA14
		private static bool IsPrintableChar(char c)
		{
			return char.IsLetterOrDigit(c) || char.IsPunctuation(c) || char.IsSymbol(c) || c == ' ';
		}

		/// <summary>Определяет, является ли заданный знак допустимым для ввода знаком.</summary>
		/// <param name="c">Проверяемое значение <see cref="T:System.Char" />.</param>
		/// <returns>Значение <see langword="true" />, если заданный знак содержит допустимое для ввода значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FF7 RID: 8183 RVA: 0x0006E835 File Offset: 0x0006CA35
		public static bool IsValidInputChar(char c)
		{
			return MaskedTextProvider.IsPrintableChar(c);
		}

		/// <summary>Определяет, является ли заданный знак допустимым знаком маски.</summary>
		/// <param name="c">Проверяемое значение <see cref="T:System.Char" />.</param>
		/// <returns>Значение <see langword="true" />, если заданный знак содержит допустимое значение маски; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FF8 RID: 8184 RVA: 0x0006E835 File Offset: 0x0006CA35
		public static bool IsValidMaskChar(char c)
		{
			return MaskedTextProvider.IsPrintableChar(c);
		}

		/// <summary>Определяет, является ли заданный знак допустимым знаком пароля.</summary>
		/// <param name="c">Проверяемое значение <see cref="T:System.Char" />.</param>
		/// <returns>Значение <see langword="true" />, если заданный знак содержит допустимое значение пароля; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FF9 RID: 8185 RVA: 0x0006E83D File Offset: 0x0006CA3D
		public static bool IsValidPasswordChar(char c)
		{
			return MaskedTextProvider.IsPrintableChar(c) || c == '\0';
		}

		/// <summary>Удаляет последний назначенный знак из форматируемой строки.</summary>
		/// <returns>Значение <see langword="true" />, если знак успешно удален, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FFA RID: 8186 RVA: 0x0006E850 File Offset: 0x0006CA50
		public bool Remove()
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.Remove(out num, out maskedTextResultHint);
		}

		/// <summary>Удаляет последний назначенный знак из форматируемой строки, а затем выводит позицию удаления и описательные сведения.</summary>
		/// <param name="testPosition">Отсчитываемая от нуля позиция в форматируемой строке, в которой был фактически удален знак. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если знак успешно удален, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FFB RID: 8187 RVA: 0x0006E868 File Offset: 0x0006CA68
		public bool Remove(out int testPosition, out MaskedTextResultHint resultHint)
		{
			int lastAssignedPosition = this.LastAssignedPosition;
			if (lastAssignedPosition == -1)
			{
				testPosition = 0;
				resultHint = MaskedTextResultHint.NoEffect;
				return true;
			}
			this.ResetChar(lastAssignedPosition);
			testPosition = lastAssignedPosition;
			resultHint = MaskedTextResultHint.Success;
			return true;
		}

		/// <summary>Удаляет назначенный знак в заданной позиции форматируемой строки.</summary>
		/// <param name="position">Отсчитываемая от нуля позиция удаляемого назначенного знака.</param>
		/// <returns>Значение <see langword="true" />, если знак успешно удален, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FFC RID: 8188 RVA: 0x0006E896 File Offset: 0x0006CA96
		public bool RemoveAt(int position)
		{
			return this.RemoveAt(position, position);
		}

		/// <summary>Удаляет назначенные знаки между заданными позициями форматируемой строки.</summary>
		/// <param name="startPosition">Отсчитываемый от нуля индекс первого удаляемого назначенного знака.</param>
		/// <param name="endPosition">Отсчитываемый от нуля индекс последнего удаляемого назначенного знака.</param>
		/// <returns>Значение <see langword="true" />, если знак успешно удален, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FFD RID: 8189 RVA: 0x0006E8A0 File Offset: 0x0006CAA0
		public bool RemoveAt(int startPosition, int endPosition)
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.RemoveAt(startPosition, endPosition, out num, out maskedTextResultHint);
		}

		/// <summary>Удаляет назначенные знаки между заданными позициями форматируемой строки, а затем выводит позицию удаления и описательные сведения.</summary>
		/// <param name="startPosition">Отсчитываемый от нуля индекс первого удаляемого назначенного знака.</param>
		/// <param name="endPosition">Отсчитываемый от нуля индекс последнего удаляемого назначенного знака.</param>
		/// <param name="testPosition">При удачном удалении отсчитываемая от нуля позиция в форматируемой строке, в которой были удалены знаки; в противном случае — первая позиция, в которой выполнение операции закончилось неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если знак успешно удален, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001FFE RID: 8190 RVA: 0x0006E8B9 File Offset: 0x0006CAB9
		public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (endPosition >= this._testString.Length)
			{
				testPosition = endPosition;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			if (startPosition < 0 || startPosition > endPosition)
			{
				testPosition = startPosition;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			return this.RemoveAtInt(startPosition, endPosition, out testPosition, out resultHint, false);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0006E8F4 File Offset: 0x0006CAF4
		private bool RemoveAtInt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			int lastAssignedPosition = this.LastAssignedPosition;
			int num = this.FindEditPositionInRange(startPosition, endPosition, true);
			resultHint = MaskedTextResultHint.NoEffect;
			if (num == -1 || num > lastAssignedPosition)
			{
				testPosition = startPosition;
				return true;
			}
			testPosition = startPosition;
			bool flag = endPosition < lastAssignedPosition;
			if (this.FindAssignedEditPositionInRange(startPosition, endPosition, true) != -1)
			{
				resultHint = MaskedTextResultHint.Success;
			}
			if (flag)
			{
				int num2 = this.FindEditPositionFrom(endPosition + 1, true);
				int num3 = num2;
				startPosition = num;
				MaskedTextResultHint maskedTextResultHint;
				for (;;)
				{
					char c = this._testString[num2];
					MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[num2];
					if ((c != this.PromptChar || charDescriptor.IsAssigned) && !this.TestChar(c, num, out maskedTextResultHint))
					{
						break;
					}
					if (num2 == lastAssignedPosition)
					{
						goto IL_B0;
					}
					num2 = this.FindEditPositionFrom(num2 + 1, true);
					num = this.FindEditPositionFrom(num + 1, true);
				}
				resultHint = maskedTextResultHint;
				testPosition = num;
				return false;
				IL_B0:
				if (MaskedTextResultHint.SideEffect > resultHint)
				{
					resultHint = MaskedTextResultHint.SideEffect;
				}
				if (testOnly)
				{
					return true;
				}
				num2 = num3;
				num = startPosition;
				for (;;)
				{
					char c2 = this._testString[num2];
					MaskedTextProvider.CharDescriptor charDescriptor2 = this._stringDescriptor[num2];
					if (c2 == this.PromptChar && !charDescriptor2.IsAssigned)
					{
						this.ResetChar(num);
					}
					else
					{
						this.SetChar(c2, num);
						this.ResetChar(num2);
					}
					if (num2 == lastAssignedPosition)
					{
						break;
					}
					num2 = this.FindEditPositionFrom(num2 + 1, true);
					num = this.FindEditPositionFrom(num + 1, true);
				}
				startPosition = num + 1;
			}
			if (startPosition <= endPosition)
			{
				this.ResetString(startPosition, endPosition);
			}
			return true;
		}

		/// <summary>Заменяет один знак в заданной позиции или после нее на заданный знак.</summary>
		/// <param name="input">Значение <see cref="T:System.Char" />, заменяющее существующее значение.</param>
		/// <param name="position">Отсчитываемая от нуля позиция, с которой начинается поиск первого редактируемого знака для замены.</param>
		/// <returns>Значение <see langword="true" />, если знак успешно заменен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002000 RID: 8192 RVA: 0x0006EA3C File Offset: 0x0006CC3C
		public bool Replace(char input, int position)
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.Replace(input, position, out num, out maskedTextResultHint);
		}

		/// <summary>Заменяет один знак, начиная с заданной позиции, на заданный знак, а затем выводит позицию удаления и описательные сведения.</summary>
		/// <param name="input">Значение <see cref="T:System.Char" />, заменяющее существующее значение.</param>
		/// <param name="position">Отсчитываемая от нуля позиция, с которой начинается поиск первого редактируемого знака для замены.</param>
		/// <param name="testPosition">При удачном удалении отсчитываемая от нуля позиция в форматируемой строке, в которой был фактически заменен последний знак; в противном случае — первая позиция, в которой выполнение операции закончилось неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции замены. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если знак успешно заменен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002001 RID: 8193 RVA: 0x0006EA58 File Offset: 0x0006CC58
		public bool Replace(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (position < 0 || position >= this._testString.Length)
			{
				testPosition = position;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			testPosition = position;
			if (!this.TestEscapeChar(input, testPosition))
			{
				testPosition = this.FindEditPositionFrom(testPosition, true);
			}
			if (testPosition == -1)
			{
				resultHint = MaskedTextResultHint.UnavailableEditPosition;
				testPosition = position;
				return false;
			}
			return this.TestSetChar(input, testPosition, out resultHint);
		}

		/// <summary>Заменяет один знак, начиная между заданными начальной и конечной позициями, на заданный знак, а затем выводит позицию удаления и описательные сведения.</summary>
		/// <param name="input">Значение <see cref="T:System.Char" />, заменяющее существующее значение.</param>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается замена.</param>
		/// <param name="endPosition">Отсчитываемая от нуля позиция в форматируемой строке, которой заканчивается замена.</param>
		/// <param name="testPosition">При удачном удалении отсчитываемая от нуля позиция в форматируемой строке, в которой был фактически заменен последний знак; в противном случае — первая позиция, в которой выполнение операции закончилось неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции замены. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если знак успешно заменен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002002 RID: 8194 RVA: 0x0006EABC File Offset: 0x0006CCBC
		public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (endPosition >= this._testString.Length)
			{
				testPosition = endPosition;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			if (startPosition < 0 || startPosition > endPosition)
			{
				testPosition = startPosition;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			if (startPosition == endPosition)
			{
				testPosition = startPosition;
				return this.TestSetChar(input, startPosition, out resultHint);
			}
			return this.Replace(input.ToString(), startPosition, endPosition, out testPosition, out resultHint);
		}

		/// <summary>Заменяет диапазон редактируемых знаков, начиная с заданной позиции в заданной строке.</summary>
		/// <param name="input">Значение <see cref="T:System.String" />, используемое для замены существующих редактируемых знаков.</param>
		/// <param name="position">Отсчитываемая от нуля позиция, с которой начинается поиск первого редактируемого знака для замены.</param>
		/// <returns>Значение <see langword="true" /> при успешной замене всех знаков; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002003 RID: 8195 RVA: 0x0006EB1C File Offset: 0x0006CD1C
		public bool Replace(string input, int position)
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.Replace(input, position, out num, out maskedTextResultHint);
		}

		/// <summary>Заменяет диапазон редактируемых знаков, начиная с заданной позиции, на заданную строку, а затем выводит позицию удаления и описательные сведения.</summary>
		/// <param name="input">Значение <see cref="T:System.String" />, используемое для замены существующих редактируемых знаков.</param>
		/// <param name="position">Отсчитываемая от нуля позиция, с которой начинается поиск первого редактируемого знака для замены.</param>
		/// <param name="testPosition">При удачном удалении отсчитываемая от нуля позиция в форматируемой строке, в которой был фактически заменен последний знак; в противном случае — первая позиция, в которой выполнение операции закончилось неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции замены. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" /> при успешной замене всех знаков; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002004 RID: 8196 RVA: 0x0006EB38 File Offset: 0x0006CD38
		public bool Replace(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (position < 0 || position >= this._testString.Length)
			{
				testPosition = position;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			if (input.Length == 0)
			{
				return this.RemoveAt(position, position, out testPosition, out resultHint);
			}
			return this.TestSetString(input, position, out testPosition, out resultHint);
		}

		/// <summary>Заменяет диапазон редактируемых знаков между заданными начальной и конечной позициями на заданную строку, а затем выводит позицию удаления и описательные сведения.</summary>
		/// <param name="input">Значение <see cref="T:System.String" />, используемое для замены существующих редактируемых знаков.</param>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается замена.</param>
		/// <param name="endPosition">Отсчитываемая от нуля позиция в форматируемой строке, которой заканчивается замена.</param>
		/// <param name="testPosition">При удачном удалении отсчитываемая от нуля позиция в форматируемой строке, в которой был фактически заменен последний знак; в противном случае — первая позиция, в которой выполнение операции закончилось неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции замены. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" /> при успешной замене всех знаков; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002005 RID: 8197 RVA: 0x0006EB94 File Offset: 0x0006CD94
		public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (endPosition >= this._testString.Length)
			{
				testPosition = endPosition;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			if (startPosition < 0 || startPosition > endPosition)
			{
				testPosition = startPosition;
				resultHint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			if (input.Length == 0)
			{
				return this.RemoveAt(startPosition, endPosition, out testPosition, out resultHint);
			}
			if (!this.TestString(input, startPosition, out testPosition, out resultHint))
			{
				return false;
			}
			if (this.AssignedEditPositionCount > 0)
			{
				if (testPosition < endPosition)
				{
					int num;
					MaskedTextResultHint maskedTextResultHint;
					if (!this.RemoveAtInt(testPosition + 1, endPosition, out num, out maskedTextResultHint, false))
					{
						testPosition = num;
						resultHint = maskedTextResultHint;
						return false;
					}
					if (maskedTextResultHint == MaskedTextResultHint.Success && resultHint != maskedTextResultHint)
					{
						resultHint = MaskedTextResultHint.SideEffect;
					}
				}
				else if (testPosition > endPosition)
				{
					int lastAssignedPosition = this.LastAssignedPosition;
					int i = testPosition + 1;
					int num2 = endPosition + 1;
					MaskedTextResultHint maskedTextResultHint;
					for (;;)
					{
						num2 = this.FindEditPositionFrom(num2, true);
						i = this.FindEditPositionFrom(i, true);
						if (i == -1)
						{
							goto Block_12;
						}
						if (!this.TestChar(this._testString[num2], i, out maskedTextResultHint))
						{
							goto Block_13;
						}
						if (maskedTextResultHint == MaskedTextResultHint.Success && resultHint != maskedTextResultHint)
						{
							resultHint = MaskedTextResultHint.Success;
						}
						if (num2 == lastAssignedPosition)
						{
							break;
						}
						num2++;
						i++;
					}
					while (i > testPosition)
					{
						this.SetChar(this._testString[num2], i);
						num2 = this.FindEditPositionFrom(num2 - 1, false);
						i = this.FindEditPositionFrom(i - 1, false);
					}
					goto IL_162;
					Block_12:
					testPosition = this._testString.Length;
					resultHint = MaskedTextResultHint.UnavailableEditPosition;
					return false;
					Block_13:
					testPosition = i;
					resultHint = maskedTextResultHint;
					return false;
				}
			}
			IL_162:
			this.SetString(input, startPosition);
			return true;
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0006ED0C File Offset: 0x0006CF0C
		private void ResetChar(int testPosition)
		{
			MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[testPosition];
			if (this.IsEditPosition(testPosition) && charDescriptor.IsAssigned)
			{
				charDescriptor.IsAssigned = false;
				this._testString[testPosition] = this._promptChar;
				int assignedEditPositionCount = this.AssignedEditPositionCount;
				this.AssignedEditPositionCount = assignedEditPositionCount - 1;
				if (charDescriptor.CharType == MaskedTextProvider.CharType.EditRequired)
				{
					this._requiredCharCount--;
				}
			}
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0006ED77 File Offset: 0x0006CF77
		private void ResetString(int startPosition, int endPosition)
		{
			startPosition = this.FindAssignedEditPositionFrom(startPosition, true);
			if (startPosition != -1)
			{
				endPosition = this.FindAssignedEditPositionFrom(endPosition, false);
				while (startPosition <= endPosition)
				{
					startPosition = this.FindAssignedEditPositionFrom(startPosition, true);
					this.ResetChar(startPosition);
					startPosition++;
				}
			}
		}

		/// <summary>Определяет форматируемую строку для заданной входной строки.</summary>
		/// <param name="input">Значение <see cref="T:System.String" />, используемое для задания форматируемой строки.</param>
		/// <returns>Значение <see langword="true" /> при успешной установке всех знаков; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002008 RID: 8200 RVA: 0x0006EDB0 File Offset: 0x0006CFB0
		public bool Set(string input)
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.Set(input, out num, out maskedTextResultHint);
		}

		/// <summary>Устанавливает форматируемую строку равной заданной входной строке, а затем выводит позицию удаления и описательные сведения.</summary>
		/// <param name="input">Значение <see cref="T:System.String" />, используемое для задания форматируемой строки.</param>
		/// <param name="testPosition">При удачном удалении отсчитываемая от нуля позиция в форматируемой строке, в которой был фактически установлен последний знак; в противном случае — первая позиция, в которой выполнение операции закончилось неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции установки. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" /> при успешной установке всех знаков; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002009 RID: 8201 RVA: 0x0006EDC8 File Offset: 0x0006CFC8
		public bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			resultHint = MaskedTextResultHint.Unknown;
			testPosition = 0;
			if (input.Length == 0)
			{
				this.Clear(out resultHint);
				return true;
			}
			if (!this.TestSetString(input, testPosition, out testPosition, out resultHint))
			{
				return false;
			}
			int num = this.FindAssignedEditPositionFrom(testPosition + 1, true);
			if (num != -1)
			{
				this.ResetString(num, this._testString.Length - 1);
			}
			return true;
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0006EE30 File Offset: 0x0006D030
		private void SetChar(char input, int position)
		{
			MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[position];
			this.SetChar(input, position, charDescriptor);
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0006EE54 File Offset: 0x0006D054
		private void SetChar(char input, int position, MaskedTextProvider.CharDescriptor charDescriptor)
		{
			MaskedTextProvider.CharDescriptor charDescriptor2 = this._stringDescriptor[position];
			if (this.TestEscapeChar(input, position, charDescriptor))
			{
				this.ResetChar(position);
				return;
			}
			if (char.IsLetter(input))
			{
				if (char.IsUpper(input))
				{
					if (charDescriptor.CaseConversion == MaskedTextProvider.CaseConversion.ToLower)
					{
						input = this.Culture.TextInfo.ToLower(input);
					}
				}
				else if (charDescriptor.CaseConversion == MaskedTextProvider.CaseConversion.ToUpper)
				{
					input = this.Culture.TextInfo.ToUpper(input);
				}
			}
			this._testString[position] = input;
			if (!charDescriptor.IsAssigned)
			{
				charDescriptor.IsAssigned = true;
				int assignedEditPositionCount = this.AssignedEditPositionCount;
				this.AssignedEditPositionCount = assignedEditPositionCount + 1;
				if (charDescriptor.CharType == MaskedTextProvider.CharType.EditRequired)
				{
					this._requiredCharCount++;
				}
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0006EF10 File Offset: 0x0006D110
		private void SetString(string input, int testPosition)
		{
			foreach (char input2 in input)
			{
				if (!this.TestEscapeChar(input2, testPosition))
				{
					testPosition = this.FindEditPositionFrom(testPosition, true);
				}
				this.SetChar(input2, testPosition);
				testPosition++;
			}
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0006EF5C File Offset: 0x0006D15C
		private bool TestChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			if (!MaskedTextProvider.IsPrintableChar(input))
			{
				resultHint = MaskedTextResultHint.InvalidInput;
				return false;
			}
			MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[position];
			if (MaskedTextProvider.IsLiteralPosition(charDescriptor))
			{
				if (this.SkipLiterals && input == this._testString[position])
				{
					resultHint = MaskedTextResultHint.CharacterEscaped;
					return true;
				}
				resultHint = MaskedTextResultHint.NonEditPosition;
				return false;
			}
			else
			{
				if (input == this._promptChar)
				{
					if (this.ResetOnPrompt)
					{
						if (MaskedTextProvider.IsEditPosition(charDescriptor) && charDescriptor.IsAssigned)
						{
							resultHint = MaskedTextResultHint.SideEffect;
						}
						else
						{
							resultHint = MaskedTextResultHint.CharacterEscaped;
						}
						return true;
					}
					if (!this.AllowPromptAsInput)
					{
						resultHint = MaskedTextResultHint.PromptCharNotAllowed;
						return false;
					}
				}
				if (input == ' ' && this.ResetOnSpace)
				{
					if (MaskedTextProvider.IsEditPosition(charDescriptor) && charDescriptor.IsAssigned)
					{
						resultHint = MaskedTextResultHint.SideEffect;
					}
					else
					{
						resultHint = MaskedTextResultHint.CharacterEscaped;
					}
					return true;
				}
				char c = this.Mask[charDescriptor.MaskPosition];
				if (c <= '0')
				{
					if (c != '#')
					{
						if (c != '&')
						{
							if (c == '0')
							{
								if (!char.IsDigit(input))
								{
									resultHint = MaskedTextResultHint.DigitExpected;
									return false;
								}
							}
						}
						else if (!MaskedTextProvider.IsAscii(input) && this.AsciiOnly)
						{
							resultHint = MaskedTextResultHint.AsciiCharacterExpected;
							return false;
						}
					}
					else if (!char.IsDigit(input) && input != '-' && input != '+' && input != ' ')
					{
						resultHint = MaskedTextResultHint.DigitExpected;
						return false;
					}
				}
				else if (c <= 'C')
				{
					if (c != '9')
					{
						switch (c)
						{
						case '?':
							if (!char.IsLetter(input) && input != ' ')
							{
								resultHint = MaskedTextResultHint.LetterExpected;
								return false;
							}
							if (!MaskedTextProvider.IsAsciiLetter(input) && this.AsciiOnly)
							{
								resultHint = MaskedTextResultHint.AsciiCharacterExpected;
								return false;
							}
							break;
						case 'A':
							if (!MaskedTextProvider.IsAlphanumeric(input))
							{
								resultHint = MaskedTextResultHint.AlphanumericCharacterExpected;
								return false;
							}
							if (!MaskedTextProvider.IsAciiAlphanumeric(input) && this.AsciiOnly)
							{
								resultHint = MaskedTextResultHint.AsciiCharacterExpected;
								return false;
							}
							break;
						case 'C':
							if (!MaskedTextProvider.IsAscii(input) && this.AsciiOnly && input != ' ')
							{
								resultHint = MaskedTextResultHint.AsciiCharacterExpected;
								return false;
							}
							break;
						}
					}
					else if (!char.IsDigit(input) && input != ' ')
					{
						resultHint = MaskedTextResultHint.DigitExpected;
						return false;
					}
				}
				else if (c != 'L')
				{
					if (c == 'a')
					{
						if (!MaskedTextProvider.IsAlphanumeric(input) && input != ' ')
						{
							resultHint = MaskedTextResultHint.AlphanumericCharacterExpected;
							return false;
						}
						if (!MaskedTextProvider.IsAciiAlphanumeric(input) && this.AsciiOnly)
						{
							resultHint = MaskedTextResultHint.AsciiCharacterExpected;
							return false;
						}
					}
				}
				else
				{
					if (!char.IsLetter(input))
					{
						resultHint = MaskedTextResultHint.LetterExpected;
						return false;
					}
					if (!MaskedTextProvider.IsAsciiLetter(input) && this.AsciiOnly)
					{
						resultHint = MaskedTextResultHint.AsciiCharacterExpected;
						return false;
					}
				}
				if (input == this._testString[position] && charDescriptor.IsAssigned)
				{
					resultHint = MaskedTextResultHint.NoEffect;
				}
				else
				{
					resultHint = MaskedTextResultHint.Success;
				}
				return true;
			}
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0006F1BC File Offset: 0x0006D3BC
		private bool TestEscapeChar(char input, int position)
		{
			MaskedTextProvider.CharDescriptor charDex = this._stringDescriptor[position];
			return this.TestEscapeChar(input, position, charDex);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0006F1E0 File Offset: 0x0006D3E0
		private bool TestEscapeChar(char input, int position, MaskedTextProvider.CharDescriptor charDex)
		{
			if (MaskedTextProvider.IsLiteralPosition(charDex))
			{
				return this.SkipLiterals && input == this._testString[position];
			}
			return (this.ResetOnPrompt && input == this._promptChar) || (this.ResetOnSpace && input == ' ');
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0006F230 File Offset: 0x0006D430
		private bool TestSetChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			if (this.TestChar(input, position, out resultHint))
			{
				if (resultHint == MaskedTextResultHint.Success || resultHint == MaskedTextResultHint.SideEffect)
				{
					this.SetChar(input, position);
				}
				return true;
			}
			return false;
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0006F252 File Offset: 0x0006D452
		private bool TestSetString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			if (this.TestString(input, position, out testPosition, out resultHint))
			{
				this.SetString(input, position);
				return true;
			}
			return false;
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0006F26C File Offset: 0x0006D46C
		private bool TestString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			resultHint = MaskedTextResultHint.Unknown;
			testPosition = position;
			if (input.Length == 0)
			{
				return true;
			}
			MaskedTextResultHint maskedTextResultHint = resultHint;
			foreach (char input2 in input)
			{
				if (testPosition >= this._testString.Length)
				{
					resultHint = MaskedTextResultHint.UnavailableEditPosition;
					return false;
				}
				if (!this.TestEscapeChar(input2, testPosition))
				{
					testPosition = this.FindEditPositionFrom(testPosition, true);
					if (testPosition == -1)
					{
						testPosition = this._testString.Length;
						resultHint = MaskedTextResultHint.UnavailableEditPosition;
						return false;
					}
				}
				if (!this.TestChar(input2, testPosition, out maskedTextResultHint))
				{
					resultHint = maskedTextResultHint;
					return false;
				}
				if (maskedTextResultHint > resultHint)
				{
					resultHint = maskedTextResultHint;
				}
				testPosition++;
			}
			testPosition--;
			return true;
		}

		/// <summary>Возвращает форматируемую строку в отображаемом виде.</summary>
		/// <returns>Форматируемая строка <see cref="T:System.String" />, содержащая приглашения и литералы маски.</returns>
		// Token: 0x06002013 RID: 8211 RVA: 0x0006F318 File Offset: 0x0006D518
		public string ToDisplayString()
		{
			if (!this.IsPassword || this.AssignedEditPositionCount == 0)
			{
				return this._testString.ToString();
			}
			StringBuilder stringBuilder = new StringBuilder(this._testString.Length);
			for (int i = 0; i < this._testString.Length; i++)
			{
				MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[i];
				stringBuilder.Append((MaskedTextProvider.IsEditPosition(charDescriptor) && charDescriptor.IsAssigned) ? this._passwordChar : this._testString[i]);
			}
			return stringBuilder.ToString();
		}

		/// <summary>Возвращает форматируемую строку, содержащую назначенные значения знаков.</summary>
		/// <returns>Форматируемая строка <see cref="T:System.String" />, содержащая все назначенные значения знаков.</returns>
		// Token: 0x06002014 RID: 8212 RVA: 0x0006F3A6 File Offset: 0x0006D5A6
		public override string ToString()
		{
			return this.ToString(true, this.IncludePrompt, this.IncludeLiterals, 0, this._testString.Length);
		}

		/// <summary>Возвращает форматируемую строку, при необходимости содержащую знаки пароля.</summary>
		/// <param name="ignorePasswordChar">Значение <see langword="true" />, чтобы вернуть фактические редактируемые знаки; в противном случае — значение <see langword="false" />, показывающее, что должно учитываться свойство <see cref="P:System.ComponentModel.MaskedTextProvider.PasswordChar" />.</param>
		/// <returns>Форматируемая строка <see cref="T:System.String" />, содержащая литералы, приглашения и, при необходимости, знаки пароля.</returns>
		// Token: 0x06002015 RID: 8213 RVA: 0x0006F3C7 File Offset: 0x0006D5C7
		public string ToString(bool ignorePasswordChar)
		{
			return this.ToString(ignorePasswordChar, this.IncludePrompt, this.IncludeLiterals, 0, this._testString.Length);
		}

		/// <summary>Возвращает подстроку форматируемой строки.</summary>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается вывод.</param>
		/// <param name="length">Число возвращаемых знаков.</param>
		/// <returns>В случае успеха подстрока форматируемой строки <see cref="T:System.String" />, содержащая все назначенные значения знаков; в противном случае — строка <see cref="F:System.String.Empty" />.</returns>
		// Token: 0x06002016 RID: 8214 RVA: 0x0006F3E8 File Offset: 0x0006D5E8
		public string ToString(int startPosition, int length)
		{
			return this.ToString(true, this.IncludePrompt, this.IncludeLiterals, startPosition, length);
		}

		/// <summary>Возвращает подстроку форматируемой строки, при необходимости содержащую знаки пароля.</summary>
		/// <param name="ignorePasswordChar">Значение <see langword="true" />, чтобы вернуть фактические редактируемые знаки; в противном случае — значение <see langword="false" />, показывающее, что должно учитываться свойство <see cref="P:System.ComponentModel.MaskedTextProvider.PasswordChar" />.</param>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается вывод.</param>
		/// <param name="length">Число возвращаемых знаков.</param>
		/// <returns>В случае успеха подстрока форматируемой строки <see cref="T:System.String" />, содержащая литералы, приглашения и, при необходимости, знаки пароля; в противном случае — строка <see cref="F:System.String.Empty" />.</returns>
		// Token: 0x06002017 RID: 8215 RVA: 0x0006F3FF File Offset: 0x0006D5FF
		public string ToString(bool ignorePasswordChar, int startPosition, int length)
		{
			return this.ToString(ignorePasswordChar, this.IncludePrompt, this.IncludeLiterals, startPosition, length);
		}

		/// <summary>Возвращает форматируемую строку, при необходимости включая знаки приглашения и литералы.</summary>
		/// <param name="includePrompt">Значение <see langword="true" />, чтобы включить знаки приглашения в возвращаемую строку; в противном случае — значение <see langword="false" />.</param>
		/// <param name="includeLiterals">Значение <see langword="true" />, чтобы включить литералы в возвращаемую строку; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Форматируемая строка <see cref="T:System.String" />, содержащая все назначенные значения знаков и, при необходимости, литералы и приглашения.</returns>
		// Token: 0x06002018 RID: 8216 RVA: 0x0006F416 File Offset: 0x0006D616
		public string ToString(bool includePrompt, bool includeLiterals)
		{
			return this.ToString(true, includePrompt, includeLiterals, 0, this._testString.Length);
		}

		/// <summary>Возвращает подстроку форматируемой строки, при необходимости включая знаки приглашения и литералы.</summary>
		/// <param name="includePrompt">Значение <see langword="true" />, чтобы включить знаки приглашения в возвращаемую строку; в противном случае — значение <see langword="false" />.</param>
		/// <param name="includeLiterals">Значение <see langword="true" />, чтобы включить литералы в возвращаемую строку; в противном случае — значение <see langword="false" />.</param>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается вывод.</param>
		/// <param name="length">Число возвращаемых знаков.</param>
		/// <returns>В случае успеха подстрока форматируемой строки <see cref="T:System.String" />, содержащая все назначенные значения знаков и, при необходимости, литералы и приглашения; в противном случае — строка <see cref="F:System.String.Empty" />.</returns>
		// Token: 0x06002019 RID: 8217 RVA: 0x0006F42D File Offset: 0x0006D62D
		public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			return this.ToString(true, includePrompt, includeLiterals, startPosition, length);
		}

		/// <summary>Возвращает подстроку форматируемой строки, при необходимости включая знаки приглашения, литералы и знаки пароля.</summary>
		/// <param name="ignorePasswordChar">Значение <see langword="true" />, чтобы вернуть фактические редактируемые знаки; в противном случае — значение <see langword="false" />, показывающее, что должно учитываться свойство <see cref="P:System.ComponentModel.MaskedTextProvider.PasswordChar" />.</param>
		/// <param name="includePrompt">Значение <see langword="true" />, чтобы включить знаки приглашения в возвращаемую строку; в противном случае — значение <see langword="false" />.</param>
		/// <param name="includeLiterals">Значение <see langword="true" />, чтобы возвратить литералы в возвращенной строке; в противном случае — значение <see langword="false" />.</param>
		/// <param name="startPosition">Отсчитываемая от нуля позиция в форматируемой строке, с которой начинается вывод.</param>
		/// <param name="length">Число возвращаемых знаков.</param>
		/// <returns>В случае успеха подстрока форматируемой строки <see cref="T:System.String" />, содержащая все назначенные значения знаков и, при необходимости, литералы, знаки приглашения и знаки пароля; в противном случае — строка <see cref="F:System.String.Empty" />.</returns>
		// Token: 0x0600201A RID: 8218 RVA: 0x0006F43C File Offset: 0x0006D63C
		public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			if (length <= 0)
			{
				return string.Empty;
			}
			if (startPosition < 0)
			{
				startPosition = 0;
			}
			if (startPosition >= this._testString.Length)
			{
				return string.Empty;
			}
			int num = this._testString.Length - startPosition;
			if (length > num)
			{
				length = num;
			}
			if ((!this.IsPassword || ignorePasswordChar) && (includePrompt && includeLiterals))
			{
				return this._testString.ToString(startPosition, length);
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = startPosition + length - 1;
			if (!includePrompt)
			{
				int num3 = includeLiterals ? this.FindNonEditPositionInRange(startPosition, num2, false) : MaskedTextProvider.InvalidIndex;
				int num4 = this.FindAssignedEditPositionInRange((num3 == MaskedTextProvider.InvalidIndex) ? startPosition : num3, num2, false);
				num2 = ((num4 != MaskedTextProvider.InvalidIndex) ? num4 : num3);
				if (num2 == MaskedTextProvider.InvalidIndex)
				{
					return string.Empty;
				}
			}
			int i = startPosition;
			while (i <= num2)
			{
				char value = this._testString[i];
				MaskedTextProvider.CharDescriptor charDescriptor = this._stringDescriptor[i];
				MaskedTextProvider.CharType charType = charDescriptor.CharType;
				if (charType - MaskedTextProvider.CharType.EditOptional > 1)
				{
					if (charType != MaskedTextProvider.CharType.Separator && charType != MaskedTextProvider.CharType.Literal)
					{
						goto IL_12F;
					}
					if (includeLiterals)
					{
						goto IL_12F;
					}
				}
				else if (charDescriptor.IsAssigned)
				{
					if (!this.IsPassword || ignorePasswordChar)
					{
						goto IL_12F;
					}
					stringBuilder.Append(this._passwordChar);
				}
				else
				{
					if (includePrompt)
					{
						goto IL_12F;
					}
					stringBuilder.Append(' ');
				}
				IL_138:
				i++;
				continue;
				IL_12F:
				stringBuilder.Append(value);
				goto IL_138;
			}
			return stringBuilder.ToString();
		}

		/// <summary>Проверяет, может ли заданный знак быть успешно установлен в заданной позиции.</summary>
		/// <param name="input">Проверяемое значение <see cref="T:System.Char" />.</param>
		/// <param name="position">Позиция в маске, для повторной проверки введенного знака.</param>
		/// <param name="hint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если заданный параметр допустим для заданной позиции, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600201B RID: 8219 RVA: 0x0006F595 File Offset: 0x0006D795
		public bool VerifyChar(char input, int position, out MaskedTextResultHint hint)
		{
			hint = MaskedTextResultHint.NoEffect;
			if (position < 0 || position >= this._testString.Length)
			{
				hint = MaskedTextResultHint.PositionOutOfRange;
				return false;
			}
			return this.TestChar(input, position, out hint);
		}

		/// <summary>Проверяет, будет ли заданный знак экранироваться в заданной позиции.</summary>
		/// <param name="input">Проверяемое значение <see cref="T:System.Char" />.</param>
		/// <param name="position">Позиция в маске, для повторной проверки введенного знака.</param>
		/// <returns>Значение <see langword="true" />, если заданный знак в заданной позиции будет экранирован, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600201C RID: 8220 RVA: 0x0006F5BB File Offset: 0x0006D7BB
		public bool VerifyEscapeChar(char input, int position)
		{
			return position >= 0 && position < this._testString.Length && this.TestEscapeChar(input, position);
		}

		/// <summary>Проверяет, может ли заданная строка быть успешно установлена.</summary>
		/// <param name="input">Проверяемое значение <see cref="T:System.String" />.</param>
		/// <returns>Значение <see langword="true" />, если заданная строка представляет допустимый ввод, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600201D RID: 8221 RVA: 0x0006F5DC File Offset: 0x0006D7DC
		public bool VerifyString(string input)
		{
			int num;
			MaskedTextResultHint maskedTextResultHint;
			return this.VerifyString(input, out num, out maskedTextResultHint);
		}

		/// <summary>Проверяет, может ли заданная строка быть успешно установлена, а затем возвращает позицию и описательные сведения.</summary>
		/// <param name="input">Проверяемое значение <see cref="T:System.String" />.</param>
		/// <param name="testPosition">В случае успеха — отсчитываемая от нуля позиция последнего фактически проверенного знака; в противном случае — первая позиция, в которой проверка закончилась неудачей. Выходной параметр.</param>
		/// <param name="resultHint">Объект <see cref="T:System.ComponentModel.MaskedTextResultHint" />, кратко описывающий результат операции проверки. Выходной параметр.</param>
		/// <returns>Значение <see langword="true" />, если заданная строка представляет допустимый ввод, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600201E RID: 8222 RVA: 0x0006F5F4 File Offset: 0x0006D7F4
		public bool VerifyString(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = 0;
			if (input == null || input.Length == 0)
			{
				resultHint = MaskedTextResultHint.NoEffect;
				return true;
			}
			return this.TestString(input, 0, out testPosition, out resultHint);
		}

		// Token: 0x04000F79 RID: 3961
		private const char SPACE_CHAR = ' ';

		// Token: 0x04000F7A RID: 3962
		private const char DEFAULT_PROMPT_CHAR = '_';

		// Token: 0x04000F7B RID: 3963
		private const char NULL_PASSWORD_CHAR = '\0';

		// Token: 0x04000F7C RID: 3964
		private const bool DEFAULT_ALLOW_PROMPT = true;

		// Token: 0x04000F7D RID: 3965
		private const int INVALID_INDEX = -1;

		// Token: 0x04000F7E RID: 3966
		private const byte EDIT_ANY = 0;

		// Token: 0x04000F7F RID: 3967
		private const byte EDIT_UNASSIGNED = 1;

		// Token: 0x04000F80 RID: 3968
		private const byte EDIT_ASSIGNED = 2;

		// Token: 0x04000F81 RID: 3969
		private const bool FORWARD = true;

		// Token: 0x04000F82 RID: 3970
		private const bool BACKWARD = false;

		// Token: 0x04000F83 RID: 3971
		private static int s_ASCII_ONLY = BitVector32.CreateMask();

		// Token: 0x04000F84 RID: 3972
		private static int s_ALLOW_PROMPT_AS_INPUT = BitVector32.CreateMask(MaskedTextProvider.s_ASCII_ONLY);

		// Token: 0x04000F85 RID: 3973
		private static int s_INCLUDE_PROMPT = BitVector32.CreateMask(MaskedTextProvider.s_ALLOW_PROMPT_AS_INPUT);

		// Token: 0x04000F86 RID: 3974
		private static int s_INCLUDE_LITERALS = BitVector32.CreateMask(MaskedTextProvider.s_INCLUDE_PROMPT);

		// Token: 0x04000F87 RID: 3975
		private static int s_RESET_ON_PROMPT = BitVector32.CreateMask(MaskedTextProvider.s_INCLUDE_LITERALS);

		// Token: 0x04000F88 RID: 3976
		private static int s_RESET_ON_LITERALS = BitVector32.CreateMask(MaskedTextProvider.s_RESET_ON_PROMPT);

		// Token: 0x04000F89 RID: 3977
		private static int s_SKIP_SPACE = BitVector32.CreateMask(MaskedTextProvider.s_RESET_ON_LITERALS);

		// Token: 0x04000F8A RID: 3978
		private static Type s_maskTextProviderType = typeof(MaskedTextProvider);

		// Token: 0x04000F8B RID: 3979
		private BitVector32 _flagState;

		// Token: 0x04000F8C RID: 3980
		private StringBuilder _testString;

		// Token: 0x04000F8D RID: 3981
		private int _requiredCharCount;

		// Token: 0x04000F8E RID: 3982
		private int _requiredEditChars;

		// Token: 0x04000F8F RID: 3983
		private int _optionalEditChars;

		// Token: 0x04000F90 RID: 3984
		private char _passwordChar;

		// Token: 0x04000F91 RID: 3985
		private char _promptChar;

		// Token: 0x04000F92 RID: 3986
		private List<MaskedTextProvider.CharDescriptor> _stringDescriptor;

		// Token: 0x020003D6 RID: 982
		private enum CaseConversion
		{
			// Token: 0x04000F97 RID: 3991
			None,
			// Token: 0x04000F98 RID: 3992
			ToLower,
			// Token: 0x04000F99 RID: 3993
			ToUpper
		}

		// Token: 0x020003D7 RID: 983
		[Flags]
		private enum CharType
		{
			// Token: 0x04000F9B RID: 3995
			EditOptional = 1,
			// Token: 0x04000F9C RID: 3996
			EditRequired = 2,
			// Token: 0x04000F9D RID: 3997
			Separator = 4,
			// Token: 0x04000F9E RID: 3998
			Literal = 8,
			// Token: 0x04000F9F RID: 3999
			Modifier = 16
		}

		// Token: 0x020003D8 RID: 984
		private class CharDescriptor
		{
			// Token: 0x06002020 RID: 8224 RVA: 0x0006F694 File Offset: 0x0006D894
			public CharDescriptor(int maskPos, MaskedTextProvider.CharType charType)
			{
				this.MaskPosition = maskPos;
				this.CharType = charType;
			}

			// Token: 0x06002021 RID: 8225 RVA: 0x0006F6AC File Offset: 0x0006D8AC
			public override string ToString()
			{
				return string.Format(CultureInfo.InvariantCulture, "MaskPosition[{0}] <CaseConversion.{1}><CharType.{2}><IsAssigned: {3}", new object[]
				{
					this.MaskPosition,
					this.CaseConversion,
					this.CharType,
					this.IsAssigned
				});
			}

			// Token: 0x04000FA0 RID: 4000
			public int MaskPosition;

			// Token: 0x04000FA1 RID: 4001
			public MaskedTextProvider.CaseConversion CaseConversion;

			// Token: 0x04000FA2 RID: 4002
			public MaskedTextProvider.CharType CharType;

			// Token: 0x04000FA3 RID: 4003
			public bool IsAssigned;
		}
	}
}
