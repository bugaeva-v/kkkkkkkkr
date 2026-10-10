using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Тайваньский календарь.</summary>
	// Token: 0x02000996 RID: 2454
	[ComVisible(true)]
	[Serializable]
	public class TaiwanCalendar : Calendar
	{
		// Token: 0x060057EA RID: 22506 RVA: 0x00128B57 File Offset: 0x00126D57
		internal static Calendar GetDefaultInstance()
		{
			if (TaiwanCalendar.s_defaultInstance == null)
			{
				TaiwanCalendar.s_defaultInstance = new TaiwanCalendar();
			}
			return TaiwanCalendar.s_defaultInstance;
		}

		/// <summary>Получает самые ранние дату и время, поддерживаемые классом <see cref="T:System.Globalization.TaiwanCalendar" />.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые классом <see cref="T:System.Globalization.TaiwanCalendar" />, что эквивалентно первому мгновению 1 января 1912 года нашей эры. по григорианскому календарю.</returns>
		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060057EB RID: 22507 RVA: 0x00128B75 File Offset: 0x00126D75
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return TaiwanCalendar.calendarMinValue;
			}
		}

		/// <summary>Получает самые последние дату и время, поддерживаемые классом <see cref="T:System.Globalization.TaiwanCalendar" />.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые классом <see cref="T:System.Globalization.TaiwanCalendar" />, что эквивалентно последнему мгновению 31 декабря 9999 года нашей эры. по григорианскому календарю.</returns>
		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060057EC RID: 22508 RVA: 0x00122755 File Offset: 0x00120955
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
		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060057ED RID: 22509 RVA: 0x000040F7 File Offset: 0x000022F7
		[ComVisible(false)]
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.TaiwanCalendar" />.</summary>
		/// <exception cref="T:System.TypeInitializationException">Не удается инициализировать объект <see cref="T:System.Globalization.TaiwanCalendar" /> из-за пропавших сведений о культуре.</exception>
		// Token: 0x060057EE RID: 22510 RVA: 0x00128B7C File Offset: 0x00126D7C
		public TaiwanCalendar()
		{
			try
			{
				new CultureInfo("zh-TW");
			}
			catch (ArgumentException innerException)
			{
				throw new TypeInitializationException(base.GetType().FullName, innerException);
			}
			this.helper = new GregorianCalendarHelper(this, TaiwanCalendar.taiwanEraInfo);
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060057EF RID: 22511 RVA: 0x00022807 File Offset: 0x00020A07
		internal override int ID
		{
			get
			{
				return 4;
			}
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
		// Token: 0x060057F0 RID: 22512 RVA: 0x00128BD0 File Offset: 0x00126DD0
		public override DateTime AddMonths(DateTime time, int months)
		{
			return this.helper.AddMonths(time, months);
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отстающее от заданного значения типа <see cref="T:System.DateTime" /> на заданное число лет.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются годы.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа лет к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		// Token: 0x060057F1 RID: 22513 RVA: 0x00128BDF File Offset: 0x00126DDF
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.helper.AddYears(time, years);
		}

		/// <summary>Возвращает число дней в указанном месяце указанных года и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Количество дней в указанном месяце указанных года и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x060057F2 RID: 22514 RVA: 0x00128BEE File Offset: 0x00126DEE
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this.helper.GetDaysInMonth(year, month, era);
		}

		/// <summary>Возвращает число дней в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число дней в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x060057F3 RID: 22515 RVA: 0x00128BFE File Offset: 0x00126DFE
		public override int GetDaysInYear(int year, int era)
		{
			return this.helper.GetDaysInYear(year, era);
		}

		/// <summary>Возвращает день месяца из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 31, обозначающее день месяца в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060057F4 RID: 22516 RVA: 0x00128C0D File Offset: 0x00126E0D
		public override int GetDayOfMonth(DateTime time)
		{
			return this.helper.GetDayOfMonth(time);
		}

		/// <summary>Возвращает день недели из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060057F5 RID: 22517 RVA: 0x00128C1B File Offset: 0x00126E1B
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this.helper.GetDayOfWeek(time);
		}

		/// <summary>Возвращает день года в заданном параметре <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 366, обозначающее день года в заданном значении <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060057F6 RID: 22518 RVA: 0x00128C29 File Offset: 0x00126E29
		public override int GetDayOfYear(DateTime time)
		{
			return this.helper.GetDayOfYear(time);
		}

		/// <summary>Возвращает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число месяцев в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x060057F7 RID: 22519 RVA: 0x00128C37 File Offset: 0x00126E37
		public override int GetMonthsInYear(int year, int era)
		{
			return this.helper.GetMonthsInYear(year, era);
		}

		/// <summary>Возвращает неделю года, к которой относится дата в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <param name="rule">Одно из значений <see cref="T:System.Globalization.CalendarWeekRule" />, определяющее календарную неделю.</param>
		/// <param name="firstDayOfWeek">Одно из значений <see cref="T:System.DayOfWeek" />, представляющее первый день недели.</param>
		/// <returns>Положительное целое число, представляющее неделю года, к которой относится дата в параметре <paramref name="time" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="time" /> или <paramref name="firstDayOfWeek" /> находятся вне поддерживаемого диапазона значений данного календаря.  
		///
		/// или - 
		/// <paramref name="rule" /> не является допустимым значением <see cref="T:System.Globalization.CalendarWeekRule" />.</exception>
		// Token: 0x060057F8 RID: 22520 RVA: 0x00128C46 File Offset: 0x00126E46
		[ComVisible(false)]
		public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			return this.helper.GetWeekOfYear(time, rule, firstDayOfWeek);
		}

		/// <summary>Возвращает значение эры из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее эру в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060057F9 RID: 22521 RVA: 0x00128C56 File Offset: 0x00126E56
		public override int GetEra(DateTime time)
		{
			return this.helper.GetEra(time);
		}

		/// <summary>Возвращает месяц в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 12, обозначающее месяц в заданном объекте <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060057FA RID: 22522 RVA: 0x00128C64 File Offset: 0x00126E64
		public override int GetMonth(DateTime time)
		{
			return this.helper.GetMonth(time);
		}

		/// <summary>Возвращает значение года в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060057FB RID: 22523 RVA: 0x00128C72 File Offset: 0x00126E72
		public override int GetYear(DateTime time)
		{
			return this.helper.GetYear(time);
		}

		/// <summary>Определяет, является ли указанная дата указанной эры високосным днем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 31, обозначающее день.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный день — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x060057FC RID: 22524 RVA: 0x00128C80 File Offset: 0x00126E80
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			return this.helper.IsLeapDay(year, month, day, era);
		}

		/// <summary>Определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x060057FD RID: 22525 RVA: 0x00128C92 File Offset: 0x00126E92
		public override bool IsLeapYear(int year, int era)
		{
			return this.helper.IsLeapYear(year, era);
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Год.</param>
		/// <param name="era">Эра.</param>
		/// <returns>Возвращаемое значение всегда равно нулю, потому что класс <see cref="T:System.Globalization.TaiwanCalendar" /> не поддерживает понятие високосного года.</returns>
		// Token: 0x060057FE RID: 22526 RVA: 0x00128CA1 File Offset: 0x00126EA1
		[ComVisible(false)]
		public override int GetLeapMonth(int year, int era)
		{
			return this.helper.GetLeapMonth(year, era);
		}

		/// <summary>Определяет, является ли указанный месяц указанного года указанной эры високосным месяцем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Этот метод всегда возвращает значение <see langword="false" />, если не переопределен производным классом.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x060057FF RID: 22527 RVA: 0x00128CB0 File Offset: 0x00126EB0
		public override bool IsLeapMonth(int year, int month, int era)
		{
			return this.helper.IsLeapMonth(year, month, era);
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
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
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
		/// Параметр <paramref name="millisecond" /> меньше нуля или больше 999.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005800 RID: 22528 RVA: 0x00128CC0 File Offset: 0x00126EC0
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this.helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		/// <summary>Возвращает список эр в классе <see cref="T:System.Globalization.TaiwanCalendar" />.</summary>
		/// <returns>Массив, состоящий из одного элемента, для которого значение всегда равно текущей эре.</returns>
		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06005801 RID: 22529 RVA: 0x00128CE5 File Offset: 0x00126EE5
		public override int[] Eras
		{
			get
			{
				return this.helper.Eras;
			}
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное в операции установки, меньше 99.  
		///
		/// или - 
		/// Значение, указанное в операции установки, больше <see langword="MaxSupportedDateTime.Year" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий экземпляр доступен только для чтения.</exception>
		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x00126F9B File Offset: 0x0012519B
		// (set) Token: 0x06005803 RID: 22531 RVA: 0x00128CF4 File Offset: 0x00126EF4
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 99);
				}
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > this.helper.MaxYear)
				{
					throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 99, this.helper.MaxYear));
				}
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Преобразует заданный год в четырехзначное представление с использованием свойства <see cref="P:System.Globalization.TaiwanCalendar.TwoDigitYearMax" /> для определения века.</summary>
		/// <param name="year">Двузначное или четырехзначное целое число, представляющее подлежащий преобразованию год.</param>
		/// <returns>Целое число, содержащее четырехразрядное представление <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005804 RID: 22532 RVA: 0x00128D58 File Offset: 0x00126F58
		public override int ToFourDigitYear(int year)
		{
			if (year <= 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Positive number required."));
			}
			if (year > this.helper.MaxYear)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, this.helper.MaxYear));
			}
			return year;
		}

		// Token: 0x0400368E RID: 13966
		internal static EraInfo[] taiwanEraInfo = new EraInfo[]
		{
			new EraInfo(1, 1912, 1, 1, 1911, 1, 8088)
		};

		// Token: 0x0400368F RID: 13967
		internal static volatile Calendar s_defaultInstance;

		// Token: 0x04003690 RID: 13968
		internal GregorianCalendarHelper helper;

		// Token: 0x04003691 RID: 13969
		internal static readonly DateTime calendarMinValue = new DateTime(1912, 1, 1);

		// Token: 0x04003692 RID: 13970
		private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 99;
	}
}
