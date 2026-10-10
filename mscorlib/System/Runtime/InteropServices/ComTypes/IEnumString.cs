using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Управляет определением интерфейса <see langword="IEnumString" />.</summary>
	// Token: 0x020007A6 RID: 1958
	[Guid("00000101-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumString
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число строк для возвращения в параметре <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При возвращении данного метода содержит ссылку на перечисленные строки. Этот параметр передается неинициализированным.</param>
		/// <param name="pceltFetched">При возвращении данного метода содержит ссылку на фактическое число строк, перечисленных в <paramref name="rgelt" />.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004515 RID: 17685
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 0)] [Out] string[] rgelt, IntPtr pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004516 RID: 17686
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		// Token: 0x06004517 RID: 17687
		void Reset();

		/// <summary>Создает новый перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При возвращении данного метода содержит ссылку на только что созданный перечислитель. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004518 RID: 17688
		void Clone(out IEnumString ppenum);
	}
}
