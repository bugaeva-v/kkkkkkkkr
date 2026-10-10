using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Управляет определением интерфейса <see langword="IEnumConnectionPoints" />.</summary>
	// Token: 0x020007A0 RID: 1952
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B196B285-BAB4-101A-B69C-00AA00341D07")]
	[ComImport]
	public interface IEnumConnectionPoints
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число ссылок <see langword="IConnectionPoint" />, возвращаемых в <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При возвращении данного метода содержит ссылку на перечисленные соединения. Этот параметр передается неинициализированным.</param>
		/// <param name="pceltFetched">В возвращаемых результатах выполнения метода содержится ссылка на фактическое число подключений, перечисленных в <paramref name="rgelt" />.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004505 RID: 17669
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] IConnectionPoint[] rgelt, IntPtr pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004506 RID: 17670
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		// Token: 0x06004507 RID: 17671
		void Reset();

		/// <summary>Создает новый перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При возвращении данного метода содержит ссылку на только что созданный перечислитель. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004508 RID: 17672
		void Clone(out IEnumConnectionPoints ppenum);
	}
}
