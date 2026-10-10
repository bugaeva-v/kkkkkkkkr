using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Globalization
{
	/// <summary>Представляет японский календарь.</summary>
	// Token: 0x0200098F RID: 2447
	[ComVisible(true)]
	[Serializable]
	public class JapaneseCalendar : Calendar
	{
		/// <summary>Возвращает самые ранние дату и время, поддерживаемые текущим объектом <see cref="T:System.Globalization.JapaneseCalendar" />.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые типом <see cref="T:System.Globalization.JapaneseCalendar" />, что эквивалентно первому мгновению 8 сентября 1868 года нашей эры. по григорианскому календарю.</returns>
		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x00126AD6 File Offset: 0x00124CD6
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return JapaneseCalendar.calendarMinValue;
			}
		}

		/// <summary>Возвращает самые последние дату и время, поддерживаемые текущим объектом <see cref="T:System.Globalization.JapaneseCalendar" />.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые типом <see cref="T:System.Globalization.JapaneseCalendar" />, что эквивалентно последнему мгновению 31 декабря 9999 года нашей эры по григорианскому календарю.</returns>
		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x0600570D RID: 22285 RVA: 0x00122755 File Offset: 0x00120955
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
		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x000040F7 File Offset: 0x000022F7
		[ComVisible(false)]
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x00126AE0 File Offset: 0x00124CE0
		internal static EraInfo[] GetEraInfo()
		{
			if (JapaneseCalendar.japaneseEraInfo == null)
			{
				JapaneseCalendar.japaneseEraInfo = JapaneseCalendar.GetErasFromRegistry();
				if (JapaneseCalendar.japaneseEraInfo == null)
				{
					JapaneseCalendar.japaneseEraInfo = new EraInfo[]
					{
						new EraInfo(5, 2019, 5, 1, 2018, 1, 7981, "令和", "令", "R"),
						new EraInfo(4, 1989, 1, 8, 1988, 1, 31, "平成", "平", "H"),
						new EraInfo(3, 1926, 12, 25, 1925, 1, 64, "昭和", "昭", "S"),
						new EraInfo(2, 1912, 7, 30, 1911, 1, 15, "大正", "大", "T"),
						new EraInfo(1, 1868, 1, 1, 1867, 1, 45, "明治", "明", "M")
					};
				}
			}
			return JapaneseCalendar.japaneseEraInfo;
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x0000AF5E File Offset: 0x0000915E
		[SecuritySafeCritical]
		private static EraInfo[] GetErasFromRegistry()
		{
			return null;
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x00126BEE File Offset: 0x00124DEE
		private static int CompareEraRanges(EraInfo a, EraInfo b)
		{
			return b.ticks.CompareTo(a.ticks);
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00126C04 File Offset: 0x00124E04
		private static EraInfo GetEraFromValue(string value, string data)
		{
			if (value == null || data == null)
			{
				return null;
			}
			if (value.Length != 10)
			{
				return null;
			}
			int num;
			int startMonth;
			int startDay;
			if (!Number.TryParseInt32(value.Substring(0, 4), NumberStyles.None, NumberFormatInfo.InvariantInfo, out num) || !Number.TryParseInt32(value.Substring(5, 2), NumberStyles.None, NumberFormatInfo.InvariantInfo, out startMonth) || !Number.TryParseInt32(value.Substring(8, 2), NumberStyles.None, NumberFormatInfo.InvariantInfo, out startDay))
			{
				return null;
			}
			string[] array = data.Split(new char[]
			{
				'_'
			});
			if (array.Length != 4)
			{
				return null;
			}
			if (array[0].Length == 0 || array[1].Length == 0 || array[2].Length == 0 || array[3].Length == 0)
			{
				return null;
			}
			return new EraInfo(0, num, startMonth, startDay, num - 1, 1, 0, array[0], array[1], array[3]);
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00126CD6 File Offset: 0x00124ED6
		internal static Calendar GetDefaultInstance()
		{
			if (JapaneseCalendar.s_defaultInstance == null)
			{
				JapaneseCalendar.s_defaultInstance = new JapaneseCalendar();
			}
			return JapaneseCalendar.s_defaultInstance;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.JapaneseCalendar" />.</summary>
		/// <exception cref="T:System.TypeInitializationException">Не удается инициализировать объект <see cref="T:System.Globalization.JapaneseCalendar" /> из-за пропавших сведений о культуре.</exception>
		// Token: 0x06005714 RID: 22292 RVA: 0x00126CF4 File Offset: 0x00124EF4
		public JapaneseCalendar()
		{
			try
			{
				new CultureInfo("ja-JP");
			}
			catch (ArgumentException innerException)
			{
				throw new TypeInitializationException(base.GetType().FullName, innerException);
			}
			this.helper = new GregorianCalendarHelper(this, JapaneseCalendar.GetEraInfo());
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06005715 RID: 22293 RVA: 0x000221D2 File Offset: 0x000203D2
		internal override int ID
		{
			get
			{
				return 3;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отличающееся от заданного значения типа <see cref="T:System.DateTime" /> на заданное число месяцев.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются месяцы.</param>
		/// <param name="months">Добавляемое число месяцев.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа месяцев к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="months" /> меньше –120 000.  
		/// -или- 
		///  Значение <paramref name="months" /> больше 120 000.</exception>
		// Token: 0x06005716 RID: 22294 RVA: 0x00126D48 File Offset: 0x00124F48
		public override DateTime AddMonths(DateTime time, int months)
		{
			return this.helper.AddMonths(time, months);
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отстающее от заданного значения типа <see cref="T:System.DateTime" /> на заданное число лет.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются годы.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа лет к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="time" /> находится вне допустимого диапазона типа <see cref="T:System.Globalization.JapaneseCalendar" />.  
		/// -или- 
		///  <paramref name="years" /> меньше –10 000 или больше 10 000.</exception>
		// Token: 0x06005717 RID: 22295 RVA: 0x00126D57 File Offset: 0x00124F57
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
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005718 RID: 22296 RVA: 0x00126D66 File Offset: 0x00124F66
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this.helper.GetDaysInMonth(year, month, era);
		}

		/// <summary>Возвращает число дней в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число дней в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005719 RID: 22297 RVA: 0x00126D76 File Offset: 0x00124F76
		public override int GetDaysInYear(int year, int era)
		{
			return this.helper.GetDaysInYear(year, era);
		}

		/// <summary>Возвращает день месяца из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 31, обозначающее день месяца в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x0600571A RID: 22298 RVA: 0x00126D85 File Offset: 0x00124F85
		public override int GetDayOfMonth(DateTime time)
		{
			return this.helper.GetDayOfMonth(time);
		}

		/// <summary>Возвращает день недели из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x0600571B RID: 22299 RVA: 0x00126D93 File Offset: 0x00124F93
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this.helper.GetDayOfWeek(time);
		}

		/// <summary>Возвращает день года в заданном параметре <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 366, обозначающее день года в заданном значении <see cref="T:System.DateTime" />.</returns>
		// Token: 0x0600571C RID: 22300 RVA: 0x00126DA1 File Offset: 0x00124FA1
		public override int GetDayOfYear(DateTime time)
		{
			return this.helper.GetDayOfYear(time);
		}

		/// <summary>Возвращает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Возвращаемое значение всегда равно 12.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600571D RID: 22301 RVA: 0x00126DAF File Offset: 0x00124FAF
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
		/// -или- 
		///  <paramref name="rule" /> не является допустимым значением <see cref="T:System.Globalization.CalendarWeekRule" />.</exception>
		// Token: 0x0600571E RID: 22302 RVA: 0x00126DBE File Offset: 0x00124FBE
		[ComVisible(false)]
		public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			return this.helper.GetWeekOfYear(time, rule, firstDayOfWeek);
		}

		/// <summary>Возвращает значение эры из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее эру в заданном <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		// Token: 0x0600571F RID: 22303 RVA: 0x00126DCE File Offset: 0x00124FCE
		public override int GetEra(DateTime time)
		{
			return this.helper.GetEra(time);
		}

		/// <summary>Возвращает месяц в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 12, обозначающее месяц в заданном объекте <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06005720 RID: 22304 RVA: 0x00126DDC File Offset: 0x00124FDC
		public override int GetMonth(DateTime time)
		{
			return this.helper.GetMonth(time);
		}

		/// <summary>Возвращает значение года в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06005721 RID: 22305 RVA: 0x00126DEA File Offset: 0x00124FEA
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
		/// -или- 
		///  Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005722 RID: 22306 RVA: 0x00126DF8 File Offset: 0x00124FF8
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			return this.helper.IsLeapDay(year, month, day, era);
		}

		/// <summary>Определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005723 RID: 22307 RVA: 0x00126E0A File Offset: 0x0012500A
		public override bool IsLeapYear(int year, int era)
		{
			return this.helper.IsLeapYear(year, era);
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Год.</param>
		/// <param name="era">Эра.</param>
		/// <returns>Возвращаемое значение всегда равно 0, потому что тип <see cref="T:System.Globalization.JapaneseCalendar" /> не поддерживает понятие високосного года.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений типа <see cref="T:System.Globalization.JapaneseCalendar" />.</exception>
		// Token: 0x06005724 RID: 22308 RVA: 0x00126E19 File Offset: 0x00125019
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
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005725 RID: 22309 RVA: 0x00126E28 File Offset: 0x00125028
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
		/// -или- 
		///  Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше нуля или больше 23.  
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
		///
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005726 RID: 22310 RVA: 0x00126E38 File Offset: 0x00125038
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this.helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		/// <summary>Преобразует заданный год в четырехзначное представление с использованием свойства <see cref="P:System.Globalization.JapaneseCalendar.TwoDigitYearMax" /> для определения века.</summary>
		/// <param name="year">Целое число (как правило, двузначное или четырехзначное), представляющее подлежащий преобразованию год.</param>
		/// <returns>Целое число, содержащее четырехразрядное представление <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005727 RID: 22311 RVA: 0x00126E60 File Offset: 0x00125060
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

		/// <summary>Возвращает список эр в классе <see cref="T:System.Globalization.JapaneseCalendar" />.</summary>
		/// <returns>Массив целых чисел для представления эр в классе <see cref="T:System.Globalization.JapaneseCalendar" />.</returns>
		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06005728 RID: 22312 RVA: 0x00126ECA File Offset: 0x001250CA
		public override int[] Eras
		{
			get
			{
				return this.helper.Eras;
			}
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00126ED8 File Offset: 0x001250D8
		internal static string[] EraNames()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			string[] array = new string[eraInfo.Length];
			for (int i = 0; i < eraInfo.Length; i++)
			{
				array[i] = eraInfo[eraInfo.Length - i - 1].eraName;
			}
			return array;
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x00126F14 File Offset: 0x00125114
		internal static string[] AbbrevEraNames()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			string[] array = new string[eraInfo.Length];
			for (int i = 0; i < eraInfo.Length; i++)
			{
				array[i] = eraInfo[eraInfo.Length - i - 1].abbrevEraName;
			}
			return array;
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x00126F50 File Offset: 0x00125150
		internal static string[] EnglishEraNames()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			string[] array = new string[eraInfo.Length];
			for (int i = 0; i < eraInfo.Length; i++)
			{
				array[i] = eraInfo[eraInfo.Length - i - 1].englishEraName;
			}
			return array;
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x00126F8C File Offset: 0x0012518C
		internal override bool IsValidYear(int year, int era)
		{
			return this.helper.IsValidYear(year, era);
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное в операции установки, меньше 99.  
		///
		/// или - 
		/// Значение, указанное в операции установки, больше 8011 (или <see langword="MaxSupportedDateTime.Year" />).</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий экземпляр доступен только для чтения.</exception>
		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x0600572D RID: 22317 RVA: 0x00126F9B File Offset: 0x0012519B
		// (set) Token: 0x0600572E RID: 22318 RVA: 0x00126FC0 File Offset: 0x001251C0
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

		// Token: 0x0400363A RID: 13882
		internal static readonly DateTime calendarMinValue = new DateTime(1868, 9, 8);

		// Token: 0x0400363B RID: 13883
		internal static volatile EraInfo[] japaneseEraInfo;

		// Token: 0x0400363C RID: 13884
		private const string c_japaneseErasHive = "System\\CurrentControlSet\\Control\\Nls\\Calendars\\Japanese\\Eras";

		// Token: 0x0400363D RID: 13885
		private const string c_japaneseErasHivePermissionList = "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Nls\\Calendars\\Japanese\\Eras";

		// Token: 0x0400363E RID: 13886
		internal static volatile Calendar s_defaultInstance;

		// Token: 0x0400363F RID: 13887
		internal GregorianCalendarHelper helper;

		// Token: 0x04003640 RID: 13888
		private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 99;
	}
}
