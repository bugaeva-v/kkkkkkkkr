using System;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Globalization
{
	/// <summary>Получает сведения о символе Юникода. Этот класс не наследуется.</summary>
	// Token: 0x02000954 RID: 2388
	public static class CharUnicodeInfo
	{
		// Token: 0x0600540F RID: 21519 RVA: 0x00118CB8 File Offset: 0x00116EB8
		internal static int InternalConvertToUtf32(string s, int index)
		{
			if (index < s.Length - 1)
			{
				int num = (int)(s[index] - '\ud800');
				if (num <= 1023)
				{
					int num2 = (int)(s[index + 1] - '\udc00');
					if (num2 <= 1023)
					{
						return num * 1024 + num2 + 65536;
					}
				}
			}
			return (int)s[index];
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x00118D18 File Offset: 0x00116F18
		internal static int InternalConvertToUtf32(StringBuilder s, int index)
		{
			int num = (int)s[index];
			if (index < s.Length - 1)
			{
				int num2 = num - 55296;
				if (num2 <= 1023)
				{
					int num3 = (int)(s[index + 1] - '\udc00');
					if (num3 <= 1023)
					{
						return num2 * 1024 + num3 + 65536;
					}
				}
			}
			return num;
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x00118D74 File Offset: 0x00116F74
		internal static int InternalConvertToUtf32(string s, int index, out int charLength)
		{
			charLength = 1;
			if (index < s.Length - 1)
			{
				int num = (int)(s[index] - '\ud800');
				if (num <= 1023)
				{
					int num2 = (int)(s[index + 1] - '\udc00');
					if (num2 <= 1023)
					{
						charLength++;
						return num * 1024 + num2 + 65536;
					}
				}
			}
			return (int)s[index];
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x00118DDC File Offset: 0x00116FDC
		internal unsafe static double InternalGetNumericValue(int ch)
		{
			int num = ch >> 8;
			if (num >= CharUnicodeInfo.NumericLevel1Index.Length)
			{
				return -1.0;
			}
			num = (int)(*CharUnicodeInfo.NumericLevel1Index[num]);
			num = (int)(*CharUnicodeInfo.NumericLevel2Index[(num << 4) + (ch >> 4 & 15)]);
			num = (int)(*CharUnicodeInfo.NumericLevel3Index[(num << 4) + (ch & 15)]);
			ref byte source = ref Unsafe.AsRef<byte>(CharUnicodeInfo.NumericValues[num * 8]);
			if (BitConverter.IsLittleEndian)
			{
				return Unsafe.ReadUnaligned<double>(ref source);
			}
			return BitConverter.Int64BitsToDouble(BinaryPrimitives.ReverseEndianness(Unsafe.ReadUnaligned<long>(ref source)));
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x00118E7C File Offset: 0x0011707C
		internal unsafe static byte InternalGetDigitValues(int ch, int offset)
		{
			int num = ch >> 8;
			if (num < CharUnicodeInfo.NumericLevel1Index.Length)
			{
				num = (int)(*CharUnicodeInfo.NumericLevel1Index[num]);
				num = (int)(*CharUnicodeInfo.NumericLevel2Index[(num << 4) + (ch >> 4 & 15)]);
				num = (int)(*CharUnicodeInfo.NumericLevel3Index[(num << 4) + (ch & 15)]);
				return *CharUnicodeInfo.DigitValues[num * 2 + offset];
			}
			return byte.MaxValue;
		}

		/// <summary>Получает числовое значение, связанное с указанным символом.</summary>
		/// <param name="ch">Символ Юникода, для которого следует получить числовое значение.</param>
		/// <returns>Числовое значение, связанное с указанным символом.  
		///
		/// или - 
		/// -1, если указанный символ не является числовым символом.</returns>
		// Token: 0x06005414 RID: 21524 RVA: 0x00118EF6 File Offset: 0x001170F6
		public static double GetNumericValue(char ch)
		{
			return CharUnicodeInfo.InternalGetNumericValue((int)ch);
		}

		/// <summary>Получает числовое значение, связанное с символом, расположенным по указанному индексу в указанной строке.</summary>
		/// <param name="s">Параметр <see cref="T:System.String" />, содержащий символ Юникода, для которого следует получить числовое значение.</param>
		/// <param name="index">Индекс символа Юникода, для которого следует получить числовое значение.</param>
		/// <returns>Числовое значение, связанное с символом, расположенным по указанному индексу в указанной строке.  
		///
		/// или - 
		/// -1, если символ на месте указанного индекса указанной строки не является числовым символом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона допустимых индексов в <paramref name="s" />.</exception>
		// Token: 0x06005415 RID: 21525 RVA: 0x00118EFE File Offset: 0x001170FE
		public static double GetNumericValue(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index < 0 || index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return CharUnicodeInfo.InternalGetNumericValue(CharUnicodeInfo.InternalConvertToUtf32(s, index));
		}

		/// <summary>Получает десятичное цифровое значение указанного числового символа.</summary>
		/// <param name="ch">Символ Юникода, для которого следует получить десятичное цифровое значение.</param>
		/// <returns>Десятичное цифровое значение указанного числового символа.  
		///
		/// или - 
		/// -1, если указанный символ не является десятичной цифрой.</returns>
		// Token: 0x06005416 RID: 21526 RVA: 0x00118F37 File Offset: 0x00117137
		public static int GetDecimalDigitValue(char ch)
		{
			return (int)((sbyte)CharUnicodeInfo.InternalGetDigitValues((int)ch, 0));
		}

		/// <summary>Получает десятичное цифровое значение числового символа на месте указанного индекса указанной строки.</summary>
		/// <param name="s">Параметр <see cref="T:System.String" />, содержащий символ Юникода, для которого следует получить десятичное цифровое значение.</param>
		/// <param name="index">Индекс символа Юникода, для которого следует получить десятичное цифровое значение.</param>
		/// <returns>Десятичное цифровое значение числового символа на месте указанного индекса указанной строки.  
		///
		/// или - 
		/// -1, если символ на месте указанного индекса указанной строки не является десятичной цифрой.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона допустимых индексов в <paramref name="s" />.</exception>
		// Token: 0x06005417 RID: 21527 RVA: 0x00118F41 File Offset: 0x00117141
		public static int GetDecimalDigitValue(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index < 0 || index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return (int)((sbyte)CharUnicodeInfo.InternalGetDigitValues(CharUnicodeInfo.InternalConvertToUtf32(s, index), 0));
		}

		/// <summary>Получает цифровое значение указанного числового символа.</summary>
		/// <param name="ch">Символ Юникода, для которого следует получить цифровое значение.</param>
		/// <returns>Цифровое значение указанного числового символа.  
		///
		/// или - 
		/// -1, если указанный символ не является цифрой.</returns>
		// Token: 0x06005418 RID: 21528 RVA: 0x00118F7C File Offset: 0x0011717C
		public static int GetDigitValue(char ch)
		{
			return (int)((sbyte)CharUnicodeInfo.InternalGetDigitValues((int)ch, 1));
		}

		/// <summary>Получает цифровое значение числового символа на месте указанного индекса указанной строки.</summary>
		/// <param name="s">Параметр <see cref="T:System.String" />, содержащий символ Юникода, для которого следует получить цифровое значение.</param>
		/// <param name="index">Индекс символа Юникода, для которого следует получить цифровое значение.</param>
		/// <returns>Цифровое значение числового символа на месте указанного индекса указанной строки.  
		///
		/// или - 
		/// -1, если символ на месте указанного индекса указанной строки не является цифрой.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона допустимых индексов в <paramref name="s" />.</exception>
		// Token: 0x06005419 RID: 21529 RVA: 0x00118F86 File Offset: 0x00117186
		public static int GetDigitValue(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index < 0 || index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return (int)((sbyte)CharUnicodeInfo.InternalGetDigitValues(CharUnicodeInfo.InternalConvertToUtf32(s, index), 1));
		}

		/// <summary>Получает категорию Юникода, относящуюся к указанному символу.</summary>
		/// <param name="ch">Символ Юникода, для которого следует получить категорию Юникода.</param>
		/// <returns>Значение <see cref="T:System.Globalization.UnicodeCategory" />, указывающее категорию указанного символа.</returns>
		// Token: 0x0600541A RID: 21530 RVA: 0x00118FC1 File Offset: 0x001171C1
		public static UnicodeCategory GetUnicodeCategory(char ch)
		{
			return CharUnicodeInfo.GetUnicodeCategory((int)ch);
		}

		/// <summary>Получает категорию Юникода, относящуюся к символу, расположенному по заданному индексу в заданной строке.</summary>
		/// <param name="s">Параметр <see cref="T:System.String" />, содержащий символ Юникода, для которого следует получить категорию Юникода.</param>
		/// <param name="index">Индекс символа Юникода, для которого следует получить категорию Юникода.</param>
		/// <returns>Значение <see cref="T:System.Globalization.UnicodeCategory" />, указывающее категорию Юникода, относящуюся к символу, расположенному по заданному индексу в заданной строке.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона допустимых индексов в <paramref name="s" />.</exception>
		// Token: 0x0600541B RID: 21531 RVA: 0x00118FC9 File Offset: 0x001171C9
		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return CharUnicodeInfo.InternalGetUnicodeCategory(s, index);
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x00118FF4 File Offset: 0x001171F4
		public static UnicodeCategory GetUnicodeCategory(int codePoint)
		{
			return (UnicodeCategory)CharUnicodeInfo.InternalGetCategoryValue(codePoint, 0);
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x00119000 File Offset: 0x00117200
		internal unsafe static byte InternalGetCategoryValue(int ch, int offset)
		{
			int num = (int)(*CharUnicodeInfo.CategoryLevel1Index[ch >> 9]);
			num = (int)Unsafe.ReadUnaligned<ushort>(Unsafe.AsRef<byte>(CharUnicodeInfo.CategoryLevel2Index[(num << 6) + (ch >> 3 & 62)]));
			if (!BitConverter.IsLittleEndian)
			{
				num = (int)BinaryPrimitives.ReverseEndianness((ushort)num);
			}
			num = (int)(*CharUnicodeInfo.CategoryLevel3Index[(num << 4) + (ch & 15)]);
			return *CharUnicodeInfo.CategoriesValue[num * 2 + offset];
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x0011907B File Offset: 0x0011727B
		internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
		{
			return CharUnicodeInfo.GetUnicodeCategory(CharUnicodeInfo.InternalConvertToUtf32(value, index));
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x00119089 File Offset: 0x00117289
		internal static BidiCategory GetBidiCategory(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return (BidiCategory)CharUnicodeInfo.InternalGetCategoryValue(CharUnicodeInfo.InternalConvertToUtf32(s, index), 1);
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x001190BA File Offset: 0x001172BA
		internal static BidiCategory GetBidiCategory(StringBuilder s, int index)
		{
			return (BidiCategory)CharUnicodeInfo.InternalGetCategoryValue(CharUnicodeInfo.InternalConvertToUtf32(s, index), 1);
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x001190C9 File Offset: 0x001172C9
		internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength)
		{
			return CharUnicodeInfo.GetUnicodeCategory(CharUnicodeInfo.InternalConvertToUtf32(str, index, out charLength));
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x001190D8 File Offset: 0x001172D8
		internal static bool IsCombiningCategory(UnicodeCategory uc)
		{
			return uc == UnicodeCategory.NonSpacingMark || uc == UnicodeCategory.SpacingCombiningMark || uc == UnicodeCategory.EnclosingMark;
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x001190E8 File Offset: 0x001172E8
		internal static bool IsWhiteSpace(string s, int index)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(s, index);
			return unicodeCategory - UnicodeCategory.SpaceSeparator <= 2;
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x00119108 File Offset: 0x00117308
		internal static bool IsWhiteSpace(char c)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
			return unicodeCategory - UnicodeCategory.SpaceSeparator <= 2;
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06005425 RID: 21541 RVA: 0x00119126 File Offset: 0x00117326
		private unsafe static ReadOnlySpan<byte> CategoryLevel1Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B55F94CD2F415D0279D7A1AF2265C4D9A90CE47F8C900D5D09AD088796210838), 2176);
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x00119137 File Offset: 0x00117337
		private unsafe static ReadOnlySpan<byte> CategoryLevel2Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.9086502742CE7F0595B57A4E5B32901FF4CF97959B92F7E91A435E4765AC1115), 5952);
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06005427 RID: 21543 RVA: 0x00119148 File Offset: 0x00117348
		private unsafe static ReadOnlySpan<byte> CategoryLevel3Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.56073E3CC3FC817690CC306D0DB7EA63EBCB0801359567CA44CA3D3B9BF63854), 10800);
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06005428 RID: 21544 RVA: 0x00119159 File Offset: 0x00117359
		private unsafe static ReadOnlySpan<byte> CategoriesValue
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.D6691EE5A533DE7E0859066942261B24D0C836D7EE016D2251377BFEE40FEA15), 172);
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06005429 RID: 21545 RVA: 0x0011916A File Offset: 0x0011736A
		private unsafe static ReadOnlySpan<byte> NumericLevel1Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.765BD07ED3CB498A599FFB48B31E077C45B4C2C37CD1547CEA27E60655CF21B6), 761);
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x0011917B File Offset: 0x0011737B
		private unsafe static ReadOnlySpan<byte> NumericLevel2Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F7D2AD02ED768134B31339AB059D864789E0A60090CC368B3881EB0631BBAF93), 1024);
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x0600542B RID: 21547 RVA: 0x0011918C File Offset: 0x0011738C
		private unsafe static ReadOnlySpan<byte> NumericLevel3Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.AB0B9733AAEC4A2806711E41E36D3D0923BAF116156F33445DC2AA58DA5DF877), 1824);
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x0011919D File Offset: 0x0011739D
		private unsafe static ReadOnlySpan<byte> NumericValues
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.692DE452EE427272A5F6154F04360D24165B56693B08F60D93127DEDC12D1DDE), 1320);
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x0600542D RID: 21549 RVA: 0x001191AE File Offset: 0x001173AE
		private unsafe static ReadOnlySpan<byte> DigitValues
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.1A52279427700E21F7E68A077A8F17857A850718317B7228442260DBA2AF68F0), 330);
			}
		}

		// Token: 0x040033B3 RID: 13235
		internal const char HIGH_SURROGATE_START = '\ud800';

		// Token: 0x040033B4 RID: 13236
		internal const char HIGH_SURROGATE_END = '\udbff';

		// Token: 0x040033B5 RID: 13237
		internal const char LOW_SURROGATE_START = '\udc00';

		// Token: 0x040033B6 RID: 13238
		internal const char LOW_SURROGATE_END = '\udfff';

		// Token: 0x040033B7 RID: 13239
		internal const int HIGH_SURROGATE_RANGE = 1023;

		// Token: 0x040033B8 RID: 13240
		internal const int UNICODE_CATEGORY_OFFSET = 0;

		// Token: 0x040033B9 RID: 13241
		internal const int BIDI_CATEGORY_OFFSET = 1;

		// Token: 0x040033BA RID: 13242
		internal const int UNICODE_PLANE01_START = 65536;
	}
}
