using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumVARIANT" />.</summary>
	// Token: 0x0200075B RID: 1883
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Obsolete]
	[Guid("00020404-0000-0000-c000-000000000046")]
	[ComImport]
	public interface UCOMIEnumVARIANT
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число элементов для возвращения в rgelt.</param>
		/// <param name="rgvar">При успешном возвращении — ссылка на перечисленные элементы.</param>
		/// <param name="pceltFetched">При успешном возвращении — ссылка на фактическое число элементов, перечисленных в rgelt.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004266 RID: 16998
		[PreserveSig]
		int Next(int celt, int rgvar, int pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004267 RID: 16999
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		/// <returns>HRESULT со значением <see langword="S_OK" />.</returns>
		// Token: 0x06004268 RID: 17000
		[PreserveSig]
		int Reset();

		/// <summary>Создает другой перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При успешном возвращении — ссылка на созданный перечислитель.</param>
		// Token: 0x06004269 RID: 17001
		void Clone(int ppenum);
	}
}
