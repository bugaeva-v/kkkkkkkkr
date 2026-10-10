using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IEnumFORMATETC" />.</summary>
	// Token: 0x0200018D RID: 397
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00000103-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IEnumFORMATETC
	{
		/// <summary>Создает новый перечислитель с тем же состоянием перечисления, что и текущий перечислитель.</summary>
		/// <param name="newEnum">При возвращении данного метода содержит ссылку на только что созданный перечислитель. Этот параметр передается неинициализированным.</param>
		// Token: 0x06000A7E RID: 2686
		void Clone(out IEnumFORMATETC newEnum);

		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число ссылок <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, возвращаемых в <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При возвращении данного метода содержит ссылку на перечисленные ссылки <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pceltFetched">При возвращении данного метода содержит ссылку на фактическое число ссылок, перечисленных в <paramref name="rgelt" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06000A7F RID: 2687
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray)] [Out] FORMATETC[] rgelt, [MarshalAs(UnmanagedType.LPArray)] [Out] int[] pceltFetched);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		/// <returns>HRESULT со значением <see langword="S_OK" />.</returns>
		// Token: 0x06000A80 RID: 2688
		[PreserveSig]
		int Reset();

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06000A81 RID: 2689
		[PreserveSig]
		int Skip(int celt);
	}
}
