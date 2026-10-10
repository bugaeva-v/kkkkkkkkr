using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />.</summary>
	// Token: 0x02000759 RID: 1881
	[Obsolete]
	[Guid("00000102-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMIEnumMoniker
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число моникеров для возвращения в <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При успешном возвращении — ссылка на перечисленные моникеры.</param>
		/// <param name="pceltFetched">При успешном возвращении — ссылка на действительное число моникеров, перечисленных в <paramref name="rgelt" />.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x0600425E RID: 16990
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] UCOMIMoniker[] rgelt, out int pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x0600425F RID: 16991
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		/// <returns>HRESULT со значением <see langword="S_OK" />.</returns>
		// Token: 0x06004260 RID: 16992
		[PreserveSig]
		int Reset();

		/// <summary>Создает другой перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При успешном возвращении — ссылка на созданный перечислитель.</param>
		// Token: 0x06004261 RID: 16993
		void Clone(out UCOMIEnumMoniker ppenum);
	}
}
