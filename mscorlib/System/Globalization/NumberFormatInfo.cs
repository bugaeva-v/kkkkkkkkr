using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Globalization
{
	/// <summary>Предоставляет сведения для конкретного языка и региональных параметров для числовых значений форматирования и анализа.</summary>
	// Token: 0x02000994 RID: 2452
	[ComVisible(true)]
	[Serializable]
	public sealed class NumberFormatInfo : ICloneable, IFormatProvider
	{
		/// <summary>Инициализирует новый доступный для записи экземпляр класса <see cref="T:System.Globalization.NumberFormatInfo" />, не зависящий от языка и региональных параметров (инвариантный).</summary>
		// Token: 0x0600578E RID: 22414 RVA: 0x00127B8B File Offset: 0x00125D8B
		public NumberFormatInfo() : this(null)
		{
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x00127B94 File Offset: 0x00125D94
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			if (this.numberDecimalSeparator != this.numberGroupSeparator)
			{
				this.validForParseAsNumber = true;
			}
			else
			{
				this.validForParseAsNumber = false;
			}
			if (this.numberDecimalSeparator != this.numberGroupSeparator && this.numberDecimalSeparator != this.currencyGroupSeparator && this.currencyDecimalSeparator != this.numberGroupSeparator && this.currencyDecimalSeparator != this.currencyGroupSeparator)
			{
				this.validForParseAsCurrency = true;
				return;
			}
			this.validForParseAsCurrency = false;
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x00127C1F File Offset: 0x00125E1F
		private static void VerifyDecimalSeparator(string decSep, string propertyName)
		{
			if (decSep == null)
			{
				throw new ArgumentNullException(propertyName, Environment.GetResourceString("String reference not set to an instance of a String."));
			}
			if (decSep.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Decimal separator cannot be the empty string."));
			}
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x00127C4D File Offset: 0x00125E4D
		private static void VerifyGroupSeparator(string groupSep, string propertyName)
		{
			if (groupSep == null)
			{
				throw new ArgumentNullException(propertyName, Environment.GetResourceString("String reference not set to an instance of a String."));
			}
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x00127C64 File Offset: 0x00125E64
		private static void VerifyNativeDigits(string[] nativeDig, string propertyName)
		{
			if (nativeDig == null)
			{
				throw new ArgumentNullException(propertyName, Environment.GetResourceString("Array cannot be null."));
			}
			if (nativeDig.Length != 10)
			{
				throw new ArgumentException(Environment.GetResourceString("The NativeDigits array must contain exactly ten members."), propertyName);
			}
			for (int i = 0; i < nativeDig.Length; i++)
			{
				if (nativeDig[i] == null)
				{
					throw new ArgumentNullException(propertyName, Environment.GetResourceString("Found a null value within an array."));
				}
				if (nativeDig[i].Length != 1)
				{
					if (nativeDig[i].Length != 2)
					{
						throw new ArgumentException(Environment.GetResourceString("Each member of the NativeDigits array must be a single text element (one or more UTF16 code points) with a Unicode Nd (Number, Decimal Digit) property indicating it is a digit."), propertyName);
					}
					if (!char.IsSurrogatePair(nativeDig[i][0], nativeDig[i][1]))
					{
						throw new ArgumentException(Environment.GetResourceString("Each member of the NativeDigits array must be a single text element (one or more UTF16 code points) with a Unicode Nd (Number, Decimal Digit) property indicating it is a digit."), propertyName);
					}
				}
				if (CharUnicodeInfo.GetDecimalDigitValue(nativeDig[i], 0) != i && CharUnicodeInfo.GetUnicodeCategory(nativeDig[i], 0) != UnicodeCategory.PrivateUse)
				{
					throw new ArgumentException(Environment.GetResourceString("Each member of the NativeDigits array must be a single text element (one or more UTF16 code points) with a Unicode Nd (Number, Decimal Digit) property indicating it is a digit."), propertyName);
				}
			}
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x00127D42 File Offset: 0x00125F42
		private static void VerifyDigitSubstitution(DigitShapes digitSub, string propertyName)
		{
			if (digitSub > DigitShapes.NativeNational)
			{
				throw new ArgumentException(Environment.GetResourceString("The DigitSubstitution property must be of a valid member of the DigitShapes enumeration. Valid entries include Context, NativeNational or None."), propertyName);
			}
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x00127D5C File Offset: 0x00125F5C
		[SecuritySafeCritical]
		internal NumberFormatInfo(CultureData cultureData)
		{
			if (GlobalizationMode.Invariant)
			{
				this.m_isInvariant = true;
				return;
			}
			if (cultureData != null)
			{
				cultureData.GetNFIValues(this);
				if (cultureData.IsInvariantCulture)
				{
					this.m_isInvariant = true;
				}
			}
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x00127EF0 File Offset: 0x001260F0
		private void VerifyWritable()
		{
			if (this.isReadOnly)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Globalization.NumberFormatInfo" />, доступный только для чтения, который не зависит от языка и региональных параметров (инвариантный).</summary>
		/// <returns>Объект, доступный только для чтения, который не зависит от языка и региональных параметров (инвариантный).</returns>
		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06005798 RID: 22424 RVA: 0x00127F0A File Offset: 0x0012610A
		public static NumberFormatInfo InvariantInfo
		{
			get
			{
				if (NumberFormatInfo.invariantInfo == null)
				{
					NumberFormatInfo.invariantInfo = NumberFormatInfo.ReadOnly(new NumberFormatInfo
					{
						m_isInvariant = true
					});
				}
				return NumberFormatInfo.invariantInfo;
			}
		}

		/// <summary>Возвращает класс <see cref="T:System.Globalization.NumberFormatInfo" />, связанный с заданным <see cref="T:System.IFormatProvider" />.</summary>
		/// <param name="formatProvider">Объект <see cref="T:System.IFormatProvider" />, используемый для получения <see cref="T:System.Globalization.NumberFormatInfo" />.  
		/// -или- 
		///  Значение <see langword="null" />, чтобы получить <see cref="P:System.Globalization.NumberFormatInfo.CurrentInfo" />.</param>
		/// <returns>Класс <see cref="T:System.Globalization.NumberFormatInfo" />, связанный с заданным классом <see cref="T:System.IFormatProvider" />.</returns>
		// Token: 0x06005799 RID: 22425 RVA: 0x00127F34 File Offset: 0x00126134
		public static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
		{
			CultureInfo cultureInfo = formatProvider as CultureInfo;
			if (cultureInfo != null && !cultureInfo.m_isInherited)
			{
				NumberFormatInfo numberFormatInfo = cultureInfo.numInfo;
				if (numberFormatInfo != null)
				{
					return numberFormatInfo;
				}
				return cultureInfo.NumberFormat;
			}
			else
			{
				NumberFormatInfo numberFormatInfo = formatProvider as NumberFormatInfo;
				if (numberFormatInfo != null)
				{
					return numberFormatInfo;
				}
				if (formatProvider != null)
				{
					numberFormatInfo = (formatProvider.GetFormat(typeof(NumberFormatInfo)) as NumberFormatInfo);
					if (numberFormatInfo != null)
					{
						return numberFormatInfo;
					}
				}
				return NumberFormatInfo.CurrentInfo;
			}
		}

		/// <summary>Создает неполную копию объекта <see cref="T:System.Globalization.NumberFormatInfo" />.</summary>
		/// <returns>Новый объект, скопированный из исходного объекта <see cref="T:System.Globalization.NumberFormatInfo" />.</returns>
		// Token: 0x0600579A RID: 22426 RVA: 0x00127F97 File Offset: 0x00126197
		public object Clone()
		{
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)base.MemberwiseClone();
			numberFormatInfo.isReadOnly = false;
			return numberFormatInfo;
		}

		/// <summary>Возвращает или задает число десятичных разрядов, используемое в значениях денежных сумм.</summary>
		/// <returns>Число десятичных разрядов, используемое в значениях денежных сумм. Значение по умолчанию для аргумента <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно 2.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано значение меньше 0 или больше 99.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x0600579B RID: 22427 RVA: 0x00127FAB File Offset: 0x001261AB
		// (set) Token: 0x0600579C RID: 22428 RVA: 0x00127FB4 File Offset: 0x001261B4
		public int CurrencyDecimalDigits
		{
			get
			{
				return this.currencyDecimalDigits;
			}
			set
			{
				if (value < 0 || value > 99)
				{
					throw new ArgumentOutOfRangeException("CurrencyDecimalDigits", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 99));
				}
				this.VerifyWritable();
				this.currencyDecimalDigits = value;
			}
		}

		/// <summary>Возвращает или задает строку, используемую в качестве десятичного разделителя в значениях денежных сумм.</summary>
		/// <returns>Строка, используемая в качестве десятичного разделителя в значениях денежных сумм. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно ".".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">Для свойства задается пустая строка.</exception>
		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x00128003 File Offset: 0x00126203
		// (set) Token: 0x0600579E RID: 22430 RVA: 0x0012800B File Offset: 0x0012620B
		public string CurrencyDecimalSeparator
		{
			get
			{
				return this.currencyDecimalSeparator;
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyDecimalSeparator(value, "CurrencyDecimalSeparator");
				this.currencyDecimalSeparator = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли данный объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x00128025 File Offset: 0x00126225
		public bool IsReadOnly
		{
			get
			{
				return this.isReadOnly;
			}
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x00128030 File Offset: 0x00126230
		internal static void CheckGroupSize(string propName, int[] groupSize)
		{
			int i = 0;
			while (i < groupSize.Length)
			{
				if (groupSize[i] < 1)
				{
					if (i == groupSize.Length - 1 && groupSize[i] == 0)
					{
						return;
					}
					throw new ArgumentException(Environment.GetResourceString("Every element in the value array should be between one and nine, except for the last element, which can be zero."), propName);
				}
				else
				{
					if (groupSize[i] > 9)
					{
						throw new ArgumentException(Environment.GetResourceString("Every element in the value array should be between one and nine, except for the last element, which can be zero."), propName);
					}
					i++;
				}
			}
		}

		/// <summary>Возвращает или задает число цифр в каждой из групп целой части десятичной дроби в значениях денежных сумм.</summary>
		/// <returns>Число цифр в каждой из групп целой части десятичной дроби в значениях денежных сумм. Для свойства <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> по умолчанию используется одномерный массив с единственным элементом, для которого задано значение 3.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для свойства задается значение, и массив содержит запись, которая меньше 0 или больше 9.  
		/// -или- 
		/// Для свойства задается значение, и массив содержит запись, отличную от последней записи, которая имеет значение 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x00128088 File Offset: 0x00126288
		// (set) Token: 0x060057A2 RID: 22434 RVA: 0x0012809C File Offset: 0x0012629C
		public int[] CurrencyGroupSizes
		{
			get
			{
				return (int[])this.currencyGroupSizes.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("CurrencyGroupSizes", Environment.GetResourceString("Object cannot be null."));
				}
				this.VerifyWritable();
				int[] groupSize = (int[])value.Clone();
				NumberFormatInfo.CheckGroupSize("CurrencyGroupSizes", groupSize);
				this.currencyGroupSizes = groupSize;
			}
		}

		/// <summary>Возвращает или задает число цифр в каждой из групп целой части десятичной дроби в числовых значениях.</summary>
		/// <returns>Число цифр в каждой из групп целой части десятичной дроби в числовых значениях. Для свойства <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> по умолчанию используется одномерный массив с единственным элементом, для которого задано значение 3.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для свойства задается значение, и массив содержит запись, которая меньше 0 или больше 9.  
		/// -или- 
		/// Для свойства задается значение, и массив содержит запись, отличную от последней записи, которая имеет значение 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x060057A3 RID: 22435 RVA: 0x001280E5 File Offset: 0x001262E5
		// (set) Token: 0x060057A4 RID: 22436 RVA: 0x001280F8 File Offset: 0x001262F8
		public int[] NumberGroupSizes
		{
			get
			{
				return (int[])this.numberGroupSizes.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("NumberGroupSizes", Environment.GetResourceString("Object cannot be null."));
				}
				this.VerifyWritable();
				int[] groupSize = (int[])value.Clone();
				NumberFormatInfo.CheckGroupSize("NumberGroupSizes", groupSize);
				this.numberGroupSizes = groupSize;
			}
		}

		/// <summary>Возвращает или задает количество цифр в каждой из групп разрядов целой части десятичной дроби в значениях процентов.</summary>
		/// <returns>Число цифр в каждой из групп целой части десятичной дроби в значениях процентов. Для свойства <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> по умолчанию используется одномерный массив с единственным элементом, для которого задано значение 3.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для свойства задается значение, и массив содержит запись, которая меньше 0 или больше 9.  
		/// -или- 
		/// Для свойства задается значение, и массив содержит запись, отличную от последней записи, которая имеет значение 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x060057A5 RID: 22437 RVA: 0x00128141 File Offset: 0x00126341
		// (set) Token: 0x060057A6 RID: 22438 RVA: 0x00128154 File Offset: 0x00126354
		public int[] PercentGroupSizes
		{
			get
			{
				return (int[])this.percentGroupSizes.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("PercentGroupSizes", Environment.GetResourceString("Object cannot be null."));
				}
				this.VerifyWritable();
				int[] groupSize = (int[])value.Clone();
				NumberFormatInfo.CheckGroupSize("PercentGroupSizes", groupSize);
				this.percentGroupSizes = groupSize;
			}
		}

		/// <summary>Возвращает или задает строку, разделяющую разряды в целой части десятичной дроби в значениях денежных сумм.</summary>
		/// <returns>Строка, разделяющая разряды в целой части десятичной дроби в значениях денежных сумм. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно "-".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x060057A7 RID: 22439 RVA: 0x0012819D File Offset: 0x0012639D
		// (set) Token: 0x060057A8 RID: 22440 RVA: 0x001281A5 File Offset: 0x001263A5
		public string CurrencyGroupSeparator
		{
			get
			{
				return this.currencyGroupSeparator;
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyGroupSeparator(value, "CurrencyGroupSeparator");
				this.currencyGroupSeparator = value;
			}
		}

		/// <summary>Возвращает или задает строку, используемую в качестве знака денежной единицы.</summary>
		/// <returns>Строка, используемая в качестве знака денежной единицы. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> — "¤".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x060057A9 RID: 22441 RVA: 0x001281BF File Offset: 0x001263BF
		// (set) Token: 0x060057AA RID: 22442 RVA: 0x001281C7 File Offset: 0x001263C7
		public string CurrencySymbol
		{
			get
			{
				return this.currencySymbol;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("CurrencySymbol", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.currencySymbol = value;
			}
		}

		/// <summary>Возвращает доступный только для чтения объект <see cref="T:System.Globalization.NumberFormatInfo" />, форматирующий значения на основе текущего языка и региональных параметров.</summary>
		/// <returns>Доступный только для чтения объект <see cref="T:System.Globalization.NumberFormatInfo" /> на основе языка и региональных параметров текущего потока.</returns>
		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x060057AB RID: 22443 RVA: 0x001281F0 File Offset: 0x001263F0
		public static NumberFormatInfo CurrentInfo
		{
			get
			{
				CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
				if (!currentCulture.m_isInherited)
				{
					NumberFormatInfo numInfo = currentCulture.numInfo;
					if (numInfo != null)
					{
						return numInfo;
					}
				}
				return (NumberFormatInfo)currentCulture.GetFormat(typeof(NumberFormatInfo));
			}
		}

		/// <summary>Возвращает или задает строку, представляющую значение IEEE NaN (не числовое).</summary>
		/// <returns>Строка, представляющая значение IEEE NaN (не числовое). Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> — "NaN".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x00128233 File Offset: 0x00126433
		// (set) Token: 0x060057AD RID: 22445 RVA: 0x0012823B File Offset: 0x0012643B
		public string NaNSymbol
		{
			get
			{
				return this.nanSymbol;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("NaNSymbol", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.nanSymbol = value;
			}
		}

		/// <summary>Возвращает или задает шаблон формата для отрицательных значений денежных сумм.</summary>
		/// <returns>Шаблон формата для отрицательных значений денежных сумм. По умолчанию для свойства <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> задано значение 0, представляющее "($n)", где "$" — это <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" />, а <paramref name="n" /> — число.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано значение меньше 0 или больше 15.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x060057AE RID: 22446 RVA: 0x00128262 File Offset: 0x00126462
		// (set) Token: 0x060057AF RID: 22447 RVA: 0x0012826C File Offset: 0x0012646C
		public int CurrencyNegativePattern
		{
			get
			{
				return this.currencyNegativePattern;
			}
			set
			{
				if (value < 0 || value > 15)
				{
					throw new ArgumentOutOfRangeException("CurrencyNegativePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 15));
				}
				this.VerifyWritable();
				this.currencyNegativePattern = value;
			}
		}

		/// <summary>Возвращает или задает шаблон формата для отрицательных числовых значений.</summary>
		/// <returns>Шаблон формата для отрицательных числовых значений.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано значение меньше 0 или больше 4.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x060057B0 RID: 22448 RVA: 0x001282BB File Offset: 0x001264BB
		// (set) Token: 0x060057B1 RID: 22449 RVA: 0x001282C4 File Offset: 0x001264C4
		public int NumberNegativePattern
		{
			get
			{
				return this.numberNegativePattern;
			}
			set
			{
				if (value < 0 || value > 4)
				{
					throw new ArgumentOutOfRangeException("NumberNegativePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 4));
				}
				this.VerifyWritable();
				this.numberNegativePattern = value;
			}
		}

		/// <summary>Возвращает или задает шаблон формата для положительных значений процентов.</summary>
		/// <returns>Шаблон формата для положительных значений процентов. По умолчанию для свойства <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> задано значение 0, представляющее "n %", где "%" — это <see cref="P:System.Globalization.NumberFormatInfo.PercentSymbol" />, а <paramref name="n" /> — число.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано значение меньше 0 или больше 3.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x060057B2 RID: 22450 RVA: 0x00128311 File Offset: 0x00126511
		// (set) Token: 0x060057B3 RID: 22451 RVA: 0x0012831C File Offset: 0x0012651C
		public int PercentPositivePattern
		{
			get
			{
				return this.percentPositivePattern;
			}
			set
			{
				if (value < 0 || value > 3)
				{
					throw new ArgumentOutOfRangeException("PercentPositivePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 3));
				}
				this.VerifyWritable();
				this.percentPositivePattern = value;
			}
		}

		/// <summary>Возвращает или задает шаблон формата для отрицательных значений процентов.</summary>
		/// <returns>Шаблон формата для отрицательных значений процентов. По умолчанию для свойства <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> задано значение 0, представляющее "-n %", где "%" — это <see cref="P:System.Globalization.NumberFormatInfo.PercentSymbol" />, а <paramref name="n" /> — число.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано значение меньше 0 или больше 11.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x060057B4 RID: 22452 RVA: 0x00128369 File Offset: 0x00126569
		// (set) Token: 0x060057B5 RID: 22453 RVA: 0x00128374 File Offset: 0x00126574
		public int PercentNegativePattern
		{
			get
			{
				return this.percentNegativePattern;
			}
			set
			{
				if (value < 0 || value > 11)
				{
					throw new ArgumentOutOfRangeException("PercentNegativePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 11));
				}
				this.VerifyWritable();
				this.percentNegativePattern = value;
			}
		}

		/// <summary>Возвращает или задает строку, представляющую минус бесконечность.</summary>
		/// <returns>Строка, представляющая минус бесконечность. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> ‏‏— "Infinity".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x060057B6 RID: 22454 RVA: 0x001283C3 File Offset: 0x001265C3
		// (set) Token: 0x060057B7 RID: 22455 RVA: 0x001283CB File Offset: 0x001265CB
		public string NegativeInfinitySymbol
		{
			get
			{
				return this.negativeInfinitySymbol;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("NegativeInfinitySymbol", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.negativeInfinitySymbol = value;
			}
		}

		/// <summary>Возвращает или задает строку, указывающую, что соответствующее число является отрицательным.</summary>
		/// <returns>Строка, указывающая, что соответствующее число является отрицательным. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> — "+".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x001283F2 File Offset: 0x001265F2
		// (set) Token: 0x060057B9 RID: 22457 RVA: 0x001283FA File Offset: 0x001265FA
		public string NegativeSign
		{
			get
			{
				return this.negativeSign;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("NegativeSign", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.negativeSign = value;
			}
		}

		/// <summary>Возвращает или задает число десятичных разрядов, используемое в числовых значениях.</summary>
		/// <returns>Число десятичных разрядов, используемое в числовых значениях. Значение по умолчанию для аргумента <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно 2.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано значение меньше 0 или больше 99.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x060057BA RID: 22458 RVA: 0x00128421 File Offset: 0x00126621
		// (set) Token: 0x060057BB RID: 22459 RVA: 0x0012842C File Offset: 0x0012662C
		public int NumberDecimalDigits
		{
			get
			{
				return this.numberDecimalDigits;
			}
			set
			{
				if (value < 0 || value > 99)
				{
					throw new ArgumentOutOfRangeException("NumberDecimalDigits", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 99));
				}
				this.VerifyWritable();
				this.numberDecimalDigits = value;
			}
		}

		/// <summary>Возвращает или задает строку, используемую в качестве десятичного разделителя в числовых значениях.</summary>
		/// <returns>Строка, используемая в качестве десятичного разделителя в числовых значениях. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно ".".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">Для свойства задается пустая строка.</exception>
		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x060057BC RID: 22460 RVA: 0x0012847B File Offset: 0x0012667B
		// (set) Token: 0x060057BD RID: 22461 RVA: 0x00128483 File Offset: 0x00126683
		public string NumberDecimalSeparator
		{
			get
			{
				return this.numberDecimalSeparator;
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyDecimalSeparator(value, "NumberDecimalSeparator");
				this.numberDecimalSeparator = value;
			}
		}

		/// <summary>Возвращает или задает строку, разделяющую разряды в целой части десятичной дроби в числовых значениях.</summary>
		/// <returns>Строка, разделяющая разряды в целой части десятичной дроби в числовых значениях. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно "-".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x0012849D File Offset: 0x0012669D
		// (set) Token: 0x060057BF RID: 22463 RVA: 0x001284A5 File Offset: 0x001266A5
		public string NumberGroupSeparator
		{
			get
			{
				return this.numberGroupSeparator;
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyGroupSeparator(value, "NumberGroupSeparator");
				this.numberGroupSeparator = value;
			}
		}

		/// <summary>Возвращает или задает шаблон формата для положительных значений денежных сумм.</summary>
		/// <returns>Шаблон формата для положительных значений денежных сумм. По умолчанию для свойства <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> задано значение 0, представляющее "$n", где "$" — это <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" />, а <paramref name="n" /> — число.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано значение меньше 0 или больше 3.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060057C0 RID: 22464 RVA: 0x001284BF File Offset: 0x001266BF
		// (set) Token: 0x060057C1 RID: 22465 RVA: 0x001284C8 File Offset: 0x001266C8
		public int CurrencyPositivePattern
		{
			get
			{
				return this.currencyPositivePattern;
			}
			set
			{
				if (value < 0 || value > 3)
				{
					throw new ArgumentOutOfRangeException("CurrencyPositivePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 3));
				}
				this.VerifyWritable();
				this.currencyPositivePattern = value;
			}
		}

		/// <summary>Возвращает или задает строку, представляющую плюс бесконечность.</summary>
		/// <returns>Строка, представляющая плюс бесконечность. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> ‏‏равно "Infinity".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x00128515 File Offset: 0x00126715
		// (set) Token: 0x060057C3 RID: 22467 RVA: 0x0012851D File Offset: 0x0012671D
		public string PositiveInfinitySymbol
		{
			get
			{
				return this.positiveInfinitySymbol;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("PositiveInfinitySymbol", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.positiveInfinitySymbol = value;
			}
		}

		/// <summary>Возвращает или задает строку, указывающую, что соответствующее число является положительным.</summary>
		/// <returns>Строка, указывающая, что соответствующее число является положительным. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно "+".</returns>
		/// <exception cref="T:System.ArgumentNullException">В операции присваивания присваиваемое значение меньше <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060057C4 RID: 22468 RVA: 0x00128544 File Offset: 0x00126744
		// (set) Token: 0x060057C5 RID: 22469 RVA: 0x0012854C File Offset: 0x0012674C
		public string PositiveSign
		{
			get
			{
				return this.positiveSign;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("PositiveSign", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.positiveSign = value;
			}
		}

		/// <summary>Возвращает или задает количество десятичных разрядов, используемое в значениях процентов.</summary>
		/// <returns>Число десятичных разрядов, используемое в значениях процентов. Значение по умолчанию для аргумента <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно 2.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано значение меньше 0 или больше 99.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060057C6 RID: 22470 RVA: 0x00128573 File Offset: 0x00126773
		// (set) Token: 0x060057C7 RID: 22471 RVA: 0x0012857C File Offset: 0x0012677C
		public int PercentDecimalDigits
		{
			get
			{
				return this.percentDecimalDigits;
			}
			set
			{
				if (value < 0 || value > 99)
				{
					throw new ArgumentOutOfRangeException("PercentDecimalDigits", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 99));
				}
				this.VerifyWritable();
				this.percentDecimalDigits = value;
			}
		}

		/// <summary>Возвращает или задает строку, используемую в качестве десятичного разделителя в значениях процентов.</summary>
		/// <returns>Строка, используемая в качестве десятичного разделителя в значениях процентов. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно ".".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">Для свойства задается пустая строка.</exception>
		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060057C8 RID: 22472 RVA: 0x001285CB File Offset: 0x001267CB
		// (set) Token: 0x060057C9 RID: 22473 RVA: 0x001285D3 File Offset: 0x001267D3
		public string PercentDecimalSeparator
		{
			get
			{
				return this.percentDecimalSeparator;
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyDecimalSeparator(value, "PercentDecimalSeparator");
				this.percentDecimalSeparator = value;
			}
		}

		/// <summary>Возвращает или задает строку, разделяющую разряды в целой части десятичной дроби в значениях процентов.</summary>
		/// <returns>Строка, разделяющая разряды в целой части десятичной дроби в значениях процентов. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно "-".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060057CA RID: 22474 RVA: 0x001285ED File Offset: 0x001267ED
		// (set) Token: 0x060057CB RID: 22475 RVA: 0x001285F5 File Offset: 0x001267F5
		public string PercentGroupSeparator
		{
			get
			{
				return this.percentGroupSeparator;
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyGroupSeparator(value, "PercentGroupSeparator");
				this.percentGroupSeparator = value;
			}
		}

		/// <summary>Возвращает или задает строку, используемую в качестве знака процентов.</summary>
		/// <returns>Строка, используемая в качестве знака процентов. Значение по умолчанию для объекта <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> равно "%".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060057CC RID: 22476 RVA: 0x0012860F File Offset: 0x0012680F
		// (set) Token: 0x060057CD RID: 22477 RVA: 0x00128617 File Offset: 0x00126817
		public string PercentSymbol
		{
			get
			{
				return this.percentSymbol;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("PercentSymbol", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.percentSymbol = value;
			}
		}

		/// <summary>Возвращает или задает строку, используемую в качестве знака промилле.</summary>
		/// <returns>Строка, используемая в качестве знака промилле. Значением по умолчанию для <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> является "‰", что соответствует символу Юникода U+2030.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x060057CE RID: 22478 RVA: 0x0012863E File Offset: 0x0012683E
		// (set) Token: 0x060057CF RID: 22479 RVA: 0x00128646 File Offset: 0x00126846
		public string PerMilleSymbol
		{
			get
			{
				return this.perMilleSymbol;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("PerMilleSymbol", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.perMilleSymbol = value;
			}
		}

		/// <summary>Возвращает или задает массив строк собственных цифр, эквивалентных арабским цифрам от 0 до 9.</summary>
		/// <returns>Массив строк, содержащий собственный эквивалент арабских цифр от 0 до 9. Значение по умолчанию — массив, включающий элементы "0", "1", "2", "3", "4", "5", "6", "7", "8" и "9".</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentNullException">В операции задания значением является <see langword="null" />.  
		/// -или- 
		/// В операции над множеством элемент массива значений является <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В операции над множеством массив значений не содержит 10 элементов.  
		/// -или- 
		/// В операции над множеством элемент массива значений не содержит ни один объект <see cref="T:System.Char" />, ни пару объектов <see cref="T:System.Char" />, составляющих суррогатную пару.  
		///
		/// или - 
		/// В операции над множеством элемент массива значений не является цифрой, как определено стандартом Юникода. То есть цифра в элементе массива не имеет значения общей категории Юникода <see langword="Number, Decimal Digit" /> (Nd).  
		///
		/// или - 
		/// В операции над множеством числовое значение элемента в массиве значений не соответствует положению элемента в массиве. То есть элемент с индексом 0, который является первым элементом массива, не имеет числового значения 0, или элемент с индексом 1 не имеет числового значения 1.</exception>
		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x060057D0 RID: 22480 RVA: 0x0012866D File Offset: 0x0012686D
		// (set) Token: 0x060057D1 RID: 22481 RVA: 0x0012867F File Offset: 0x0012687F
		[ComVisible(false)]
		public string[] NativeDigits
		{
			get
			{
				return (string[])this.nativeDigits.Clone();
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyNativeDigits(value, "NativeDigits");
				this.nativeDigits = value;
			}
		}

		/// <summary>Возвращает или задает значение, определяющее, каким образом а графическом интерфейсе пользователя должны отображаться фигуры цифр.</summary>
		/// <returns>Одно из значений перечисления, указывающее фигуру цифры, связанную с языком и региональными параметрами.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Globalization.NumberFormatInfo" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">Значение в операции задания не является допустимым значением <see cref="T:System.Globalization.DigitShapes" />.</exception>
		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060057D2 RID: 22482 RVA: 0x00128699 File Offset: 0x00126899
		// (set) Token: 0x060057D3 RID: 22483 RVA: 0x001286A1 File Offset: 0x001268A1
		[ComVisible(false)]
		public DigitShapes DigitSubstitution
		{
			get
			{
				return (DigitShapes)this.digitSubstitution;
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyDigitSubstitution(value, "DigitSubstitution");
				this.digitSubstitution = (int)value;
			}
		}

		/// <summary>Возвращает объект указанного типа, предоставляющий службу форматирования чисел.</summary>
		/// <param name="formatType">
		///   <see cref="T:System.Type" /> требуемой службы форматирования.</param>
		/// <returns>Текущий объект <see cref="T:System.Globalization.NumberFormatInfo" />, если параметр <paramref name="formatType" /> совпадает с типом текущего объекта <see cref="T:System.Globalization.NumberFormatInfo" />; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x060057D4 RID: 22484 RVA: 0x001286BB File Offset: 0x001268BB
		public object GetFormat(Type formatType)
		{
			if (!(formatType == typeof(NumberFormatInfo)))
			{
				return null;
			}
			return this;
		}

		/// <summary>Возвращает программу-оболочку <see cref="T:System.Globalization.NumberFormatInfo" />, доступную только для чтения.</summary>
		/// <param name="nfi">Класс <see cref="T:System.Globalization.NumberFormatInfo" />, для которого создается оболочка.</param>
		/// <returns>Доступная только для чтения программа-оболочка <see cref="T:System.Globalization.NumberFormatInfo" /> для параметра <paramref name="nfi" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="nfi" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060057D5 RID: 22485 RVA: 0x001286D2 File Offset: 0x001268D2
		public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			if (nfi == null)
			{
				throw new ArgumentNullException("nfi");
			}
			if (nfi.IsReadOnly)
			{
				return nfi;
			}
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)nfi.MemberwiseClone();
			numberFormatInfo.isReadOnly = true;
			return numberFormatInfo;
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x00128700 File Offset: 0x00126900
		internal static void ValidateParseStyleInteger(NumberStyles style)
		{
			if ((style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier)) != NumberStyles.None)
			{
				throw new ArgumentException(Environment.GetResourceString("An undefined NumberStyles value is being used."), "style");
			}
			if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None && (style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowHexSpecifier)) != NumberStyles.None)
			{
				throw new ArgumentException(Environment.GetResourceString("With the AllowHexSpecifier bit set in the enum bit field, the only other valid bits that can be combined into the enum value must be a subset of those in HexNumber."));
			}
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x0012874D File Offset: 0x0012694D
		internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
			if ((style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier)) != NumberStyles.None)
			{
				throw new ArgumentException(Environment.GetResourceString("An undefined NumberStyles value is being used."), "style");
			}
			if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
			{
				throw new ArgumentException(Environment.GetResourceString("The number style AllowHexSpecifier is not supported on floating point data types."));
			}
		}

		// Token: 0x04003668 RID: 13928
		private static volatile NumberFormatInfo invariantInfo;

		// Token: 0x04003669 RID: 13929
		internal int[] numberGroupSizes = new int[]
		{
			3
		};

		// Token: 0x0400366A RID: 13930
		internal int[] currencyGroupSizes = new int[]
		{
			3
		};

		// Token: 0x0400366B RID: 13931
		internal int[] percentGroupSizes = new int[]
		{
			3
		};

		// Token: 0x0400366C RID: 13932
		internal string positiveSign = "+";

		// Token: 0x0400366D RID: 13933
		internal string negativeSign = "-";

		// Token: 0x0400366E RID: 13934
		internal string numberDecimalSeparator = ".";

		// Token: 0x0400366F RID: 13935
		internal string numberGroupSeparator = ",";

		// Token: 0x04003670 RID: 13936
		internal string currencyGroupSeparator = ",";

		// Token: 0x04003671 RID: 13937
		internal string currencyDecimalSeparator = ".";

		// Token: 0x04003672 RID: 13938
		internal string currencySymbol = "¤";

		// Token: 0x04003673 RID: 13939
		internal string ansiCurrencySymbol;

		// Token: 0x04003674 RID: 13940
		internal string nanSymbol = "NaN";

		// Token: 0x04003675 RID: 13941
		internal string positiveInfinitySymbol = "Infinity";

		// Token: 0x04003676 RID: 13942
		internal string negativeInfinitySymbol = "-Infinity";

		// Token: 0x04003677 RID: 13943
		internal string percentDecimalSeparator = ".";

		// Token: 0x04003678 RID: 13944
		internal string percentGroupSeparator = ",";

		// Token: 0x04003679 RID: 13945
		internal string percentSymbol = "%";

		// Token: 0x0400367A RID: 13946
		internal string perMilleSymbol = "‰";

		// Token: 0x0400367B RID: 13947
		[OptionalField(VersionAdded = 2)]
		internal string[] nativeDigits = new string[]
		{
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9"
		};

		// Token: 0x0400367C RID: 13948
		[OptionalField(VersionAdded = 1)]
		internal int m_dataItem;

		// Token: 0x0400367D RID: 13949
		internal int numberDecimalDigits = 2;

		// Token: 0x0400367E RID: 13950
		internal int currencyDecimalDigits = 2;

		// Token: 0x0400367F RID: 13951
		internal int currencyPositivePattern;

		// Token: 0x04003680 RID: 13952
		internal int currencyNegativePattern;

		// Token: 0x04003681 RID: 13953
		internal int numberNegativePattern = 1;

		// Token: 0x04003682 RID: 13954
		internal int percentPositivePattern;

		// Token: 0x04003683 RID: 13955
		internal int percentNegativePattern;

		// Token: 0x04003684 RID: 13956
		internal int percentDecimalDigits = 2;

		// Token: 0x04003685 RID: 13957
		[OptionalField(VersionAdded = 2)]
		internal int digitSubstitution = 1;

		// Token: 0x04003686 RID: 13958
		internal bool isReadOnly;

		// Token: 0x04003687 RID: 13959
		[OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		// Token: 0x04003688 RID: 13960
		[OptionalField(VersionAdded = 2)]
		internal bool m_isInvariant;

		// Token: 0x04003689 RID: 13961
		[OptionalField(VersionAdded = 1)]
		internal bool validForParseAsNumber = true;

		// Token: 0x0400368A RID: 13962
		[OptionalField(VersionAdded = 1)]
		internal bool validForParseAsCurrency = true;

		// Token: 0x0400368B RID: 13963
		private const NumberStyles InvalidNumberStyles = ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier);
	}
}
