using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IEnumSTATDATA" />.</summary>
	// Token: 0x0200018E RID: 398
	[Guid("00000103-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumSTATDATA
	{
		/// <summary>Создает новый перечислитель с тем же состоянием перечисления, что и текущий перечислитель.</summary>
		/// <param name="newEnum">При возвращении данного метода содержит ссылку на только что созданный перечислитель. Этот параметр передается неинициализированным.</param>
		// Token: 0x06000A82 RID: 2690
		void Clone(out IEnumSTATDATA newEnum);

		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число ссылок <see cref="T:System.Runtime.InteropServices.ComTypes.STATDATA" />, возвращаемых в <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При возвращении данного метода содержит ссылку на перечисленные ссылки <see cref="T:System.Runtime.InteropServices.ComTypes.STATDATA" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pceltFetched">При возвращении данного параметра содержит ссылку на фактическое число ссылок, перечисленных в <paramref name="rgelt" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06000A83 RID: 2691
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray)] [Out] STATDATA[] rgelt, [MarshalAs(UnmanagedType.LPArray)] [Out] int[] pceltFetched);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		/// <returns>HRESULT со значением <see langword="S_OK" />.</returns>
		// Token: 0x06000A84 RID: 2692
		[PreserveSig]
		int Reset();

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06000A85 RID: 2693
		[PreserveSig]
		int Skip(int celt);
	}
}
