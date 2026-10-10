using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using Unity;

namespace System.Globalization
{
	/// <summary>Определяет свойства и поведение текста, характерные для той или иной системы письма, например регистр.</summary>
	// Token: 0x02000999 RID: 2457
	[ComVisible(true)]
	[Serializable]
	public class TextInfo : ICloneable, IDeserializationCallback
	{
		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06005821 RID: 22561 RVA: 0x00129145 File Offset: 0x00127345
		internal static TextInfo Invariant
		{
			get
			{
				if (TextInfo.s_Invariant == null)
				{
					TextInfo.s_Invariant = new TextInfo(CultureData.Invariant);
				}
				return TextInfo.s_Invariant;
			}
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x00129168 File Offset: 0x00127368
		internal TextInfo(CultureData cultureData)
		{
			this.m_cultureData = cultureData;
			this.m_cultureName = this.m_cultureData.CultureName;
			this.m_textInfoName = this.m_cultureData.STEXTINFO;
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x00129199 File Offset: 0x00127399
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.m_cultureData = null;
			this.m_cultureName = null;
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x001291AC File Offset: 0x001273AC
		private void OnDeserialized()
		{
			if (this.m_cultureData == null)
			{
				if (this.m_cultureName == null)
				{
					if (this.customCultureName != null)
					{
						this.m_cultureName = this.customCultureName;
					}
					else if (this.m_win32LangID == 0)
					{
						this.m_cultureName = "ar-SA";
					}
					else
					{
						this.m_cultureName = CultureInfo.GetCultureInfo(this.m_win32LangID).m_cultureData.CultureName;
					}
				}
				this.m_cultureData = CultureInfo.GetCultureInfo(this.m_cultureName).m_cultureData;
				this.m_textInfoName = this.m_cultureData.STEXTINFO;
			}
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x00129236 File Offset: 0x00127436
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x0012923E File Offset: 0x0012743E
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this.m_useUserOverride = false;
			this.customCultureName = this.m_cultureName;
			this.m_win32LangID = CultureInfo.GetCultureInfo(this.m_cultureName).LCID;
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x00129269 File Offset: 0x00127469
		internal static int GetHashCodeOrdinalIgnoreCase(string s)
		{
			return TextInfo.GetHashCodeOrdinalIgnoreCase(s, false, 0L);
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x00129274 File Offset: 0x00127474
		internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy)
		{
			return TextInfo.Invariant.GetCaseInsensitiveHashCode(s, forceRandomizedHashing, additionalEntropy);
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00129283 File Offset: 0x00127483
		[SecuritySafeCritical]
		internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB)
		{
			return TextInfo.InternalCompareStringOrdinalIgnoreCase(strA, indexA, strB, indexB, lengthA, lengthB);
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x00129294 File Offset: 0x00127494
		internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count)
		{
			if (source.Length == 0 && value.Length == 0)
			{
				return 0;
			}
			int num = startIndex + count - value.Length;
			while (startIndex <= num)
			{
				if (TextInfo.CompareOrdinalIgnoreCaseEx(source, startIndex, value, 0, value.Length, value.Length) == 0)
				{
					return startIndex;
				}
				startIndex++;
			}
			return -1;
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x001292E4 File Offset: 0x001274E4
		internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count)
		{
			if (value.Length == 0)
			{
				return startIndex;
			}
			int num = startIndex - count + 1;
			if (value.Length > 0)
			{
				startIndex -= value.Length - 1;
			}
			while (startIndex >= num)
			{
				if (TextInfo.CompareOrdinalIgnoreCaseEx(source, startIndex, value, 0, value.Length, value.Length) == 0)
				{
					return startIndex;
				}
				startIndex--;
			}
			return -1;
		}

		/// <summary>Возвращает кодовую страницу ANSI, которую использует система письма, представленная текущим классом <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>Кодовая страница в системе ANSI, которую использует система письма, представленная текущим классом <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x0600582C RID: 22572 RVA: 0x0012933B File Offset: 0x0012753B
		public virtual int ANSICodePage
		{
			get
			{
				return this.m_cultureData.IDEFAULTANSICODEPAGE;
			}
		}

		/// <summary>Возвращает кодовую страницу в системе поставщиков основного оборудования (OEM), которую использует система письма, представленная текущим классом <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>Кодовая страница в системе OEM, которую использует система письма, представленная текущим классом <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x0600582D RID: 22573 RVA: 0x00129348 File Offset: 0x00127548
		public virtual int OEMCodePage
		{
			get
			{
				return this.m_cultureData.IDEFAULTOEMCODEPAGE;
			}
		}

		/// <summary>Возвращает кодовую страницу в системе Macintosh, которую использует система письма, представленная текущим классом <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>Кодовая страница в системе Macintosh, которую использует система письма, представленная текущим классом <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x0600582E RID: 22574 RVA: 0x00129355 File Offset: 0x00127555
		public virtual int MacCodePage
		{
			get
			{
				return this.m_cultureData.IDEFAULTMACCODEPAGE;
			}
		}

		/// <summary>Возвращает кодовую страницу в расширенном двоично-десятичном коде обмена информацией (EBCDIC), который используется в системе письма, представленной текущим классом <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>Страница кода EBCDIC, который используется системаой письма, представленной текущим классом <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x0600582F RID: 22575 RVA: 0x00129362 File Offset: 0x00127562
		public virtual int EBCDICCodePage
		{
			get
			{
				return this.m_cultureData.IDEFAULTEBCDICCODEPAGE;
			}
		}

		/// <summary>Получает идентификатор языка и региональных параметров, связанных с текущим объектом <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>Номер, который служит для идентификации языка и региональных параметров, на основе которых был создан текущий объект <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06005830 RID: 22576 RVA: 0x0012936F File Offset: 0x0012756F
		[ComVisible(false)]
		public int LCID
		{
			get
			{
				return CultureInfo.GetCultureInfo(this.m_textInfoName).LCID;
			}
		}

		/// <summary>Получает имя языка и региональных параметров, связанных с текущим объектом <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>Имя языка и региональных параметров.</returns>
		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06005831 RID: 22577 RVA: 0x00129381 File Offset: 0x00127581
		[ComVisible(false)]
		public string CultureName
		{
			get
			{
				return this.m_textInfoName;
			}
		}

		/// <summary>Получает значение, определяющее, доступен ли текущий объект <see cref="T:System.Globalization.TextInfo" /> только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Globalization.TextInfo" /> доступен только для чтения, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06005832 RID: 22578 RVA: 0x00129389 File Offset: 0x00127589
		[ComVisible(false)]
		public bool IsReadOnly
		{
			get
			{
				return this.m_isReadOnly;
			}
		}

		/// <summary>Создает новый объект, являющийся копией текущего объекта <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>Новый экземпляр объекта <see cref="T:System.Object" />, который является копией по элементам текущего объекта <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x06005833 RID: 22579 RVA: 0x00129391 File Offset: 0x00127591
		[ComVisible(false)]
		public virtual object Clone()
		{
			object obj = base.MemberwiseClone();
			((TextInfo)obj).SetReadOnlyState(false);
			return obj;
		}

		/// <summary>Возвращает доступную только для чтения версию указанного объекта <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <param name="textInfo">Объект <see cref="T:System.Globalization.TextInfo" />.</param>
		/// <returns>Объект <see cref="T:System.Globalization.TextInfo" />, указанный параметром <paramref name="textInfo" />, если этот параметр <paramref name="textInfo" /> доступен только для чтения.  
		///
		/// или - 
		/// Доступная только для чтения копия по элементам объекта <see cref="T:System.Globalization.TextInfo" />, указанного параметром <paramref name="textInfo" />, если параметр <paramref name="textInfo" /> доступен не только для чтения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="textInfo" /> имеет значение null.</exception>
		// Token: 0x06005834 RID: 22580 RVA: 0x001293A5 File Offset: 0x001275A5
		[ComVisible(false)]
		public static TextInfo ReadOnly(TextInfo textInfo)
		{
			if (textInfo == null)
			{
				throw new ArgumentNullException("textInfo");
			}
			if (textInfo.IsReadOnly)
			{
				return textInfo;
			}
			TextInfo textInfo2 = (TextInfo)textInfo.MemberwiseClone();
			textInfo2.SetReadOnlyState(true);
			return textInfo2;
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x001293D1 File Offset: 0x001275D1
		private void VerifyWritable()
		{
			if (this.m_isReadOnly)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
			}
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x001293EB File Offset: 0x001275EB
		internal void SetReadOnlyState(bool readOnly)
		{
			this.m_isReadOnly = readOnly;
		}

		/// <summary>Возвращает или задает строку, разделяющую элементы в списке.</summary>
		/// <returns>Строка, разделяющая элементы в списке.</returns>
		/// <exception cref="T:System.ArgumentNullException">В операции задания этим значением является нуль.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий объект <see cref="T:System.Globalization.TextInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06005837 RID: 22583 RVA: 0x001293F4 File Offset: 0x001275F4
		// (set) Token: 0x06005838 RID: 22584 RVA: 0x00129415 File Offset: 0x00127615
		public virtual string ListSeparator
		{
			[SecuritySafeCritical]
			get
			{
				if (this.m_listSeparator == null)
				{
					this.m_listSeparator = this.m_cultureData.SLIST;
				}
				return this.m_listSeparator;
			}
			[ComVisible(false)]
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.m_listSeparator = value;
			}
		}

		/// <summary>Преобразует заданный знак в нижний регистр.</summary>
		/// <param name="c">Знак для преобразования в нижний регистр.</param>
		/// <returns>Заданный знак, преобразуемый в нижний регистр.</returns>
		// Token: 0x06005839 RID: 22585 RVA: 0x0012943C File Offset: 0x0012763C
		[SecuritySafeCritical]
		public virtual char ToLower(char c)
		{
			if (TextInfo.IsAscii(c) && this.IsAsciiCasingSameAsInvariant)
			{
				return TextInfo.ToLowerAsciiInvariant(c);
			}
			return this.ToLowerInternal(c);
		}

		/// <summary>Преобразует заданную строку в нижний регистр.</summary>
		/// <param name="str">Строка для преобразования в нижний регистр.</param>
		/// <returns>Заданная строка, преобразованная в нижний регистр.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="str" /> имеет значение null.</exception>
		// Token: 0x0600583A RID: 22586 RVA: 0x0012945C File Offset: 0x0012765C
		[SecuritySafeCritical]
		public virtual string ToLower(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return this.ToLowerInternal(str);
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00129473 File Offset: 0x00127673
		private static char ToLowerAsciiInvariant(char c)
		{
			if ('A' <= c && c <= 'Z')
			{
				c |= ' ';
			}
			return c;
		}

		/// <summary>Преобразует заданный знак в верхний регистр.</summary>
		/// <param name="c">Знак для преобразования в верхний регистр.</param>
		/// <returns>Заданный знак, преобразуемый в верхний регистр.</returns>
		// Token: 0x0600583C RID: 22588 RVA: 0x00129487 File Offset: 0x00127687
		[SecuritySafeCritical]
		public virtual char ToUpper(char c)
		{
			if (TextInfo.IsAscii(c) && this.IsAsciiCasingSameAsInvariant)
			{
				return TextInfo.ToUpperAsciiInvariant(c);
			}
			return this.ToUpperInternal(c);
		}

		/// <summary>Преобразует заданную строку в верхний регистр.</summary>
		/// <param name="str">Строка для преобразования в верхний регистр.</param>
		/// <returns>Заданная строка, преобразуемая в верхний регистр.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="str" /> имеет значение null.</exception>
		// Token: 0x0600583D RID: 22589 RVA: 0x001294A7 File Offset: 0x001276A7
		[SecuritySafeCritical]
		public virtual string ToUpper(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return this.ToUpperInternal(str);
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x001294BE File Offset: 0x001276BE
		internal static char ToUpperAsciiInvariant(char c)
		{
			if ('a' <= c && c <= 'z')
			{
				c = (char)((int)c & -33);
			}
			return c;
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x001294D2 File Offset: 0x001276D2
		private static bool IsAscii(char c)
		{
			return c < '\u0080';
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06005840 RID: 22592 RVA: 0x001294DC File Offset: 0x001276DC
		private bool IsAsciiCasingSameAsInvariant
		{
			get
			{
				if (this.m_IsAsciiCasingSameAsInvariant == null)
				{
					this.m_IsAsciiCasingSameAsInvariant = new bool?(!(this.m_cultureData.SISO639LANGNAME == "az") && !(this.m_cultureData.SISO639LANGNAME == "tr"));
				}
				return this.m_IsAsciiCasingSameAsInvariant.Value;
			}
		}

		/// <summary>Определяет, представляет ли заданный объект ту же систему письма, что и текущий объект <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом <see cref="T:System.Globalization.TextInfo" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> представляет ту же систему письма, что и текущий объект <see cref="T:System.Globalization.TextInfo" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005841 RID: 22593 RVA: 0x00129540 File Offset: 0x00127740
		public override bool Equals(object obj)
		{
			TextInfo textInfo = obj as TextInfo;
			return textInfo != null && this.CultureName.Equals(textInfo.CultureName);
		}

		/// <summary>Служит хэш-функцией текущего класса <see cref="T:System.Globalization.TextInfo" /> для использования в алгоритмах и структурах данных хеширования, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x06005842 RID: 22594 RVA: 0x0012956A File Offset: 0x0012776A
		public override int GetHashCode()
		{
			return this.CultureName.GetHashCode();
		}

		/// <summary>Возвращает строку, которая представляет текущий объект <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>Строка, представляющая текущий объект <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x06005843 RID: 22595 RVA: 0x00129577 File Offset: 0x00127777
		public override string ToString()
		{
			return "TextInfo - " + this.m_cultureData.CultureName;
		}

		/// <summary>Преобразует заданную строку в заглавные символы (за исключением слов полностью в верхнем регистре, которые считаются сокращениями).</summary>
		/// <param name="str">Строка для преобразования в верхний регистр.</param>
		/// <returns>Заданная строка, преобразуемая в заглавные символы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005844 RID: 22596 RVA: 0x00129590 File Offset: 0x00127790
		public string ToTitleCase(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			if (str.Length == 0)
			{
				return str;
			}
			StringBuilder stringBuilder = new StringBuilder();
			string text = null;
			for (int i = 0; i < str.Length; i++)
			{
				int num;
				UnicodeCategory unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, i, out num);
				if (char.CheckLetter(unicodeCategory))
				{
					i = this.AddTitlecaseLetter(ref stringBuilder, ref str, i, num) + 1;
					int num2 = i;
					bool flag = unicodeCategory == UnicodeCategory.LowercaseLetter;
					while (i < str.Length)
					{
						unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, i, out num);
						if (TextInfo.IsLetterCategory(unicodeCategory))
						{
							if (unicodeCategory == UnicodeCategory.LowercaseLetter)
							{
								flag = true;
							}
							i += num;
						}
						else if (str[i] == '\'')
						{
							i++;
							if (flag)
							{
								if (text == null)
								{
									text = this.ToLower(str);
								}
								stringBuilder.Append(text, num2, i - num2);
							}
							else
							{
								stringBuilder.Append(str, num2, i - num2);
							}
							num2 = i;
							flag = true;
						}
						else
						{
							if (TextInfo.IsWordSeparator(unicodeCategory))
							{
								break;
							}
							i += num;
						}
					}
					int num3 = i - num2;
					if (num3 > 0)
					{
						if (flag)
						{
							if (text == null)
							{
								text = this.ToLower(str);
							}
							stringBuilder.Append(text, num2, num3);
						}
						else
						{
							stringBuilder.Append(str, num2, num3);
						}
					}
					if (i < str.Length)
					{
						i = TextInfo.AddNonLetter(ref stringBuilder, ref str, i, num);
					}
				}
				else
				{
					i = TextInfo.AddNonLetter(ref stringBuilder, ref str, i, num);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x001296DD File Offset: 0x001278DD
		private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
		{
			if (charLen == 2)
			{
				result.Append(input[inputIndex++]);
				result.Append(input[inputIndex]);
			}
			else
			{
				result.Append(input[inputIndex]);
			}
			return inputIndex;
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0012971C File Offset: 0x0012791C
		private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
		{
			if (charLen == 2)
			{
				result.Append(this.ToUpper(input.Substring(inputIndex, charLen)));
				inputIndex++;
			}
			else
			{
				char c = input[inputIndex];
				switch (c)
				{
				case 'Ǆ':
				case 'ǅ':
				case 'ǆ':
					result.Append('ǅ');
					break;
				case 'Ǉ':
				case 'ǈ':
				case 'ǉ':
					result.Append('ǈ');
					break;
				case 'Ǌ':
				case 'ǋ':
				case 'ǌ':
					result.Append('ǋ');
					break;
				default:
					switch (c)
					{
					case 'Ǳ':
					case 'ǲ':
					case 'ǳ':
						result.Append('ǲ');
						break;
					default:
						result.Append(this.ToUpper(input[inputIndex]));
						break;
					}
					break;
				}
			}
			return inputIndex;
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x001297F6 File Offset: 0x001279F6
		private static bool IsWordSeparator(UnicodeCategory category)
		{
			return (536672256 & 1 << (int)category) != 0;
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x00129807 File Offset: 0x00127A07
		private static bool IsLetterCategory(UnicodeCategory uc)
		{
			return uc == UnicodeCategory.UppercaseLetter || uc == UnicodeCategory.LowercaseLetter || uc == UnicodeCategory.TitlecaseLetter || uc == UnicodeCategory.ModifierLetter || uc == UnicodeCategory.OtherLetter;
		}

		/// <summary>Получает значение, указывающее, представляет ли текущий объект <see cref="T:System.Globalization.TextInfo" /> систему письма справа налево.</summary>
		/// <returns>
		///   <see langword="true" />, если текст пишется справа налево, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06005849 RID: 22601 RVA: 0x0012981E File Offset: 0x00127A1E
		[ComVisible(false)]
		public bool IsRightToLeft
		{
			get
			{
				return this.m_cultureData.IsRightToLeft;
			}
		}

		/// <summary>Вызывает событие десериализации после завершения десериализации.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		// Token: 0x0600584A RID: 22602 RVA: 0x00129236 File Offset: 0x00127436
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialized();
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x0012982B File Offset: 0x00127A2B
		[SecuritySafeCritical]
		internal int GetCaseInsensitiveHashCode(string str)
		{
			return this.GetCaseInsensitiveHashCode(str, false, 0L);
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00129837 File Offset: 0x00127A37
		[SecuritySafeCritical]
		internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			if (this != TextInfo.s_Invariant)
			{
				return StringComparer.CurrentCultureIgnoreCase.GetHashCode(str);
			}
			return this.GetInvariantCaseInsensitiveHashCode(str);
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x00129864 File Offset: 0x00127A64
		private unsafe int GetInvariantCaseInsensitiveHashCode(string str)
		{
			char* ptr = str;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = ptr;
			char* ptr3 = ptr2 + str.Length - 1;
			int num = 0;
			while (ptr2 < ptr3)
			{
				num = (num << 5) - num + (int)char.ToUpperInvariant(*ptr2);
				num = (num << 5) - num + (int)char.ToUpperInvariant(ptr2[1]);
				ptr2 += 2;
			}
			ptr3++;
			if (ptr2 < ptr3)
			{
				num = (num << 5) - num + (int)char.ToUpperInvariant(*ptr2);
			}
			return num;
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x001298E0 File Offset: 0x00127AE0
		private unsafe string ToUpperInternal(string str)
		{
			if (str.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(str.Length);
			fixed (string text2 = str)
			{
				char* ptr = text2;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				fixed (string text3 = text)
				{
					char* ptr2 = text3;
					if (ptr2 != null)
					{
						ptr2 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr3 = ptr2;
					char* ptr4 = ptr;
					for (int i = 0; i < str.Length; i++)
					{
						*ptr3 = this.ToUpper(*ptr4);
						ptr4++;
						ptr3++;
					}
					text2 = null;
				}
				return text;
			}
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x00129964 File Offset: 0x00127B64
		private unsafe string ToLowerInternal(string str)
		{
			if (str.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(str.Length);
			fixed (string text2 = str)
			{
				char* ptr = text2;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				fixed (string text3 = text)
				{
					char* ptr2 = text3;
					if (ptr2 != null)
					{
						ptr2 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr3 = ptr2;
					char* ptr4 = ptr;
					for (int i = 0; i < str.Length; i++)
					{
						*ptr3 = this.ToLower(*ptr4);
						ptr4++;
						ptr3++;
					}
					text2 = null;
				}
				return text;
			}
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x001299E8 File Offset: 0x00127BE8
		private char ToUpperInternal(char c)
		{
			if (!this.m_cultureData.IsInvariantCulture)
			{
				if (c <= 'ǲ')
				{
					if (c > 'ſ')
					{
						if (c <= 'ǈ')
						{
							if (c != 'ǅ' && c != 'ǈ')
							{
								goto IL_15A;
							}
						}
						else if (c != 'ǋ' && c != 'ǲ')
						{
							goto IL_15A;
						}
						return c - '\u0001';
					}
					if (c == 'µ')
					{
						return 'Μ';
					}
					if (c == 'ı')
					{
						return 'I';
					}
					if (c == 'ſ')
					{
						return 'S';
					}
				}
				else if (c <= 'ϰ')
				{
					if (c <= 'ς')
					{
						if (c == 'ͅ')
						{
							return 'Ι';
						}
						if (c == 'ς')
						{
							return 'Σ';
						}
					}
					else
					{
						switch (c)
						{
						case 'ϐ':
							return 'Β';
						case 'ϑ':
							return 'Θ';
						case 'ϒ':
						case 'ϓ':
						case 'ϔ':
							break;
						case 'ϕ':
							return 'Φ';
						case 'ϖ':
							return 'Π';
						default:
							if (c == 'ϰ')
							{
								return 'Κ';
							}
							break;
						}
					}
				}
				else if (c <= 'ϵ')
				{
					if (c == 'ϱ')
					{
						return 'Ρ';
					}
					if (c == 'ϵ')
					{
						return 'Ε';
					}
				}
				else
				{
					if (c == 'ẛ')
					{
						return 'Ṡ';
					}
					if (c == 'ι')
					{
						return 'Ι';
					}
				}
				IL_15A:
				if (!this.IsAsciiCasingSameAsInvariant)
				{
					if (c == 'i')
					{
						return 'İ';
					}
					if (TextInfo.IsAscii(c))
					{
						return TextInfo.ToUpperAsciiInvariant(c);
					}
				}
			}
			if (c >= 'à' && c <= 'ֆ')
			{
				return TextInfoToUpperData.range_00e0_0586[(int)(c - 'à')];
			}
			if (c >= 'ḁ' && c <= 'ῳ')
			{
				return TextInfoToUpperData.range_1e01_1ff3[(int)(c - 'ḁ')];
			}
			if (c >= 'ⅰ' && c <= 'ↄ')
			{
				return TextInfoToUpperData.range_2170_2184[(int)(c - 'ⅰ')];
			}
			if (c >= 'ⓐ' && c <= 'ⓩ')
			{
				return TextInfoToUpperData.range_24d0_24e9[(int)(c - 'ⓐ')];
			}
			if (c >= 'ⰰ' && c <= 'ⳣ')
			{
				return TextInfoToUpperData.range_2c30_2ce3[(int)(c - 'ⰰ')];
			}
			if (c >= 'ⴀ' && c <= 'ⴥ')
			{
				return TextInfoToUpperData.range_2d00_2d25[(int)(c - 'ⴀ')];
			}
			if (c >= 'ꙁ' && c <= 'ꚗ')
			{
				return TextInfoToUpperData.range_a641_a697[(int)(c - 'ꙁ')];
			}
			if (c >= 'ꜣ' && c <= 'ꞌ')
			{
				return TextInfoToUpperData.range_a723_a78c[(int)(c - 'ꜣ')];
			}
			if ('ａ' <= c && c <= 'ｚ')
			{
				return c - ' ';
			}
			if (c == 'ᵹ')
			{
				return 'Ᵹ';
			}
			if (c == 'ᵽ')
			{
				return 'Ᵽ';
			}
			if (c != 'ⅎ')
			{
				return c;
			}
			return 'Ⅎ';
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x00129CA4 File Offset: 0x00127EA4
		private char ToLowerInternal(char c)
		{
			if (!this.m_cultureData.IsInvariantCulture)
			{
				if (c <= 'ǲ')
				{
					if (c <= 'ǅ')
					{
						if (c == 'İ')
						{
							return 'i';
						}
						if (c != 'ǅ')
						{
							goto IL_D3;
						}
					}
					else if (c != 'ǈ' && c != 'ǋ' && c != 'ǲ')
					{
						goto IL_D3;
					}
					return c + '\u0001';
				}
				if (c <= 'ẞ')
				{
					switch (c)
					{
					case 'ϒ':
						return 'υ';
					case 'ϓ':
						return 'ύ';
					case 'ϔ':
						return 'ϋ';
					default:
						if (c == 'ϴ')
						{
							return 'θ';
						}
						if (c == 'ẞ')
						{
							return 'ß';
						}
						break;
					}
				}
				else
				{
					if (c == 'Ω')
					{
						return 'ω';
					}
					if (c == 'K')
					{
						return 'k';
					}
					if (c == 'Å')
					{
						return 'å';
					}
				}
				IL_D3:
				if (!this.IsAsciiCasingSameAsInvariant)
				{
					if (c == 'I')
					{
						return 'ı';
					}
					if (TextInfo.IsAscii(c))
					{
						return TextInfo.ToLowerAsciiInvariant(c);
					}
				}
			}
			if (c >= 'À' && c <= 'Ֆ')
			{
				return TextInfoToLowerData.range_00c0_0556[(int)(c - 'À')];
			}
			if (c >= 'Ⴀ' && c <= 'Ⴥ')
			{
				return TextInfoToLowerData.range_10a0_10c5[(int)(c - 'Ⴀ')];
			}
			if (c >= 'Ḁ' && c <= 'ῼ')
			{
				return TextInfoToLowerData.range_1e00_1ffc[(int)(c - 'Ḁ')];
			}
			if (c >= 'Ⅰ' && c <= 'Ⅿ')
			{
				return TextInfoToLowerData.range_2160_216f[(int)(c - 'Ⅰ')];
			}
			if (c >= 'Ⓐ' && c <= 'Ⓩ')
			{
				return TextInfoToLowerData.range_24b6_24cf[(int)(c - 'Ⓐ')];
			}
			if (c >= 'Ⰰ' && c <= 'Ⱞ')
			{
				return TextInfoToLowerData.range_2c00_2c2e[(int)(c - 'Ⰰ')];
			}
			if (c >= 'Ⱡ' && c <= 'Ⳣ')
			{
				return TextInfoToLowerData.range_2c60_2ce2[(int)(c - 'Ⱡ')];
			}
			if (c >= 'Ꙁ' && c <= 'Ꚗ')
			{
				return TextInfoToLowerData.range_a640_a696[(int)(c - 'Ꙁ')];
			}
			if (c >= 'Ꜣ' && c <= 'Ꞌ')
			{
				return TextInfoToLowerData.range_a722_a78b[(int)(c - 'Ꜣ')];
			}
			if ('Ａ' <= c && c <= 'Ｚ')
			{
				return c + ' ';
			}
			if (c == 'Ⅎ')
			{
				return 'ⅎ';
			}
			if (c != 'Ↄ')
			{
				return c;
			}
			return 'ↄ';
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x00129EEC File Offset: 0x001280EC
		internal unsafe static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB)
		{
			if (strA == null)
			{
				if (strB != null)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (strB == null)
				{
					return 1;
				}
				int num = Math.Min(lenA, strA.Length - indexA);
				int num2 = Math.Min(lenB, strB.Length - indexB);
				if (num == num2 && strA == strB)
				{
					return 0;
				}
				char* ptr = strA;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				char* ptr2 = strB;
				if (ptr2 != null)
				{
					ptr2 += RuntimeHelpers.OffsetToStringData / 2;
				}
				char* ptr3 = ptr + indexA;
				char* ptr4 = ptr3 + Math.Min(num, num2);
				char* ptr5 = ptr2 + indexB;
				while (ptr3 < ptr4)
				{
					if (*ptr3 != *ptr5)
					{
						char c = char.ToUpperInvariant(*ptr3);
						char c2 = char.ToUpperInvariant(*ptr5);
						if (c != c2)
						{
							return (int)(c - c2);
						}
					}
					ptr3++;
					ptr5++;
				}
				return num - num2;
			}
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x00129FB4 File Offset: 0x001281B4
		internal unsafe void ToLowerAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination)
		{
			for (int i = 0; i < source.Length; i++)
			{
				*destination[i] = TextInfo.ToLowerAsciiInvariant((char)(*source[i]));
			}
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x00129FEC File Offset: 0x001281EC
		internal unsafe void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination)
		{
			for (int i = 0; i < source.Length; i++)
			{
				*destination[i] = TextInfo.ToUpperAsciiInvariant((char)(*source[i]));
			}
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x0012A024 File Offset: 0x00128224
		internal unsafe void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper)
		{
			if (source.IsEmpty)
			{
				return;
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(destination))
				{
					char* ptr2 = reference2;
					int i = 0;
					char* ptr3 = ptr;
					char* ptr4 = ptr2;
					if (toUpper)
					{
						while (i < source.Length)
						{
							*(ptr4++) = this.ToUpper(*(ptr3++));
							i++;
						}
					}
					else
					{
						while (i < source.Length)
						{
							*(ptr4++) = this.ToLower(*(ptr3++));
							i++;
						}
					}
				}
			}
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x000173AD File Offset: 0x000155AD
		internal TextInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040036A9 RID: 13993
		[OptionalField(VersionAdded = 2)]
		private string m_listSeparator;

		// Token: 0x040036AA RID: 13994
		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x040036AB RID: 13995
		[OptionalField(VersionAdded = 3)]
		private string m_cultureName;

		// Token: 0x040036AC RID: 13996
		[NonSerialized]
		private CultureData m_cultureData;

		// Token: 0x040036AD RID: 13997
		[NonSerialized]
		private string m_textInfoName;

		// Token: 0x040036AE RID: 13998
		[NonSerialized]
		private bool? m_IsAsciiCasingSameAsInvariant;

		// Token: 0x040036AF RID: 13999
		internal static volatile TextInfo s_Invariant;

		// Token: 0x040036B0 RID: 14000
		[OptionalField(VersionAdded = 2)]
		private string customCultureName;

		// Token: 0x040036B1 RID: 14001
		[OptionalField(VersionAdded = 1)]
		internal int m_nDataItem;

		// Token: 0x040036B2 RID: 14002
		[OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		// Token: 0x040036B3 RID: 14003
		[OptionalField(VersionAdded = 1)]
		internal int m_win32LangID;

		// Token: 0x040036B4 RID: 14004
		private const int wordSeparatorMask = 536672256;
	}
}
