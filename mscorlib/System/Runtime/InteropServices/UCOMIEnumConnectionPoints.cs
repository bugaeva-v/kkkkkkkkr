using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints" />.</summary>
	// Token: 0x02000758 RID: 1880
	[Obsolete]
	[Guid("b196b285-bab4-101a-b69c-00aa00341d07")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMIEnumConnectionPoints
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число ссылок <see langword="IConnectionPoint" />, возвращаемых в <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При успешном возвращении — ссылка на перечисленные соединения.</param>
		/// <param name="pceltFetched">При успешном возвращении — ссылка на фактическое число соединений, перечисленных в параметре <paramref name="rgelt" />.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x0600425A RID: 16986
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] UCOMIConnectionPoint[] rgelt, out int pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x0600425B RID: 16987
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		/// <returns>HRESULT со значением <see langword="S_OK" />.</returns>
		// Token: 0x0600425C RID: 16988
		[PreserveSig]
		int Reset();

		/// <summary>Создает другой перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При успешном возвращении — ссылка на созданный перечислитель.</param>
		// Token: 0x0600425D RID: 16989
		void Clone(out UCOMIEnumConnectionPoints ppenum);
	}
}
