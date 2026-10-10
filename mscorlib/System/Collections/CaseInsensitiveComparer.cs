using System;
using System.Globalization;

namespace System.Collections
{
	/// <summary>Проверяет равенство двух объектов без учета регистра строк.</summary>
	// Token: 0x02000A22 RID: 2594
	[Serializable]
	public class CaseInsensitiveComparer : IComparer
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.CaseInsensitiveComparer" /> с помощью свойства <see cref="P:System.Threading.Thread.CurrentCulture" /> текущего потока.</summary>
		// Token: 0x06005BCE RID: 23502 RVA: 0x00135416 File Offset: 0x00133616
		public CaseInsensitiveComparer()
		{
			this._compareInfo = CultureInfo.CurrentCulture.CompareInfo;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.CaseInsensitiveComparer" /> с использованием указанного объекта <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, который используется для нового объекта <see cref="T:System.Collections.CaseInsensitiveComparer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005BCF RID: 23503 RVA: 0x0013542E File Offset: 0x0013362E
		public CaseInsensitiveComparer(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			this._compareInfo = culture.CompareInfo;
		}

		/// <summary>Получает экземпляр класса <see cref="T:System.Collections.CaseInsensitiveComparer" />, который связан со свойством <see cref="P:System.Threading.Thread.CurrentCulture" /> текущего потока и всегда доступен.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Collections.CaseInsensitiveComparer" />, который связан со свойством <see cref="P:System.Threading.Thread.CurrentCulture" /> текущего потока.</returns>
		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x00135450 File Offset: 0x00133650
		public static CaseInsensitiveComparer Default
		{
			get
			{
				return new CaseInsensitiveComparer(CultureInfo.CurrentCulture);
			}
		}

		/// <summary>Получает экземпляр класса <see cref="T:System.Collections.CaseInsensitiveComparer" />, который связан со свойством <see cref="P:System.Globalization.CultureInfo.InvariantCulture" /> и всегда доступен.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Collections.CaseInsensitiveComparer" />, который связан со свойством <see cref="P:System.Globalization.CultureInfo.InvariantCulture" />.</returns>
		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x0013545C File Offset: 0x0013365C
		public static CaseInsensitiveComparer DefaultInvariant
		{
			get
			{
				if (CaseInsensitiveComparer.s_InvariantCaseInsensitiveComparer == null)
				{
					CaseInsensitiveComparer.s_InvariantCaseInsensitiveComparer = new CaseInsensitiveComparer(CultureInfo.InvariantCulture);
				}
				return CaseInsensitiveComparer.s_InvariantCaseInsensitiveComparer;
			}
		}

		/// <summary>Выполняет сравнение двух объектов одного типа без учета регистра и возвращает значение, которое показывает, в каком отношении (меньше, равно или больше) находятся два объекта.</summary>
		/// <param name="a">Первый из сравниваемых объектов.</param>
		/// <param name="b">Второй из сравниваемых объектов.</param>
		/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="a" /> и <paramref name="b" />, как показано в следующей таблице.  
		///   Значение 
		///   Значение 
		///   Меньше нуля 
		///  Значение параметра <paramref name="a" /> меньше, чем значение параметра <paramref name="b" /> при сравнении без учета регистра.  
		///
		///   Нуль 
		///  Значение параметра <paramref name="a" /> равно значению параметра <paramref name="b" /> при сравнении без учета регистра.  
		///
		///   Больше нуля 
		///  Значение параметра <paramref name="a" /> больше, чем значение параметра <paramref name="b" /> при сравнении без учета регистра.</returns>
		/// <exception cref="T:System.ArgumentException">Ни параметр <paramref name="a" />, ни параметр <paramref name="b" /> не реализует интерфейс <see cref="T:System.IComparable" />.  
		///
		/// или - 
		/// Типы параметров <paramref name="a" /> и <paramref name="b" /> различны.</exception>
		// Token: 0x06005BD2 RID: 23506 RVA: 0x00135480 File Offset: 0x00133680
		public int Compare(object a, object b)
		{
			string text = a as string;
			string text2 = b as string;
			if (text != null && text2 != null)
			{
				return this._compareInfo.Compare(text, text2, CompareOptions.IgnoreCase);
			}
			return Comparer.Default.Compare(a, b);
		}

		// Token: 0x04003882 RID: 14466
		private CompareInfo _compareInfo;

		// Token: 0x04003883 RID: 14467
		private static volatile CaseInsensitiveComparer s_InvariantCaseInsensitiveComparer;
	}
}
