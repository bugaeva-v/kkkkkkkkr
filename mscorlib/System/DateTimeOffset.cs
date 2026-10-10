using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Представляет момент времени, который обычно выражается в виде даты и времени суток, относительно времени в формате UTC.</summary>
	// Token: 0x0200010E RID: 270
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public readonly struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTimeOffset" /> с использованием заданного количества тактов и смещения.</summary>
		/// <param name="ticks">Дата и время, представленные в виде числа 100-наносекундных интервалов, прошедших с 00:00 1 января 0001 г.</param>
		/// <param name="offset">Смещение по времени от времени в формате UTC.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" /> не следует указывать в целых минутах.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <see cref="P:System.DateTimeOffset.UtcDateTime" /> является более ранним, чем <see cref="F:System.DateTimeOffset.MinValue" />, или более поздним, чем <see cref="F:System.DateTimeOffset.MaxValue" />.  
		/// -или- 
		///  Значение <paramref name="ticks" /> меньше <see langword="DateTimeOffset.MinValue.Ticks" /> или больше <see langword="DateTimeOffset.MaxValue.Ticks" />.  
		/// -или- 
		///  <paramref name="Offset" /> меньше -14 часов или больше 14 часов.</exception>
		// Token: 0x06000A2D RID: 2605 RVA: 0x000271C4 File Offset: 0x000253C4
		public DateTimeOffset(long ticks, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			DateTime dateTime = new DateTime(ticks);
			this._dateTime = DateTimeOffset.ValidateDate(dateTime, offset);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTimeOffset" /> с использованием заданного значения <see cref="T:System.DateTime" />.</summary>
		/// <param name="dateTime">Дата и время.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время в формате UTC, которые получаются в результате применения смещения, более раннего чем <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Дата и время в формате UTC, которые получаются в результате применения смещения, более позднего чем <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A2E RID: 2606 RVA: 0x000271F4 File Offset: 0x000253F4
		public DateTimeOffset(DateTime dateTime)
		{
			TimeSpan localUtcOffset;
			if (dateTime.Kind != DateTimeKind.Utc)
			{
				localUtcOffset = TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
			else
			{
				localUtcOffset = new TimeSpan(0L);
			}
			this._offsetMinutes = DateTimeOffset.ValidateOffset(localUtcOffset);
			this._dateTime = DateTimeOffset.ValidateDate(dateTime, localUtcOffset);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTimeOffset" /> с использованием заданного значения <see cref="T:System.DateTime" /> и смещения.</summary>
		/// <param name="dateTime">Дата и время.</param>
		/// <param name="offset">Смещение по времени от времени в формате UTC.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="dateTime.Kind" /> равно <see cref="F:System.DateTimeKind.Utc" />, а <paramref name="offset" /> не равно нулю.  
		/// -или- 
		///  <paramref name="dateTime.Kind" /> равно <see cref="F:System.DateTimeKind.Local" />, а <paramref name="offset" /> не равно смещению местного часового пояса в системе.  
		/// -или- 
		///  <paramref name="offset" /> не указано в целых минутах.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> меньше -14 часов или больше 14 часов.  
		/// -или- 
		///  Значение <see cref="P:System.DateTimeOffset.UtcDateTime" /> меньше <see cref="F:System.DateTimeOffset.MinValue" /> или больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A2F RID: 2607 RVA: 0x00027238 File Offset: 0x00025438
		public DateTimeOffset(DateTime dateTime, TimeSpan offset)
		{
			if (dateTime.Kind == DateTimeKind.Local)
			{
				if (offset != TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime))
				{
					throw new ArgumentException("The UTC Offset of the local dateTime parameter does not match the offset argument.", "offset");
				}
			}
			else if (dateTime.Kind == DateTimeKind.Utc && offset != TimeSpan.Zero)
			{
				throw new ArgumentException("The UTC Offset for Utc DateTime instances must be 0.", "offset");
			}
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(dateTime, offset);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTimeOffset" />, используя указанный год, месяц, день, час, минуту, секунду и смещение.</summary>
		/// <param name="year">Год (от 1 до 9999).</param>
		/// <param name="month">Месяц (от 1 до 12).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="offset">Смещение по времени от времени в формате UTC.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="offset" /> не представляет целое количество минут.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="year" /> меньше единицы или больше 9999.  
		/// -или- 
		///  Значение <paramref name="month" /> меньше единицы или больше 12.  
		/// -или- 
		///  Значение параметра <paramref name="day" /> меньше единицы или больше чем число дней в параметре <paramref name="month" />.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше нуля или больше 23.  
		/// -или- 
		///  Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.  
		/// -или- 
		///  Значение параметра <paramref name="offset" /> меньше –14 часов или больше 14 часов.  
		/// -или- 
		/// Момент времени, заданный в свойстве <see cref="P:System.DateTimeOffset.UtcDateTime" />, наступает раньше <see cref="F:System.DateTimeOffset.MinValue" /> или позже <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A30 RID: 2608 RVA: 0x000272AE File Offset: 0x000254AE
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second), offset);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTimeOffset" />, используя указанные год, месяц, день, час, минуту, секунду, миллисекунду и смещение.</summary>
		/// <param name="year">Год (от 1 до 9999).</param>
		/// <param name="month">Месяц (от 1 до 12).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="millisecond">Миллисекунды (от 0 до 999).</param>
		/// <param name="offset">Смещение по времени от времени в формате UTC.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="offset" /> не представляет целое количество минут.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="year" /> меньше единицы или больше 9999.  
		/// -или- 
		///  Значение <paramref name="month" /> меньше единицы или больше 12.  
		/// -или- 
		///  Значение параметра <paramref name="day" /> меньше единицы или больше чем число дней в параметре <paramref name="month" />.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше нуля или больше 23.  
		/// -или- 
		///  Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="millisecond" /> имеет значение меньше 0 или больше 999.  
		/// -или- 
		///  Параметр <paramref name="offset" /> меньше –14 или больше 14.  
		/// -или- 
		/// Момент времени, заданный в свойстве <see cref="P:System.DateTimeOffset.UtcDateTime" />, наступает раньше <see cref="F:System.DateTimeOffset.MinValue" /> или позже <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A31 RID: 2609 RVA: 0x000272D8 File Offset: 0x000254D8
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second, millisecond), offset);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTimeOffset" />, используя указанные год, месяц, день, час, минуту, секунду, миллисекунду и смещение для заданного календаря.</summary>
		/// <param name="year">Год.</param>
		/// <param name="month">Месяц (от 1 до 12).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="millisecond">Миллисекунды (от 0 до 999).</param>
		/// <param name="calendar">Календарь, используемый для анализа параметров <paramref name="year" />, <paramref name="month" /> и <paramref name="day" />.</param>
		/// <param name="offset">Смещение по времени от времени в формате UTC.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="offset" /> не представляет целое количество минут.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="calendar" /> не может иметь значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> меньше заданного для параметра <paramref name="calendar" /> значения <see langword="MinSupportedDateTime.Year" /> или больше чем <see langword="MaxSupportedDateTime.Year" />.  
		/// -или- 
		///  Значение параметра <paramref name="month" /> меньше или больше чем число месяцев, заданное в параметре <paramref name="year" /> параметра <paramref name="calendar" />.  
		/// -или- 
		///  Значение параметра <paramref name="day" /> меньше единицы или больше чем число дней в параметре <paramref name="month" />.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше нуля или больше 23.  
		/// -или- 
		///  Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="millisecond" /> имеет значение меньше 0 или больше 999.  
		/// -или- 
		///  Значение параметра <paramref name="offset" /> меньше –14 часов или больше 14 часов.  
		/// -или- 
		/// Параметры <paramref name="year" />, <paramref name="month" /> и <paramref name="day" /> не удается представить как значения типа даты и времени.  
		/// -или- 
		/// Момент времени, заданный в свойстве <see cref="P:System.DateTimeOffset.UtcDateTime" />, наступает раньше <see cref="F:System.DateTimeOffset.MinValue" /> или позже <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A32 RID: 2610 RVA: 0x00027304 File Offset: 0x00025504
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second, millisecond, calendar), offset);
		}

		/// <summary>Возвращает объект <see cref="T:System.DateTimeOffset" />, для которого в качестве значения установлены текущие дата и время на текущем компьютере, а в качестве смещения — смещение местного времени от времени в формате UTC.</summary>
		/// <returns>Объект <see cref="T:System.DateTimeOffset" />, дата и время которого соответствуют текущему местному времени, а смещение равно смещению местного часового пояса от времени в формате UTC.</returns>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0002733D File Offset: 0x0002553D
		public static DateTimeOffset Now
		{
			get
			{
				return new DateTimeOffset(DateTime.Now);
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.DateTimeOffset" />, в качестве даты и времени которого установлены текущие дата и время в формате UTC, а в качестве смещения — значение <see cref="F:System.TimeSpan.Zero" />.</summary>
		/// <returns>Объект, дата и время которого совпадают с текущим временем в формате UTC, а смещение которого равно <see cref="F:System.TimeSpan.Zero" />.</returns>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00027349 File Offset: 0x00025549
		public static DateTimeOffset UtcNow
		{
			get
			{
				return new DateTimeOffset(DateTime.UtcNow);
			}
		}

		/// <summary>Получает значение <see cref="T:System.DateTime" />, представляющее дату и время текущего объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Дата и время текущего объекта <see cref="T:System.DateTimeOffset" />.</returns>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00027355 File Offset: 0x00025555
		public DateTime DateTime
		{
			get
			{
				return this.ClockDateTime;
			}
		}

		/// <summary>Получает значение <see cref="T:System.DateTime" />, представляющее дату и время текущего объекта <see cref="T:System.DateTimeOffset" /> в формате UTC.</summary>
		/// <returns>Дата и время текущего объекта <see cref="T:System.DateTimeOffset" /> в формате UTC.</returns>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0002735D File Offset: 0x0002555D
		public DateTime UtcDateTime
		{
			get
			{
				return DateTime.SpecifyKind(this._dateTime, DateTimeKind.Utc);
			}
		}

		/// <summary>Получает значение <see cref="T:System.DateTime" />, представляющее местную дату и время в текущем объекте <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Локальные дата и время текущего объекта <see cref="T:System.DateTimeOffset" />.</returns>
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0002736C File Offset: 0x0002556C
		public DateTime LocalDateTime
		{
			get
			{
				return this.UtcDateTime.ToLocalTime();
			}
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTimeOffset" /> в дату и время, указанные в значении смещения.</summary>
		/// <param name="offset">Смещение, в которое необходимо преобразовать значение <see cref="T:System.DateTimeOffset" />.</param>
		/// <returns>Объект, равный исходному объекту <see cref="T:System.DateTimeOffset" /> (то есть, методы <see cref="M:System.DateTimeOffset.ToUniversalTime" /> этих объектов возвращают один и тот же момент времени), свойству <see cref="P:System.DateTimeOffset.Offset" /> которого, однако, присвоено значение <paramref name="offset" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующий объект <see cref="T:System.DateTimeOffset" /> имеет значение <see cref="P:System.DateTimeOffset.DateTime" />, соответствующее более раннему моменту времени, чем <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Результирующий объект <see cref="T:System.DateTimeOffset" /> имеет значение <see cref="P:System.DateTimeOffset.DateTime" />, соответствующее более позднему моменту времени, чем <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше -14 часов.  
		/// -или- 
		///  Значение параметра <paramref name="offset" /> больше 14 часов.</exception>
		// Token: 0x06000A38 RID: 2616 RVA: 0x00027388 File Offset: 0x00025588
		public DateTimeOffset ToOffset(TimeSpan offset)
		{
			return new DateTimeOffset((this._dateTime + offset).Ticks, offset);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000273B0 File Offset: 0x000255B0
		private DateTime ClockDateTime
		{
			get
			{
				return new DateTime((this._dateTime + this.Offset).Ticks, DateTimeKind.Unspecified);
			}
		}

		/// <summary>Получает значение <see cref="T:System.DateTime" />, представляющее компонент даты в текущем объекте <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Значение <see cref="T:System.DateTime" />, представляющее компонент даты в текущем объекте <see cref="T:System.DateTimeOffset" />.</returns>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000273DC File Offset: 0x000255DC
		public DateTime Date
		{
			get
			{
				return this.ClockDateTime.Date;
			}
		}

		/// <summary>Возвращает день месяца, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Компонент дня текущего объекта <see cref="T:System.DateTimeOffset" />, выраженный в виде значения в диапазоне от 1 до 31.</returns>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000273F8 File Offset: 0x000255F8
		public int Day
		{
			get
			{
				return this.ClockDateTime.Day;
			}
		}

		/// <summary>Возвращает день недели, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Одно из значений перечисления, определяющее день недели текущего объекта <see cref="T:System.DateTimeOffset" />.</returns>
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00027414 File Offset: 0x00025614
		public DayOfWeek DayOfWeek
		{
			get
			{
				return this.ClockDateTime.DayOfWeek;
			}
		}

		/// <summary>Возвращает день года, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Компонент года текущего объекта <see cref="T:System.DateTimeOffset" />, выраженный в виде значения в диапазоне от 1 до 366.</returns>
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00027430 File Offset: 0x00025630
		public int DayOfYear
		{
			get
			{
				return this.ClockDateTime.DayOfYear;
			}
		}

		/// <summary>Возвращает часовой компонент, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Часовой компонент текущего объекта <see cref="T:System.DateTimeOffset" />. В этом свойстве используются 24-часовые часы; значение может меняться в диапазоне от 0 до 23.</returns>
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0002744C File Offset: 0x0002564C
		public int Hour
		{
			get
			{
				return this.ClockDateTime.Hour;
			}
		}

		/// <summary>Возвращает временной компонент миллисекунд, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Компонент миллисекунд текущего объекта <see cref="T:System.DateTimeOffset" />, выраженный в виде целого числа в диапазоне от 0 до 999.</returns>
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00027468 File Offset: 0x00025668
		public int Millisecond
		{
			get
			{
				return this.ClockDateTime.Millisecond;
			}
		}

		/// <summary>Возвращает компонент минут, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Компонент минут текущего объекта <see cref="T:System.DateTimeOffset" />, выраженный в виде целого числа в диапазоне от 0 до 59.</returns>
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00027484 File Offset: 0x00025684
		public int Minute
		{
			get
			{
				return this.ClockDateTime.Minute;
			}
		}

		/// <summary>Возвращает компонент месяца даты, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Компонент месяца текущего объекта <see cref="T:System.DateTimeOffset" />, выраженный в виде целого числа в диапазоне от 1 до 12.</returns>
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x000274A0 File Offset: 0x000256A0
		public int Month
		{
			get
			{
				return this.ClockDateTime.Month;
			}
		}

		/// <summary>Возвращает смещение по времени от времени в формате UTC.</summary>
		/// <returns>Разность между значением времени текущего объекта <see cref="T:System.DateTimeOffset" /> и временем в формате UTC.</returns>
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x000274BB File Offset: 0x000256BB
		public TimeSpan Offset
		{
			get
			{
				return new TimeSpan(0, (int)this._offsetMinutes, 0);
			}
		}

		/// <summary>Возвращает компонент секунд по показаниям часов, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Компонент секунд текущего объекта <see cref="T:System.DateTimeOffset" />, выраженный в виде целочисленного значения в диапазоне от 0 до 59.</returns>
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x000274CC File Offset: 0x000256CC
		public int Second
		{
			get
			{
				return this.ClockDateTime.Second;
			}
		}

		/// <summary>Возвращает количество тактов, представляющее местную дату и время в текущем объекте <see cref="T:System.DateTimeOffset" /> по показаниям часов.</summary>
		/// <returns>Число тактов во времени объекта <see cref="T:System.DateTimeOffset" />.</returns>
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x000274E8 File Offset: 0x000256E8
		public long Ticks
		{
			get
			{
				return this.ClockDateTime.Ticks;
			}
		}

		/// <summary>Возвращает количество тактов, которое представляет дату и время текущего объекта <see cref="T:System.DateTimeOffset" /> в формате UTC.</summary>
		/// <returns>Число тактов во времени объекта <see cref="T:System.DateTimeOffset" /> в формате UTC.</returns>
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00027504 File Offset: 0x00025704
		public long UtcTicks
		{
			get
			{
				return this.UtcDateTime.Ticks;
			}
		}

		/// <summary>Получает время суток текущего объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Время, истекшее с полуночи на текущую дату.</returns>
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00027520 File Offset: 0x00025720
		public TimeSpan TimeOfDay
		{
			get
			{
				return this.ClockDateTime.TimeOfDay;
			}
		}

		/// <summary>Возвращает компонент года даты, представленный текущим объектом <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Компонент года текущего объекта <see cref="T:System.DateTimeOffset" />, выраженный в виде целочисленного значения в диапазоне от 0 до 9999.</returns>
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0002753C File Offset: 0x0002573C
		public int Year
		{
			get
			{
				return this.ClockDateTime.Year;
			}
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, добавляющий указанный интервал времени к значению этого экземпляра.</summary>
		/// <param name="timeSpan">Объект <see cref="T:System.TimeSpan" />, представляющий положительный или отрицательный интервал времени.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и интервала времени, представленного параметром <paramref name="timeSpan" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A48 RID: 2632 RVA: 0x00027558 File Offset: 0x00025758
		public DateTimeOffset Add(TimeSpan timeSpan)
		{
			return new DateTimeOffset(this.ClockDateTime.Add(timeSpan), this.Offset);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, прибавляющий заданное количество полных и неполных дней к значению данного экземпляра.</summary>
		/// <param name="days">Число полных и неполных дней. Это число может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и количества дней, представленного параметром <paramref name="days" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A49 RID: 2633 RVA: 0x00027580 File Offset: 0x00025780
		public DateTimeOffset AddDays(double days)
		{
			return new DateTimeOffset(this.ClockDateTime.AddDays(days), this.Offset);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, добавляющий заданное количество полных и неполных часов к значению этого экземпляра.</summary>
		/// <param name="hours">Число полных и неполных часов. Это число может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и количества часов, представленного параметром <paramref name="hours" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A4A RID: 2634 RVA: 0x000275A8 File Offset: 0x000257A8
		public DateTimeOffset AddHours(double hours)
		{
			return new DateTimeOffset(this.ClockDateTime.AddHours(hours), this.Offset);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, прибавляющий заданное число миллисекунд к значению данного экземпляра.</summary>
		/// <param name="milliseconds">Число полных и неполных миллисекунд. Это число может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и количества полных миллисекунд, представленных параметром <paramref name="milliseconds" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A4B RID: 2635 RVA: 0x000275D0 File Offset: 0x000257D0
		public DateTimeOffset AddMilliseconds(double milliseconds)
		{
			return new DateTimeOffset(this.ClockDateTime.AddMilliseconds(milliseconds), this.Offset);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, прибавляющий заданное количество полных и неполных минут к значению данного экземпляра.</summary>
		/// <param name="minutes">Число полных и неполных минут. Это число может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и количества минут, представленного параметром <paramref name="minutes" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A4C RID: 2636 RVA: 0x000275F8 File Offset: 0x000257F8
		public DateTimeOffset AddMinutes(double minutes)
		{
			return new DateTimeOffset(this.ClockDateTime.AddMinutes(minutes), this.Offset);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, добавляющий заданное число месяцев к значению данного экземпляра.</summary>
		/// <param name="months">Число полных месяцев. Это число может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и количества месяцев, представленных параметром <paramref name="months" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A4D RID: 2637 RVA: 0x00027620 File Offset: 0x00025820
		public DateTimeOffset AddMonths(int months)
		{
			return new DateTimeOffset(this.ClockDateTime.AddMonths(months), this.Offset);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, прибавляющий заданное количество полных и неполных секунд к значению данного экземпляра.</summary>
		/// <param name="seconds">Число полных и неполных секунд. Это число может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и количества секунд, представленного параметром <paramref name="seconds" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A4E RID: 2638 RVA: 0x00027648 File Offset: 0x00025848
		public DateTimeOffset AddSeconds(double seconds)
		{
			return new DateTimeOffset(this.ClockDateTime.AddSeconds(seconds), this.Offset);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, прибавляющий заданное число тактов к значению этого экземпляра.</summary>
		/// <param name="ticks">Число 100-наносекундных тактов. Это число может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и количества тактов, представленного параметром <paramref name="ticks" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A4F RID: 2639 RVA: 0x00027670 File Offset: 0x00025870
		public DateTimeOffset AddTicks(long ticks)
		{
			return new DateTimeOffset(this.ClockDateTime.AddTicks(ticks), this.Offset);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTimeOffset" />, прибавляющий заданное число лет к значению этого экземпляра.</summary>
		/// <param name="years">Число лет. Это число может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим объектом <see cref="T:System.DateTimeOffset" />, и количества лет, представленного параметром <paramref name="years" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A50 RID: 2640 RVA: 0x00027698 File Offset: 0x00025898
		public DateTimeOffset AddYears(int years)
		{
			return new DateTimeOffset(this.ClockDateTime.AddYears(years), this.Offset);
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.DateTimeOffset" />, и указывает, как соотносятся между собой указанные в них моменты времени: первый раньше второго, первый и второй равны, или же первый позже второго.</summary>
		/// <param name="first">Первый из сравниваемых объектов.</param>
		/// <param name="second">Второй из сравниваемых объектов.</param>
		/// <returns>Знаковое целое число, позволяющее определить, наступает ли момент, указанный в параметре <paramref name="first" />, раньше или одновременно с моментом, указанным в параметре <paramref name="second" />, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   Меньше нуля 
		///  Момент, указанный в параметре <paramref name="first" />, наступает раньше, чем момент, указанный в параметре <paramref name="second" />.  
		///
		///   Нуль 
		///  <paramref name="first" /> равно <paramref name="second" />.  
		///
		///   Больше нуля 
		///  Момент, указанный в параметре <paramref name="first" />, наступает позже, чем момент, указанный в параметре <paramref name="second" />.</returns>
		// Token: 0x06000A51 RID: 2641 RVA: 0x000276BF File Offset: 0x000258BF
		public static int Compare(DateTimeOffset first, DateTimeOffset second)
		{
			return DateTime.Compare(first.UtcDateTime, second.UtcDateTime);
		}

		/// <summary>Сравнивает значение текущего объекта <see cref="T:System.DateTimeOffset" /> с другим объектом того же типа.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом <see cref="T:System.DateTimeOffset" />.</param>
		/// <returns>32-разрядное целое число со знаком, позволяющее определить, больше, меньше или равно значение текущего объекта <see cref="T:System.DateTimeOffset" /> значению параметра <paramref name="obj" />. Возвращаемые значения метода интерпретируются следующим образом: 
		///   Возвращаемое значение 
		///   Описание 
		///   Меньше нуля 
		///   Текущий объект <see cref="T:System.DateTimeOffset" /> меньше параметра <paramref name="obj" /> (заданный в нем момент времени наступает раньше).  
		///   Нуль 
		///   Текущий объект <see cref="T:System.DateTimeOffset" /> равен параметру <paramref name="obj" /> (соответствует тому же моменту времени).  
		///   Больше нуля 
		///   Текущий объект <see cref="T:System.DateTimeOffset" /> больше параметра <paramref name="obj" /> (заданный в нем момент времени наступает позже).</returns>
		// Token: 0x06000A52 RID: 2642 RVA: 0x000276D4 File Offset: 0x000258D4
		int IComparable.CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is DateTimeOffset))
			{
				throw new ArgumentException("Object must be of type DateTimeOffset.");
			}
			DateTime utcDateTime = ((DateTimeOffset)obj).UtcDateTime;
			DateTime utcDateTime2 = this.UtcDateTime;
			if (utcDateTime2 > utcDateTime)
			{
				return 1;
			}
			if (utcDateTime2 < utcDateTime)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.DateTimeOffset" /> с заданным объектом <see cref="T:System.DateTimeOffset" /> и указывает, когда наступает момент, заданный в первом объекте: раньше, позже или одновременно с моментом, указанным во втором объекте <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="other">Объект, сравниваемый с текущим объектом <see cref="T:System.DateTimeOffset" />.</param>
		/// <returns>Целое число со знаком, позволяющее определить, как соотносятся между собой текущий объект <see cref="T:System.DateTimeOffset" /> и параметр <paramref name="other" />. Возможные соотношения показаны в следующей таблице.  
		///   Возвращаемое значение 
		///   Описание 
		///   Меньше нуля 
		///   Момент времени в объекте <see cref="T:System.DateTimeOffset" /> наступает раньше момента времени в параметре <paramref name="other" />.  
		///
		///   Нуль 
		///   Моменты времени в текущем объекте <see cref="T:System.DateTimeOffset" /> и параметре <paramref name="other" /> совпадают.  
		///
		///   Больше нуля.  
		///
		///   Момент времени в текущем объекте <see cref="T:System.DateTimeOffset" /> наступает позже момента времени в параметре <paramref name="other" />.</returns>
		// Token: 0x06000A53 RID: 2643 RVA: 0x00027728 File Offset: 0x00025928
		public int CompareTo(DateTimeOffset other)
		{
			DateTime utcDateTime = other.UtcDateTime;
			DateTime utcDateTime2 = this.UtcDateTime;
			if (utcDateTime2 > utcDateTime)
			{
				return 1;
			}
			if (utcDateTime2 < utcDateTime)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Определяет, представляет ли объект <see cref="T:System.DateTimeOffset" /> тот же момент времени, что и заданный объект.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом <see cref="T:System.DateTimeOffset" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является объектом <see cref="T:System.DateTimeOffset" /> и представляет тот же момент времени, что и текущий объект <see cref="T:System.DateTimeOffset" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A54 RID: 2644 RVA: 0x0002775C File Offset: 0x0002595C
		public override bool Equals(object obj)
		{
			return obj is DateTimeOffset && this.UtcDateTime.Equals(((DateTimeOffset)obj).UtcDateTime);
		}

		/// <summary>Определяет, представляет ли текущий объект <see cref="T:System.DateTimeOffset" /> тот же момент времени, что и заданный объект <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="other">Объект, который требуется сравнить с текущим объектом <see cref="T:System.DateTimeOffset" />.</param>
		/// <returns>Значение <see langword="true" />, если объекты <see cref="T:System.DateTimeOffset" /> имеют одинаковые значения <see cref="P:System.DateTimeOffset.UtcDateTime" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A55 RID: 2645 RVA: 0x00027790 File Offset: 0x00025990
		public bool Equals(DateTimeOffset other)
		{
			return this.UtcDateTime.Equals(other.UtcDateTime);
		}

		/// <summary>Определяет, представляет ли текущий объект <see cref="T:System.DateTimeOffset" /> тот же момент времени, что и заданный объект <see cref="T:System.DateTimeOffset" /> и совпадают ли их смещения.</summary>
		/// <param name="other">Объект, который требуется сравнить с текущим объектом <see cref="T:System.DateTimeOffset" />.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.DateTimeOffset" /> и параметр <paramref name="other" /> имеет одинаковые дату, время и значения <see cref="P:System.DateTimeOffset.Offset" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A56 RID: 2646 RVA: 0x000277B4 File Offset: 0x000259B4
		public bool EqualsExact(DateTimeOffset other)
		{
			return this.ClockDateTime == other.ClockDateTime && this.Offset == other.Offset && this.ClockDateTime.Kind == other.ClockDateTime.Kind;
		}

		/// <summary>Определяет, представляют ли два заданных объекта <see cref="T:System.DateTimeOffset" /> один и тот же момент времени.</summary>
		/// <param name="first">Первый из сравниваемых объектов.</param>
		/// <param name="second">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если два объекта <see cref="T:System.DateTimeOffset" /> имеют одинаковые значения <see cref="P:System.DateTimeOffset.UtcDateTime" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A57 RID: 2647 RVA: 0x0002780A File Offset: 0x00025A0A
		public static bool Equals(DateTimeOffset first, DateTimeOffset second)
		{
			return DateTime.Equals(first.UtcDateTime, second.UtcDateTime);
		}

		/// <summary>Преобразует заданное время файла Windows в его эквивалент по местному времени.</summary>
		/// <param name="fileTime">Время файла Windows, выраженное в тактах.</param>
		/// <returns>Объект, представляющий дату и время <paramref name="fileTime" /> со смещением, равным смещению местного времени.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="filetime" /> меньше нуля.  
		/// -или- 
		///  Значение <paramref name="filetime" /> больше значения <see langword="DateTimeOffset.MaxValue.Ticks" />.</exception>
		// Token: 0x06000A58 RID: 2648 RVA: 0x0002781F File Offset: 0x00025A1F
		public static DateTimeOffset FromFileTime(long fileTime)
		{
			return new DateTimeOffset(DateTime.FromFileTime(fileTime));
		}

		/// <summary>Преобразует время в формате Unix, выраженное как количество секунд, истекших с 1970-01-01T00:00:00Z, в значение <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="seconds">Время Unix, выраженное как количество секунд, истекших с 1970-01-01T00:00:00Z (1 января 1970 года, 00:00 UTC). Для времени Unix до этой даты значение отрицательное.</param>
		/// <returns>Значение даты и времени, представляющее тот же момент, что и время в формате Unix.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="seconds" /> меньше –62 135 596 800.  
		/// -или- 
		///  Значение <paramref name="seconds" /> больше 253 402 300 799.</exception>
		// Token: 0x06000A59 RID: 2649 RVA: 0x0002782C File Offset: 0x00025A2C
		public static DateTimeOffset FromUnixTimeSeconds(long seconds)
		{
			if (seconds < -62135596800L || seconds > 253402300799L)
			{
				throw new ArgumentOutOfRangeException("seconds", SR.Format("Valid values are between {0} and {1}, inclusive.", -62135596800L, 253402300799L));
			}
			return new DateTimeOffset(seconds * 10000000L + 621355968000000000L, TimeSpan.Zero);
		}

		/// <summary>Преобразует время в формате Unix, выраженное как количество миллисекунд, истекших с 1970-01-01T00:00:00Z, в значение <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="milliseconds">Время Unix, выраженное как количество миллисекунд, истекших с 1970-01-01T00:00:00Z (1 января 1970 года, 00:00 UTC). Для времени Unix до этой даты значение отрицательное.</param>
		/// <returns>Значение даты и времени, представляющее тот же момент, что и время в формате Unix.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="milliseconds" /> меньше –62 135 596 800 000.  
		/// -или- 
		///  Значение <paramref name="milliseconds" /> больше 253 402 300 799 999.</exception>
		// Token: 0x06000A5A RID: 2650 RVA: 0x000278A0 File Offset: 0x00025AA0
		public static DateTimeOffset FromUnixTimeMilliseconds(long milliseconds)
		{
			if (milliseconds < -62135596800000L || milliseconds > 253402300799999L)
			{
				throw new ArgumentOutOfRangeException("milliseconds", SR.Format("Valid values are between {0} and {1}, inclusive.", -62135596800000L, 253402300799999L));
			}
			return new DateTimeOffset(milliseconds * 10000L + 621355968000000000L, TimeSpan.Zero);
		}

		/// <summary>Выполняется после завершения десериализации объекта.</summary>
		/// <param name="sender">Объект, который инициализирует обратный вызов. Данная функциональная возможность для этого параметра в настоящее время не реализуется.</param>
		// Token: 0x06000A5B RID: 2651 RVA: 0x00027914 File Offset: 0x00025B14
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				DateTimeOffset.ValidateOffset(this.Offset);
				DateTimeOffset.ValidateDate(this.ClockDateTime, this.Offset);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException("An error occurred while deserializing the object.  The serialized data is corrupt.", innerException);
			}
		}

		/// <summary>Передает объекту <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данные, необходимые для сериализации текущего объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="info">Объект, который требуется заполнить данными.</param>
		/// <param name="context">Конечный объект для этой сериализации (см. раздел, посвященный <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000A5C RID: 2652 RVA: 0x00027960 File Offset: 0x00025B60
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("DateTime", this._dateTime);
			info.AddValue("OffsetMinutes", this._offsetMinutes);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00027994 File Offset: 0x00025B94
		private DateTimeOffset(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this._dateTime = (DateTime)info.GetValue("DateTime", typeof(DateTime));
			this._offsetMinutes = (short)info.GetValue("OffsetMinutes", typeof(short));
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000A5E RID: 2654 RVA: 0x000279F0 File Offset: 0x00025BF0
		public override int GetHashCode()
		{
			return this.UtcDateTime.GetHashCode();
		}

		/// <summary>Преобразует заданное строковое представление даты, времени и смещения в его эквивалент <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <returns>Объект, эквивалентный дате и времени, содержащимся в параметре <paramref name="input" />.</returns>
		/// <exception cref="T:System.ArgumentException">Смещение больше 14 часов или меньше –14 часов.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не содержит допустимое строковое представление даты и времени.  
		/// -или- 
		///  <paramref name="input" /> содержит строковое представление смещения без даты или времени.</exception>
		// Token: 0x06000A5F RID: 2655 RVA: 0x00027A0C File Offset: 0x00025C0C
		public static DateTimeOffset Parse(string input)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out offset).Ticks, offset);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" />, используя указанные сведения о форматировании, связанные с языком и региональными параметрами.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании значения <paramref name="input" />, связанные с языком и региональными параметрами.</param>
		/// <returns>Объект, эквивалентный дате и времени, содержащимся в параметре <paramref name="input" />, в соответствии со значением параметра <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentException">Смещение больше 14 часов или меньше –14 часов.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не содержит допустимое строковое представление даты и времени.  
		/// -или- 
		///  <paramref name="input" /> содержит строковое представление смещения без даты или времени.</exception>
		// Token: 0x06000A60 RID: 2656 RVA: 0x00027A44 File Offset: 0x00025C44
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return DateTimeOffset.Parse(input, formatProvider, DateTimeStyles.None);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" />, используя указанную информацию о форматировании, связанную с языком и региональными параметрами, а также заданный стиль форматирования.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании значения <paramref name="input" />, связанные с языком и региональными параметрами.</param>
		/// <param name="styles">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="input" />. Обычно указывается значение <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <returns>Объект, эквивалентный дате и времени, содержащимся в параметре <paramref name="input" />, в соответствии со значениями параметров <paramref name="formatProvider" /> и <paramref name="styles" />.</returns>
		/// <exception cref="T:System.ArgumentException">Смещение больше 14 часов или меньше –14 часов.  
		/// -или- 
		///  <paramref name="styles" /> не является допустимым значением <see cref="T:System.Globalization.DateTimeStyles" />.  
		/// -или- 
		///  <paramref name="styles" /> содержит неподдерживаемое значение <see cref="T:System.Globalization.DateTimeStyles" />.  
		/// -или- 
		///  Параметр <paramref name="styles" /> содержит значения <see cref="T:System.Globalization.DateTimeStyles" />, которые нельзя использовать вместе.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не содержит допустимое строковое представление даты и времени.  
		/// -или- 
		///  <paramref name="input" /> содержит строковое представление смещения без даты или времени.</exception>
		// Token: 0x06000A61 RID: 2657 RVA: 0x00027A58 File Offset: 0x00025C58
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00027AA0 File Offset: 0x00025CA0
		public static DateTimeOffset Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" />, используя указанные сведения о форматировании, связанные с языком и региональными параметрами. Формат строкового представления должен полностью соответствовать заданному формату.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="format">Описатель формата, задающий ожидаемый формат <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, который предоставляет сведения о форматировании параметра <paramref name="input" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>Объект, эквивалентный дате и времени, содержащимся в параметре <paramref name="input" />, в соответствии со значениями параметров <paramref name="format" /> и <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentException">Смещение больше 14 часов или меньше –14 часов.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="format" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="input" /> является пустой строкой ("").  
		/// -или- 
		///  <paramref name="input" /> не содержит допустимое строковое представление даты и времени.  
		/// -или- 
		///  Параметр <paramref name="format" /> равен пустой строке.  
		/// -или- 
		/// Компонент часов и обозначение AM/PM в <paramref name="input" /> не соответствуют друг другу.</exception>
		// Token: 0x06000A63 RID: 2659 RVA: 0x00027AD7 File Offset: 0x00025CD7
		public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return DateTimeOffset.ParseExact(input, format, formatProvider, DateTimeStyles.None);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" />, используя заданный формат, указанные сведения о форматировании, связанные с языком и региональными параметрами, а также стиль. Формат строкового представления должен полностью соответствовать заданному формату.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="format">Описатель формата, задающий ожидаемый формат <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, который предоставляет сведения о форматировании параметра <paramref name="input" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="styles">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="input" />.</param>
		/// <returns>Объект, эквивалентный дате и времени, содержащимся в параметре <paramref name="input" />, в соответствии со значениями параметров <paramref name="format" />, <paramref name="formatProvider" /> и <paramref name="styles" />.</returns>
		/// <exception cref="T:System.ArgumentException">Смещение больше 14 часов или меньше –14 часов.  
		/// -или- 
		/// Параметр <paramref name="styles" /> содержит неподдерживаемое значение.  
		/// -или- 
		/// Параметр <paramref name="styles" /> содержит значения <see cref="T:System.Globalization.DateTimeStyles" />, которые нельзя использовать вместе.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="format" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="input" /> является пустой строкой ("").  
		/// -или- 
		///  <paramref name="input" /> не содержит допустимое строковое представление даты и времени.  
		/// -или- 
		///  Параметр <paramref name="format" /> равен пустой строке.  
		/// -или- 
		/// Компонент часов и обозначение AM/PM в <paramref name="input" /> не соответствуют друг другу.</exception>
		// Token: 0x06000A64 RID: 2660 RVA: 0x00027AF8 File Offset: 0x00025CF8
		public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00027B50 File Offset: 0x00025D50
		public static DateTimeOffset ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, DateTimeStyles styles = DateTimeStyles.None)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" />, используя заданные форматы, сведения о форматировании, связанные с языком и региональными параметрами, а также стиль. Формат строкового представления должен полностью соответствовать одному из заданных форматов.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="formats">Массив спецификаторов формата, в котором заданы требуемые форматы <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, который предоставляет сведения о форматировании параметра <paramref name="input" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="styles">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="input" />.</param>
		/// <returns>Объект, эквивалентный дате и времени, содержащимся в параметре <paramref name="input" />, в соответствии со значениями параметров <paramref name="formats" />, <paramref name="formatProvider" /> и <paramref name="styles" />.</returns>
		/// <exception cref="T:System.ArgumentException">Смещение больше 14 часов или меньше –14 часов.  
		/// -или- 
		///  <paramref name="styles" /> содержит неподдерживаемое значение.  
		/// -или- 
		/// Параметр <paramref name="styles" /> содержит значения <see cref="T:System.Globalization.DateTimeStyles" />, которые нельзя использовать вместе.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="input" /> является пустой строкой ("").  
		/// -или- 
		///  <paramref name="input" /> не содержит допустимое строковое представление даты и времени.  
		/// -или- 
		/// В <paramref name="formats" /> нет элементов, содержащих допустимые спецификаторы формата.  
		/// -или- 
		/// Компонент часов и обозначение AM/PM в <paramref name="input" /> не соответствуют друг другу.</exception>
		// Token: 0x06000A66 RID: 2662 RVA: 0x00027B88 File Offset: 0x00025D88
		public static DateTimeOffset ParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00027BD0 File Offset: 0x00025DD0
		public static DateTimeOffset ParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles = DateTimeStyles.None)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		/// <summary>Вычитает значение <see cref="T:System.DateTimeOffset" />, представляющее определенную дату и время, из текущего объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="value">Объект, представляющий вычитаемое значение.</param>
		/// <returns>Объект, задающий интервал между двумя объектами <see cref="T:System.DateTimeOffset" />.</returns>
		// Token: 0x06000A68 RID: 2664 RVA: 0x00027C08 File Offset: 0x00025E08
		public TimeSpan Subtract(DateTimeOffset value)
		{
			return this.UtcDateTime.Subtract(value.UtcDateTime);
		}

		/// <summary>Вычитает указанный интервал времени из текущего объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="value">Вычитаемый интервал времени.</param>
		/// <returns>Объект, значение которого равно дате и времени, представленным текущим объектом <see cref="T:System.DateTimeOffset" />, за вычетом интервала времени, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A69 RID: 2665 RVA: 0x00027C2C File Offset: 0x00025E2C
		public DateTimeOffset Subtract(TimeSpan value)
		{
			return new DateTimeOffset(this.ClockDateTime.Subtract(value), this.Offset);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTimeOffset" /> во временную характеристику файла Windows.</summary>
		/// <returns>Значение текущего объекта <see cref="T:System.DateTimeOffset" /> представленное в виде временной характеристики файла Windows.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Результирующая временная характеристика будет представлять дату и время до полуночи 1 января, 1601 от Р. Х. в формате UTC.</exception>
		// Token: 0x06000A6A RID: 2666 RVA: 0x00027C54 File Offset: 0x00025E54
		public long ToFileTime()
		{
			return this.UtcDateTime.ToFileTime();
		}

		/// <summary>Возвращает количество секунд, истекших с 1970-01-01T00:00:00Z.</summary>
		/// <returns>Количество секунд, истекших с 1970-01-01T00:00:00Z.</returns>
		// Token: 0x06000A6B RID: 2667 RVA: 0x00027C70 File Offset: 0x00025E70
		public long ToUnixTimeSeconds()
		{
			return this.UtcDateTime.Ticks / 10000000L - 62135596800L;
		}

		/// <summary>Возвращает количество миллисекунд, истекших с 1970-01-01T00:00:00.000Z.</summary>
		/// <returns>Количество миллисекунд, истекших с 1970-01-01T00:00:00.000Z.</returns>
		// Token: 0x06000A6C RID: 2668 RVA: 0x00027C9C File Offset: 0x00025E9C
		public long ToUnixTimeMilliseconds()
		{
			return this.UtcDateTime.Ticks / 10000L - 62135596800000L;
		}

		/// <summary>Преобразует текущий объект <see cref="T:System.DateTimeOffset" /> в объект <see cref="T:System.DateTimeOffset" />, представляющий местное время.</summary>
		/// <returns>Объект, который представляет дату и время текущего объекта <see cref="T:System.DateTimeOffset" />, преобразованные в местное время.</returns>
		// Token: 0x06000A6D RID: 2669 RVA: 0x00027CC8 File Offset: 0x00025EC8
		public DateTimeOffset ToLocalTime()
		{
			return this.ToLocalTime(false);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00027CD4 File Offset: 0x00025ED4
		internal DateTimeOffset ToLocalTime(bool throwOnOverflow)
		{
			return new DateTimeOffset(this.UtcDateTime.ToLocalTime(throwOnOverflow));
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTimeOffset" /> в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление объекта <see cref="T:System.DateTimeOffset" />, которое включает смещение, добавленное в конце строки.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время находятся за пределами диапазона дат, поддерживаемого календарем, принятым для текущего языка и региональных параметров.</exception>
		// Token: 0x06000A6F RID: 2671 RVA: 0x00027CF5 File Offset: 0x00025EF5
		public override string ToString()
		{
			return DateTimeFormat.Format(this.ClockDateTime, null, null, this.Offset);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTimeOffset" /> в эквивалентное ему строковое представление с использованием заданного формата.</summary>
		/// <param name="format">Строка формата.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.DateTimeOffset" />, заданное параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">Длина <paramref name="format" /> равна 1, и он не является одним из стандартных символов описателя формата, определенных для <see cref="T:System.Globalization.DateTimeFormatInfo" />.  
		/// -или- 
		///  <paramref name="format" /> не содержит допустимого шаблона пользовательского формата.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время находятся за пределами диапазона дат, поддерживаемого календарем, принятым для текущего языка и региональных параметров.</exception>
		// Token: 0x06000A70 RID: 2672 RVA: 0x00027D0A File Offset: 0x00025F0A
		public string ToString(string format)
		{
			return DateTimeFormat.Format(this.ClockDateTime, format, null, this.Offset);
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.DateTimeOffset" /> в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.DateTimeOffset" />, заданное параметром <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время находятся за пределами диапазона дат, поддерживаемого календарем, который используется у <paramref name="formatProvider" />.</exception>
		// Token: 0x06000A71 RID: 2673 RVA: 0x00027D1F File Offset: 0x00025F1F
		public string ToString(IFormatProvider formatProvider)
		{
			return DateTimeFormat.Format(this.ClockDateTime, null, formatProvider, this.Offset);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTimeOffset" /> в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях формата для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка формата.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.DateTimeOffset" />, заданное параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">Длина <paramref name="format" /> равна 1, и он не является одним из стандартных символов описателя формата, определенных для <see cref="T:System.Globalization.DateTimeFormatInfo" />.  
		/// -или- 
		///  <paramref name="format" /> не содержит допустимого шаблона пользовательского формата.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время находятся за пределами диапазона дат, поддерживаемого календарем, который используется у <paramref name="formatProvider" />.</exception>
		// Token: 0x06000A72 RID: 2674 RVA: 0x00027D34 File Offset: 0x00025F34
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return DateTimeFormat.Format(this.ClockDateTime, format, formatProvider, this.Offset);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00027D49 File Offset: 0x00025F49
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider formatProvider = null)
		{
			return DateTimeFormat.TryFormat(this.ClockDateTime, destination, out charsWritten, format, formatProvider, this.Offset);
		}

		/// <summary>Преобразует текущий объект <see cref="T:System.DateTimeOffset" /> в значение <see cref="T:System.DateTimeOffset" />, представляющее время в формате UTC.</summary>
		/// <returns>Объект, представляющий дату и время текущего объекта <see cref="T:System.DateTimeOffset" />, преобразованную во время в формате UTC.</returns>
		// Token: 0x06000A74 RID: 2676 RVA: 0x00027D61 File Offset: 0x00025F61
		public DateTimeOffset ToUniversalTime()
		{
			return new DateTimeOffset(this.UtcDateTime);
		}

		/// <summary>Предпринимает попытку преобразования указанного строкового представления даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" /> и возвращает значение, позволяющее определить успешность преобразования.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="result">После возврата из этого метода содержит эквивалент <see cref="T:System.DateTimeOffset" /> для даты и времени, заданных в параметре <paramref name="input" />, если преобразование прошло успешно, или значение <see cref="F:System.DateTimeOffset.MinValue" />, если преобразование завершилось неудачей. Преобразование завершается неудачей, если значение параметра <paramref name="input" /> равно <see langword="null" /> или в нем не содержится допустимое строковое представление даты и времени. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A75 RID: 2677 RVA: 0x00027D70 File Offset: 0x00025F70
		public static bool TryParse(string input, out DateTimeOffset result)
		{
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00027DA8 File Offset: 0x00025FA8
		public static bool TryParse(ReadOnlySpan<char> input, out DateTimeOffset result)
		{
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		/// <summary>Предпринимает попытку преобразования указанного строкового представления даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" /> и возвращает значение, позволяющее определить успешность преобразования.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании параметра <paramref name="input" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="styles">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="input" />.</param>
		/// <param name="result">После возврата из этого метода содержит значение <see cref="T:System.DateTimeOffset" />, эквивалентное дате и времени, заданным в параметре <paramref name="input" />, если преобразование прошло успешно, или значение <see cref="F:System.DateTimeOffset.MinValue" />, если преобразование завершилось неудачей. Преобразование завершается неудачей, если значение параметра <paramref name="input" /> равно <see langword="null" /> или в нем не содержится допустимое строковое представление даты и времени. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="styles" /> включает неопределенное значение <see cref="T:System.Globalization.DateTimeStyles" />.  
		/// -или- 
		///  Тип <see cref="F:System.Globalization.DateTimeStyles.NoCurrentDateDefault" /> не поддерживается.  
		/// -или- 
		///  Параметр <paramref name="styles" /> содержит взаимоисключающие значения <see cref="T:System.Globalization.DateTimeStyles" />.</exception>
		// Token: 0x06000A77 RID: 2679 RVA: 0x00027DD8 File Offset: 0x00025FD8
		public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				result = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00027E28 File Offset: 0x00026028
		public static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" />, используя заданный формат, указанные сведения о форматировании, связанные с языком и региональными параметрами, а также стиль. Формат строкового представления должен полностью соответствовать заданному формату.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="format">Описатель формата, задающий требуемый формат <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, который предоставляет сведения о форматировании параметра <paramref name="input" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="styles">Побитовое сочетание значений перечисления, которое показывает разрешенный формат ввода. Обычно указывается значение <see langword="None" />.</param>
		/// <param name="result">После возврата из этого метода содержит эквивалент <see cref="T:System.DateTimeOffset" /> для даты и времени, заданных в параметре <paramref name="input" />, если преобразование прошло успешно, или значение <see cref="F:System.DateTimeOffset.MinValue" />, если преобразование завершилось неудачей. Преобразование завершается неудачно, если параметр <paramref name="input" /> имеет значение <see langword="null" /> или не содержит допустимое строчное представление даты и времени в требуемом формате, заданном параметрами <paramref name="format" /> и provider. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="styles" /> включает неопределенное значение <see cref="T:System.Globalization.DateTimeStyles" />.  
		/// -или- 
		///  Тип <see cref="F:System.Globalization.DateTimeStyles.NoCurrentDateDefault" /> не поддерживается.  
		/// -или- 
		///  Параметр <paramref name="styles" /> содержит взаимоисключающие значения <see cref="T:System.Globalization.DateTimeStyles" />.</exception>
		// Token: 0x06000A79 RID: 2681 RVA: 0x00027E68 File Offset: 0x00026068
		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null || format == null)
			{
				result = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00027EC4 File Offset: 0x000260C4
		public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTimeOffset" />, используя заданный массив форматов, указанные сведения о форматировании, связанные с языком и региональными параметрами, и стиль форматирования. Формат строкового представления должен полностью соответствовать одному из заданных форматов.</summary>
		/// <param name="input">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="formats">Массив, в котором задаются ожидаемые форматы <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, который предоставляет сведения о форматировании параметра <paramref name="input" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="styles">Побитовое сочетание значений перечисления, которое показывает разрешенный формат ввода. Обычно указывается значение <see langword="None" />.</param>
		/// <param name="result">После возврата из этого метода содержит эквивалент <see cref="T:System.DateTimeOffset" /> для даты и времени, заданных в параметре <paramref name="input" />, если преобразование прошло успешно, или значение <see cref="F:System.DateTimeOffset.MinValue" />, если преобразование завершилось неудачей. Преобразование завершается неудачно, если параметр <paramref name="format" /> не содержит допустимое строчное представление даты и времени или же даты и времени в требуемом формате, заданном параметром <paramref name="formats" />, или если параметр <see langword="null" /> имеет значение <paramref name="input" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="styles" /> включает неопределенное значение <see cref="T:System.Globalization.DateTimeStyles" />.  
		/// -или- 
		///  Тип <see cref="F:System.Globalization.DateTimeStyles.NoCurrentDateDefault" /> не поддерживается.  
		/// -или- 
		///  Параметр <paramref name="styles" /> содержит взаимоисключающие значения <see cref="T:System.Globalization.DateTimeStyles" />.</exception>
		// Token: 0x06000A7B RID: 2683 RVA: 0x00027F04 File Offset: 0x00026104
		public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				result = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00027F58 File Offset: 0x00026158
		public static bool TryParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00027F98 File Offset: 0x00026198
		private static short ValidateOffset(TimeSpan offset)
		{
			long ticks = offset.Ticks;
			if (ticks % 600000000L != 0L)
			{
				throw new ArgumentException("Offset must be specified in whole minutes.", "offset");
			}
			if (ticks < -504000000000L || ticks > 504000000000L)
			{
				throw new ArgumentOutOfRangeException("offset", "Offset must be within plus or minus 14 hours.");
			}
			return (short)(offset.Ticks / 600000000L);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00028000 File Offset: 0x00026200
		private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
		{
			long num = dateTime.Ticks - offset.Ticks;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("offset", "The UTC time represented when the offset is applied must be between year 0 and 10,000.");
			}
			return new DateTime(num, DateTimeKind.Unspecified);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00028048 File Offset: 0x00026248
		private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) != DateTimeStyles.None)
			{
				throw new ArgumentException("An undefined DateTimeStyles value is being used.", parameterName);
			}
			if ((style & DateTimeStyles.AssumeLocal) != DateTimeStyles.None && (style & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
			{
				throw new ArgumentException("The DateTimeStyles values AssumeLocal and AssumeUniversal cannot be used together.", parameterName);
			}
			if ((style & DateTimeStyles.NoCurrentDateDefault) != DateTimeStyles.None)
			{
				throw new ArgumentException("The DateTimeStyles value 'NoCurrentDateDefault' is not allowed when parsing DateTimeOffset.", parameterName);
			}
			style &= ~DateTimeStyles.RoundtripKind;
			style &= ~DateTimeStyles.AssumeLocal;
			return style;
		}

		/// <summary>Определяется неявное преобразование объекта <see cref="T:System.DateTime" /> в объект <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="dateTime">Преобразуемый объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время в формате UTC, которые получаются в результате применения смещения, более раннего чем <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Дата и время в формате UTC, которые получаются в результате применения смещения, более позднего чем <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A80 RID: 2688 RVA: 0x000280A3 File Offset: 0x000262A3
		public static implicit operator DateTimeOffset(DateTime dateTime)
		{
			return new DateTimeOffset(dateTime);
		}

		/// <summary>Добавляет указанный интервал времени в объект <see cref="T:System.DateTimeOffset" />, имеющий заданную дату и время, и образует объект <see cref="T:System.DateTimeOffset" /> с новыми значениями даты и времени.</summary>
		/// <param name="dateTimeOffset">Объект, к которому необходимо добавить интервал времени.</param>
		/// <param name="timeSpan">Добавляемый интервал времени.</param>
		/// <returns>Объект, значение которого является суммой значений <paramref name="dateTimeTz" /> и <paramref name="timeSpan" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" />.  
		/// -или- 
		/// Итоговое значение <see cref="T:System.DateTimeOffset" /> больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A81 RID: 2689 RVA: 0x000280AB File Offset: 0x000262AB
		public static DateTimeOffset operator +(DateTimeOffset dateTimeOffset, TimeSpan timeSpan)
		{
			return new DateTimeOffset(dateTimeOffset.ClockDateTime + timeSpan, dateTimeOffset.Offset);
		}

		/// <summary>Вычитает заданный временной интервал из указанной даты и времени и выдает новую дату и время.</summary>
		/// <param name="dateTimeOffset">Объект даты и времени, из которого вычитается интервал.</param>
		/// <param name="timeSpan">Вычитаемый интервал времени.</param>
		/// <returns>Объект, равный значению <paramref name="dateTimeOffset" /> за вычетом значения <paramref name="timeSpan" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTimeOffset" /> меньше <see cref="F:System.DateTimeOffset.MinValue" /> или больше <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000A82 RID: 2690 RVA: 0x000280C6 File Offset: 0x000262C6
		public static DateTimeOffset operator -(DateTimeOffset dateTimeOffset, TimeSpan timeSpan)
		{
			return new DateTimeOffset(dateTimeOffset.ClockDateTime - timeSpan, dateTimeOffset.Offset);
		}

		/// <summary>Вычитает объект <see cref="T:System.DateTimeOffset" /> из другого объекта и выдает интервал времени.</summary>
		/// <param name="left">Уменьшаемое.</param>
		/// <param name="right">Вычитаемое.</param>
		/// <returns>Объект, представляющий разность между <paramref name="left" /> и <paramref name="right" />.</returns>
		// Token: 0x06000A83 RID: 2691 RVA: 0x000280E1 File Offset: 0x000262E1
		public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime - right.UtcDateTime;
		}

		/// <summary>Определяет, представляют ли два заданных объекта <see cref="T:System.DateTimeOffset" /> один и тот же момент времени.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если объекты <see cref="T:System.DateTimeOffset" /> имеют одинаковые значения <see cref="P:System.DateTimeOffset.UtcDateTime" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A84 RID: 2692 RVA: 0x000280F6 File Offset: 0x000262F6
		public static bool operator ==(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime == right.UtcDateTime;
		}

		/// <summary>Определяет, указывают ли два заданных объекта <see cref="T:System.DateTimeOffset" /> на разные моменты времени.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" /> если параметры <paramref name="left" /> и <paramref name="right" /> обладают разными значениями свойства <see cref="P:System.DateTimeOffset.UtcDateTime" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A85 RID: 2693 RVA: 0x0002810B File Offset: 0x0002630B
		public static bool operator !=(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime != right.UtcDateTime;
		}

		/// <summary>Определяет, меньше ли значение одного указанного объекта <see cref="T:System.DateTimeOffset" />, чем значение другого указанного объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" /> если момент времени в значении <see cref="P:System.DateTimeOffset.UtcDateTime" /> параметра <paramref name="left" /> наступает раньше, чем момент в значении <see cref="P:System.DateTimeOffset.UtcDateTime" /> параметра <paramref name="right" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A86 RID: 2694 RVA: 0x00028120 File Offset: 0x00026320
		public static bool operator <(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime < right.UtcDateTime;
		}

		/// <summary>Определяет, меньше ли значение одного указанного объекта <see cref="T:System.DateTimeOffset" />, чем значение другого указанного объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" /> если момент времени в значении <see cref="P:System.DateTimeOffset.UtcDateTime" /> параметра <paramref name="left" /> наступает раньше, чем момент в значении <see cref="P:System.DateTimeOffset.UtcDateTime" /> параметра <paramref name="right" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A87 RID: 2695 RVA: 0x00028135 File Offset: 0x00026335
		public static bool operator <=(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime <= right.UtcDateTime;
		}

		/// <summary>Определяет, больше ли (или меньше) значение одного указанного объекта <see cref="T:System.DateTimeOffset" /> значения другого указанного объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" /> если момент времени в значении <see cref="P:System.DateTimeOffset.UtcDateTime" /> параметра <paramref name="left" /> наступает позже, чем момент в значении <see cref="P:System.DateTimeOffset.UtcDateTime" /> параметра <paramref name="right" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A88 RID: 2696 RVA: 0x0002814A File Offset: 0x0002634A
		public static bool operator >(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime > right.UtcDateTime;
		}

		/// <summary>Определяет, действительно ли значение одного указанного объекта <see cref="T:System.DateTimeOffset" /> больше или равно значению другого указанного объекта <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" /> если значение <see cref="P:System.DateTimeOffset.UtcDateTime" /> параметра <paramref name="left" /> соответствует тому же или более позднему моменту времени, чем момент, заданный значением <see cref="P:System.DateTimeOffset.UtcDateTime" /> параметра <paramref name="right" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A89 RID: 2697 RVA: 0x0002815F File Offset: 0x0002635F
		public static bool operator >=(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime >= right.UtcDateTime;
		}

		// Token: 0x040010C6 RID: 4294
		internal const long MaxOffset = 504000000000L;

		// Token: 0x040010C7 RID: 4295
		internal const long MinOffset = -504000000000L;

		// Token: 0x040010C8 RID: 4296
		private const long UnixEpochSeconds = 62135596800L;

		// Token: 0x040010C9 RID: 4297
		private const long UnixEpochMilliseconds = 62135596800000L;

		// Token: 0x040010CA RID: 4298
		internal const long UnixMinSeconds = -62135596800L;

		// Token: 0x040010CB RID: 4299
		internal const long UnixMaxSeconds = 253402300799L;

		/// <summary>Представляет наиболее раннее из возможных значений <see cref="T:System.DateTimeOffset" />. Это поле доступно только для чтения.</summary>
		// Token: 0x040010CC RID: 4300
		public static readonly DateTimeOffset MinValue = new DateTimeOffset(0L, TimeSpan.Zero);

		/// <summary>Представляет максимально допустимое значение типа <see cref="T:System.DateTimeOffset" />. Это поле доступно только для чтения.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <see cref="F:System.DateTime.MaxValue" /> находится вне диапазона текущего или заданного по умолчанию календаря культуры.</exception>
		// Token: 0x040010CD RID: 4301
		public static readonly DateTimeOffset MaxValue = new DateTimeOffset(3155378975999999999L, TimeSpan.Zero);

		// Token: 0x040010CE RID: 4302
		public static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(621355968000000000L, TimeSpan.Zero);

		// Token: 0x040010CF RID: 4303
		private readonly DateTime _dateTime;

		// Token: 0x040010D0 RID: 4304
		private readonly short _offsetMinutes;
	}
}
