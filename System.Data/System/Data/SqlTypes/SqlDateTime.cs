using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет сохраняемые в базе данных или извлекаемые из нее данные о дате и времени в диапазоне значений от 1 января 1753 г. до 31 декабря 9999 г. с точностью 3,33 миллисекунды. Базовая структура данных структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> отличается от соответствующего типа платформы .NET Framework, <see cref="T:System.DateTime" />, который может представлять любое время между 00:00:00 01.01.0001 и 23:59:59 31.12.9999 с точностью 100 наносекунд. В объекте <see cref="T:System.Data.SqlTypes.SqlDateTime" /> фактически хранится разница относительно 00:00:00 01.01.1900. Поэтому в результате преобразования "00:00:00 01.01.1900" в целое число будет возвращен 0.</summary>
	// Token: 0x0200030D RID: 781
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlDateTime : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06002344 RID: 9028 RVA: 0x000A1883 File Offset: 0x0009FA83
		private SqlDateTime(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_day = 0;
			this.m_time = 0;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> с использованием заданного значения <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Структура <see langword="DateTime" />.</param>
		// Token: 0x06002345 RID: 9029 RVA: 0x000A189A File Offset: 0x0009FA9A
		public SqlDateTime(DateTime value)
		{
			this = SqlDateTime.FromDateTime(value);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> с использованием предоставленных параметров для инициализации года, месяца, дня.</summary>
		/// <param name="year">Целое число, представляющее год в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="month">Целое число, представляющее месяц в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="day">Целое значение, представляющее номер дня в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		// Token: 0x06002346 RID: 9030 RVA: 0x000A18A8 File Offset: 0x0009FAA8
		public SqlDateTime(int year, int month, int day)
		{
			this = new SqlDateTime(year, month, day, 0, 0, 0, 0.0);
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> с помощью предоставленных параметров для инициализации года, месяца, дня, часа, минуты и секунды новой структуры.</summary>
		/// <param name="year">Целое число, представляющее год в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="month">Целое число, представляющее месяц в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="day">Целое число, представляющее день месяца в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="hour">Целое число, представляющее час в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="minute">Целое число, представляющее минуту в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="second">Целое число, представляющее секунду в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		// Token: 0x06002347 RID: 9031 RVA: 0x000A18BF File Offset: 0x0009FABF
		public SqlDateTime(int year, int month, int day, int hour, int minute, int second)
		{
			this = new SqlDateTime(year, month, day, hour, minute, second, 0.0);
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> с помощью предоставленных параметров для инициализации года, месяца, дня, часа, минуты, секунды и миллисекунды новой структуры.</summary>
		/// <param name="year">Целое число, представляющее год в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="month">Целое число, представляющее месяц в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="day">Целое число, представляющее день месяца в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="hour">Целое число, представляющее час в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="minute">Целое число, представляющее минуту в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="second">Целое число, представляющее секунду в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="millisecond">Значение типа double, представляющее миллисекунду в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		// Token: 0x06002348 RID: 9032 RVA: 0x000A18DC File Offset: 0x0009FADC
		public SqlDateTime(int year, int month, int day, int hour, int minute, int second, double millisecond)
		{
			if (year >= SqlDateTime.s_minYear && year <= SqlDateTime.s_maxYear && month >= 1 && month <= 12)
			{
				int[] array = SqlDateTime.IsLeapYear(year) ? SqlDateTime.s_daysToMonth366 : SqlDateTime.s_daysToMonth365;
				if (day >= 1 && day <= array[month] - array[month - 1])
				{
					int num = year - 1;
					int num2 = num * 365 + num / 4 - num / 100 + num / 400 + array[month - 1] + day - 1;
					num2 -= SqlDateTime.s_dayBase;
					if (num2 >= SqlDateTime.s_minDay && num2 <= SqlDateTime.s_maxDay && hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60 && millisecond >= 0.0 && millisecond < 1000.0)
					{
						double num3 = millisecond * SqlDateTime.s_SQLTicksPerMillisecond + 0.5;
						int num4 = hour * SqlDateTime.SQLTicksPerHour + minute * SqlDateTime.SQLTicksPerMinute + second * SqlDateTime.SQLTicksPerSecond + (int)num3;
						if (num4 > SqlDateTime.s_maxTime)
						{
							num4 = 0;
							num2++;
						}
						this = new SqlDateTime(num2, num4);
						return;
					}
				}
			}
			throw new SqlTypeException(SQLResource.InvalidDateTimeMessage);
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> с помощью предоставленных параметров для инициализации года, месяца, дня, часа, минуты, секунды и микросекунды новой структуры.</summary>
		/// <param name="year">Целое число, представляющее год в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="month">Целое число, представляющее месяц в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="day">Целое значение, представляющее день в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="hour">Целое число, представляющее час в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="minute">Целое число, представляющее минуту в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="second">Целое число, представляющее секунду в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="bilisecond">Целое число, представляющее микросекунду (одну тысячную миллисекунды) в новой структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		// Token: 0x06002349 RID: 9033 RVA: 0x000A1A1C File Offset: 0x0009FC1C
		public SqlDateTime(int year, int month, int day, int hour, int minute, int second, int bilisecond)
		{
			this = new SqlDateTime(year, month, day, hour, minute, second, (double)bilisecond / 1000.0);
		}

		/// <summary>Выполняет инициализацию нового экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> с использованием предоставленных параметров.</summary>
		/// <param name="dayTicks">Целое значение, представляющее дату как число импульсов.</param>
		/// <param name="timeTicks">Целое значение, представляющее время как число импульсов.</param>
		// Token: 0x0600234A RID: 9034 RVA: 0x000A1A48 File Offset: 0x0009FC48
		public SqlDateTime(int dayTicks, int timeTicks)
		{
			if (dayTicks < SqlDateTime.s_minDay || dayTicks > SqlDateTime.s_maxDay || timeTicks < SqlDateTime.s_minTime || timeTicks > SqlDateTime.s_maxTime)
			{
				this.m_fNotNull = false;
				throw new OverflowException(SQLResource.DateTimeOverflowMessage);
			}
			this.m_day = dayTicks;
			this.m_time = timeTicks;
			this.m_fNotNull = true;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x000A1A9C File Offset: 0x0009FC9C
		internal SqlDateTime(double dblVal)
		{
			if (dblVal < (double)SqlDateTime.s_minDay || dblVal >= (double)(SqlDateTime.s_maxDay + 1))
			{
				throw new OverflowException(SQLResource.DateTimeOverflowMessage);
			}
			int num = (int)dblVal;
			int num2 = (int)((dblVal - (double)num) * (double)SqlDateTime.s_SQLTicksPerDay);
			if (num2 < 0)
			{
				num--;
				num2 += SqlDateTime.s_SQLTicksPerDay;
			}
			else if (num2 >= SqlDateTime.s_SQLTicksPerDay)
			{
				num++;
				num2 -= SqlDateTime.s_SQLTicksPerDay;
			}
			this = new SqlDateTime(num, num2);
		}

		/// <summary>Указывает, имеет ли структура <see cref="T:System.Data.SqlTypes.SqlDateTime" /> значение null.</summary>
		/// <returns>Значение <see langword="true" />, если NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x000A1B0B File Offset: 0x0009FD0B
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x000A1B18 File Offset: 0x0009FD18
		private static TimeSpan ToTimeSpan(SqlDateTime value)
		{
			long num = (long)((double)value.m_time / SqlDateTime.s_SQLTicksPerMillisecond + 0.5);
			return new TimeSpan((long)value.m_day * 864000000000L + num * 10000L);
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x000A1B5D File Offset: 0x0009FD5D
		private static DateTime ToDateTime(SqlDateTime value)
		{
			return SqlDateTime.s_SQLBaseDate.Add(SqlDateTime.ToTimeSpan(value));
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x000A1B70 File Offset: 0x0009FD70
		internal static DateTime ToDateTime(int daypart, int timepart)
		{
			if (daypart < SqlDateTime.s_minDay || daypart > SqlDateTime.s_maxDay || timepart < SqlDateTime.s_minTime || timepart > SqlDateTime.s_maxTime)
			{
				throw new OverflowException(SQLResource.DateTimeOverflowMessage);
			}
			long num = (long)daypart * 864000000000L;
			long num2 = (long)((double)timepart / SqlDateTime.s_SQLTicksPerMillisecond + 0.5) * 10000L;
			return new DateTime(SqlDateTime.s_SQLBaseDateTicks + num + num2);
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x000A1BE0 File Offset: 0x0009FDE0
		private static SqlDateTime FromTimeSpan(TimeSpan value)
		{
			if (value < SqlDateTime.s_minTimeSpan || value > SqlDateTime.s_maxTimeSpan)
			{
				throw new SqlTypeException(SQLResource.DateTimeOverflowMessage);
			}
			int num = value.Days;
			long num2 = value.Ticks - (long)num * 864000000000L;
			if (num2 < 0L)
			{
				num--;
				num2 += 864000000000L;
			}
			int num3 = (int)((double)num2 / 10000.0 * SqlDateTime.s_SQLTicksPerMillisecond + 0.5);
			if (num3 > SqlDateTime.s_maxTime)
			{
				num3 = 0;
				num++;
			}
			return new SqlDateTime(num, num3);
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x000A1C77 File Offset: 0x0009FE77
		private static SqlDateTime FromDateTime(DateTime value)
		{
			if (value == DateTime.MaxValue)
			{
				return SqlDateTime.MaxValue;
			}
			return SqlDateTime.FromTimeSpan(value.Subtract(SqlDateTime.s_SQLBaseDate));
		}

		/// <summary>Получает значение структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Значение данной структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Исключение, возникающее, когда для свойства <see langword="Value" /> структуры <see cref="N:System.Data.SqlTypes" /> установлено значение NULL.</exception>
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x000A1C9D File Offset: 0x0009FE9D
		public DateTime Value
		{
			get
			{
				if (this.m_fNotNull)
				{
					return SqlDateTime.ToDateTime(this);
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Получает число импульсов, представляющее дату данной структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <returns>Число импульсов, представляющее дату, которая содержится в свойстве <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> данной структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Исключение, возникающее, когда для свойства <see langword="Value" /> структуры <see cref="N:System.Data.SqlTypes" /> установлено значение NULL.</exception>
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x000A1CB8 File Offset: 0x0009FEB8
		public int DayTicks
		{
			get
			{
				if (this.m_fNotNull)
				{
					return this.m_day;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Получает число импульсов, представляющее время данной структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <returns>Число импульсов, представляющее время данной структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x000A1CCE File Offset: 0x0009FECE
		public int TimeTicks
		{
			get
			{
				if (this.m_fNotNull)
				{
					return this.m_time;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Преобразует структуру <see cref="T:System.DateTime" /> в структуру <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <param name="value">Структура <see langword="DateTime" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />, <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> которой равно объединенным свойствам <see cref="P:System.DateTime.Date" /> и <see cref="P:System.DateTime.TimeOfDay" /> предоставленной структуры <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002355 RID: 9045 RVA: 0x000A1CE4 File Offset: 0x0009FEE4
		public static implicit operator SqlDateTime(DateTime value)
		{
			return new SqlDateTime(value);
		}

		/// <summary>Преобразует структуру <see cref="T:System.Data.SqlTypes.SqlDateTime" /> в структуру <see cref="T:System.DateTime" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, свойства <see cref="P:System.DateTime.Date" /> и <see cref="P:System.DateTime.TimeOfDay" /> которого содержат те же значения даты и времени, что и свойство <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> предоставленной структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		// Token: 0x06002356 RID: 9046 RVA: 0x000A1CEC File Offset: 0x0009FEEC
		public static explicit operator DateTime(SqlDateTime x)
		{
			return SqlDateTime.ToDateTime(x);
		}

		/// <summary>Преобразует данную структуру <see cref="T:System.Data.SqlTypes.SqlDateTime" /> в <see cref="T:System.String" />.</summary>
		/// <returns>
		///   <see langword="String" /> представляет свойство <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		// Token: 0x06002357 RID: 9047 RVA: 0x000A1CF4 File Offset: 0x0009FEF4
		public override string ToString()
		{
			if (this.IsNull)
			{
				return SQLResource.NullString;
			}
			return SqlDateTime.ToDateTime(this).ToString(null);
		}

		/// <summary>Преобразует заданное представление даты и времени <see cref="T:System.String" /> в его эквивалент для структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <param name="s">Представление <see langword="string" />, которое необходимо проанализировать.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />, эквивалентная дате и времени, которые представлены заданной <see langword="string" />.</returns>
		// Token: 0x06002358 RID: 9048 RVA: 0x000A1D24 File Offset: 0x0009FF24
		public static SqlDateTime Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlDateTime.Null;
			}
			DateTime value;
			try
			{
				value = DateTime.Parse(s, CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
				DateTimeFormatInfo provider = (DateTimeFormatInfo)CultureInfo.CurrentCulture.GetFormat(typeof(DateTimeFormatInfo));
				value = DateTime.ParseExact(s, SqlDateTime.s_dateTimeFormats, provider, DateTimeStyles.AllowWhiteSpaces);
			}
			return new SqlDateTime(value);
		}

		/// <summary>Добавляет период времени, указанный предоставленным параметром <see cref="T:System.TimeSpan" />, <paramref name="t" />, к предоставленной структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="t">Структура <see cref="T:System.TimeSpan" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlDateTime" />. Если один из аргументов имеет значение <see cref="F:System.Data.SqlTypes.SqlDateTime.Null" />, новый объект <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlDateTime.Null" />.</returns>
		// Token: 0x06002359 RID: 9049 RVA: 0x000A1D94 File Offset: 0x0009FF94
		public static SqlDateTime operator +(SqlDateTime x, TimeSpan t)
		{
			if (!x.IsNull)
			{
				return SqlDateTime.FromDateTime(SqlDateTime.ToDateTime(x) + t);
			}
			return SqlDateTime.Null;
		}

		/// <summary>Вычитает предоставленную структуру <see cref="T:System.TimeSpan" />, <paramref name="t" />, из предоставленной структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="t">Структура <see cref="T:System.TimeSpan" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />, представляющая результаты вычитания.</returns>
		// Token: 0x0600235A RID: 9050 RVA: 0x000A1DB6 File Offset: 0x0009FFB6
		public static SqlDateTime operator -(SqlDateTime x, TimeSpan t)
		{
			if (!x.IsNull)
			{
				return SqlDateTime.FromDateTime(SqlDateTime.ToDateTime(x) - t);
			}
			return SqlDateTime.Null;
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.SqlTypes.SqlDateTime" /> к указанному объекту <see langword="TimeSpan" />.</summary>
		/// <param name="x">Значение <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="t">Значение <see langword="Timespan" />.</param>
		/// <returns>Значение <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		// Token: 0x0600235B RID: 9051 RVA: 0x000A1DD8 File Offset: 0x0009FFD8
		public static SqlDateTime Add(SqlDateTime x, TimeSpan t)
		{
			return x + t;
		}

		/// <summary>Вычитает указанное значение  <see langword="Timespan" /> из этого экземпляра <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <param name="x">Значение <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="t">Значение <see langword="Timespan" />.</param>
		/// <returns>Значение <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		// Token: 0x0600235C RID: 9052 RVA: 0x000A1DE1 File Offset: 0x0009FFE1
		public static SqlDateTime Subtract(SqlDateTime x, TimeSpan t)
		{
			return x - t;
		}

		/// <summary>Преобразует параметр <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />, значение свойства <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> которой равно дате и времени, представленным параметром <see cref="T:System.Data.SqlTypes.SqlString" />. Если <see cref="T:System.Data.SqlTypes.SqlString" /> равно NULL, <see langword="Value" /> созданной структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> будет равно NULL.</returns>
		// Token: 0x0600235D RID: 9053 RVA: 0x000A1DEA File Offset: 0x0009FFEA
		public static explicit operator SqlDateTime(SqlString x)
		{
			if (!x.IsNull)
			{
				return SqlDateTime.Parse(x.Value);
			}
			return SqlDateTime.Null;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x000A1E07 File Offset: 0x000A0007
		private static bool IsLeapYear(int year)
		{
			return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600235F RID: 9055 RVA: 0x000A1E22 File Offset: 0x000A0022
		public static SqlBoolean operator ==(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day == y.m_day && x.m_time == y.m_time);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух экземпляров <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002360 RID: 9056 RVA: 0x000A1E60 File Offset: 0x000A0060
		public static SqlBoolean operator !=(SqlDateTime x, SqlDateTime y)
		{
			return !(x == y);
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002361 RID: 9057 RVA: 0x000A1E70 File Offset: 0x000A0070
		public static SqlBoolean operator <(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day < y.m_day || (x.m_day == y.m_day && x.m_time < y.m_time));
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002362 RID: 9058 RVA: 0x000A1ECC File Offset: 0x000A00CC
		public static SqlBoolean operator >(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day > y.m_day || (x.m_day == y.m_day && x.m_time > y.m_time));
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002363 RID: 9059 RVA: 0x000A1F28 File Offset: 0x000A0128
		public static SqlBoolean operator <=(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day < y.m_day || (x.m_day == y.m_day && x.m_time <= y.m_time));
			}
			return SqlBoolean.Null;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, равны ли они, или первый больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002364 RID: 9060 RVA: 0x000A1F88 File Offset: 0x000A0188
		public static SqlBoolean operator >=(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day > y.m_day || (x.m_day == y.m_day && x.m_time >= y.m_time));
			}
			return SqlBoolean.Null;
		}

		/// <summary>Выполняет логическое сравнение двух структур <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, равны ли они.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002365 RID: 9061 RVA: 0x000A1FE5 File Offset: 0x000A01E5
		public static SqlBoolean Equals(SqlDateTime x, SqlDateTime y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух экземпляров <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, что они не равны.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002366 RID: 9062 RVA: 0x000A1FEE File Offset: 0x000A01EE
		public static SqlBoolean NotEquals(SqlDateTime x, SqlDateTime y)
		{
			return x != y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, является ли первый меньшим, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002367 RID: 9063 RVA: 0x000A1FF7 File Offset: 0x000A01F7
		public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y)
		{
			return x < y;
		}

		/// <summary>Сравнивает два экземпляра <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, что первый объект больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002368 RID: 9064 RVA: 0x000A2000 File Offset: 0x000A0200
		public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y)
		{
			return x > y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, равны ли они, или первый меньше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06002369 RID: 9065 RVA: 0x000A2009 File Offset: 0x000A0209
		public static SqlBoolean LessThanOrEqual(SqlDateTime x, SqlDateTime y)
		{
			return x <= y;
		}

		/// <summary>Сравнивает два экземпляра структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />, чтобы определить, равны ли они, или первый больше, чем второй.</summary>
		/// <param name="x">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <param name="y">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x0600236A RID: 9066 RVA: 0x000A2012 File Offset: 0x000A0212
		public static SqlBoolean GreaterThanOrEqual(SqlDateTime x, SqlDateTime y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlDateTime" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Структура <see langword="SqlString" />, значением которой является строка, представляющая дату и время, содержащиеся в данной структуре <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		// Token: 0x0600236B RID: 9067 RVA: 0x000A201B File Offset: 0x000A021B
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Сравнивает данную структуру <see cref="T:System.Data.SqlTypes.SqlDateTime" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Object" /> для сравнения.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений экземпляра и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Этот экземпляр меньше данного объекта.  
		///
		///   Нуль 
		///   Этот экземпляр равен данному объекту.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше данного объекта 
		/// - или - 
		/// объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x0600236C RID: 9068 RVA: 0x000A2028 File Offset: 0x000A0228
		public int CompareTo(object value)
		{
			if (value is SqlDateTime)
			{
				SqlDateTime value2 = (SqlDateTime)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlDateTime));
		}

		/// <summary>Сравнивает данную структуру <see cref="T:System.Data.SqlTypes.SqlDateTime" /> с предоставленной структурой <see cref="T:System.Data.SqlTypes.SqlDateTime" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Структура <see cref="T:System.Data.SqlTypes.SqlDateTime" /> для сравнения.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений экземпляра и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <see cref="T:System.Data.SqlTypes.SqlDateTime" />.  
		///
		///   Нуль 
		///   Данный экземпляр равен <see cref="T:System.Data.SqlTypes.SqlDateTime" />.  
		///
		///   Больше нуля 
		///   Данный экземпляр больше, чем <see cref="T:System.Data.SqlTypes.SqlDateTime" />.  
		///
		/// - или - 
		///  Параметр <see cref="T:System.Data.SqlTypes.SqlDateTime" /> является неопределенной ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x0600236D RID: 9069 RVA: 0x000A2064 File Offset: 0x000A0264
		public int CompareTo(SqlDateTime value)
		{
			if (this.IsNull)
			{
				if (!value.IsNull)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (value.IsNull)
				{
					return 1;
				}
				if (this < value)
				{
					return -1;
				}
				if (this > value)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" /> и они равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600236E RID: 9070 RVA: 0x000A20BC File Offset: 0x000A02BC
		public override bool Equals(object value)
		{
			if (!(value is SqlDateTime))
			{
				return false;
			}
			SqlDateTime y = (SqlDateTime)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Получает хэш-код для этого экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600236F RID: 9071 RVA: 0x000A2114 File Offset: 0x000A0314
		public override int GetHashCode()
		{
			if (!this.IsNull)
			{
				return this.Value.GetHashCode();
			}
			return 0;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <returns>Объект <see langword="XmlSchema" />.</returns>
		// Token: 0x06002370 RID: 9072 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x06002371 RID: 9073 RVA: 0x000A213C File Offset: 0x000A033C
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			DateTime value = XmlConvert.ToDateTime(reader.ReadElementString(), XmlDateTimeSerializationMode.RoundtripKind);
			if (value.Kind != DateTimeKind.Unspecified)
			{
				throw new SqlTypeException(SQLResource.TimeZoneSpecifiedMessage);
			}
			SqlDateTime sqlDateTime = SqlDateTime.FromDateTime(value);
			this.m_day = sqlDateTime.DayTicks;
			this.m_time = sqlDateTime.TimeTicks;
			this.m_fNotNull = true;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x06002372 RID: 9074 RVA: 0x000A21BD File Offset: 0x000A03BD
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(XmlConvert.ToString(this.Value, SqlDateTime.s_ISO8601_DateTimeFormat));
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06002373 RID: 9075 RVA: 0x000A21F8 File Offset: 0x000A03F8
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("dateTime", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x0400184A RID: 6218
		private bool m_fNotNull;

		// Token: 0x0400184B RID: 6219
		private int m_day;

		// Token: 0x0400184C RID: 6220
		private int m_time;

		// Token: 0x0400184D RID: 6221
		private static readonly double s_SQLTicksPerMillisecond = 0.3;

		/// <summary>Константа, значение которой представляет собой число импульсов, эквивалентное одной секунде.</summary>
		// Token: 0x0400184E RID: 6222
		public static readonly int SQLTicksPerSecond = 300;

		/// <summary>Константа, значение которой представляет собой число импульсов, эквивалентное одной минуте.</summary>
		// Token: 0x0400184F RID: 6223
		public static readonly int SQLTicksPerMinute = SqlDateTime.SQLTicksPerSecond * 60;

		/// <summary>Константа, значение которой представляет собой число импульсов, эквивалентное одному часу.</summary>
		// Token: 0x04001850 RID: 6224
		public static readonly int SQLTicksPerHour = SqlDateTime.SQLTicksPerMinute * 60;

		// Token: 0x04001851 RID: 6225
		private static readonly int s_SQLTicksPerDay = SqlDateTime.SQLTicksPerHour * 24;

		// Token: 0x04001852 RID: 6226
		private static readonly long s_ticksPerSecond = 10000000L;

		// Token: 0x04001853 RID: 6227
		private static readonly DateTime s_SQLBaseDate = new DateTime(1900, 1, 1);

		// Token: 0x04001854 RID: 6228
		private static readonly long s_SQLBaseDateTicks = SqlDateTime.s_SQLBaseDate.Ticks;

		// Token: 0x04001855 RID: 6229
		private static readonly int s_minYear = 1753;

		// Token: 0x04001856 RID: 6230
		private static readonly int s_maxYear = 9999;

		// Token: 0x04001857 RID: 6231
		private static readonly int s_minDay = -53690;

		// Token: 0x04001858 RID: 6232
		private static readonly int s_maxDay = 2958463;

		// Token: 0x04001859 RID: 6233
		private static readonly int s_minTime = 0;

		// Token: 0x0400185A RID: 6234
		private static readonly int s_maxTime = SqlDateTime.s_SQLTicksPerDay - 1;

		// Token: 0x0400185B RID: 6235
		private static readonly int s_dayBase = 693595;

		// Token: 0x0400185C RID: 6236
		private static readonly int[] s_daysToMonth365 = new int[]
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

		// Token: 0x0400185D RID: 6237
		private static readonly int[] s_daysToMonth366 = new int[]
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

		// Token: 0x0400185E RID: 6238
		private static readonly DateTime s_minDateTime = new DateTime(1753, 1, 1);

		// Token: 0x0400185F RID: 6239
		private static readonly DateTime s_maxDateTime = DateTime.MaxValue;

		// Token: 0x04001860 RID: 6240
		private static readonly TimeSpan s_minTimeSpan = SqlDateTime.s_minDateTime.Subtract(SqlDateTime.s_SQLBaseDate);

		// Token: 0x04001861 RID: 6241
		private static readonly TimeSpan s_maxTimeSpan = SqlDateTime.s_maxDateTime.Subtract(SqlDateTime.s_SQLBaseDate);

		// Token: 0x04001862 RID: 6242
		private static readonly string s_ISO8601_DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fff";

		// Token: 0x04001863 RID: 6243
		private static readonly string[] s_dateTimeFormats = new string[]
		{
			"MMM d yyyy hh:mm:ss:ffftt",
			"MMM d yyyy hh:mm:ss:fff",
			"d MMM yyyy hh:mm:ss:ffftt",
			"d MMM yyyy hh:mm:ss:fff",
			"hh:mm:ss:ffftt",
			"hh:mm:ss:fff",
			"yyMMdd",
			"yyyyMMdd"
		};

		// Token: 0x04001864 RID: 6244
		private const DateTimeStyles x_DateTimeStyle = DateTimeStyles.AllowWhiteSpaces;

		/// <summary>Представляет минимальное допустимое значение даты для структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		// Token: 0x04001865 RID: 6245
		public static readonly SqlDateTime MinValue = new SqlDateTime(SqlDateTime.s_minDay, 0);

		/// <summary>Представляет максимальное допустимое значение даты для структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		// Token: 0x04001866 RID: 6246
		public static readonly SqlDateTime MaxValue = new SqlDateTime(SqlDateTime.s_maxDay, SqlDateTime.s_maxTime);

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		// Token: 0x04001867 RID: 6247
		public static readonly SqlDateTime Null = new SqlDateTime(true);
	}
}
