using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System
{
	/// <summary>Представляет операции сравнения строк, в которых используются правила сравнения с учетом регистра, языка и региональных параметров или правил сравнения по порядковому номеру.</summary>
	// Token: 0x02000187 RID: 391
	[Serializable]
	public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string>
	{
		/// <summary>Получает объект <see cref="T:System.StringComparer" />, выполняющий сравнение строк с учетом регистра, используя правила сравнения строк по словам для инвариантных языка и региональных параметров.</summary>
		/// <returns>Новый объект <see cref="T:System.StringComparer" />.</returns>
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x000414FB File Offset: 0x0003F6FB
		public static StringComparer InvariantCulture
		{
			get
			{
				return StringComparer.s_invariantCulture;
			}
		}

		/// <summary>Получает объект <see cref="T:System.StringComparer" />, выполняющий сравнение строк без учета регистра, используя правила сравнения строк по словам для инвариантных языка и региональных параметров.</summary>
		/// <returns>Новый объект <see cref="T:System.StringComparer" />.</returns>
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00041502 File Offset: 0x0003F702
		public static StringComparer InvariantCultureIgnoreCase
		{
			get
			{
				return StringComparer.s_invariantCultureIgnoreCase;
			}
		}

		/// <summary>Получает объект <see cref="T:System.StringComparer" />, выполняющий сравнение строк с учетом регистра, используя правила сравнения строк по словам для текущего языка и региональных параметров.</summary>
		/// <returns>Новый объект <see cref="T:System.StringComparer" />.</returns>
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00041509 File Offset: 0x0003F709
		public static StringComparer CurrentCulture
		{
			get
			{
				return new CultureAwareComparer(CultureInfo.CurrentCulture, CompareOptions.None);
			}
		}

		/// <summary>Получает объект <see cref="T:System.StringComparer" />, выполняющий сравнения строк без учета регистра, используя правила сравнения строк по словам для текущего языка и региональных параметров.</summary>
		/// <returns>Новый объект для сравнения строк.</returns>
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00041516 File Offset: 0x0003F716
		public static StringComparer CurrentCultureIgnoreCase
		{
			get
			{
				return new CultureAwareComparer(CultureInfo.CurrentCulture, CompareOptions.IgnoreCase);
			}
		}

		/// <summary>Получает объект <see cref="T:System.StringComparer" />, выполняющий сравнение строк по порядковому номеру с учетом регистра.</summary>
		/// <returns>Объект <see cref="T:System.StringComparer" />.</returns>
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00041523 File Offset: 0x0003F723
		public static StringComparer Ordinal
		{
			get
			{
				return StringComparer.s_ordinal;
			}
		}

		/// <summary>Получает объект <see cref="T:System.StringComparer" />, выполняющий сравнение строк по порядковому номеру без учета регистра.</summary>
		/// <returns>Объект <see cref="T:System.StringComparer" />.</returns>
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0004152A File Offset: 0x0003F72A
		public static StringComparer OrdinalIgnoreCase
		{
			get
			{
				return StringComparer.s_ordinalIgnoreCase;
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00041534 File Offset: 0x0003F734
		public static StringComparer FromComparison(StringComparison comparisonType)
		{
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				return StringComparer.CurrentCulture;
			case StringComparison.CurrentCultureIgnoreCase:
				return StringComparer.CurrentCultureIgnoreCase;
			case StringComparison.InvariantCulture:
				return StringComparer.InvariantCulture;
			case StringComparison.InvariantCultureIgnoreCase:
				return StringComparer.InvariantCultureIgnoreCase;
			case StringComparison.Ordinal:
				return StringComparer.Ordinal;
			case StringComparison.OrdinalIgnoreCase:
				return StringComparer.OrdinalIgnoreCase;
			default:
				throw new ArgumentException("The string comparison type passed in is currently not supported.", "comparisonType");
			}
		}

		/// <summary>Создает объект <see cref="T:System.StringComparer" />, который сравнивает строки в соответствии с правилами заданного языка и региональных параметров.</summary>
		/// <param name="culture">Язык и региональные параметры, лингвистические правила которых используются для сравнения строк.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы в операциях сравнения регистр не учитывался; значение <see langword="false" /> для учета регистра в операциях сравнения.</param>
		/// <returns>Новый объект <see cref="T:System.StringComparer" />, выполняющий сравнение строк в соответствии с правилами сравнения, используемыми параметром <paramref name="culture" />, и правилом учета регистра параметра <paramref name="ignoreCase" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000FA5 RID: 4005 RVA: 0x00041594 File Offset: 0x0003F794
		public static StringComparer Create(CultureInfo culture, bool ignoreCase)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return new CultureAwareComparer(culture, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000415B1 File Offset: 0x0003F7B1
		public static StringComparer Create(CultureInfo culture, CompareOptions options)
		{
			if (culture == null)
			{
				throw new ArgumentException("culture");
			}
			return new CultureAwareComparer(culture, options);
		}

		/// <summary>При переопределении в производном классе сравнивает два объекта и возвращает сведения об их относительном порядке сортировки.</summary>
		/// <param name="x">Объект, сравниваемый с <paramref name="y" />.</param>
		/// <param name="y">Объект, сравниваемый с <paramref name="x" />.</param>
		/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="x" /> и <paramref name="y" />, как показано в следующей таблице.  
		///   Значение 
		///   Значение 
		///   Меньше нуля 
		///  <paramref name="x" /> предшествует <paramref name="y" /> в порядке сортировки.  
		///
		/// -или- 
		///  <paramref name="x" /> имеет значение <see langword="null" />, а <paramref name="y" /> не имеет значения <see langword="null" />.  
		///
		///   Нуль 
		///  <paramref name="x" /> равно <paramref name="y" />.  
		///
		/// -или- 
		///  Оба параметра <paramref name="x" /> и <paramref name="y" /> имеют значение <see langword="null" />.  
		///
		///   Больше нуля 
		///  <paramref name="x" /> следует за <paramref name="y" /> в порядке сортировки.  
		///
		/// -или- 
		///  <paramref name="y" /> имеет значение <see langword="null" />, а <paramref name="x" /> не имеет значения <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Ни параметр <paramref name="x" />, ни параметр <paramref name="y" /> не являются объектами <see cref="T:System.String" /> и ни один из этих параметров, <paramref name="x" /> и <paramref name="y" />, не реализует экземпляр <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06000FA7 RID: 4007 RVA: 0x000415C8 File Offset: 0x0003F7C8
		public int Compare(object x, object y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			string text = x as string;
			if (text != null)
			{
				string text2 = y as string;
				if (text2 != null)
				{
					return this.Compare(text, text2);
				}
			}
			IComparable comparable = x as IComparable;
			if (comparable != null)
			{
				return comparable.CompareTo(y);
			}
			throw new ArgumentException("At least one object must implement IComparable.");
		}

		/// <summary>При переопределении в производном классе позволяет определить, равны ли два объекта.</summary>
		/// <param name="x">Объект, сравниваемый с <paramref name="y" />.</param>
		/// <param name="y">Объект, сравниваемый с <paramref name="x" />.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="x" /> и <paramref name="y" /> указывают на один и тот же объект, если параметры <paramref name="x" /> и <paramref name="y" /> относятся к одному и тому же типу объектов и эти объекты равны или если параметры <paramref name="x" /> и <paramref name="y" /> равны <see langword="null" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000FA8 RID: 4008 RVA: 0x00041620 File Offset: 0x0003F820
		public bool Equals(object x, object y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			string text = x as string;
			if (text != null)
			{
				string text2 = y as string;
				if (text2 != null)
				{
					return this.Equals(text, text2);
				}
			}
			return x.Equals(y);
		}

		/// <summary>При переопределении в производном классе возвращает хэш-код для указанного объекта.</summary>
		/// <param name="obj">Объект.</param>
		/// <returns>32-разрядный хэш-код, вычисленный на основе значения параметра <paramref name="obj" />.</returns>
		/// <exception cref="T:System.ArgumentException">Недостаточно памяти для выделения буфера, который необходим для вычисления хэш-кода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000FA9 RID: 4009 RVA: 0x00041660 File Offset: 0x0003F860
		public int GetHashCode(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			string text = obj as string;
			if (text != null)
			{
				return this.GetHashCode(text);
			}
			return obj.GetHashCode();
		}

		/// <summary>При переопределении в производном классе сравнивает две строки и возвращает сведения об их относительном порядке сортировки.</summary>
		/// <param name="x">Строка, сравниваемая с параметром <paramref name="y" />.</param>
		/// <param name="y">Строка, сравниваемая с параметром <paramref name="x" />.</param>
		/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="x" /> и <paramref name="y" />, как показано в следующей таблице.  
		///   Значение 
		///   Значение 
		///   Меньше нуля 
		///  <paramref name="x" /> предшествует <paramref name="y" /> в порядке сортировки.  
		///
		/// -или- 
		///  <paramref name="x" /> имеет значение <see langword="null" />, а <paramref name="y" /> не имеет значения <see langword="null" />.  
		///
		///   Нуль 
		///  <paramref name="x" /> равно <paramref name="y" />.  
		///
		/// -или- 
		///  Оба параметра <paramref name="x" /> и <paramref name="y" /> имеют значение <see langword="null" />.  
		///
		///   Больше нуля 
		///  <paramref name="x" /> следует за <paramref name="y" /> в порядке сортировки.  
		///
		/// -или- 
		///  <paramref name="y" /> имеет значение <see langword="null" />, а <paramref name="x" /> не имеет значения <see langword="null" />.</returns>
		// Token: 0x06000FAA RID: 4010
		public abstract int Compare(string x, string y);

		/// <summary>При переопределении в производном классе позволяет определить, равны ли две строки.</summary>
		/// <param name="x">Строка, сравниваемая с параметром <paramref name="y" />.</param>
		/// <param name="y">Строка, сравниваемая с параметром <paramref name="x" />.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="x" /> и <paramref name="y" /> указывают не один и тот же объект, если параметры <paramref name="x" /> и <paramref name="y" /> равны или если параметры <paramref name="x" /> и <paramref name="y" /> равны <see langword="null" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000FAB RID: 4011
		public abstract bool Equals(string x, string y);

		/// <summary>При переопределении в производном классе возвращает хэш-код указанной строки.</summary>
		/// <param name="obj">Строка.</param>
		/// <returns>32-разрядный хэш-код, вычисленный на основе значения параметра <paramref name="obj" />.</returns>
		/// <exception cref="T:System.ArgumentException">Недостаточно памяти для выделения буфера, который необходим для вычисления хэш-кода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000FAC RID: 4012
		public abstract int GetHashCode(string obj);

		// Token: 0x040012EE RID: 4846
		private static readonly CultureAwareComparer s_invariantCulture = new CultureAwareComparer(CultureInfo.InvariantCulture, CompareOptions.None);

		// Token: 0x040012EF RID: 4847
		private static readonly CultureAwareComparer s_invariantCultureIgnoreCase = new CultureAwareComparer(CultureInfo.InvariantCulture, CompareOptions.IgnoreCase);

		// Token: 0x040012F0 RID: 4848
		private static readonly OrdinalCaseSensitiveComparer s_ordinal = new OrdinalCaseSensitiveComparer();

		// Token: 0x040012F1 RID: 4849
		private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase = new OrdinalIgnoreCaseComparer();
	}
}
