using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Управляет определением интерфейса <see langword="IEnumVARIANT" />.</summary>
	// Token: 0x020007A7 RID: 1959
	[Guid("00020404-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumVARIANT
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число элементов для возвращения в rgelt.</param>
		/// <param name="rgVar">При возвращении данного метода содержит ссылку на перечисленные элементы. Этот параметр передается неинициализированным.</param>
		/// <param name="pceltFetched">При возвращении данного метода содержит ссылку на фактическое число элементов, перечисленных в rgelt.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004519 RID: 17689
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] object[] rgVar, IntPtr pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x0600451A RID: 17690
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		/// <returns>HRESULT со значением <see langword="S_OK" />.</returns>
		// Token: 0x0600451B RID: 17691
		[PreserveSig]
		int Reset();

		/// <summary>Создает новый перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <returns>Ссылка <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumVARIANT" /> на только что созданный перечислитель.</returns>
		// Token: 0x0600451C RID: 17692
		IEnumVARIANT Clone();
	}
}
