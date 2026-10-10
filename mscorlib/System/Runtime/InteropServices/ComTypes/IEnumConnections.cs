using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Управляет определением интерфейса <see langword="IEnumConnections" />.</summary>
	// Token: 0x020007A2 RID: 1954
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B196B287-BAB4-101A-B69C-00AA00341D07")]
	[ComImport]
	public interface IEnumConnections
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число структур <see cref="T:System.Runtime.InteropServices.CONNECTDATA" />, которые будут возвращены в <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При возвращении данного метода содержит ссылку на перечисленные соединения. Этот параметр передается неинициализированным.</param>
		/// <param name="pceltFetched">В возвращаемых результатах выполнения метода содержится ссылка на фактическое число подключений, перечисленных в <paramref name="rgelt" />.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004509 RID: 17673
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] CONNECTDATA[] rgelt, IntPtr pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x0600450A RID: 17674
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		// Token: 0x0600450B RID: 17675
		void Reset();

		/// <summary>Создает новый перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При возвращении данного метода содержит ссылку на только что созданный перечислитель. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600450C RID: 17676
		void Clone(out IEnumConnections ppenum);
	}
}
