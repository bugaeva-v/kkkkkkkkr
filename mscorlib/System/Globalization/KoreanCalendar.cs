using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Представляет корейский календарь.</summary>
	// Token: 0x02000992 RID: 2450
	[ComVisible(true)]
	[Serializable]
	public class KoreanCalendar : Calendar
	{
		/// <summary>Получает самые ранние дату и время, поддерживаемые классом <see cref="T:System.Globalization.KoreanCalendar" />.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые классом <see cref="T:System.Globalization.KoreanCalendar" />, что эквивалентно первому мгновению 1 января 0001 года нашей эры по григорианскому календарю.</returns>
		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x0012274E File Offset: 0x0012094E
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		/// <summary>Получает самые последние дату и время, поддерживаемые классом <see cref="T:System.Globalization.KoreanCalendar" />.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые классом <see cref="T:System.Globalization.KoreanCalendar" />, что эквивалентно последнему мгновению 31 декабря 9999 года нашей эры. по григорианскому календарю.</returns>
		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06005763 RID: 22371 RVA: 0x00122755 File Offset: 0x00120955
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
		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x000040F7 File Offset: 0x000022F7
		[ComVisible(false)]
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.KoreanCalendar" />.</summary>
		/// <exception cref="T:System.TypeInitializationException">Не удается инициализировать объект <see cref="T:System.Globalization.KoreanCalendar" /> из-за пропавших сведений о культуре.</exception>
		// Token: 0x06005765 RID: 22373 RVA: 0x001277C8 File Offset: 0x001259C8
		public KoreanCalendar()
		{
			try
			{
				new CultureInfo("ko-KR");
			}
			catch (ArgumentException innerException)
			{
				throw new TypeInitializationException(base.GetType().FullName, innerException);
			}
			this.helper = new GregorianCalendarHelper(this, KoreanCalendar.koreanEraInfo);
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
		internal override int ID
		{
			get
			{
				return 5;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отличающееся от заданного значения типа <see cref="T:System.DateTime" /> на заданное число месяцев.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются месяцы.</param>
		/// <param name="months">Добавляемое число месяцев.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа месяцев к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="months" /> меньше –120 000.  
		///
		/// или - 
		/// Значение <paramref name="months" /> больше 120 000.</exception>
		// Token: 0x06005767 RID: 22375 RVA: 0x0012781C File Offset: 0x00125A1C
		public override DateTime AddMonths(DateTime time, int months)
		{
			return this.helper.AddMonths(time, months);
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отстающее от заданного значения типа <see cref="T:System.DateTime" /> на заданное число лет.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются годы.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа лет к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="years" /> или <paramref name="time" /> выходят за пределы допустимого диапазона.</exception>
		// Token: 0x06005768 RID: 22376 RVA: 0x0012782B File Offset: 0x00125A2B
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
		// Token: 0x06005769 RID: 22377 RVA: 0x0012783A File Offset: 0x00125A3A
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
		// Token: 0x0600576A RID: 22378 RVA: 0x0012784A File Offset: 0x00125A4A
		public override int GetDaysInYear(int year, int era)
		{
			return this.helper.GetDaysInYear(year, era);
		}

		/// <summary>Возвращает день месяца из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 31, обозначающее день месяца в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x0600576B RID: 22379 RVA: 0x00127859 File Offset: 0x00125A59
		public override int GetDayOfMonth(DateTime time)
		{
			return this.helper.GetDayOfMonth(time);
		}

		/// <summary>Возвращает день недели из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x0600576C RID: 22380 RVA: 0x00127867 File Offset: 0x00125A67
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this.helper.GetDayOfWeek(time);
		}

		/// <summary>Возвращает день года в заданном параметре <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 366, обозначающее день года в заданном значении <see cref="T:System.DateTime" />.</returns>
		// Token: 0x0600576D RID: 22381 RVA: 0x00127875 File Offset: 0x00125A75
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
		// Token: 0x0600576E RID: 22382 RVA: 0x00127883 File Offset: 0x00125A83
		public override int GetMonthsInYear(int year, int era)
		{
			return this.helper.GetMonthsInYear(year, era);
		}

		/// <summary>Возвращает неделю года, к которой относится дата в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <param name="rule">Одно из значений <see cref="T:System.Globalization.CalendarWeekRule" />, определяющее календарную неделю.</param>
		/// <param name="firstDayOfWeek">Одно из значений <see cref="T:System.DayOfWeek" />, представляющее первый день недели.</param>
		/// <returns>Начинающееся с единицы целое число, представляющее неделю года, к которой относится дата в параметре <paramref name="time" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="time" /> или <paramref name="firstDayOfWeek" /> находятся вне поддерживаемого диапазона значений данного календаря.  
		///
		/// или - 
		/// <paramref name="rule" /> не является допустимым значением <see cref="T:System.Globalization.CalendarWeekRule" />.</exception>
		// Token: 0x0600576F RID: 22383 RVA: 0x00127892 File Offset: 0x00125A92
		[ComVisible(false)]
		public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			return this.helper.GetWeekOfYear(time, rule, firstDayOfWeek);
		}

		/// <summary>Возвращает значение эры из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее эру в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06005770 RID: 22384 RVA: 0x001278A2 File Offset: 0x00125AA2
		public override int GetEra(DateTime time)
		{
			return this.helper.GetEra(time);
		}

		/// <summary>Возвращает месяц в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 12, обозначающее месяц в заданном объекте <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06005771 RID: 22385 RVA: 0x001278B0 File Offset: 0x00125AB0
		public override int GetMonth(DateTime time)
		{
			return this.helper.GetMonth(time);
		}

		/// <summary>Возвращает значение года в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06005772 RID: 22386 RVA: 0x001278BE File Offset: 0x00125ABE
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
		// Token: 0x06005773 RID: 22387 RVA: 0x001278CC File Offset: 0x00125ACC
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
		// Token: 0x06005774 RID: 22388 RVA: 0x001278DE File Offset: 0x00125ADE
		public override bool IsLeapYear(int year, int era)
		{
			return this.helper.IsLeapYear(year, era);
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Год.</param>
		/// <param name="era">Эра.</param>
		/// <returns>Возвращаемое значение всегда равно нулю, потому что класс <see cref="T:System.Globalization.KoreanCalendar" /> не поддерживает понятие високосного года.</returns>
		// Token: 0x06005775 RID: 22389 RVA: 0x001278ED File Offset: 0x00125AED
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
		// Token: 0x06005776 RID: 22390 RVA: 0x001278FC File Offset: 0x00125AFC
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
		// Token: 0x06005777 RID: 22391 RVA: 0x0012790C File Offset: 0x00125B0C
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this.helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		/// <summary>Возвращает список эр в классе <see cref="T:System.Globalization.KoreanCalendar" />.</summary>
		/// <returns>Массив целых чисел для представления эр в классе <see cref="T:System.Globalization.KoreanCalendar" />.</returns>
		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x00127931 File Offset: 0x00125B31
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
		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x0012793E File Offset: 0x00125B3E
		// (set) Token: 0x0600577A RID: 22394 RVA: 0x00127968 File Offset: 0x00125B68
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 4362);
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

		/// <summary>Преобразует заданный год в четырехзначное представление с использованием свойства <see cref="P:System.Globalization.KoreanCalendar.TwoDigitYearMax" /> для определения века.</summary>
		/// <param name="year">Двузначное или четырехзначное целое число, представляющее подлежащий преобразованию год.</param>
		/// <returns>Целое число, содержащее четырехразрядное представление <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600577B RID: 22395 RVA: 0x001279CB File Offset: 0x00125BCB
		public override int ToFourDigitYear(int year)
		{
			if (year < 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Non-negative number required."));
			}
			return this.helper.ToFourDigitYear(year, this.TwoDigitYearMax);
		}

		/// <summary>Представляет текущую эру. Это поле является константой.</summary>
		// Token: 0x04003658 RID: 13912
		public const int KoreanEra = 1;

		// Token: 0x04003659 RID: 13913
		internal static EraInfo[] koreanEraInfo = new EraInfo[]
		{
			new EraInfo(1, 1, 1, 1, -2333, 2334, 12332)
		};

		// Token: 0x0400365A RID: 13914
		internal GregorianCalendarHelper helper;

		// Token: 0x0400365B RID: 13915
		private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 4362;
	}
}
