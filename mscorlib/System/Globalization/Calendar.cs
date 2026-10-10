using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
	/// <summary>Представляет время в виде раздельных значений, например недель, месяцев и лет.</summary>
	// Token: 0x02000983 RID: 2435
	[ComVisible(true)]
	[Serializable]
	public abstract class Calendar : ICloneable
	{
		/// <summary>Возвращает самые ранние дату и время, поддерживаемые этим объектом <see cref="T:System.Globalization.Calendar" />.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые этим календарем. Значение по умолчанию — <see cref="F:System.DateTime.MinValue" />.</returns>
		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x0012274E File Offset: 0x0012094E
		[ComVisible(false)]
		public virtual DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		/// <summary>Возвращает самые последние дату и время, поддерживаемые этим объектом <see cref="T:System.Globalization.Calendar" />.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые этим календарем. Значение по умолчанию — <see cref="F:System.DateTime.MaxValue" />.</returns>
		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x00122755 File Offset: 0x00120955
		[ComVisible(false)]
		public virtual DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x00122772 File Offset: 0x00120972
		internal virtual int ID
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x00122775 File Offset: 0x00120975
		internal virtual int BaseCalendarID
		{
			get
			{
				return this.ID;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли текущий календарь солнечным, лунным или сочетанием и того, и другого.</summary>
		/// <returns>Одно из значений <see cref="T:System.Globalization.CalendarAlgorithmType" />.</returns>
		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x060055F7 RID: 22007 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[ComVisible(false)]
		public virtual CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.Unknown;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли объект <see cref="T:System.Globalization.Calendar" /> доступным только для чтения.</summary>
		/// <returns>
		///   <see langword="true" />, если объект <see cref="T:System.Globalization.Calendar" /> доступен только для чтения, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060055F8 RID: 22008 RVA: 0x0012277D File Offset: 0x0012097D
		[ComVisible(false)]
		public bool IsReadOnly
		{
			get
			{
				return this.m_isReadOnly;
			}
		}

		/// <summary>Создает новый объект, являющийся копией текущего объекта <see cref="T:System.Globalization.Calendar" />.</summary>
		/// <returns>Новый экземпляр объекта <see cref="T:System.Object" />, который является копией по элементам текущего объекта <see cref="T:System.Globalization.Calendar" />.</returns>
		// Token: 0x060055F9 RID: 22009 RVA: 0x00122785 File Offset: 0x00120985
		[ComVisible(false)]
		public virtual object Clone()
		{
			object obj = base.MemberwiseClone();
			((Calendar)obj).SetReadOnlyState(false);
			return obj;
		}

		/// <summary>Возвращает доступную только для чтения версию указанного объекта <see cref="T:System.Globalization.Calendar" />.</summary>
		/// <param name="calendar">Объект <see cref="T:System.Globalization.Calendar" />.</param>
		/// <returns>Объект <see cref="T:System.Globalization.Calendar" />, указанный параметром <paramref name="calendar" />, если этот параметр <paramref name="calendar" /> доступен только для чтения.  
		///
		/// или - 
		/// Доступная только для чтения копия по элементам объекта <see cref="T:System.Globalization.Calendar" />, указанного параметром <paramref name="calendar" />, если параметр <paramref name="calendar" /> доступен не только для чтения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="calendar" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060055FA RID: 22010 RVA: 0x00122799 File Offset: 0x00120999
		[ComVisible(false)]
		public static Calendar ReadOnly(Calendar calendar)
		{
			if (calendar == null)
			{
				throw new ArgumentNullException("calendar");
			}
			if (calendar.IsReadOnly)
			{
				return calendar;
			}
			Calendar calendar2 = (Calendar)calendar.MemberwiseClone();
			calendar2.SetReadOnlyState(true);
			return calendar2;
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x001227C5 File Offset: 0x001209C5
		internal void VerifyWritable()
		{
			if (this.m_isReadOnly)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
			}
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x001227DF File Offset: 0x001209DF
		internal void SetReadOnlyState(bool readOnly)
		{
			this.m_isReadOnly = readOnly;
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x060055FD RID: 22013 RVA: 0x001227E8 File Offset: 0x001209E8
		internal virtual int CurrentEraValue
		{
			get
			{
				if (this.m_currentEraValue == -1)
				{
					this.m_currentEraValue = CalendarData.GetCalendarData(this.BaseCalendarID).iCurrentEra;
				}
				return this.m_currentEraValue;
			}
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x0012280F File Offset: 0x00120A0F
		internal static void CheckAddResult(long ticks, DateTime minValue, DateTime maxValue)
		{
			if (ticks < minValue.Ticks || ticks > maxValue.Ticks)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("The result is out of the supported range for this calendar. The result should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive."), minValue, maxValue));
			}
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x0012284C File Offset: 0x00120A4C
		internal DateTime Add(DateTime time, double value, int scale)
		{
			double num = value * (double)scale + ((value >= 0.0) ? 0.5 : -0.5);
			if (num <= -315537897600000.0 || num >= 315537897600000.0)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("Value to add was out of range."));
			}
			long num2 = (long)num;
			long ticks = time.Ticks + num2 * 10000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		/// <summary>Возвращает <see cref="T:System.DateTime" /> как заданное число миллисекунд из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются миллисекунды.</param>
		/// <param name="milliseconds">Добавляемое число миллисекунд.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа миллисекунд к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующее значение <see cref="T:System.DateTime" /> находится вне диапазона значений данного календаря.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="milliseconds" /> находится вне допустимого диапазона возвращаемого значения <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06005600 RID: 22016 RVA: 0x001228D6 File Offset: 0x00120AD6
		public virtual DateTime AddMilliseconds(DateTime time, double milliseconds)
		{
			return this.Add(time, milliseconds, 1);
		}

		/// <summary>Возвращает <see cref="T:System.DateTime" /> как заданное число дней из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются дни.</param>
		/// <param name="days">Добавляемое число дней.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа дней к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующее значение <see cref="T:System.DateTime" /> находится вне диапазона значений данного календаря.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="days" /> находится вне допустимого диапазона возвращаемого значения <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06005601 RID: 22017 RVA: 0x001228E1 File Offset: 0x00120AE1
		public virtual DateTime AddDays(DateTime time, int days)
		{
			return this.Add(time, (double)days, 86400000);
		}

		/// <summary>Возвращает <see cref="T:System.DateTime" /> как заданное число часов из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются часы.</param>
		/// <param name="hours">Добавляемое число часов.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа часов к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующее значение <see cref="T:System.DateTime" /> находится вне диапазона значений данного календаря.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="hours" /> находится вне допустимого диапазона возвращаемого значения <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06005602 RID: 22018 RVA: 0x001228F1 File Offset: 0x00120AF1
		public virtual DateTime AddHours(DateTime time, int hours)
		{
			return this.Add(time, (double)hours, 3600000);
		}

		/// <summary>Возвращает <see cref="T:System.DateTime" /> как заданное число минут из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются минуты.</param>
		/// <param name="minutes">Добавляемое число минут.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа минут к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующее значение <see cref="T:System.DateTime" /> находится вне диапазона значений данного календаря.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="minutes" /> находится вне допустимого диапазона возвращаемого значения <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06005603 RID: 22019 RVA: 0x00122901 File Offset: 0x00120B01
		public virtual DateTime AddMinutes(DateTime time, int minutes)
		{
			return this.Add(time, (double)minutes, 60000);
		}

		/// <summary>При переопределении в производном классе возвращает <see cref="T:System.DateTime" /> как заданное число месяцев из заданного <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются месяцы.</param>
		/// <param name="months">Добавляемое число месяцев.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа месяцев к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующее значение <see cref="T:System.DateTime" /> находится вне диапазона значений данного календаря.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="months" /> находится вне допустимого диапазона возвращаемого значения <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06005604 RID: 22020
		public abstract DateTime AddMonths(DateTime time, int months);

		/// <summary>Возвращает <see cref="T:System.DateTime" /> как заданное число секунд из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются секунды.</param>
		/// <param name="seconds">Добавляемое число секунд.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа секунд к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующее значение <see cref="T:System.DateTime" /> находится вне диапазона значений данного календаря.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="seconds" /> находится вне допустимого диапазона возвращаемого значения <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06005605 RID: 22021 RVA: 0x00122911 File Offset: 0x00120B11
		public virtual DateTime AddSeconds(DateTime time, int seconds)
		{
			return this.Add(time, (double)seconds, 1000);
		}

		/// <summary>Возвращает <see cref="T:System.DateTime" /> как заданное число недель из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются недели.</param>
		/// <param name="weeks">Добавляемое число недель.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа недель к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующее значение <see cref="T:System.DateTime" /> находится вне диапазона значений данного календаря.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="weeks" /> находится вне допустимого диапазона возвращаемого значения <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06005606 RID: 22022 RVA: 0x00122921 File Offset: 0x00120B21
		public virtual DateTime AddWeeks(DateTime time, int weeks)
		{
			return this.AddDays(time, weeks * 7);
		}

		/// <summary>При переопределении в производном классе возвращает <see cref="T:System.DateTime" /> как заданное число лет из заданного <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются годы.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа лет к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующее значение <see cref="T:System.DateTime" /> находится вне диапазона значений данного календаря.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="years" /> находится вне допустимого диапазона возвращаемого значения <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06005607 RID: 22023
		public abstract DateTime AddYears(DateTime time, int years);

		/// <summary>При переопределении в производном классе возвращает день месяца в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Положительное целое число, обозначающее день месяца в параметре <paramref name="time" />.</returns>
		// Token: 0x06005608 RID: 22024
		public abstract int GetDayOfMonth(DateTime time);

		/// <summary>При переопределении в производном классе возвращает день недели в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в параметре <paramref name="time" />.</returns>
		// Token: 0x06005609 RID: 22025
		public abstract DayOfWeek GetDayOfWeek(DateTime time);

		/// <summary>При переопределении в производном классе возвращает день года в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Положительное целое число, обозначающее день года в параметре <paramref name="time" />.</returns>
		// Token: 0x0600560A RID: 22026
		public abstract int GetDayOfYear(DateTime time);

		/// <summary>Возвращает число дней в указанном месяце указанных года текущей эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Положительное целое число, представляющее месяц.</param>
		/// <returns>Количество дней в указанном месяце указанных года текущей эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600560B RID: 22027 RVA: 0x0012292D File Offset: 0x00120B2D
		public virtual int GetDaysInMonth(int year, int month)
		{
			return this.GetDaysInMonth(year, month, 0);
		}

		/// <summary>При переопределении в производном классе возвращает число дней в указанном месяце, году и в указанной эре.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Положительное целое число, представляющее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Количество дней в указанном месяце указанных года и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600560C RID: 22028
		public abstract int GetDaysInMonth(int year, int month, int era);

		/// <summary>Возвращает число дней в указанном году текущей эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <returns>Число дней в указанном году текущей эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600560D RID: 22029 RVA: 0x00122938 File Offset: 0x00120B38
		public virtual int GetDaysInYear(int year)
		{
			return this.GetDaysInYear(year, 0);
		}

		/// <summary>При переопределении в производном классе возвращает число дней в указанном году и в указанной эре.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число дней в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600560E RID: 22030
		public abstract int GetDaysInYear(int year, int era);

		/// <summary>При переопределении в производном классе возвращает эру в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее эру в <paramref name="time" />.</returns>
		// Token: 0x0600560F RID: 22031
		public abstract int GetEra(DateTime time);

		/// <summary>При переопределении в производном классе возвращает список эр в текущем календаре.</summary>
		/// <returns>Массив целых чисел для представления эр в текущем календаре.</returns>
		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06005610 RID: 22032
		public abstract int[] Eras { get; }

		/// <summary>Возвращает значение часов в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 0 до 23, обозначающее час в <paramref name="time" />.</returns>
		// Token: 0x06005611 RID: 22033 RVA: 0x00122942 File Offset: 0x00120B42
		public virtual int GetHour(DateTime time)
		{
			return (int)(time.Ticks / 36000000000L % 24L);
		}

		/// <summary>Возвращает значение миллисекунд в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Число двойной точности с плавающей запятой удвоенной точности от 0 до 999, которое представляет миллисекунды в параметре <paramref name="time" />.</returns>
		// Token: 0x06005612 RID: 22034 RVA: 0x0012295A File Offset: 0x00120B5A
		public virtual double GetMilliseconds(DateTime time)
		{
			return (double)(time.Ticks / 10000L % 1000L);
		}

		/// <summary>Возвращает значение минут в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 0 до 59, представляющее минуты в <paramref name="time" />.</returns>
		// Token: 0x06005613 RID: 22035 RVA: 0x00122972 File Offset: 0x00120B72
		public virtual int GetMinute(DateTime time)
		{
			return (int)(time.Ticks / 600000000L % 60L);
		}

		/// <summary>При переопределении в производном классе возвращает месяц в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Положительное целое число, представляющее месяц в параметре <paramref name="time" />.</returns>
		// Token: 0x06005614 RID: 22036
		public abstract int GetMonth(DateTime time);

		/// <summary>Возвращает число месяцев в указанном году текущей эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <returns>Число месяцев в указанном году текущей эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005615 RID: 22037 RVA: 0x00122987 File Offset: 0x00120B87
		public virtual int GetMonthsInYear(int year)
		{
			return this.GetMonthsInYear(year, 0);
		}

		/// <summary>При переопределении в производном классе возвращает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число месяцев в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005616 RID: 22038
		public abstract int GetMonthsInYear(int year, int era);

		/// <summary>Возвращает значение секунд в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 0 до 59, представляющее секунды в <paramref name="time" />.</returns>
		// Token: 0x06005617 RID: 22039 RVA: 0x00122991 File Offset: 0x00120B91
		public virtual int GetSecond(DateTime time)
		{
			return (int)(time.Ticks / 10000000L % 60L);
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x001229A8 File Offset: 0x00120BA8
		internal int GetFirstDayWeekOfYear(DateTime time, int firstDayOfWeek)
		{
			int num = this.GetDayOfYear(time) - 1;
			int num2 = (this.GetDayOfWeek(time) - (DayOfWeek)(num % 7) - firstDayOfWeek + 14) % 7;
			return (num + num2) / 7 + 1;
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x001229DC File Offset: 0x00120BDC
		private int GetWeekOfYearFullDays(DateTime time, int firstDayOfWeek, int fullDays)
		{
			int num = this.GetDayOfYear(time) - 1;
			int num2 = this.GetDayOfWeek(time) - (DayOfWeek)(num % 7);
			int num3 = (firstDayOfWeek - num2 + 14) % 7;
			if (num3 != 0 && num3 >= fullDays)
			{
				num3 -= 7;
			}
			int num4 = num - num3;
			if (num4 >= 0)
			{
				return num4 / 7 + 1;
			}
			if (time <= this.MinSupportedDateTime.AddDays((double)num))
			{
				return this.GetWeekOfYearOfMinSupportedDateTime(firstDayOfWeek, fullDays);
			}
			return this.GetWeekOfYearFullDays(time.AddDays((double)(-(double)(num + 1))), firstDayOfWeek, fullDays);
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00122A58 File Offset: 0x00120C58
		private int GetWeekOfYearOfMinSupportedDateTime(int firstDayOfWeek, int minimumDaysInFirstWeek)
		{
			int num = this.GetDayOfYear(this.MinSupportedDateTime) - 1;
			int num2 = this.GetDayOfWeek(this.MinSupportedDateTime) - (DayOfWeek)(num % 7);
			int num3 = (firstDayOfWeek + 7 - num2) % 7;
			if (num3 == 0 || num3 >= minimumDaysInFirstWeek)
			{
				return 1;
			}
			int num4 = this.DaysInYearBeforeMinSupportedYear - 1;
			int num5 = num2 - 1 - num4 % 7;
			int num6 = (firstDayOfWeek - num5 + 14) % 7;
			int num7 = num4 - num6;
			if (num6 >= minimumDaysInFirstWeek)
			{
				num7 += 7;
			}
			return num7 / 7 + 1;
		}

		/// <summary>Получает число дней в году, который предшествует году, указанному свойством <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" />.</summary>
		/// <returns>Число дней в году, который предшествует году, указанному с помощью <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" />.</returns>
		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x0600561B RID: 22043 RVA: 0x00122ACA File Offset: 0x00120CCA
		protected virtual int DaysInYearBeforeMinSupportedYear
		{
			get
			{
				return 365;
			}
		}

		/// <summary>Возвращает неделю года, к которой относится дата в заданном значении <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">Значение даты и времени.</param>
		/// <param name="rule">Значение перечисления, определяющее календарную неделю.</param>
		/// <param name="firstDayOfWeek">Значение перечисления, представляющее первый день недели.</param>
		/// <returns>Положительное целое число, представляющее неделю года, к которой относится дата в параметре <paramref name="time" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Время, указанное в параметре <paramref name="time" />, наступает раньше момента времени, определенного свойством <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" />, или позже момента времени, определенного свойством <see cref="P:System.Globalization.Calendar.MaxSupportedDateTime" />.  
		/// -или- 
		///  <paramref name="firstDayOfWeek" /> не является допустимым значением <see cref="T:System.DayOfWeek" />.  
		/// -или- 
		///  <paramref name="rule" /> не является допустимым значением <see cref="T:System.Globalization.CalendarWeekRule" />.</exception>
		// Token: 0x0600561C RID: 22044 RVA: 0x00122AD4 File Offset: 0x00120CD4
		public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
		{
			if (firstDayOfWeek < DayOfWeek.Sunday || firstDayOfWeek > DayOfWeek.Saturday)
			{
				throw new ArgumentOutOfRangeException("firstDayOfWeek", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					DayOfWeek.Sunday,
					DayOfWeek.Saturday
				}));
			}
			switch (rule)
			{
			case CalendarWeekRule.FirstDay:
				return this.GetFirstDayWeekOfYear(time, (int)firstDayOfWeek);
			case CalendarWeekRule.FirstFullWeek:
				return this.GetWeekOfYearFullDays(time, (int)firstDayOfWeek, 7);
			case CalendarWeekRule.FirstFourDayWeek:
				return this.GetWeekOfYearFullDays(time, (int)firstDayOfWeek, 4);
			default:
				throw new ArgumentOutOfRangeException("rule", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					CalendarWeekRule.FirstDay,
					CalendarWeekRule.FirstFourDayWeek
				}));
			}
		}

		/// <summary>При переопределении в производном классе возвращает год в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в параметре <paramref name="time" />.</returns>
		// Token: 0x0600561D RID: 22045
		public abstract int GetYear(DateTime time);

		/// <summary>Определяет, является ли указанная дата текущей эры високосным днем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Положительное целое число, представляющее месяц.</param>
		/// <param name="day">Положительное целое число, представляющее день.</param>
		/// <returns>Значение <see langword="true" />, если указанный день — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// -или- 
		///  Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600561E RID: 22046 RVA: 0x00122B73 File Offset: 0x00120D73
		public virtual bool IsLeapDay(int year, int month, int day)
		{
			return this.IsLeapDay(year, month, day, 0);
		}

		/// <summary>При переопределении в производном классе определяет, является ли указанная дата указанной эры високосным днем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Положительное целое число, представляющее месяц.</param>
		/// <param name="day">Положительное целое число, представляющее день.</param>
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
		///
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600561F RID: 22047
		public abstract bool IsLeapDay(int year, int month, int day, int era);

		/// <summary>Определяет, является ли указанный месяц указанного года текущей эры високосным месяцем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Положительное целое число, представляющее месяц.</param>
		/// <returns>Значение <see langword="true" />, если указанный месяц — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005620 RID: 22048 RVA: 0x00122B7F File Offset: 0x00120D7F
		public virtual bool IsLeapMonth(int year, int month)
		{
			return this.IsLeapMonth(year, month, 0);
		}

		/// <summary>При переопределении в производном классе определяет, является ли указанный месяц указанных года и эры високосным месяцем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Положительное целое число, представляющее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный месяц — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005621 RID: 22049
		public abstract bool IsLeapMonth(int year, int month, int era);

		/// <summary>Вычисляет високосный месяц для заданного года.</summary>
		/// <param name="year">Год.</param>
		/// <returns>Положительное целое число от 1 до 13, указывающее високосный месяц в указанном году.  
		///
		/// или - 
		/// Нуль, если этот календарь не поддерживает високосные месяцы, или если в параметре <paramref name="year" /> не указан високосный год.</returns>
		// Token: 0x06005622 RID: 22050 RVA: 0x00122B8A File Offset: 0x00120D8A
		[ComVisible(false)]
		public virtual int GetLeapMonth(int year)
		{
			return this.GetLeapMonth(year, 0);
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Год.</param>
		/// <param name="era">Эра.</param>
		/// <returns>Положительное целое число от 1 до 13, указывающее високосный месяц в указанном году указанной эры.  
		/// -или- 
		/// Нуль, если этот календарь не поддерживает високосные месяцы или если в параметрах <paramref name="year" /> и <paramref name="era" /> не указан високосный год.</returns>
		// Token: 0x06005623 RID: 22051 RVA: 0x00122B94 File Offset: 0x00120D94
		[ComVisible(false)]
		public virtual int GetLeapMonth(int year, int era)
		{
			if (!this.IsLeapYear(year, era))
			{
				return 0;
			}
			int monthsInYear = this.GetMonthsInYear(year, era);
			for (int i = 1; i <= monthsInYear; i++)
			{
				if (this.IsLeapMonth(year, i, era))
				{
					return i;
				}
			}
			return 0;
		}

		/// <summary>Определяет, является ли указанный год текущей эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005624 RID: 22052 RVA: 0x00122BD0 File Offset: 0x00120DD0
		public virtual bool IsLeapYear(int year)
		{
			return this.IsLeapYear(year, 0);
		}

		/// <summary>При переопределении в производном классе определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005625 RID: 22053
		public abstract bool IsLeapYear(int year, int era);

		/// <summary>Возвращает <see cref="T:System.DateTime" /> с заданными значениями даты и времени текущей эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Положительное целое число, представляющее месяц.</param>
		/// <param name="day">Положительное целое число, представляющее день.</param>
		/// <param name="hour">Целое число от 0 до 23, представляющее час.</param>
		/// <param name="minute">Целое число от 0 до 59, представляющее минуту.</param>
		/// <param name="second">Целое число от 0 до 59, представляющее секунду.</param>
		/// <param name="millisecond">Целое число от 0 до 999, представляющее миллисекунду.</param>
		/// <returns>Объект <see cref="T:System.DateTime" /> с заданными значениями даты и времени в текущей эре.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше нуля или больше 23.  
		/// -или- 
		///  Параметр <paramref name="minute" /> меньше нуля или больше 59.  
		///
		/// или - 
		/// Параметр <paramref name="second" /> меньше нуля или больше 59.  
		///
		/// -или- 
		///  Параметр <paramref name="millisecond" /> меньше нуля или больше 999.</exception>
		// Token: 0x06005626 RID: 22054 RVA: 0x00122BDC File Offset: 0x00120DDC
		public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			return this.ToDateTime(year, month, day, hour, minute, second, millisecond, 0);
		}

		/// <summary>При переопределении в производном классе возвращает <see cref="T:System.DateTime" /> со значением даты и времени в заданной эре.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Положительное целое число, представляющее месяц.</param>
		/// <param name="day">Положительное целое число, представляющее день.</param>
		/// <param name="hour">Целое число от 0 до 23, представляющее час.</param>
		/// <param name="minute">Целое число от 0 до 59, представляющее минуту.</param>
		/// <param name="second">Целое число от 0 до 59, представляющее секунду.</param>
		/// <param name="millisecond">Целое число от 0 до 999, представляющее миллисекунду.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Объект <see cref="T:System.DateTime" /> с заданными значениями даты и времени в текущей эре.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше нуля или больше 23.  
		///
		/// или - 
		/// Параметр <paramref name="minute" /> меньше нуля или больше 59.  
		///
		/// -или- 
		///  Параметр <paramref name="second" /> меньше нуля или больше 59.  
		/// -или- 
		///  Параметр <paramref name="millisecond" /> меньше нуля или больше 999.  
		/// -или- 
		///  Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005627 RID: 22055
		public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

		// Token: 0x06005628 RID: 22056 RVA: 0x00122BFC File Offset: 0x00120DFC
		internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			result = DateTime.MinValue;
			bool result2;
			try
			{
				result = this.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
				result2 = true;
			}
			catch (ArgumentException)
			{
				result2 = false;
			}
			return result2;
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x00017C70 File Offset: 0x00015E70
		internal virtual bool IsValidYear(int year, int era)
		{
			return year >= this.GetYear(this.MinSupportedDateTime) && year <= this.GetYear(this.MaxSupportedDateTime);
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x00017C50 File Offset: 0x00015E50
		internal virtual bool IsValidMonth(int year, int month, int era)
		{
			return this.IsValidYear(year, era) && month >= 1 && month <= this.GetMonthsInYear(year, era);
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x00017C2C File Offset: 0x00015E2C
		internal virtual bool IsValidDay(int year, int month, int day, int era)
		{
			return this.IsValidMonth(year, month, era) && day >= 1 && day <= this.GetDaysInMonth(year, month, era);
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Globalization.Calendar" /> доступен только для чтения.</exception>
		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x0600562C RID: 22060 RVA: 0x00122C4C File Offset: 0x00120E4C
		// (set) Token: 0x0600562D RID: 22061 RVA: 0x00122C54 File Offset: 0x00120E54
		public virtual int TwoDigitYearMax
		{
			get
			{
				return this.twoDigitYearMax;
			}
			set
			{
				this.VerifyWritable();
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Преобразует заданный год в четырехзначное представление с использованием свойства <see cref="P:System.Globalization.Calendar.TwoDigitYearMax" /> для определения века.</summary>
		/// <param name="year">Двузначное или четырехзначное целое число, представляющее подлежащий преобразованию год.</param>
		/// <returns>Целое число, содержащее четырехразрядное представление <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600562E RID: 22062 RVA: 0x00122C64 File Offset: 0x00120E64
		public virtual int ToFourDigitYear(int year)
		{
			if (year < 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Non-negative number required."));
			}
			if (year < 100)
			{
				return (this.TwoDigitYearMax / 100 - ((year > this.TwoDigitYearMax % 100) ? 1 : 0)) * 100 + year;
			}
			return year;
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x00122CB0 File Offset: 0x00120EB0
		internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			if (hour < 0 || hour >= 24 || minute < 0 || minute >= 60 || second < 0 || second >= 60)
			{
				throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Hour, Minute, and Second parameters describe an un-representable DateTime."));
			}
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 999));
			}
			return TimeSpan.TimeToTicks(hour, minute, second) + (long)millisecond * 10000L;
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x00122D38 File Offset: 0x00120F38
		[SecuritySafeCritical]
		internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			int num = CalendarData.nativeGetTwoDigitYearMax(CalID);
			if (num < 0)
			{
				num = defaultYearValue;
			}
			return num;
		}

		// Token: 0x04003586 RID: 13702
		internal const long TicksPerMillisecond = 10000L;

		// Token: 0x04003587 RID: 13703
		internal const long TicksPerSecond = 10000000L;

		// Token: 0x04003588 RID: 13704
		internal const long TicksPerMinute = 600000000L;

		// Token: 0x04003589 RID: 13705
		internal const long TicksPerHour = 36000000000L;

		// Token: 0x0400358A RID: 13706
		internal const long TicksPerDay = 864000000000L;

		// Token: 0x0400358B RID: 13707
		internal const int MillisPerSecond = 1000;

		// Token: 0x0400358C RID: 13708
		internal const int MillisPerMinute = 60000;

		// Token: 0x0400358D RID: 13709
		internal const int MillisPerHour = 3600000;

		// Token: 0x0400358E RID: 13710
		internal const int MillisPerDay = 86400000;

		// Token: 0x0400358F RID: 13711
		internal const int DaysPerYear = 365;

		// Token: 0x04003590 RID: 13712
		internal const int DaysPer4Years = 1461;

		// Token: 0x04003591 RID: 13713
		internal const int DaysPer100Years = 36524;

		// Token: 0x04003592 RID: 13714
		internal const int DaysPer400Years = 146097;

		// Token: 0x04003593 RID: 13715
		internal const int DaysTo10000 = 3652059;

		// Token: 0x04003594 RID: 13716
		internal const long MaxMillis = 315537897600000L;

		// Token: 0x04003595 RID: 13717
		internal const int CAL_GREGORIAN = 1;

		// Token: 0x04003596 RID: 13718
		internal const int CAL_GREGORIAN_US = 2;

		// Token: 0x04003597 RID: 13719
		internal const int CAL_JAPAN = 3;

		// Token: 0x04003598 RID: 13720
		internal const int CAL_TAIWAN = 4;

		// Token: 0x04003599 RID: 13721
		internal const int CAL_KOREA = 5;

		// Token: 0x0400359A RID: 13722
		internal const int CAL_HIJRI = 6;

		// Token: 0x0400359B RID: 13723
		internal const int CAL_THAI = 7;

		// Token: 0x0400359C RID: 13724
		internal const int CAL_HEBREW = 8;

		// Token: 0x0400359D RID: 13725
		internal const int CAL_GREGORIAN_ME_FRENCH = 9;

		// Token: 0x0400359E RID: 13726
		internal const int CAL_GREGORIAN_ARABIC = 10;

		// Token: 0x0400359F RID: 13727
		internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;

		// Token: 0x040035A0 RID: 13728
		internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;

		// Token: 0x040035A1 RID: 13729
		internal const int CAL_JULIAN = 13;

		// Token: 0x040035A2 RID: 13730
		internal const int CAL_JAPANESELUNISOLAR = 14;

		// Token: 0x040035A3 RID: 13731
		internal const int CAL_CHINESELUNISOLAR = 15;

		// Token: 0x040035A4 RID: 13732
		internal const int CAL_SAKA = 16;

		// Token: 0x040035A5 RID: 13733
		internal const int CAL_LUNAR_ETO_CHN = 17;

		// Token: 0x040035A6 RID: 13734
		internal const int CAL_LUNAR_ETO_KOR = 18;

		// Token: 0x040035A7 RID: 13735
		internal const int CAL_LUNAR_ETO_ROKUYOU = 19;

		// Token: 0x040035A8 RID: 13736
		internal const int CAL_KOREANLUNISOLAR = 20;

		// Token: 0x040035A9 RID: 13737
		internal const int CAL_TAIWANLUNISOLAR = 21;

		// Token: 0x040035AA RID: 13738
		internal const int CAL_PERSIAN = 22;

		// Token: 0x040035AB RID: 13739
		internal const int CAL_UMALQURA = 23;

		// Token: 0x040035AC RID: 13740
		internal int m_currentEraValue = -1;

		// Token: 0x040035AD RID: 13741
		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		/// <summary>Представляет текущую эру для текущего календаря. Значение этого поля равно 0.</summary>
		// Token: 0x040035AE RID: 13742
		public const int CurrentEra = 0;

		// Token: 0x040035AF RID: 13743
		internal int twoDigitYearMax = -1;
	}
}
