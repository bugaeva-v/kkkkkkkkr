using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	/// <summary>Представляет григорианский календарь.</summary>
	// Token: 0x02000988 RID: 2440
	[ComVisible(true)]
	[Serializable]
	public class GregorianCalendar : Calendar
	{
		// Token: 0x0600567D RID: 22141 RVA: 0x00124544 File Offset: 0x00122744
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			if (this.m_type == (GregorianCalendarTypes)0)
			{
				this.m_type = GregorianCalendarTypes.Localized;
			}
			if (this.m_type < GregorianCalendarTypes.Localized || this.m_type > GregorianCalendarTypes.TransliteratedFrench)
			{
				throw new SerializationException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("The deserialized value of the member \"{0}\" in the class \"{1}\" is out of range."), "type", "GregorianCalendar"));
			}
		}

		/// <summary>Возвращает самые ранние дату и время, поддерживаемые типом <see cref="T:System.Globalization.GregorianCalendar" />.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые типом <see cref="T:System.Globalization.GregorianCalendar" />, что является первым мгновением 1 января 0001 года нашей эры. и эквивалентно <see cref="F:System.DateTime.MinValue" />.</returns>
		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x0600567E RID: 22142 RVA: 0x0012274E File Offset: 0x0012094E
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		/// <summary>Возвращает самые последние дату и время, поддерживаемые этим типом <see cref="T:System.Globalization.GregorianCalendar" />.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые типом <see cref="T:System.Globalization.GregorianCalendar" />, что эквивалентно последнему мгновению 31 декабря 9999 года нашей эры. и эквивалентно <see cref="F:System.DateTime.MaxValue" />.</returns>
		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x00122755 File Offset: 0x00120955
		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли текущий календарь солнечным, лунным или сочетанием и того, и другого.</summary>
		/// <returns>Всегда возвращает значение <see cref="F:System.Globalization.CalendarAlgorithmType.SolarCalendar" />.</returns>
		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06005680 RID: 22144 RVA: 0x000040F7 File Offset: 0x000022F7
		[ComVisible(false)]
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x00124597 File Offset: 0x00122797
		internal static Calendar GetDefaultInstance()
		{
			if (GregorianCalendar.s_defaultInstance == null)
			{
				GregorianCalendar.s_defaultInstance = new GregorianCalendar();
			}
			return GregorianCalendar.s_defaultInstance;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.GregorianCalendar" /> с помощью значения <see cref="T:System.Globalization.GregorianCalendarTypes" />, используемого по умолчанию.</summary>
		// Token: 0x06005682 RID: 22146 RVA: 0x001245B5 File Offset: 0x001227B5
		public GregorianCalendar() : this(GregorianCalendarTypes.Localized)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.GregorianCalendar" />, используя указанное значение <see cref="T:System.Globalization.GregorianCalendarTypes" />.</summary>
		/// <param name="type">Значение <see cref="T:System.Globalization.GregorianCalendarTypes" /> указывает, какую языковую версию календаря следует создать.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Элемент <paramref name="type" /> не является элементом перечисления <see cref="T:System.Globalization.GregorianCalendarTypes" />.</exception>
		// Token: 0x06005683 RID: 22147 RVA: 0x001245C0 File Offset: 0x001227C0
		public GregorianCalendar(GregorianCalendarTypes type)
		{
			if (type < GregorianCalendarTypes.Localized || type > GregorianCalendarTypes.TransliteratedFrench)
			{
				throw new ArgumentOutOfRangeException("type", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					GregorianCalendarTypes.Localized,
					GregorianCalendarTypes.TransliteratedFrench
				}));
			}
			this.m_type = type;
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Globalization.GregorianCalendarTypes" />, определяющее языковую версию текущего <see cref="T:System.Globalization.GregorianCalendar" />.</summary>
		/// <returns>Значение <see cref="T:System.Globalization.GregorianCalendarTypes" />, определяющее языковую версию текущего <see cref="T:System.Globalization.GregorianCalendar" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное в операции установки, не является элементом перечисления <see cref="T:System.Globalization.GregorianCalendarTypes" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий экземпляр доступен только для чтения.</exception>
		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x00124611 File Offset: 0x00122811
		// (set) Token: 0x06005685 RID: 22149 RVA: 0x00124619 File Offset: 0x00122819
		public virtual GregorianCalendarTypes CalendarType
		{
			get
			{
				return this.m_type;
			}
			set
			{
				base.VerifyWritable();
				if (value - GregorianCalendarTypes.Localized <= 1 || value - GregorianCalendarTypes.MiddleEastFrench <= 3)
				{
					this.m_type = value;
					return;
				}
				throw new ArgumentOutOfRangeException("m_type", Environment.GetResourceString("Enum value was out of legal range."));
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06005686 RID: 22150 RVA: 0x00124611 File Offset: 0x00122811
		internal override int ID
		{
			get
			{
				return (int)this.m_type;
			}
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x0012464C File Offset: 0x0012284C
		internal virtual int GetDatePart(long ticks, int part)
		{
			int i = (int)(ticks / 864000000000L);
			int num = i / 146097;
			i -= num * 146097;
			int num2 = i / 36524;
			if (num2 == 4)
			{
				num2 = 3;
			}
			i -= num2 * 36524;
			int num3 = i / 1461;
			i -= num3 * 1461;
			int num4 = i / 365;
			if (num4 == 4)
			{
				num4 = 3;
			}
			if (part == 0)
			{
				return num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
			}
			i -= num4 * 365;
			if (part == 1)
			{
				return i + 1;
			}
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			int num5 = i >> 6;
			while (i >= array[num5])
			{
				num5++;
			}
			if (part == 2)
			{
				return num5;
			}
			return i - array[num5 - 1] + 1;
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x0012472C File Offset: 0x0012292C
		internal static long GetAbsoluteDate(int year, int month, int day)
		{
			if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
			{
				int[] array = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
				if (day >= 1 && day <= array[month] - array[month - 1])
				{
					int num = year - 1;
					return (long)(num * 365 + num / 4 - num / 100 + num / 400 + array[month - 1] + day - 1);
				}
			}
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Year, Month, and Day parameters describe an un-representable DateTime."));
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x001247B7 File Offset: 0x001229B7
		internal virtual long DateToTicks(int year, int month, int day)
		{
			return GregorianCalendar.GetAbsoluteDate(year, month, day) * 864000000000L;
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отличающееся от заданного значения типа <see cref="T:System.DateTime" /> на заданное число месяцев.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются месяцы.</param>
		/// <param name="months">Добавляемое число месяцев.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа месяцев к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="months" /> меньше –120 000.  
		///
		/// или - 
		/// Значение <paramref name="months" /> больше 120 000.</exception>
		// Token: 0x0600568A RID: 22154 RVA: 0x001247CC File Offset: 0x001229CC
		public override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), -120000, 120000));
			}
			int num = this.GetDatePart(time.Ticks, 0);
			int num2 = this.GetDatePart(time.Ticks, 2);
			int num3 = this.GetDatePart(time.Ticks, 3);
			int num4 = num2 - 1 + months;
			if (num4 >= 0)
			{
				num2 = num4 % 12 + 1;
				num += num4 / 12;
			}
			else
			{
				num2 = 12 + (num4 + 1) % 12;
				num += (num4 - 11) / 12;
			}
			int[] array = (num % 4 == 0 && (num % 100 != 0 || num % 400 == 0)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			int num5 = array[num2] - array[num2 - 1];
			if (num3 > num5)
			{
				num3 = num5;
			}
			long ticks = this.DateToTicks(num, num2, num3) + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отстающее от заданного значения типа <see cref="T:System.DateTime" /> на заданное число лет.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются годы.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа лет к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		// Token: 0x0600568B RID: 22155 RVA: 0x001223A9 File Offset: 0x001205A9
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		/// <summary>Возвращает день месяца из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 31, обозначающее день месяца в параметре <paramref name="time" />.</returns>
		// Token: 0x0600568C RID: 22156 RVA: 0x001248E0 File Offset: 0x00122AE0
		public override int GetDayOfMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 3);
		}

		/// <summary>Возвращает день недели из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в <paramref name="time" />.</returns>
		// Token: 0x0600568D RID: 22157 RVA: 0x001223C6 File Offset: 0x001205C6
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return (DayOfWeek)(time.Ticks / 864000000000L + 1L) % (DayOfWeek)7;
		}

		/// <summary>Возвращает день года в заданном параметре <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 366, обозначающее день года в параметре <paramref name="time" />.</returns>
		// Token: 0x0600568E RID: 22158 RVA: 0x001248F0 File Offset: 0x00122AF0
		public override int GetDayOfYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 1);
		}

		/// <summary>Возвращает число дней в указанном месяце указанных года и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Количество дней в указанном месяце указанных года и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600568F RID: 22159 RVA: 0x00124900 File Offset: 0x00122B00
		public override int GetDaysInMonth(int year, int month, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					1,
					9999
				}));
			}
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
			int[] array = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			return array[month] - array[month - 1];
		}

		/// <summary>Возвращает число дней в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число дней в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005690 RID: 22160 RVA: 0x001249B4 File Offset: 0x00122BB4
		public override int GetDaysInYear(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
			}
			if (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0))
			{
				return 365;
			}
			return 366;
		}

		/// <summary>Возвращает значение эры из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее эру в <paramref name="time" />.</returns>
		// Token: 0x06005691 RID: 22161 RVA: 0x000040F7 File Offset: 0x000022F7
		public override int GetEra(DateTime time)
		{
			return 1;
		}

		/// <summary>Возвращает список эр в классе <see cref="T:System.Globalization.GregorianCalendar" />.</summary>
		/// <returns>Массив целых чисел для представления эр в классе <see cref="T:System.Globalization.GregorianCalendar" />.</returns>
		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x00123905 File Offset: 0x00121B05
		public override int[] Eras
		{
			get
			{
				return new int[]
				{
					1
				};
			}
		}

		/// <summary>Возвращает месяц в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 12, обозначающее месяц в параметре <paramref name="time" />.</returns>
		// Token: 0x06005693 RID: 22163 RVA: 0x00124A37 File Offset: 0x00122C37
		public override int GetMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 2);
		}

		/// <summary>Возвращает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число месяцев в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005694 RID: 22164 RVA: 0x00124A48 File Offset: 0x00122C48
		public override int GetMonthsInYear(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year >= 1 && year <= 9999)
			{
				return 12;
			}
			throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
		}

		/// <summary>Возвращает значение года в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в параметре <paramref name="time" />.</returns>
		// Token: 0x06005695 RID: 22165 RVA: 0x00124AAE File Offset: 0x00122CAE
		public override int GetYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 0);
		}

		/// <summary>Определяет, является ли указанная дата указанной эры високосным днем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 31, обозначающее день.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный день — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005696 RID: 22166 RVA: 0x00124AC0 File Offset: 0x00122CC0
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					1,
					12
				}));
			}
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					1,
					9999
				}));
			}
			if (day < 1 || day > this.GetDaysInMonth(year, month))
			{
				throw new ArgumentOutOfRangeException("day", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					1,
					this.GetDaysInMonth(year, month)
				}));
			}
			return this.IsLeapYear(year) && (month == 2 && day == 29);
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Год.</param>
		/// <param name="era">Эра. Укажите <see cref="F:System.Globalization.GregorianCalendar.ADEra" /> или <see langword="GregorianCalendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Всегда значение 0, поскольку григорианский календарь не распознает високосные месяцы.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> меньше года 1 или больше года 9999 по григорианскому календарю.  
		///
		/// или - 
		/// Свойству <paramref name="era" /> задано значение, отличное от <see cref="F:System.Globalization.GregorianCalendar.ADEra" /> или <see langword="GregorianCalendar.Eras[Calendar.CurrentEra]" />.</exception>
		// Token: 0x06005697 RID: 22167 RVA: 0x00124BBC File Offset: 0x00122DBC
		[ComVisible(false)]
		public override int GetLeapMonth(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
			}
			return 0;
		}

		/// <summary>Определяет, является ли указанный месяц указанного года указанной эры високосным месяцем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Этот метод всегда возвращает значение <see langword="false" />, если не переопределен производным классом.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005698 RID: 22168 RVA: 0x00124C24 File Offset: 0x00122E24
		public override bool IsLeapMonth(int year, int month, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
			}
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					1,
					12
				}));
			}
			return false;
		}

		/// <summary>Определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005699 RID: 22169 RVA: 0x00124CC0 File Offset: 0x00122EC0
		public override bool IsLeapYear(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year >= 1 && year <= 9999)
			{
				return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
			}
			throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
		}

		/// <summary>Возвращает <see cref="T:System.DateTime" /> с заданными значениями даты и времени в указанной эре.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 31, обозначающее день.</param>
		/// <param name="hour">Целое число от 0 до 23, представляющее час.</param>
		/// <param name="minute">Целое число от 0 до 59, представляющее минуту.</param>
		/// <param name="second">Целое число от 0 до 59, представляющее секунду.</param>
		/// <param name="millisecond">Целое число от 0 до 999, представляющее миллисекунду.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Объект <see cref="T:System.DateTime" /> с заданными значениями даты и времени в текущей эре.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Параметр <paramref name="hour" /> меньше нуля или больше 23.  
		///
		/// или - 
		/// Параметр <paramref name="minute" /> меньше нуля или больше 59.  
		///
		/// или - 
		/// Параметр <paramref name="second" /> меньше нуля или больше 59.  
		///
		/// или - 
		/// Параметр <paramref name="millisecond" /> меньше нуля или больше 999.</exception>
		// Token: 0x0600569A RID: 22170 RVA: 0x00124D3D File Offset: 0x00122F3D
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			if (era == 0 || era == 1)
			{
				return new DateTime(year, month, day, hour, minute, second, millisecond);
			}
			throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x00124D6D File Offset: 0x00122F6D
		internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			if (era == 0 || era == 1)
			{
				return DateTime.TryCreate(year, month, day, hour, minute, second, millisecond, out result);
			}
			result = DateTime.MinValue;
			return false;
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное в операции установки, меньше 99.  
		///
		/// или - 
		/// Значение, указанное в операции установки, больше <see langword="MaxSupportedDateTime.Year" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий экземпляр доступен только для чтения.</exception>
		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x0600569C RID: 22172 RVA: 0x00124D98 File Offset: 0x00122F98
		// (set) Token: 0x0600569D RID: 22173 RVA: 0x00124DC0 File Offset: 0x00122FC0
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 2029);
				}
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > 9999)
				{
					throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 99, 9999));
				}
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Преобразует заданный год в четырехзначное представление с использованием свойства <see cref="P:System.Globalization.GregorianCalendar.TwoDigitYearMax" /> для определения века.</summary>
		/// <param name="year">Двузначное или четырехзначное целое число, представляющее подлежащий преобразованию год.</param>
		/// <returns>Целое число, содержащее четырехразрядное представление <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600569E RID: 22174 RVA: 0x00124E18 File Offset: 0x00123018
		public override int ToFourDigitYear(int year)
		{
			if (year < 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Non-negative number required."));
			}
			if (year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
			}
			return base.ToFourDigitYear(year);
		}

		/// <summary>Представляет текущую эру. Это поле является константой.</summary>
		// Token: 0x040035E0 RID: 13792
		public const int ADEra = 1;

		// Token: 0x040035E1 RID: 13793
		internal const int DatePartYear = 0;

		// Token: 0x040035E2 RID: 13794
		internal const int DatePartDayOfYear = 1;

		// Token: 0x040035E3 RID: 13795
		internal const int DatePartMonth = 2;

		// Token: 0x040035E4 RID: 13796
		internal const int DatePartDay = 3;

		// Token: 0x040035E5 RID: 13797
		internal const int MaxYear = 9999;

		// Token: 0x040035E6 RID: 13798
		internal const int MinYear = 1;

		// Token: 0x040035E7 RID: 13799
		internal GregorianCalendarTypes m_type;

		// Token: 0x040035E8 RID: 13800
		internal static readonly int[] DaysToMonth365 = new int[]
		{
			0,
			31,
			59,
			90,
			120,
			151,
			181,
			212,
			243,
			273,
			304,
			334,
			365
		};

		// Token: 0x040035E9 RID: 13801
		internal static readonly int[] DaysToMonth366 = new int[]
		{
			0,
			31,
			60,
			91,
			121,
			152,
			182,
			213,
			244,
			274,
			305,
			335,
			366
		};

		// Token: 0x040035EA RID: 13802
		private static volatile Calendar s_defaultInstance;

		// Token: 0x040035EB RID: 13803
		private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 2029;
	}
}
