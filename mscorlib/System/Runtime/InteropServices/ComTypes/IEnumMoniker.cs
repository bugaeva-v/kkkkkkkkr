using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Управляет определением интерфейса <see langword="IEnumMoniker" />.</summary>
	// Token: 0x020007A5 RID: 1957
	[Guid("00000102-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumMoniker
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число моникеров для возвращения в <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При возвращении данного метода содержит ссылку на перечисленные моникеры. Этот параметр передается неинициализированным.</param>
		/// <param name="pceltFetched">При возвращении данного метода содержит ссылку на фактическое число моникеров, перечисленных в <paramref name="rgelt" />.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004511 RID: 17681
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] IMoniker[] rgelt, IntPtr pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004512 RID: 17682
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		// Token: 0x06004513 RID: 17683
		void Reset();

		/// <summary>Создает новый перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При возвращении данного метода содержит ссылку на только что созданный перечислитель. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004514 RID: 17684
		void Clone(out IEnumMoniker ppenum);
	}
}
