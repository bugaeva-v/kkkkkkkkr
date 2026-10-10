using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumConnections" />.</summary>
	// Token: 0x02000720 RID: 1824
	[Guid("B196B287-BAB4-101A-B69C-00AA00341D07")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.IEnumConnections instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[ComImport]
	public interface UCOMIEnumConnections
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число структур <see cref="T:System.Runtime.InteropServices.CONNECTDATA" />, которые будут возвращены в <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При успешном возвращении — ссылка на перечисленные соединения.</param>
		/// <param name="pceltFetched">При успешном возвращении — ссылка на фактическое число соединений, перечисленных в параметре <paramref name="rgelt" />.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x060040FD RID: 16637
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] CONNECTDATA[] rgelt, out int pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x060040FE RID: 16638
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		// Token: 0x060040FF RID: 16639
		[PreserveSig]
		void Reset();

		/// <summary>Создает другой перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При успешном возвращении — ссылка на созданный перечислитель.</param>
		// Token: 0x06004100 RID: 16640
		void Clone(out UCOMIEnumConnections ppenum);
	}
}
