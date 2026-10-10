using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	/// <summary>Предоставляет сведения о форматировании значений даты и времени, связанные с языком и региональными параметрами.</summary>
	// Token: 0x0200095B RID: 2395
	[Serializable]
	public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
	{
		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x0011AD25 File Offset: 0x00118F25
		private string CultureName
		{
			get
			{
				if (this._name == null)
				{
					this._name = this._cultureData.CultureName;
				}
				return this._name;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060054A9 RID: 21673 RVA: 0x0011AD46 File Offset: 0x00118F46
		private CultureInfo Culture
		{
			get
			{
				if (this._cultureInfo == null)
				{
					this._cultureInfo = CultureInfo.GetCultureInfo(this.CultureName);
				}
				return this._cultureInfo;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x0011AD67 File Offset: 0x00118F67
		private string LanguageName
		{
			get
			{
				if (this._langName == null)
				{
					this._langName = this._cultureData.SISO639LANGNAME;
				}
				return this._langName;
			}
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x0011AD88 File Offset: 0x00118F88
		private string[] internalGetAbbreviatedDayOfWeekNames()
		{
			return this.abbreviatedDayNames ?? this.internalGetAbbreviatedDayOfWeekNamesCore();
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x0011AD9A File Offset: 0x00118F9A
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetAbbreviatedDayOfWeekNamesCore()
		{
			this.abbreviatedDayNames = this._cultureData.AbbreviatedDayNames(this.Calendar.ID);
			return this.abbreviatedDayNames;
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x0011ADBE File Offset: 0x00118FBE
		private string[] internalGetSuperShortDayNames()
		{
			return this.m_superShortDayNames ?? this.internalGetSuperShortDayNamesCore();
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x0011ADD0 File Offset: 0x00118FD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetSuperShortDayNamesCore()
		{
			this.m_superShortDayNames = this._cultureData.SuperShortDayNames(this.Calendar.ID);
			return this.m_superShortDayNames;
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x0011ADF4 File Offset: 0x00118FF4
		private string[] internalGetDayOfWeekNames()
		{
			return this.dayNames ?? this.internalGetDayOfWeekNamesCore();
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x0011AE06 File Offset: 0x00119006
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetDayOfWeekNamesCore()
		{
			this.dayNames = this._cultureData.DayNames(this.Calendar.ID);
			return this.dayNames;
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x0011AE2A File Offset: 0x0011902A
		private string[] internalGetAbbreviatedMonthNames()
		{
			return this.abbreviatedMonthNames ?? this.internalGetAbbreviatedMonthNamesCore();
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x0011AE3C File Offset: 0x0011903C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetAbbreviatedMonthNamesCore()
		{
			this.abbreviatedMonthNames = this._cultureData.AbbreviatedMonthNames(this.Calendar.ID);
			return this.abbreviatedMonthNames;
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x0011AE60 File Offset: 0x00119060
		private string[] internalGetMonthNames()
		{
			return this.monthNames ?? this.internalGetMonthNamesCore();
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x0011AE72 File Offset: 0x00119072
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetMonthNamesCore()
		{
			this.monthNames = this._cultureData.MonthNames(this.Calendar.ID);
			return this.monthNames;
		}

		/// <summary>Инициализирует новый доступный для записи экземпляр класса <see cref="T:System.Globalization.DateTimeFormatInfo" />, не зависящий от языка и региональных параметров (инвариантный).</summary>
		// Token: 0x060054B5 RID: 21685 RVA: 0x0011AE98 File Offset: 0x00119098
		public DateTimeFormatInfo()
		{
			this._cultureData = CultureInfo.InvariantCulture._cultureData;
			this.calendar = GregorianCalendar.GetDefaultInstance();
			this.InitializeOverridableProperties(this._cultureData, this.calendar.ID);
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x0011AEF2 File Offset: 0x001190F2
		internal DateTimeFormatInfo(CultureData cultureData, Calendar cal)
		{
			this._cultureData = cultureData;
			this.Calendar = cal;
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x0011AF20 File Offset: 0x00119120
		private void InitializeOverridableProperties(CultureData cultureData, int calendarId)
		{
			if (this.firstDayOfWeek == -1)
			{
				this.firstDayOfWeek = cultureData.IFIRSTDAYOFWEEK;
			}
			if (this.calendarWeekRule == -1)
			{
				this.calendarWeekRule = cultureData.IFIRSTWEEKOFYEAR;
			}
			if (this.amDesignator == null)
			{
				this.amDesignator = cultureData.SAM1159;
			}
			if (this.pmDesignator == null)
			{
				this.pmDesignator = cultureData.SPM2359;
			}
			if (this.timeSeparator == null)
			{
				this.timeSeparator = cultureData.TimeSeparator;
			}
			if (this.dateSeparator == null)
			{
				this.dateSeparator = cultureData.DateSeparator(calendarId);
			}
			this.allLongTimePatterns = this._cultureData.LongTimes;
			this.allShortTimePatterns = this._cultureData.ShortTimes;
			this.allLongDatePatterns = cultureData.LongDates(calendarId);
			this.allShortDatePatterns = cultureData.ShortDates(calendarId);
			this.allYearMonthPatterns = cultureData.YearMonths(calendarId);
		}

		/// <summary>Получает доступный только для чтения объект по умолчанию <see cref="T:System.Globalization.DateTimeFormatInfo" />, который не зависит от языка и региональных параметров (инвариантный).</summary>
		/// <returns>Объект, доступный только для чтения, который не зависит от языка и региональных параметров (инвариантный).</returns>
		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x0011AFF1 File Offset: 0x001191F1
		public static DateTimeFormatInfo InvariantInfo
		{
			get
			{
				if (DateTimeFormatInfo.s_invariantInfo == null)
				{
					DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
					dateTimeFormatInfo.Calendar.SetReadOnlyState(true);
					dateTimeFormatInfo._isReadOnly = true;
					DateTimeFormatInfo.s_invariantInfo = dateTimeFormatInfo;
				}
				return DateTimeFormatInfo.s_invariantInfo;
			}
		}

		/// <summary>Получает доступный только для чтения объект <see cref="T:System.Globalization.DateTimeFormatInfo" />, форматирующий значения на основе текущего языка и региональных параметров.</summary>
		/// <returns>Доступный только для чтения объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> на основе объекта <see cref="T:System.Globalization.CultureInfo" /> текущего потока.</returns>
		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060054B9 RID: 21689 RVA: 0x0011B024 File Offset: 0x00119224
		public static DateTimeFormatInfo CurrentInfo
		{
			get
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				if (!currentCulture._isInherited)
				{
					DateTimeFormatInfo dateTimeInfo = currentCulture.dateTimeInfo;
					if (dateTimeInfo != null)
					{
						return dateTimeInfo;
					}
				}
				return (DateTimeFormatInfo)currentCulture.GetFormat(typeof(DateTimeFormatInfo));
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Globalization.DateTimeFormatInfo" />, связанный с указанным <see cref="T:System.IFormatProvider" />.</summary>
		/// <param name="provider">
		///   <see cref="T:System.IFormatProvider" />, который получает объект <see cref="T:System.Globalization.DateTimeFormatInfo" />.  
		/// -или- 
		///  Значение <see langword="null" />, чтобы получить <see cref="P:System.Globalization.DateTimeFormatInfo.CurrentInfo" />.</param>
		/// <returns>Объект <see cref="T:System.Globalization.DateTimeFormatInfo" />, связанный с <see cref="T:System.IFormatProvider" />.</returns>
		// Token: 0x060054BA RID: 21690 RVA: 0x0011B064 File Offset: 0x00119264
		public static DateTimeFormatInfo GetInstance(IFormatProvider provider)
		{
			if (provider == null)
			{
				return DateTimeFormatInfo.CurrentInfo;
			}
			CultureInfo cultureInfo = provider as CultureInfo;
			if (cultureInfo != null && !cultureInfo._isInherited)
			{
				return cultureInfo.DateTimeFormat;
			}
			DateTimeFormatInfo dateTimeFormatInfo = provider as DateTimeFormatInfo;
			if (dateTimeFormatInfo != null)
			{
				return dateTimeFormatInfo;
			}
			DateTimeFormatInfo dateTimeFormatInfo2 = provider.GetFormat(typeof(DateTimeFormatInfo)) as DateTimeFormatInfo;
			if (dateTimeFormatInfo2 == null)
			{
				return DateTimeFormatInfo.CurrentInfo;
			}
			return dateTimeFormatInfo2;
		}

		/// <summary>Возвращает объект указанного типа, предоставляющий службу форматирования времени и даты.</summary>
		/// <param name="formatType">Тип требуемой службы форматирования.</param>
		/// <returns>Текущий объект, если параметр <paramref name="formatType" /> совпадает с типом текущего объекта <see cref="T:System.Globalization.DateTimeFormatInfo" />; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x060054BB RID: 21691 RVA: 0x0011B0BF File Offset: 0x001192BF
		public object GetFormat(Type formatType)
		{
			if (!(formatType == typeof(DateTimeFormatInfo)))
			{
				return null;
			}
			return this;
		}

		/// <summary>Создает неполную копию <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Globalization.DateTimeFormatInfo" />, скопированный из исходного <see cref="T:System.Globalization.DateTimeFormatInfo" />.</returns>
		// Token: 0x060054BC RID: 21692 RVA: 0x0011B0D6 File Offset: 0x001192D6
		public object Clone()
		{
			DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)base.MemberwiseClone();
			dateTimeFormatInfo.calendar = (Calendar)this.Calendar.Clone();
			dateTimeFormatInfo._isReadOnly = false;
			return dateTimeFormatInfo;
		}

		/// <summary>Возвращает или задает строку указателя часов до полудня (АМ — "ante meridiem").</summary>
		/// <returns>Строка указателя часов до полудня. По умолчанию для свойства <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> установлено значение AM.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060054BD RID: 21693 RVA: 0x0011B100 File Offset: 0x00119300
		// (set) Token: 0x060054BE RID: 21694 RVA: 0x0011B121 File Offset: 0x00119321
		public string AMDesignator
		{
			get
			{
				if (this.amDesignator == null)
				{
					this.amDesignator = this._cultureData.SAM1159;
				}
				return this.amDesignator;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.ClearTokenHashTable();
				this.amDesignator = value;
			}
		}

		/// <summary>Возвращает или задает календарь, используемый в текущей языке и региональных параметрах.</summary>
		/// <returns>Календарь, используемый в текущем языке и региональных параметрах. Значением по умолчанию для <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> является объект <see cref="T:System.Globalization.GregorianCalendar" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задается объект <see cref="T:System.Globalization.Calendar" />, недопустимый для текущего языка и региональных параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x060054BF RID: 21695 RVA: 0x0011B156 File Offset: 0x00119356
		// (set) Token: 0x060054C0 RID: 21696 RVA: 0x0011B160 File Offset: 0x00119360
		public Calendar Calendar
		{
			get
			{
				return this.calendar;
			}
			set
			{
				if (GlobalizationMode.Invariant)
				{
					throw new PlatformNotSupportedException();
				}
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Object cannot be null.");
				}
				if (value == this.calendar)
				{
					return;
				}
				for (int i = 0; i < this.OptionalCalendars.Length; i++)
				{
					if (this.OptionalCalendars[i] == (CalendarId)value.ID)
					{
						if (this.calendar != null)
						{
							this.m_eraNames = null;
							this.m_abbrevEraNames = null;
							this.m_abbrevEnglishEraNames = null;
							this.monthDayPattern = null;
							this.dayNames = null;
							this.abbreviatedDayNames = null;
							this.m_superShortDayNames = null;
							this.monthNames = null;
							this.abbreviatedMonthNames = null;
							this.genitiveMonthNames = null;
							this.m_genitiveAbbreviatedMonthNames = null;
							this.leapYearMonthNames = null;
							this.formatFlags = DateTimeFormatFlags.NotInitialized;
							this.allShortDatePatterns = null;
							this.allLongDatePatterns = null;
							this.allYearMonthPatterns = null;
							this.dateTimeOffsetPattern = null;
							this.longDatePattern = null;
							this.shortDatePattern = null;
							this.yearMonthPattern = null;
							this.fullDateTimePattern = null;
							this.generalShortTimePattern = null;
							this.generalLongTimePattern = null;
							this.dateSeparator = null;
							this.ClearTokenHashTable();
						}
						this.calendar = value;
						this.InitializeOverridableProperties(this._cultureData, this.calendar.ID);
						return;
					}
				}
				throw new ArgumentOutOfRangeException("value", "Not a valid calendar for the given culture.");
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x0011B2BE File Offset: 0x001194BE
		private CalendarId[] OptionalCalendars
		{
			get
			{
				if (this.optionalCalendars == null)
				{
					this.optionalCalendars = this._cultureData.GetCalendarIds();
				}
				return this.optionalCalendars;
			}
		}

		/// <summary>Возвращает целое число, представляющее собой указанную эру.</summary>
		/// <param name="eraName">Строка, содержащая название эры.</param>
		/// <returns>Целое число, представляющее эру, если <paramref name="eraName" /> является допустимым; в противном случае -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="eraName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060054C2 RID: 21698 RVA: 0x0011B2E0 File Offset: 0x001194E0
		public int GetEra(string eraName)
		{
			if (eraName == null)
			{
				throw new ArgumentNullException("eraName", "String reference not set to an instance of a String.");
			}
			if (eraName.Length == 0)
			{
				return -1;
			}
			for (int i = 0; i < this.EraNames.Length; i++)
			{
				if (this.m_eraNames[i].Length > 0 && this.Culture.CompareInfo.Compare(eraName, this.m_eraNames[i], CompareOptions.IgnoreCase) == 0)
				{
					return i + 1;
				}
			}
			for (int j = 0; j < this.AbbreviatedEraNames.Length; j++)
			{
				if (this.Culture.CompareInfo.Compare(eraName, this.m_abbrevEraNames[j], CompareOptions.IgnoreCase) == 0)
				{
					return j + 1;
				}
			}
			for (int k = 0; k < this.AbbreviatedEnglishEraNames.Length; k++)
			{
				if (CompareInfo.Invariant.Compare(eraName, this.m_abbrevEnglishEraNames[k], CompareOptions.IgnoreCase) == 0)
				{
					return k + 1;
				}
			}
			return -1;
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060054C3 RID: 21699 RVA: 0x0011B3AE File Offset: 0x001195AE
		internal string[] EraNames
		{
			get
			{
				if (this.m_eraNames == null)
				{
					this.m_eraNames = this._cultureData.EraNames(this.Calendar.ID);
				}
				return this.m_eraNames;
			}
		}

		/// <summary>Возвращает строку, содержащую название указанной эры.</summary>
		/// <param name="era">Целое число, представляющее собой эру.</param>
		/// <returns>Строка, содержащая название эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="era" /> не является допустимым значением эры в календаре, определенном в свойстве <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" />.</exception>
		// Token: 0x060054C4 RID: 21700 RVA: 0x0011B3DA File Offset: 0x001195DA
		public string GetEraName(int era)
		{
			if (era == 0)
			{
				era = this.Calendar.CurrentEraValue;
			}
			if (--era < this.EraNames.Length && era >= 0)
			{
				return this.m_eraNames[era];
			}
			throw new ArgumentOutOfRangeException("era", "Era value was not valid.");
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x060054C5 RID: 21701 RVA: 0x0011B418 File Offset: 0x00119618
		internal string[] AbbreviatedEraNames
		{
			get
			{
				if (this.m_abbrevEraNames == null)
				{
					this.m_abbrevEraNames = this._cultureData.AbbrevEraNames(this.Calendar.ID);
				}
				return this.m_abbrevEraNames;
			}
		}

		/// <summary>Возвращает строку, содержащую сокращенное название указанной эры, если такое сокращение существует.</summary>
		/// <param name="era">Целое число, представляющее собой эру.</param>
		/// <returns>Строка, содержащая сокращенное название указанной эры, если такое сокращение существует,  
		///
		/// или - 
		/// Строка, содержащая полное название указанной эры, если сокращение отсутствует.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="era" /> не является допустимым значением эры в календаре, определенном в свойстве <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" />.</exception>
		// Token: 0x060054C6 RID: 21702 RVA: 0x0011B444 File Offset: 0x00119644
		public string GetAbbreviatedEraName(int era)
		{
			if (this.AbbreviatedEraNames.Length == 0)
			{
				return this.GetEraName(era);
			}
			if (era == 0)
			{
				era = this.Calendar.CurrentEraValue;
			}
			if (--era < this.m_abbrevEraNames.Length && era >= 0)
			{
				return this.m_abbrevEraNames[era];
			}
			throw new ArgumentOutOfRangeException("era", "Era value was not valid.");
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x060054C7 RID: 21703 RVA: 0x0011B49E File Offset: 0x0011969E
		internal string[] AbbreviatedEnglishEraNames
		{
			get
			{
				if (this.m_abbrevEnglishEraNames == null)
				{
					this.m_abbrevEnglishEraNames = this._cultureData.AbbreviatedEnglishEraNames(this.Calendar.ID);
				}
				return this.m_abbrevEnglishEraNames;
			}
		}

		/// <summary>Возвращает или задает строку, разделяющую компоненты даты — год, месяц и день.</summary>
		/// <returns>Строка, разделяющая компоненты даты — год, месяц и день. Значение по умолчанию для объекта <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> равно "/".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x060054C8 RID: 21704 RVA: 0x0011B4CA File Offset: 0x001196CA
		// (set) Token: 0x060054C9 RID: 21705 RVA: 0x0011B4F6 File Offset: 0x001196F6
		public string DateSeparator
		{
			get
			{
				if (this.dateSeparator == null)
				{
					this.dateSeparator = this._cultureData.DateSeparator(this.Calendar.ID);
				}
				return this.dateSeparator;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.ClearTokenHashTable();
				this.dateSeparator = value;
			}
		}

		/// <summary>Возвращает или задает первый день недели.</summary>
		/// <returns>Значение перечисления, представляющее первый день недели. Значение по умолчанию для свойства <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> равно <see cref="F:System.DayOfWeek.Sunday" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задается значение, не являющееся допустимым значением <see cref="T:System.DayOfWeek" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x0011B52B File Offset: 0x0011972B
		// (set) Token: 0x060054CB RID: 21707 RVA: 0x0011B550 File Offset: 0x00119750
		public DayOfWeek FirstDayOfWeek
		{
			get
			{
				if (this.firstDayOfWeek == -1)
				{
					this.firstDayOfWeek = this._cultureData.IFIRSTDAYOFWEEK;
				}
				return (DayOfWeek)this.firstDayOfWeek;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value >= DayOfWeek.Sunday && value <= DayOfWeek.Saturday)
				{
					this.firstDayOfWeek = (int)value;
					return;
				}
				throw new ArgumentOutOfRangeException("value", SR.Format("Valid values are between {0} and {1}, inclusive.", DayOfWeek.Sunday, DayOfWeek.Saturday));
			}
		}

		/// <summary>Возвращает или задает значение, определяющее правило, используемое для определения первой календарной недели года.</summary>
		/// <returns>Значение, определяющее первую календарную неделю года. Значение по умолчанию для свойства <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> равно <see cref="F:System.Globalization.CalendarWeekRule.FirstDay" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задается значение, не являющееся допустимым значением <see cref="T:System.Globalization.CalendarWeekRule" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x0011B5A0 File Offset: 0x001197A0
		// (set) Token: 0x060054CD RID: 21709 RVA: 0x0011B5C4 File Offset: 0x001197C4
		public CalendarWeekRule CalendarWeekRule
		{
			get
			{
				if (this.calendarWeekRule == -1)
				{
					this.calendarWeekRule = this._cultureData.IFIRSTWEEKOFYEAR;
				}
				return (CalendarWeekRule)this.calendarWeekRule;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value >= CalendarWeekRule.FirstDay && value <= CalendarWeekRule.FirstFourDayWeek)
				{
					this.calendarWeekRule = (int)value;
					return;
				}
				throw new ArgumentOutOfRangeException("value", SR.Format("Valid values are between {0} and {1}, inclusive.", CalendarWeekRule.FirstDay, CalendarWeekRule.FirstFourDayWeek));
			}
		}

		/// <summary>Получает или задает строку пользовательского формата для длинного значения даты и длинного значения времени.</summary>
		/// <returns>Строка пользовательского формата для длинного значения даты и длинного значения времени.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x060054CE RID: 21710 RVA: 0x0011B614 File Offset: 0x00119814
		// (set) Token: 0x060054CF RID: 21711 RVA: 0x0011B640 File Offset: 0x00119840
		public string FullDateTimePattern
		{
			get
			{
				if (this.fullDateTimePattern == null)
				{
					this.fullDateTimePattern = this.LongDatePattern + " " + this.LongTimePattern;
				}
				return this.fullDateTimePattern;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.fullDateTimePattern = value;
			}
		}

		/// <summary>Получает или задает строку пользовательского формата для длинного значения даты.</summary>
		/// <returns>Строка пользовательского формата для длинного значения даты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x060054D0 RID: 21712 RVA: 0x0011B66F File Offset: 0x0011986F
		// (set) Token: 0x060054D1 RID: 21713 RVA: 0x0011B68D File Offset: 0x0011988D
		public string LongDatePattern
		{
			get
			{
				if (this.longDatePattern == null)
				{
					this.longDatePattern = this.UnclonedLongDatePatterns[0];
				}
				return this.longDatePattern;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.longDatePattern = value;
				this.ClearTokenHashTable();
				this.fullDateTimePattern = null;
			}
		}

		/// <summary>Получает или задает строку пользовательского формата для длинного значения времени.</summary>
		/// <returns>Шаблон формата для долговременного значения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x0011B6C9 File Offset: 0x001198C9
		// (set) Token: 0x060054D3 RID: 21715 RVA: 0x0011B6E8 File Offset: 0x001198E8
		public string LongTimePattern
		{
			get
			{
				if (this.longTimePattern == null)
				{
					this.longTimePattern = this.UnclonedLongTimePatterns[0];
				}
				return this.longTimePattern;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.longTimePattern = value;
				this.ClearTokenHashTable();
				this.fullDateTimePattern = null;
				this.generalLongTimePattern = null;
				this.dateTimeOffsetPattern = null;
			}
		}

		/// <summary>Получает или задает строку пользовательского формата для значения месяца и дня.</summary>
		/// <returns>Строка пользовательского формата для значения месяца и дня.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x060054D4 RID: 21716 RVA: 0x0011B73D File Offset: 0x0011993D
		// (set) Token: 0x060054D5 RID: 21717 RVA: 0x0011B769 File Offset: 0x00119969
		public string MonthDayPattern
		{
			get
			{
				if (this.monthDayPattern == null)
				{
					this.monthDayPattern = this._cultureData.MonthDay(this.Calendar.ID);
				}
				return this.monthDayPattern;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.monthDayPattern = value;
			}
		}

		/// <summary>Возвращает или задает строку указателя часов после полудня (PМ — "post meridiem").</summary>
		/// <returns>Строка указателя часов после полудня (PМ — "post meridiem"). Значение по умолчанию для объекта <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> равно PM.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060054D6 RID: 21718 RVA: 0x0011B798 File Offset: 0x00119998
		// (set) Token: 0x060054D7 RID: 21719 RVA: 0x0011B7B9 File Offset: 0x001199B9
		public string PMDesignator
		{
			get
			{
				if (this.pmDesignator == null)
				{
					this.pmDesignator = this._cultureData.SPM2359;
				}
				return this.pmDesignator;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.ClearTokenHashTable();
				this.pmDesignator = value;
			}
		}

		/// <summary>Получает строку пользовательского формата для значения времени, основанного на спецификации IETF Request for Comments 1123 (RFC IETF).</summary>
		/// <returns>Строка пользовательского формата для значения времени на основе спецификации 1123 IETF RFC.</returns>
		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x060054D8 RID: 21720 RVA: 0x0011B7EE File Offset: 0x001199EE
		public string RFC1123Pattern
		{
			get
			{
				return "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";
			}
		}

		/// <summary>Получает или задает строку пользовательского формата для короткого значения даты.</summary>
		/// <returns>Строка пользовательского формата для короткого значения даты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060054D9 RID: 21721 RVA: 0x0011B7F5 File Offset: 0x001199F5
		// (set) Token: 0x060054DA RID: 21722 RVA: 0x0011B814 File Offset: 0x00119A14
		public string ShortDatePattern
		{
			get
			{
				if (this.shortDatePattern == null)
				{
					this.shortDatePattern = this.UnclonedShortDatePatterns[0];
				}
				return this.shortDatePattern;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.shortDatePattern = value;
				this.ClearTokenHashTable();
				this.generalLongTimePattern = null;
				this.generalShortTimePattern = null;
				this.dateTimeOffsetPattern = null;
			}
		}

		/// <summary>Получает или задает строку пользовательского формата для короткого значения времени.</summary>
		/// <returns>Строка пользовательского формата для короткого значения времени.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x0011B869 File Offset: 0x00119A69
		// (set) Token: 0x060054DC RID: 21724 RVA: 0x0011B887 File Offset: 0x00119A87
		public string ShortTimePattern
		{
			get
			{
				if (this.shortTimePattern == null)
				{
					this.shortTimePattern = this.UnclonedShortTimePatterns[0];
				}
				return this.shortTimePattern;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.shortTimePattern = value;
				this.ClearTokenHashTable();
				this.generalShortTimePattern = null;
			}
		}

		/// <summary>Получает строку пользовательского формата для сортируемого значения даты и времени.</summary>
		/// <returns>Строка пользовательского формата для сортируемого значения даты и времени.</returns>
		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x0011B8C3 File Offset: 0x00119AC3
		public string SortableDateTimePattern
		{
			get
			{
				return "yyyy'-'MM'-'dd'T'HH':'mm':'ss";
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x060054DE RID: 21726 RVA: 0x0011B8CA File Offset: 0x00119ACA
		internal string GeneralShortTimePattern
		{
			get
			{
				if (this.generalShortTimePattern == null)
				{
					this.generalShortTimePattern = this.ShortDatePattern + " " + this.ShortTimePattern;
				}
				return this.generalShortTimePattern;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x060054DF RID: 21727 RVA: 0x0011B8F6 File Offset: 0x00119AF6
		internal string GeneralLongTimePattern
		{
			get
			{
				if (this.generalLongTimePattern == null)
				{
					this.generalLongTimePattern = this.ShortDatePattern + " " + this.LongTimePattern;
				}
				return this.generalLongTimePattern;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x060054E0 RID: 21728 RVA: 0x0011B924 File Offset: 0x00119B24
		internal string DateTimeOffsetPattern
		{
			get
			{
				if (this.dateTimeOffsetPattern == null)
				{
					string str = this.ShortDatePattern + " " + this.LongTimePattern;
					bool flag = false;
					bool flag2 = false;
					char c = '\'';
					int num = 0;
					while (!flag && num < this.LongTimePattern.Length)
					{
						char c2 = this.LongTimePattern[num];
						if (c2 <= '%')
						{
							if (c2 == '"')
							{
								goto IL_6A;
							}
							if (c2 == '%')
							{
								goto IL_96;
							}
						}
						else
						{
							if (c2 == '\'')
							{
								goto IL_6A;
							}
							if (c2 == '\\')
							{
								goto IL_96;
							}
							if (c2 == 'z')
							{
								flag = !flag2;
							}
						}
						IL_9C:
						num++;
						continue;
						IL_6A:
						if (flag2 && c == this.LongTimePattern[num])
						{
							flag2 = false;
							goto IL_9C;
						}
						if (!flag2)
						{
							c = this.LongTimePattern[num];
							flag2 = true;
							goto IL_9C;
						}
						goto IL_9C;
						IL_96:
						num++;
						goto IL_9C;
					}
					if (!flag)
					{
						str += " zzz";
					}
					this.dateTimeOffsetPattern = str;
				}
				return this.dateTimeOffsetPattern;
			}
		}

		/// <summary>Возвращает или задает строку, разделяющую компоненты времени — час, минуты и секунды.</summary>
		/// <returns>Строка, разделяющая компоненты времени. Значение по умолчанию для объекта <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> равно ":".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x0011BA04 File Offset: 0x00119C04
		// (set) Token: 0x060054E2 RID: 21730 RVA: 0x0011BA25 File Offset: 0x00119C25
		public string TimeSeparator
		{
			get
			{
				if (this.timeSeparator == null)
				{
					this.timeSeparator = this._cultureData.TimeSeparator;
				}
				return this.timeSeparator;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.ClearTokenHashTable();
				this.timeSeparator = value;
			}
		}

		/// <summary>Получает строку пользовательского формата для универсальной, сортируемой строки даты и времени.</summary>
		/// <returns>Строка пользовательского формата для универсальной, сортируемой строки даты и времени.</returns>
		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060054E3 RID: 21731 RVA: 0x0011BA5A File Offset: 0x00119C5A
		public string UniversalSortableDateTimePattern
		{
			get
			{
				return "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";
			}
		}

		/// <summary>Получает или задает строку пользовательского формата для значения года и месяца.</summary>
		/// <returns>Строка пользовательского формата для значения года и месяца.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060054E4 RID: 21732 RVA: 0x0011BA61 File Offset: 0x00119C61
		// (set) Token: 0x060054E5 RID: 21733 RVA: 0x0011BA7F File Offset: 0x00119C7F
		public string YearMonthPattern
		{
			get
			{
				if (this.yearMonthPattern == null)
				{
					this.yearMonthPattern = this.UnclonedYearMonthPatterns[0];
				}
				return this.yearMonthPattern;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "String reference not set to an instance of a String.");
				}
				this.yearMonthPattern = value;
				this.ClearTokenHashTable();
			}
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x0011BAB4 File Offset: 0x00119CB4
		private static void CheckNullValue(string[] values, int length)
		{
			for (int i = 0; i < length; i++)
			{
				if (values[i] == null)
				{
					throw new ArgumentNullException("value", "Found a null value within an array.");
				}
			}
		}

		/// <summary>Возвращает или задает одномерный массив типа <see cref="T:System.String" />, содержащий сокращения дней недели, принятые в определенном языке и региональных параметрах.</summary>
		/// <returns>Одномерный массив типа <see cref="T:System.String" />, содержащий сокращения дней недели, принятые в определенном языке и региональных параметрах. Массив для <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> содержит сокращения "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство задается для многомерного массива или для массива, длина которого не равна 7.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x0011BAE2 File Offset: 0x00119CE2
		// (set) Token: 0x060054E8 RID: 21736 RVA: 0x0011BAF4 File Offset: 0x00119CF4
		public string[] AbbreviatedDayNames
		{
			get
			{
				return (string[])this.internalGetAbbreviatedDayOfWeekNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Array cannot be null.");
				}
				if (value.Length != 7)
				{
					throw new ArgumentException(SR.Format("Length of the array must be {0}.", 7), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length);
				this.ClearTokenHashTable();
				this.abbreviatedDayNames = value;
			}
		}

		/// <summary>Возвращает или задает массив строк самых кратких уникальных сокращений имен дней, связанный с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <returns>Массив строк имен дней.</returns>
		/// <exception cref="T:System.ArgumentException">В операции присваивания массив не имеет ровно семь элементов.</exception>
		/// <exception cref="T:System.ArgumentNullException">В наборе операций массив значений или один из элементов массива значений имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x0011BB5E File Offset: 0x00119D5E
		// (set) Token: 0x060054EA RID: 21738 RVA: 0x0011BB70 File Offset: 0x00119D70
		public string[] ShortestDayNames
		{
			get
			{
				return (string[])this.internalGetSuperShortDayNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Array cannot be null.");
				}
				if (value.Length != 7)
				{
					throw new ArgumentException(SR.Format("Length of the array must be {0}.", 7), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length);
				this.m_superShortDayNames = value;
			}
		}

		/// <summary>Получает или задает одномерный массив строк, содержащий полные названия дней недели, принятые в определенном языке и региональных параметрах.</summary>
		/// <returns>Одномерный массив строк, содержащий полные названия дней недели, принятые в определенном языке и региональных параметрах. Массив для свойства <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> содержит значения "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" и "Воскресенье".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство задается для многомерного массива или для массива, длина которого не равна 7.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x0011BBD4 File Offset: 0x00119DD4
		// (set) Token: 0x060054EC RID: 21740 RVA: 0x0011BBE8 File Offset: 0x00119DE8
		public string[] DayNames
		{
			get
			{
				return (string[])this.internalGetDayOfWeekNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Array cannot be null.");
				}
				if (value.Length != 7)
				{
					throw new ArgumentException(SR.Format("Length of the array must be {0}.", 7), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length);
				this.ClearTokenHashTable();
				this.dayNames = value;
			}
		}

		/// <summary>Получает или задает одномерный строковый массив, содержащий сокращения месяцев, принятые в определенном языке и региональных параметрах.</summary>
		/// <returns>Одномерный строковый массив, состоящий из 13 элементов и содержащий сокращения месяцев, принятые в определенном языке и региональных параметрах. В 12-месячных календарях тринадцатый элемент массива представляет собой пустую строку. Массив для свойства <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> содержит элементы "Янв", "Фев", "Мар", "Апр", "Май", "Июн", "Июл", "Авг", "Сен", "Окт", "Ноя", "Дек" и "".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство задается для многомерного массива или для массива, длина которого не равна 13.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x0011BC52 File Offset: 0x00119E52
		// (set) Token: 0x060054EE RID: 21742 RVA: 0x0011BC64 File Offset: 0x00119E64
		public string[] AbbreviatedMonthNames
		{
			get
			{
				return (string[])this.internalGetAbbreviatedMonthNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Array cannot be null.");
				}
				if (value.Length != 13)
				{
					throw new ArgumentException(SR.Format("Length of the array must be {0}.", 13), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length - 1);
				this.ClearTokenHashTable();
				this.abbreviatedMonthNames = value;
			}
		}

		/// <summary>Возвращает или задает одномерный массив типа <see cref="T:System.String" />, содержащий полные названия месяцев, принятые в определенном языке и региональных параметрах.</summary>
		/// <returns>Одномерный массив типа <see cref="T:System.String" />, содержащий полные названия месяцев, принятые в определенном языке и региональных параметрах. В 12-месячном календаре тринадцатый элемент массива представляет собой пустую строку. Массив для свойства <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> содержит элементы "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" и "".</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство задается для многомерного массива или для массива, длина которого не равна 13.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для свойства задается значение, а объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x0011BCD2 File Offset: 0x00119ED2
		// (set) Token: 0x060054F0 RID: 21744 RVA: 0x0011BCE4 File Offset: 0x00119EE4
		public string[] MonthNames
		{
			get
			{
				return (string[])this.internalGetMonthNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Array cannot be null.");
				}
				if (value.Length != 13)
				{
					throw new ArgumentException(SR.Format("Length of the array must be {0}.", 13), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length - 1);
				this.monthNames = value;
				this.ClearTokenHashTable();
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x0011BD52 File Offset: 0x00119F52
		internal bool HasSpacesInMonthNames
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseSpacesInMonthNames) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x060054F2 RID: 21746 RVA: 0x0011BD5F File Offset: 0x00119F5F
		internal bool HasSpacesInDayNames
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseSpacesInDayNames) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x0011BD70 File Offset: 0x00119F70
		internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			string[] array;
			if (style != MonthNameStyles.Genitive)
			{
				if (style != MonthNameStyles.LeapYear)
				{
					array = (abbreviated ? this.internalGetAbbreviatedMonthNames() : this.internalGetMonthNames());
				}
				else
				{
					array = this.internalGetLeapYearMonthNames();
				}
			}
			else
			{
				array = this.internalGetGenitiveMonthNames(abbreviated);
			}
			if (month < 1 || month > array.Length)
			{
				throw new ArgumentOutOfRangeException("month", SR.Format("Valid values are between {0} and {1}, inclusive.", 1, array.Length));
			}
			return array[month - 1];
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x0011BDE0 File Offset: 0x00119FE0
		private string[] internalGetGenitiveMonthNames(bool abbreviated)
		{
			if (abbreviated)
			{
				if (this.m_genitiveAbbreviatedMonthNames == null)
				{
					this.m_genitiveAbbreviatedMonthNames = this._cultureData.AbbreviatedGenitiveMonthNames(this.Calendar.ID);
				}
				return this.m_genitiveAbbreviatedMonthNames;
			}
			if (this.genitiveMonthNames == null)
			{
				this.genitiveMonthNames = this._cultureData.GenitiveMonthNames(this.Calendar.ID);
			}
			return this.genitiveMonthNames;
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x0011BE45 File Offset: 0x0011A045
		internal string[] internalGetLeapYearMonthNames()
		{
			if (this.leapYearMonthNames == null)
			{
				this.leapYearMonthNames = this._cultureData.LeapYearMonthNames(this.Calendar.ID);
			}
			return this.leapYearMonthNames;
		}

		/// <summary>Возвращает полное название указанного дня недели, принятое в определенном языке и региональных параметрах, связанных с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <param name="dayofweek">Значение <see cref="T:System.DayOfWeek" />.</param>
		/// <returns>Сокращение дня недели, принятое в определенном языке и региональных параметрах, представленных свойством <paramref name="dayofweek" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="dayofweek" /> не является допустимым значением <see cref="T:System.DayOfWeek" />.</exception>
		// Token: 0x060054F6 RID: 21750 RVA: 0x0011BE71 File Offset: 0x0011A071
		public string GetAbbreviatedDayName(DayOfWeek dayofweek)
		{
			if (dayofweek < DayOfWeek.Sunday || dayofweek > DayOfWeek.Saturday)
			{
				throw new ArgumentOutOfRangeException("dayofweek", SR.Format("Valid values are between {0} and {1}, inclusive.", DayOfWeek.Sunday, DayOfWeek.Saturday));
			}
			return this.internalGetAbbreviatedDayOfWeekNames()[(int)dayofweek];
		}

		/// <summary>Получает самое короткое сокращенное название дня для определенного дня недели, связанное с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <param name="dayOfWeek">Одно из значений <see cref="T:System.DayOfWeek" />.</param>
		/// <returns>Сокращение для недели, соответствующее параметру <paramref name="dayOfWeek" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="dayOfWeek" /> не является значением перечисления <see cref="T:System.DayOfWeek" />.</exception>
		// Token: 0x060054F7 RID: 21751 RVA: 0x0011BEA4 File Offset: 0x0011A0A4
		public string GetShortestDayName(DayOfWeek dayOfWeek)
		{
			if (dayOfWeek < DayOfWeek.Sunday || dayOfWeek > DayOfWeek.Saturday)
			{
				throw new ArgumentOutOfRangeException("dayOfWeek", SR.Format("Valid values are between {0} and {1}, inclusive.", DayOfWeek.Sunday, DayOfWeek.Saturday));
			}
			return this.internalGetSuperShortDayNames()[(int)dayOfWeek];
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x0011BED8 File Offset: 0x0011A0D8
		private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString)
		{
			string[] array = new string[patterns1.Length * patterns2.Length];
			int num = 0;
			for (int i = 0; i < patterns1.Length; i++)
			{
				for (int j = 0; j < patterns2.Length; j++)
				{
					array[num++] = patterns1[i] + connectString + patterns2[j];
				}
			}
			return array;
		}

		/// <summary>Возвращает все стандартные шаблоны, в которых можно форматировать значения даты и времени.</summary>
		/// <returns>Массив, содержащий стандартные шаблоны, в которых можно форматировать значения даты и времени.</returns>
		// Token: 0x060054F9 RID: 21753 RVA: 0x0011BF24 File Offset: 0x0011A124
		public string[] GetAllDateTimePatterns()
		{
			List<string> list = new List<string>(132);
			for (int i = 0; i < DateTimeFormat.allStandardFormats.Length; i++)
			{
				string[] allDateTimePatterns = this.GetAllDateTimePatterns(DateTimeFormat.allStandardFormats[i]);
				for (int j = 0; j < allDateTimePatterns.Length; j++)
				{
					list.Add(allDateTimePatterns[j]);
				}
			}
			return list.ToArray();
		}

		/// <summary>Возвращает все шаблоны, в которых значения даты и времени можно форматировать с использованием заданной стандартной строки формата.</summary>
		/// <param name="format">Строка стандартного формата.</param>
		/// <returns>Массив, содержащий стандартные шаблоны, в которых значения даты и времени можно форматировать с помощью указанной строки формата.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="format" /> не является допустимой строкой стандартного формата.</exception>
		// Token: 0x060054FA RID: 21754 RVA: 0x0011BF7C File Offset: 0x0011A17C
		public string[] GetAllDateTimePatterns(char format)
		{
			if (format <= 'U')
			{
				switch (format)
				{
				case 'D':
					return this.AllLongDatePatterns;
				case 'E':
					goto IL_1AF;
				case 'F':
					break;
				case 'G':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllShortDatePatterns, this.AllLongTimePatterns, " ");
				default:
					switch (format)
					{
					case 'M':
						goto IL_13D;
					case 'N':
					case 'P':
					case 'Q':
					case 'S':
						goto IL_1AF;
					case 'O':
						goto IL_14F;
					case 'R':
						goto IL_160;
					case 'T':
						return this.AllLongTimePatterns;
					case 'U':
						break;
					default:
						goto IL_1AF;
					}
					break;
				}
				return DateTimeFormatInfo.GetCombinedPatterns(this.AllLongDatePatterns, this.AllLongTimePatterns, " ");
			}
			if (format != 'Y')
			{
				switch (format)
				{
				case 'd':
					return this.AllShortDatePatterns;
				case 'e':
					goto IL_1AF;
				case 'f':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllLongDatePatterns, this.AllShortTimePatterns, " ");
				case 'g':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllShortDatePatterns, this.AllShortTimePatterns, " ");
				default:
					switch (format)
					{
					case 'm':
						goto IL_13D;
					case 'n':
					case 'p':
					case 'q':
					case 'v':
					case 'w':
					case 'x':
						goto IL_1AF;
					case 'o':
						goto IL_14F;
					case 'r':
						goto IL_160;
					case 's':
						return new string[]
						{
							"yyyy'-'MM'-'dd'T'HH':'mm':'ss"
						};
					case 't':
						return this.AllShortTimePatterns;
					case 'u':
						return new string[]
						{
							this.UniversalSortableDateTimePattern
						};
					case 'y':
						break;
					default:
						goto IL_1AF;
					}
					break;
				}
			}
			return this.AllYearMonthPatterns;
			IL_13D:
			return new string[]
			{
				this.MonthDayPattern
			};
			IL_14F:
			return new string[]
			{
				"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"
			};
			IL_160:
			return new string[]
			{
				"ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"
			};
			IL_1AF:
			throw new ArgumentException(SR.Format("Format specifier '{0}' was invalid.", format), "format");
		}

		/// <summary>Возвращает сокращение указанного дня недели, принятое в определенном языке и региональных параметрах, связанных с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <param name="dayofweek">Значение <see cref="T:System.DayOfWeek" />.</param>
		/// <returns>Полное название дня недели, принятое в определенном языке и региональных параметрах, представленное свойством <paramref name="dayofweek" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="dayofweek" /> не является допустимым значением <see cref="T:System.DayOfWeek" />.</exception>
		// Token: 0x060054FB RID: 21755 RVA: 0x0011C154 File Offset: 0x0011A354
		public string GetDayName(DayOfWeek dayofweek)
		{
			if (dayofweek < DayOfWeek.Sunday || dayofweek > DayOfWeek.Saturday)
			{
				throw new ArgumentOutOfRangeException("dayofweek", SR.Format("Valid values are between {0} and {1}, inclusive.", DayOfWeek.Sunday, DayOfWeek.Saturday));
			}
			return this.internalGetDayOfWeekNames()[(int)dayofweek];
		}

		/// <summary>Возвращает сокращение указанного месяца, принятое в определенном языке и региональных параметрах, связанных с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <param name="month">Целое число от 1 до 13, представляющее собой название извлекаемого месяца.</param>
		/// <returns>Сокращенное название месяца, принятое в определенном языке и региональных параметрах, представленное свойством <paramref name="month" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="month" /> меньше 1 или больше 13.</exception>
		// Token: 0x060054FC RID: 21756 RVA: 0x0011C187 File Offset: 0x0011A387
		public string GetAbbreviatedMonthName(int month)
		{
			if (month < 1 || month > 13)
			{
				throw new ArgumentOutOfRangeException("month", SR.Format("Valid values are between {0} and {1}, inclusive.", 1, 13));
			}
			return this.internalGetAbbreviatedMonthNames()[month - 1];
		}

		/// <summary>Возвращает полное имя указанного месяца, принятое в определенном языке и региональных параметрах, связанных с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <param name="month">Целое число от 1 до 13, представляющее собой название извлекаемого месяца.</param>
		/// <returns>Полное название месяца, принятое в определенном языке и региональных параметрах, представленное параметром <paramref name="month" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="month" /> меньше 1 или больше 13.</exception>
		// Token: 0x060054FD RID: 21757 RVA: 0x0011C1BE File Offset: 0x0011A3BE
		public string GetMonthName(int month)
		{
			if (month < 1 || month > 13)
			{
				throw new ArgumentOutOfRangeException("month", SR.Format("Valid values are between {0} and {1}, inclusive.", 1, 13));
			}
			return this.internalGetMonthNames()[month - 1];
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x0011C1F8 File Offset: 0x0011A3F8
		private static string[] GetMergedPatterns(string[] patterns, string defaultPattern)
		{
			if (defaultPattern == patterns[0])
			{
				return (string[])patterns.Clone();
			}
			int num = 0;
			while (num < patterns.Length && !(defaultPattern == patterns[num]))
			{
				num++;
			}
			string[] array;
			if (num < patterns.Length)
			{
				array = (string[])patterns.Clone();
				array[num] = array[0];
			}
			else
			{
				array = new string[patterns.Length + 1];
				Array.Copy(patterns, 0, array, 1, patterns.Length);
			}
			array[0] = defaultPattern;
			return array;
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x060054FF RID: 21759 RVA: 0x0011C26B File Offset: 0x0011A46B
		private string[] AllYearMonthPatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedYearMonthPatterns, this.YearMonthPattern);
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x0011C27E File Offset: 0x0011A47E
		private string[] AllShortDatePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedShortDatePatterns, this.ShortDatePattern);
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06005501 RID: 21761 RVA: 0x0011C291 File Offset: 0x0011A491
		private string[] AllShortTimePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedShortTimePatterns, this.ShortTimePattern);
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06005502 RID: 21762 RVA: 0x0011C2A4 File Offset: 0x0011A4A4
		private string[] AllLongDatePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedLongDatePatterns, this.LongDatePattern);
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06005503 RID: 21763 RVA: 0x0011C2B7 File Offset: 0x0011A4B7
		private string[] AllLongTimePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedLongTimePatterns, this.LongTimePattern);
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06005504 RID: 21764 RVA: 0x0011C2CA File Offset: 0x0011A4CA
		private string[] UnclonedYearMonthPatterns
		{
			get
			{
				if (this.allYearMonthPatterns == null)
				{
					this.allYearMonthPatterns = this._cultureData.YearMonths(this.Calendar.ID);
				}
				return this.allYearMonthPatterns;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x0011C2F6 File Offset: 0x0011A4F6
		private string[] UnclonedShortDatePatterns
		{
			get
			{
				if (this.allShortDatePatterns == null)
				{
					this.allShortDatePatterns = this._cultureData.ShortDates(this.Calendar.ID);
				}
				return this.allShortDatePatterns;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x0011C322 File Offset: 0x0011A522
		private string[] UnclonedLongDatePatterns
		{
			get
			{
				if (this.allLongDatePatterns == null)
				{
					this.allLongDatePatterns = this._cultureData.LongDates(this.Calendar.ID);
				}
				return this.allLongDatePatterns;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06005507 RID: 21767 RVA: 0x0011C34E File Offset: 0x0011A54E
		private string[] UnclonedShortTimePatterns
		{
			get
			{
				if (this.allShortTimePatterns == null)
				{
					this.allShortTimePatterns = this._cultureData.ShortTimes;
				}
				return this.allShortTimePatterns;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06005508 RID: 21768 RVA: 0x0011C36F File Offset: 0x0011A56F
		private string[] UnclonedLongTimePatterns
		{
			get
			{
				if (this.allLongTimePatterns == null)
				{
					this.allLongTimePatterns = this._cultureData.LongTimes;
				}
				return this.allLongTimePatterns;
			}
		}

		/// <summary>Возвращает программу-оболочку <see cref="T:System.Globalization.DateTimeFormatInfo" />, доступную только для чтения.</summary>
		/// <param name="dtfi">Объект <see cref="T:System.Globalization.DateTimeFormatInfo" />, для которого создается оболочка.</param>
		/// <returns>Оболочка <see cref="T:System.Globalization.DateTimeFormatInfo" />, доступная только для чтения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dtfi" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005509 RID: 21769 RVA: 0x0011C390 File Offset: 0x0011A590
		public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi)
		{
			if (dtfi == null)
			{
				throw new ArgumentNullException("dtfi", "Object cannot be null.");
			}
			if (dtfi.IsReadOnly)
			{
				return dtfi;
			}
			DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)dtfi.MemberwiseClone();
			dateTimeFormatInfo.calendar = Calendar.ReadOnly(dtfi.Calendar);
			dateTimeFormatInfo._isReadOnly = true;
			return dateTimeFormatInfo;
		}

		/// <summary>Получает значение, показывающее, является ли объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x0011C3DD File Offset: 0x0011A5DD
		public bool IsReadOnly
		{
			get
			{
				return GlobalizationMode.Invariant || this._isReadOnly;
			}
		}

		/// <summary>Получает собственное имя календаря, связанного с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <returns>Собственное имя календаря, используемое в языке и региональных параметрах, связано с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />, если имя доступно, или с пустой строкой (""), если собственное имя календаря недоступно.</returns>
		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x0600550B RID: 21771 RVA: 0x0011C3EE File Offset: 0x0011A5EE
		public string NativeCalendarName
		{
			get
			{
				return this._cultureData.CalendarName(this.Calendar.ID);
			}
		}

		/// <summary>Задает строки пользовательского формата даты и времени, соответствующие заданной стандартной строке формата.</summary>
		/// <param name="patterns">Массив пользовательских строк формата.</param>
		/// <param name="format">Строка стандартного формата, связанная со строками пользовательского формата, указанными в параметре <paramref name="patterns" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="patterns" /> имеет значение <see langword="null" /> или является массивом нулевой длины.  
		/// -или- 
		///  <paramref name="format" /> не является допустимым строка стандартного формата или является строка стандартного формата, шаблоны которых не может быть задано.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="patterns" /> имеет элемент массива со значением <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x0600550C RID: 21772 RVA: 0x0011C408 File Offset: 0x0011A608
		public void SetAllDateTimePatterns(string[] patterns, char format)
		{
			if (this.IsReadOnly)
			{
				throw new InvalidOperationException("Instance is read-only.");
			}
			if (patterns == null)
			{
				throw new ArgumentNullException("patterns", "Array cannot be null.");
			}
			if (patterns.Length == 0)
			{
				throw new ArgumentException("Array must not be of length zero.", "patterns");
			}
			for (int i = 0; i < patterns.Length; i++)
			{
				if (patterns[i] == null)
				{
					throw new ArgumentNullException("patterns[" + i.ToString() + "]", "Found a null value within an array.");
				}
			}
			if (format <= 'Y')
			{
				if (format == 'D')
				{
					this.allLongDatePatterns = patterns;
					this.longDatePattern = this.allLongDatePatterns[0];
					goto IL_126;
				}
				if (format == 'T')
				{
					this.allLongTimePatterns = patterns;
					this.longTimePattern = this.allLongTimePatterns[0];
					goto IL_126;
				}
				if (format != 'Y')
				{
					goto IL_10B;
				}
			}
			else
			{
				if (format == 'd')
				{
					this.allShortDatePatterns = patterns;
					this.shortDatePattern = this.allShortDatePatterns[0];
					goto IL_126;
				}
				if (format == 't')
				{
					this.allShortTimePatterns = patterns;
					this.shortTimePattern = this.allShortTimePatterns[0];
					goto IL_126;
				}
				if (format != 'y')
				{
					goto IL_10B;
				}
			}
			this.allYearMonthPatterns = patterns;
			this.yearMonthPattern = this.allYearMonthPatterns[0];
			goto IL_126;
			IL_10B:
			throw new ArgumentException(SR.Format("Format specifier '{0}' was invalid.", format), "format");
			IL_126:
			this.ClearTokenHashTable();
		}

		/// <summary>Возвращает или задает массив строк сокращенных названий месяцев, связанных с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <returns>Массив сокращенных имен месяцев.</returns>
		/// <exception cref="T:System.ArgumentException">В операции присваивания массив является многомерным или имеет длину, это не точно 13.</exception>
		/// <exception cref="T:System.ArgumentNullException">В наборе операций массив или один из элементов массива имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x0600550D RID: 21773 RVA: 0x0011C541 File Offset: 0x0011A741
		// (set) Token: 0x0600550E RID: 21774 RVA: 0x0011C554 File Offset: 0x0011A754
		public string[] AbbreviatedMonthGenitiveNames
		{
			get
			{
				return (string[])this.internalGetGenitiveMonthNames(true).Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Array cannot be null.");
				}
				if (value.Length != 13)
				{
					throw new ArgumentException(SR.Format("Length of the array must be {0}.", 13), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length - 1);
				this.ClearTokenHashTable();
				this.m_genitiveAbbreviatedMonthNames = value;
			}
		}

		/// <summary>Возвращает или задает массив строк имен месяцев, связанных с текущим объектом <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <returns>Массив строк имен месяцев.</returns>
		/// <exception cref="T:System.ArgumentException">В операции присваивания массив является многомерным или имеет длину, это не точно 13.</exception>
		/// <exception cref="T:System.ArgumentNullException">В операции задания массив или один из его элементов имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий объект <see cref="T:System.Globalization.DateTimeFormatInfo" /> доступен только для чтения.</exception>
		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x0600550F RID: 21775 RVA: 0x0011C5C2 File Offset: 0x0011A7C2
		// (set) Token: 0x06005510 RID: 21776 RVA: 0x0011C5D8 File Offset: 0x0011A7D8
		public string[] MonthGenitiveNames
		{
			get
			{
				return (string[])this.internalGetGenitiveMonthNames(false).Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException("Instance is read-only.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value", "Array cannot be null.");
				}
				if (value.Length != 13)
				{
					throw new ArgumentException(SR.Format("Length of the array must be {0}.", 13), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length - 1);
				this.genitiveMonthNames = value;
				this.ClearTokenHashTable();
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x0011C648 File Offset: 0x0011A848
		internal string FullTimeSpanPositivePattern
		{
			get
			{
				if (this._fullTimeSpanPositivePattern == null)
				{
					CultureData cultureData;
					if (this._cultureData.UseUserOverride)
					{
						cultureData = CultureData.GetCultureData(this._cultureData.CultureName, false);
					}
					else
					{
						cultureData = this._cultureData;
					}
					string numberDecimalSeparator = new NumberFormatInfo(cultureData).NumberDecimalSeparator;
					this._fullTimeSpanPositivePattern = "d':'h':'mm':'ss'" + numberDecimalSeparator + "'FFFFFFF";
				}
				return this._fullTimeSpanPositivePattern;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x0011C6AD File Offset: 0x0011A8AD
		internal string FullTimeSpanNegativePattern
		{
			get
			{
				if (this._fullTimeSpanNegativePattern == null)
				{
					this._fullTimeSpanNegativePattern = "'-'" + this.FullTimeSpanPositivePattern;
				}
				return this._fullTimeSpanNegativePattern;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06005513 RID: 21779 RVA: 0x0011C6D3 File Offset: 0x0011A8D3
		internal CompareInfo CompareInfo
		{
			get
			{
				if (this._compareInfo == null)
				{
					this._compareInfo = CompareInfo.GetCompareInfo(this._cultureData.SCOMPAREINFO);
				}
				return this._compareInfo;
			}
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x0011C6FC File Offset: 0x0011A8FC
		internal static void ValidateStyles(DateTimeStyles style, string parameterName)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) != DateTimeStyles.None)
			{
				throw new ArgumentException("An undefined DateTimeStyles value is being used.", parameterName);
			}
			if ((style & DateTimeStyles.AssumeLocal) != DateTimeStyles.None && (style & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
			{
				throw new ArgumentException("The DateTimeStyles values AssumeLocal and AssumeUniversal cannot be used together.", parameterName);
			}
			if ((style & DateTimeStyles.RoundtripKind) != DateTimeStyles.None && (style & (DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal)) != DateTimeStyles.None)
			{
				throw new ArgumentException("The DateTimeStyles value RoundtripKind cannot be used with the values AssumeLocal, AssumeUniversal or AdjustToUniversal.", parameterName);
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x0011C751 File Offset: 0x0011A951
		internal DateTimeFormatFlags FormatFlags
		{
			get
			{
				if (this.formatFlags == DateTimeFormatFlags.NotInitialized)
				{
					return this.InitializeFormatFlags();
				}
				return this.formatFlags;
			}
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x0011C76C File Offset: 0x0011A96C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DateTimeFormatFlags InitializeFormatFlags()
		{
			this.formatFlags = (DateTimeFormatFlags)(DateTimeFormatInfoScanner.GetFormatFlagGenitiveMonth(this.MonthNames, this.internalGetGenitiveMonthNames(false), this.AbbreviatedMonthNames, this.internalGetGenitiveMonthNames(true)) | DateTimeFormatInfoScanner.GetFormatFlagUseSpaceInMonthNames(this.MonthNames, this.internalGetGenitiveMonthNames(false), this.AbbreviatedMonthNames, this.internalGetGenitiveMonthNames(true)) | DateTimeFormatInfoScanner.GetFormatFlagUseSpaceInDayNames(this.DayNames, this.AbbreviatedDayNames) | DateTimeFormatInfoScanner.GetFormatFlagUseHebrewCalendar(this.Calendar.ID));
			return this.formatFlags;
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x0011C7E8 File Offset: 0x0011A9E8
		internal bool HasForceTwoDigitYears
		{
			get
			{
				CalendarId calendarId = (CalendarId)this.calendar.ID;
				return calendarId - CalendarId.JAPAN <= 1;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06005518 RID: 21784 RVA: 0x0011C80B File Offset: 0x0011AA0B
		internal bool HasYearMonthAdjustment
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseHebrewRule) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x0011C818 File Offset: 0x0011AA18
		internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
		{
			if ((this.FormatFlags & DateTimeFormatFlags.UseHebrewRule) != DateTimeFormatFlags.None)
			{
				if (year < 1000)
				{
					year += 5000;
				}
				if (year < this.Calendar.GetYear(this.Calendar.MinSupportedDateTime) || year > this.Calendar.GetYear(this.Calendar.MaxSupportedDateTime))
				{
					return false;
				}
				if (parsedMonthName && !this.Calendar.IsLeapYear(year))
				{
					if (month >= 8)
					{
						month--;
					}
					else if (month == 7)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x0011C8A0 File Offset: 0x0011AAA0
		internal static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			DateTimeFormatInfo dateTimeFormat = DateTimeFormatInfo.s_jajpDTFI;
			if (dateTimeFormat == null && !GlobalizationMode.Invariant)
			{
				dateTimeFormat = new CultureInfo("ja-JP", false).DateTimeFormat;
				dateTimeFormat.Calendar = JapaneseCalendar.GetDefaultInstance();
				DateTimeFormatInfo.s_jajpDTFI = dateTimeFormat;
			}
			return dateTimeFormat;
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x0011C8E4 File Offset: 0x0011AAE4
		internal static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			DateTimeFormatInfo dateTimeFormat = DateTimeFormatInfo.s_zhtwDTFI;
			if (dateTimeFormat == null && !GlobalizationMode.Invariant)
			{
				dateTimeFormat = new CultureInfo("zh-TW", false).DateTimeFormat;
				dateTimeFormat.Calendar = TaiwanCalendar.GetDefaultInstance();
				DateTimeFormatInfo.s_zhtwDTFI = dateTimeFormat;
			}
			return dateTimeFormat;
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x0011C928 File Offset: 0x0011AB28
		private void ClearTokenHashTable()
		{
			this._dtfiTokenHash = null;
			this.formatFlags = DateTimeFormatFlags.NotInitialized;
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x0011C938 File Offset: 0x0011AB38
		internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable()
		{
			DateTimeFormatInfo.TokenHashValue[] array = this._dtfiTokenHash;
			if (array == null)
			{
				array = new DateTimeFormatInfo.TokenHashValue[199];
				if (!GlobalizationMode.Invariant)
				{
					this.LanguageName.Equals("ko");
				}
				string b = this.TimeSeparator.Trim();
				if ("," != b)
				{
					this.InsertHash(array, ",", TokenType.IgnorableSymbol, 0);
				}
				if ("." != b)
				{
					this.InsertHash(array, ".", TokenType.IgnorableSymbol, 0);
				}
				if (!GlobalizationMode.Invariant && "시" != b && "時" != b && "时" != b)
				{
					this.InsertHash(array, this.TimeSeparator, TokenType.SEP_Time, 0);
				}
				this.InsertHash(array, this.AMDesignator, (TokenType)1027, 0);
				this.InsertHash(array, this.PMDesignator, (TokenType)1284, 1);
				bool flag = false;
				if (!GlobalizationMode.Invariant)
				{
					this.PopulateSpecialTokenHashTable(array, ref flag);
				}
				if (!GlobalizationMode.Invariant && this.LanguageName.Equals("ky"))
				{
					this.InsertHash(array, "-", TokenType.IgnorableSymbol, 0);
				}
				else
				{
					this.InsertHash(array, "-", TokenType.SEP_DateOrOffset, 0);
				}
				if (!flag)
				{
					this.InsertHash(array, this.DateSeparator, TokenType.SEP_Date, 0);
				}
				this.AddMonthNames(array, null);
				for (int i = 1; i <= 13; i++)
				{
					this.InsertHash(array, this.GetAbbreviatedMonthName(i), TokenType.MonthToken, i);
				}
				if ((this.FormatFlags & DateTimeFormatFlags.UseGenitiveMonth) != DateTimeFormatFlags.None)
				{
					for (int j = 1; j <= 13; j++)
					{
						string str = this.internalGetMonthName(j, MonthNameStyles.Genitive, false);
						this.InsertHash(array, str, TokenType.MonthToken, j);
					}
				}
				if ((this.FormatFlags & DateTimeFormatFlags.UseLeapYearMonth) != DateTimeFormatFlags.None)
				{
					for (int k = 1; k <= 13; k++)
					{
						string str2 = this.internalGetMonthName(k, MonthNameStyles.LeapYear, false);
						this.InsertHash(array, str2, TokenType.MonthToken, k);
					}
				}
				for (int l = 0; l < 7; l++)
				{
					string str3 = this.GetDayName((DayOfWeek)l);
					this.InsertHash(array, str3, TokenType.DayOfWeekToken, l);
					str3 = this.GetAbbreviatedDayName((DayOfWeek)l);
					this.InsertHash(array, str3, TokenType.DayOfWeekToken, l);
				}
				int[] eras = this.calendar.Eras;
				for (int m = 1; m <= eras.Length; m++)
				{
					this.InsertHash(array, this.GetEraName(m), TokenType.EraToken, m);
					this.InsertHash(array, this.GetAbbreviatedEraName(m), TokenType.EraToken, m);
				}
				this.InsertHash(array, DateTimeFormatInfo.InvariantInfo.AMDesignator, (TokenType)1027, 0);
				this.InsertHash(array, DateTimeFormatInfo.InvariantInfo.PMDesignator, (TokenType)1284, 1);
				for (int n = 1; n <= 12; n++)
				{
					string str4 = DateTimeFormatInfo.InvariantInfo.GetMonthName(n);
					this.InsertHash(array, str4, TokenType.MonthToken, n);
					str4 = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(n);
					this.InsertHash(array, str4, TokenType.MonthToken, n);
				}
				for (int num = 0; num < 7; num++)
				{
					string str5 = DateTimeFormatInfo.InvariantInfo.GetDayName((DayOfWeek)num);
					this.InsertHash(array, str5, TokenType.DayOfWeekToken, num);
					str5 = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedDayName((DayOfWeek)num);
					this.InsertHash(array, str5, TokenType.DayOfWeekToken, num);
				}
				for (int num2 = 0; num2 < this.AbbreviatedEnglishEraNames.Length; num2++)
				{
					this.InsertHash(array, this.AbbreviatedEnglishEraNames[num2], TokenType.EraToken, num2 + 1);
				}
				this.InsertHash(array, "T", TokenType.SEP_LocalTimeMark, 0);
				this.InsertHash(array, "GMT", TokenType.TimeZoneToken, 0);
				this.InsertHash(array, "Z", TokenType.TimeZoneToken, 0);
				this.InsertHash(array, "/", TokenType.SEP_Date, 0);
				this.InsertHash(array, ":", TokenType.SEP_Time, 0);
				this._dtfiTokenHash = array;
			}
			return array;
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x0011CCD8 File Offset: 0x0011AED8
		private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol)
		{
			if (this.LanguageName.Equals("sq"))
			{
				this.InsertHash(temp, "." + this.AMDesignator, (TokenType)1027, 0);
				this.InsertHash(temp, "." + this.PMDesignator, (TokenType)1284, 1);
			}
			this.InsertHash(temp, "年", TokenType.SEP_YearSuff, 0);
			this.InsertHash(temp, "년", TokenType.SEP_YearSuff, 0);
			this.InsertHash(temp, "月", TokenType.SEP_MonthSuff, 0);
			this.InsertHash(temp, "월", TokenType.SEP_MonthSuff, 0);
			this.InsertHash(temp, "日", TokenType.SEP_DaySuff, 0);
			this.InsertHash(temp, "일", TokenType.SEP_DaySuff, 0);
			this.InsertHash(temp, "時", TokenType.SEP_HourSuff, 0);
			this.InsertHash(temp, "时", TokenType.SEP_HourSuff, 0);
			this.InsertHash(temp, "分", TokenType.SEP_MinuteSuff, 0);
			this.InsertHash(temp, "秒", TokenType.SEP_SecondSuff, 0);
			if (!AppContextSwitches.EnforceLegacyJapaneseDateParsing && this.Calendar.ID == 3)
			{
				this.InsertHash(temp, "元", TokenType.YearNumberToken, 1);
				this.InsertHash(temp, "(", TokenType.IgnorableSymbol, 0);
				this.InsertHash(temp, ")", TokenType.IgnorableSymbol, 0);
			}
			if (this.LanguageName.Equals("ko"))
			{
				this.InsertHash(temp, "시", TokenType.SEP_HourSuff, 0);
				this.InsertHash(temp, "분", TokenType.SEP_MinuteSuff, 0);
				this.InsertHash(temp, "초", TokenType.SEP_SecondSuff, 0);
			}
			string[] dateWordsOfDTFI = new DateTimeFormatInfoScanner().GetDateWordsOfDTFI(this);
			DateTimeFormatFlags dateTimeFormatFlags = this.FormatFlags;
			if (dateWordsOfDTFI != null)
			{
				for (int i = 0; i < dateWordsOfDTFI.Length; i++)
				{
					char c = dateWordsOfDTFI[i][0];
					if (c != '')
					{
						if (c != '')
						{
							this.InsertHash(temp, dateWordsOfDTFI[i], TokenType.DateWordToken, 0);
							if (this.LanguageName.Equals("eu"))
							{
								this.InsertHash(temp, "." + dateWordsOfDTFI[i], TokenType.DateWordToken, 0);
							}
						}
						else
						{
							string text = dateWordsOfDTFI[i].Substring(1);
							this.InsertHash(temp, text, TokenType.IgnorableSymbol, 0);
							if (this.DateSeparator.Trim(null).Equals(text))
							{
								useDateSepAsIgnorableSymbol = true;
							}
						}
					}
					else
					{
						string monthPostfix = dateWordsOfDTFI[i].Substring(1);
						this.AddMonthNames(temp, monthPostfix);
					}
				}
			}
			if (this.LanguageName.Equals("ja"))
			{
				for (int j = 0; j < 7; j++)
				{
					string str = "(" + this.GetAbbreviatedDayName((DayOfWeek)j) + ")";
					this.InsertHash(temp, str, TokenType.DayOfWeekToken, j);
				}
				if (!DateTimeFormatInfo.IsJapaneseCalendar(this.Calendar))
				{
					DateTimeFormatInfo japaneseCalendarDTFI = DateTimeFormatInfo.GetJapaneseCalendarDTFI();
					for (int k = 1; k <= japaneseCalendarDTFI.Calendar.Eras.Length; k++)
					{
						this.InsertHash(temp, japaneseCalendarDTFI.GetEraName(k), TokenType.JapaneseEraToken, k);
						this.InsertHash(temp, japaneseCalendarDTFI.GetAbbreviatedEraName(k), TokenType.JapaneseEraToken, k);
						this.InsertHash(temp, japaneseCalendarDTFI.AbbreviatedEnglishEraNames[k - 1], TokenType.JapaneseEraToken, k);
					}
					return;
				}
			}
			else if (this.CultureName.Equals("zh-TW"))
			{
				DateTimeFormatInfo taiwanCalendarDTFI = DateTimeFormatInfo.GetTaiwanCalendarDTFI();
				for (int l = 1; l <= taiwanCalendarDTFI.Calendar.Eras.Length; l++)
				{
					if (taiwanCalendarDTFI.GetEraName(l).Length > 0)
					{
						this.InsertHash(temp, taiwanCalendarDTFI.GetEraName(l), TokenType.TEraToken, l);
					}
				}
			}
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x0011D04D File Offset: 0x0011B24D
		private static bool IsJapaneseCalendar(Calendar calendar)
		{
			if (GlobalizationMode.Invariant)
			{
				throw new PlatformNotSupportedException();
			}
			return calendar.GetType() == typeof(JapaneseCalendar);
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x0011D074 File Offset: 0x0011B274
		private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix)
		{
			for (int i = 1; i <= 13; i++)
			{
				string text = this.GetMonthName(i);
				if (text.Length > 0)
				{
					if (monthPostfix != null)
					{
						this.InsertHash(temp, text + monthPostfix, TokenType.MonthToken, i);
					}
					else
					{
						this.InsertHash(temp, text, TokenType.MonthToken, i);
					}
				}
				text = this.GetAbbreviatedMonthName(i);
				this.InsertHash(temp, text, TokenType.MonthToken, i);
			}
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x0011D0D0 File Offset: 0x0011B2D0
		private unsafe static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
		{
			number = -1;
			badFormat = false;
			int index = str.Index;
			if (!HebrewNumber.IsDigit((char)(*str.Value[index])))
			{
				return false;
			}
			HebrewNumberParsingContext hebrewNumberParsingContext = new HebrewNumberParsingContext(0);
			HebrewNumberParsingState hebrewNumberParsingState;
			for (;;)
			{
				hebrewNumberParsingState = HebrewNumber.ParseByChar((char)(*str.Value[index++]), ref hebrewNumberParsingContext);
				if (hebrewNumberParsingState <= HebrewNumberParsingState.NotHebrewDigit)
				{
					break;
				}
				if (index >= str.Value.Length || hebrewNumberParsingState == HebrewNumberParsingState.FoundEndOfHebrewNumber)
				{
					goto IL_5C;
				}
			}
			return false;
			IL_5C:
			if (hebrewNumberParsingState != HebrewNumberParsingState.FoundEndOfHebrewNumber)
			{
				return false;
			}
			str.Advance(index - str.Index);
			number = hebrewNumberParsingContext.result;
			return true;
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x0011D157 File Offset: 0x0011B357
		private static bool IsHebrewChar(char ch)
		{
			return ch >= '֐' && ch <= '׿';
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x0011D170 File Offset: 0x0011B370
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
		{
			return !AppContextSwitches.EnforceLegacyJapaneseDateParsing && this.Calendar.ID == 3 && (nextCh == "元"[0] || (tokenString == "元" && nextCh == "年"[0]));
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x0011D1C0 File Offset: 0x0011B3C0
		internal unsafe bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
		{
			tokenType = TokenType.UnknownToken;
			tokenValue = 0;
			char c = str.m_current;
			bool flag = char.IsLetter(c);
			if (flag)
			{
				c = this.Culture.TextInfo.ToLower(c);
				bool flag2;
				if (!GlobalizationMode.Invariant && DateTimeFormatInfo.IsHebrewChar(c) && TokenMask == TokenType.RegularTokenMask && DateTimeFormatInfo.TryParseHebrewNumber(ref str, out flag2, out tokenValue))
				{
					if (flag2)
					{
						tokenType = TokenType.UnknownToken;
						return false;
					}
					tokenType = TokenType.HebrewNumber;
					return true;
				}
			}
			int num = (int)(c % 'Ç');
			int num2 = (int)('\u0001' + c % 'Å');
			int num3 = str.Length - str.Index;
			int num4 = 0;
			DateTimeFormatInfo.TokenHashValue[] array = this._dtfiTokenHash;
			if (array == null)
			{
				array = this.CreateTokenHashTable();
			}
			DateTimeFormatInfo.TokenHashValue tokenHashValue;
			int count;
			for (;;)
			{
				tokenHashValue = array[num];
				if (tokenHashValue == null)
				{
					return false;
				}
				if ((tokenHashValue.tokenType & TokenMask) > (TokenType)0 && tokenHashValue.tokenString.Length <= num3)
				{
					bool flag3 = true;
					if (flag)
					{
						int num5 = str.Index + tokenHashValue.tokenString.Length;
						if (num5 > str.Length)
						{
							flag3 = false;
						}
						else if (num5 < str.Length)
						{
							char c2 = (char)(*str.Value[num5]);
							flag3 = (!char.IsLetter(c2) || this.IsAllowedJapaneseTokenFollowedByNonSpaceLetter(tokenHashValue.tokenString, c2));
						}
					}
					if (flag3 && ((tokenHashValue.tokenString.Length == 1 && *str.Value[str.Index] == (ushort)tokenHashValue.tokenString[0]) || this.Culture.CompareInfo.Compare(str.Value.Slice(str.Index, tokenHashValue.tokenString.Length), tokenHashValue.tokenString, CompareOptions.IgnoreCase) == 0))
					{
						break;
					}
					if ((tokenHashValue.tokenType == TokenType.MonthToken && this.HasSpacesInMonthNames) || (tokenHashValue.tokenType == TokenType.DayOfWeekToken && this.HasSpacesInDayNames))
					{
						count = 0;
						if (str.MatchSpecifiedWords(tokenHashValue.tokenString, true, ref count))
						{
							goto Block_19;
						}
					}
				}
				num4++;
				num += num2;
				if (num >= 199)
				{
					num -= 199;
				}
				if (num4 >= 199)
				{
					return false;
				}
			}
			tokenType = (tokenHashValue.tokenType & TokenMask);
			tokenValue = tokenHashValue.tokenValue;
			str.Advance(tokenHashValue.tokenString.Length);
			return true;
			Block_19:
			tokenType = (tokenHashValue.tokenType & TokenMask);
			tokenValue = tokenHashValue.tokenValue;
			str.Advance(count);
			return true;
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x0011D408 File Offset: 0x0011B608
		private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
			DateTimeFormatInfo.TokenHashValue tokenHashValue = hashTable[hashcode];
			hashTable[hashcode] = new DateTimeFormatInfo.TokenHashValue(str, tokenType, tokenValue);
			while (++pos < 199)
			{
				hashcode += hashProbe;
				if (hashcode >= 199)
				{
					hashcode -= 199;
				}
				DateTimeFormatInfo.TokenHashValue tokenHashValue2 = hashTable[hashcode];
				if (tokenHashValue2 == null || this.Culture.TextInfo.ToLower(tokenHashValue2.tokenString[0]) == ch)
				{
					hashTable[hashcode] = tokenHashValue;
					if (tokenHashValue2 == null)
					{
						return;
					}
					tokenHashValue = tokenHashValue2;
				}
			}
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x0011D484 File Offset: 0x0011B684
		private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue)
		{
			if (str == null || str.Length == 0)
			{
				return;
			}
			int num = 0;
			if (char.IsWhiteSpace(str[0]) || char.IsWhiteSpace(str[str.Length - 1]))
			{
				str = str.Trim(null);
				if (str.Length == 0)
				{
					return;
				}
			}
			char c = this.Culture.TextInfo.ToLower(str[0]);
			int num2 = (int)(c % 'Ç');
			int num3 = (int)('\u0001' + c % 'Å');
			DateTimeFormatInfo.TokenHashValue tokenHashValue;
			for (;;)
			{
				tokenHashValue = hashTable[num2];
				if (tokenHashValue == null)
				{
					break;
				}
				if (str.Length >= tokenHashValue.tokenString.Length && this.CompareStringIgnoreCaseOptimized(str, 0, tokenHashValue.tokenString.Length, tokenHashValue.tokenString, 0, tokenHashValue.tokenString.Length))
				{
					goto Block_6;
				}
				num++;
				num2 += num3;
				if (num2 >= 199)
				{
					num2 -= 199;
				}
				if (num >= 199)
				{
					return;
				}
			}
			hashTable[num2] = new DateTimeFormatInfo.TokenHashValue(str, tokenType, tokenValue);
			return;
			Block_6:
			if (str.Length > tokenHashValue.tokenString.Length)
			{
				this.InsertAtCurrentHashNode(hashTable, str, c, tokenType, tokenValue, num, num2, num3);
				return;
			}
			int tokenType2 = (int)tokenHashValue.tokenType;
			if (((tokenType2 & 255) == 0 && (tokenType & TokenType.RegularTokenMask) != (TokenType)0) || ((tokenType2 & 65280) == 0 && (tokenType & TokenType.SeparatorTokenMask) != (TokenType)0))
			{
				tokenHashValue.tokenType |= tokenType;
				if (tokenValue != 0)
				{
					tokenHashValue.tokenValue = tokenValue;
				}
			}
			return;
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x0011D5E6 File Offset: 0x0011B7E6
		private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			return (length1 == 1 && length2 == 1 && string1[offset1] == string2[offset2]) || this.Culture.CompareInfo.Compare(string1, offset1, length1, string2, offset2, length2, CompareOptions.IgnoreCase) == 0;
		}

		// Token: 0x040033EA RID: 13290
		private static volatile DateTimeFormatInfo s_invariantInfo;

		// Token: 0x040033EB RID: 13291
		[NonSerialized]
		private CultureData _cultureData;

		// Token: 0x040033EC RID: 13292
		private string _name;

		// Token: 0x040033ED RID: 13293
		[NonSerialized]
		private string _langName;

		// Token: 0x040033EE RID: 13294
		[NonSerialized]
		private CompareInfo _compareInfo;

		// Token: 0x040033EF RID: 13295
		[NonSerialized]
		private CultureInfo _cultureInfo;

		// Token: 0x040033F0 RID: 13296
		private string amDesignator;

		// Token: 0x040033F1 RID: 13297
		private string pmDesignator;

		// Token: 0x040033F2 RID: 13298
		private string dateSeparator;

		// Token: 0x040033F3 RID: 13299
		private string generalShortTimePattern;

		// Token: 0x040033F4 RID: 13300
		private string generalLongTimePattern;

		// Token: 0x040033F5 RID: 13301
		private string timeSeparator;

		// Token: 0x040033F6 RID: 13302
		private string monthDayPattern;

		// Token: 0x040033F7 RID: 13303
		private string dateTimeOffsetPattern;

		// Token: 0x040033F8 RID: 13304
		private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";

		// Token: 0x040033F9 RID: 13305
		private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

		// Token: 0x040033FA RID: 13306
		private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";

		// Token: 0x040033FB RID: 13307
		private Calendar calendar;

		// Token: 0x040033FC RID: 13308
		private int firstDayOfWeek = -1;

		// Token: 0x040033FD RID: 13309
		private int calendarWeekRule = -1;

		// Token: 0x040033FE RID: 13310
		private string fullDateTimePattern;

		// Token: 0x040033FF RID: 13311
		private string[] abbreviatedDayNames;

		// Token: 0x04003400 RID: 13312
		private string[] m_superShortDayNames;

		// Token: 0x04003401 RID: 13313
		private string[] dayNames;

		// Token: 0x04003402 RID: 13314
		private string[] abbreviatedMonthNames;

		// Token: 0x04003403 RID: 13315
		private string[] monthNames;

		// Token: 0x04003404 RID: 13316
		private string[] genitiveMonthNames;

		// Token: 0x04003405 RID: 13317
		private string[] m_genitiveAbbreviatedMonthNames;

		// Token: 0x04003406 RID: 13318
		private string[] leapYearMonthNames;

		// Token: 0x04003407 RID: 13319
		private string longDatePattern;

		// Token: 0x04003408 RID: 13320
		private string shortDatePattern;

		// Token: 0x04003409 RID: 13321
		private string yearMonthPattern;

		// Token: 0x0400340A RID: 13322
		private string longTimePattern;

		// Token: 0x0400340B RID: 13323
		private string shortTimePattern;

		// Token: 0x0400340C RID: 13324
		private string[] allYearMonthPatterns;

		// Token: 0x0400340D RID: 13325
		private string[] allShortDatePatterns;

		// Token: 0x0400340E RID: 13326
		private string[] allLongDatePatterns;

		// Token: 0x0400340F RID: 13327
		private string[] allShortTimePatterns;

		// Token: 0x04003410 RID: 13328
		private string[] allLongTimePatterns;

		// Token: 0x04003411 RID: 13329
		private string[] m_eraNames;

		// Token: 0x04003412 RID: 13330
		private string[] m_abbrevEraNames;

		// Token: 0x04003413 RID: 13331
		private string[] m_abbrevEnglishEraNames;

		// Token: 0x04003414 RID: 13332
		private CalendarId[] optionalCalendars;

		// Token: 0x04003415 RID: 13333
		private const int DEFAULT_ALL_DATETIMES_SIZE = 132;

		// Token: 0x04003416 RID: 13334
		internal bool _isReadOnly;

		// Token: 0x04003417 RID: 13335
		private DateTimeFormatFlags formatFlags = DateTimeFormatFlags.NotInitialized;

		// Token: 0x04003418 RID: 13336
		private static readonly char[] s_monthSpaces = new char[]
		{
			' ',
			'\u00a0'
		};

		// Token: 0x04003419 RID: 13337
		internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

		// Token: 0x0400341A RID: 13338
		internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";

		// Token: 0x0400341B RID: 13339
		private string _fullTimeSpanPositivePattern;

		// Token: 0x0400341C RID: 13340
		private string _fullTimeSpanNegativePattern;

		// Token: 0x0400341D RID: 13341
		internal const DateTimeStyles InvalidDateTimeStyles = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind);

		// Token: 0x0400341E RID: 13342
		[NonSerialized]
		private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash;

		// Token: 0x0400341F RID: 13343
		private const int TOKEN_HASH_SIZE = 199;

		// Token: 0x04003420 RID: 13344
		private const int SECOND_PRIME = 197;

		// Token: 0x04003421 RID: 13345
		private const string dateSeparatorOrTimeZoneOffset = "-";

		// Token: 0x04003422 RID: 13346
		private const string invariantDateSeparator = "/";

		// Token: 0x04003423 RID: 13347
		private const string invariantTimeSeparator = ":";

		// Token: 0x04003424 RID: 13348
		internal const string IgnorablePeriod = ".";

		// Token: 0x04003425 RID: 13349
		internal const string IgnorableComma = ",";

		// Token: 0x04003426 RID: 13350
		internal const string CJKYearSuff = "年";

		// Token: 0x04003427 RID: 13351
		internal const string CJKMonthSuff = "月";

		// Token: 0x04003428 RID: 13352
		internal const string CJKDaySuff = "日";

		// Token: 0x04003429 RID: 13353
		internal const string KoreanYearSuff = "년";

		// Token: 0x0400342A RID: 13354
		internal const string KoreanMonthSuff = "월";

		// Token: 0x0400342B RID: 13355
		internal const string KoreanDaySuff = "일";

		// Token: 0x0400342C RID: 13356
		internal const string KoreanHourSuff = "시";

		// Token: 0x0400342D RID: 13357
		internal const string KoreanMinuteSuff = "분";

		// Token: 0x0400342E RID: 13358
		internal const string KoreanSecondSuff = "초";

		// Token: 0x0400342F RID: 13359
		internal const string CJKHourSuff = "時";

		// Token: 0x04003430 RID: 13360
		internal const string ChineseHourSuff = "时";

		// Token: 0x04003431 RID: 13361
		internal const string CJKMinuteSuff = "分";

		// Token: 0x04003432 RID: 13362
		internal const string CJKSecondSuff = "秒";

		// Token: 0x04003433 RID: 13363
		internal const string JapaneseEraStart = "元";

		// Token: 0x04003434 RID: 13364
		internal const string LocalTimeMark = "T";

		// Token: 0x04003435 RID: 13365
		internal const string GMTName = "GMT";

		// Token: 0x04003436 RID: 13366
		internal const string ZuluName = "Z";

		// Token: 0x04003437 RID: 13367
		internal const string KoreanLangName = "ko";

		// Token: 0x04003438 RID: 13368
		internal const string JapaneseLangName = "ja";

		// Token: 0x04003439 RID: 13369
		internal const string EnglishLangName = "en";

		// Token: 0x0400343A RID: 13370
		private static volatile DateTimeFormatInfo s_jajpDTFI;

		// Token: 0x0400343B RID: 13371
		private static volatile DateTimeFormatInfo s_zhtwDTFI;

		// Token: 0x0200095C RID: 2396
		internal class TokenHashValue
		{
			// Token: 0x06005529 RID: 21801 RVA: 0x0011D63C File Offset: 0x0011B83C
			internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
			{
				this.tokenString = tokenString;
				this.tokenType = tokenType;
				this.tokenValue = tokenValue;
			}

			// Token: 0x0400343C RID: 13372
			internal string tokenString;

			// Token: 0x0400343D RID: 13373
			internal TokenType tokenType;

			// Token: 0x0400343E RID: 13374
			internal int tokenValue;
		}
	}
}
